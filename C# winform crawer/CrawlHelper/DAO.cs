using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Dapper;
using System.Data;
using CrawlHelper.Models;
using System.Windows.Forms;

namespace CrawlHelper
{
    public class ConnectionPool
    {
        protected static string con_str = "server=192.168.5.130; user id=lk; password=lk123456; database=craw_db";
        protected Stack<MySqlConnection> pools = new Stack<MySqlConnection>();

        protected void ChunkPool(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                MySqlConnection con = new MySqlConnection(con_str);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    pools.Push(con);
                }

            }
        }

        public ConnectionPool(int size = 1)
        {
            ChunkPool(size);
        }

        public MySqlConnection Get()
        {
            if(pools.Count == 0)
            {
                ChunkPool(2);
            }
            return pools.Pop();
        }

        public void Put(MySqlConnection con)
        {
            pools.Push(con);
        }

        public void FreeAll()
        {
            while(pools != null && pools.Count != 0)
            {
                pools.Pop().Close();
            }
        }
    }

    public class DAO
    {
        protected static ConnectionPool pool = new ConnectionPool();

        public void InsertTask(task_tb m)
        {
            MySqlConnection con = pool.Get();

            string query = @"INSERT INTO `task_tb` (`id`,`url`,`mark`,`type`,`link_reg`,`next_reg`,`craw_flag`)VALUES
                                    (@id,@url,@mark,@type,@link_reg,@next_reg,@craw_flag)";

            con.Execute(query, m);
            pool.Put(con);
        }

        public IList<task_tb> SelectTask(string key)
        {
            MySqlConnection con = pool.Get();

            string sql = string.Format(@"select * from task_tb where (url like '%{0}%' or mark like '%{0}%') and (delete_flag = 0)",key);
            IList<task_tb> datas =  con.Query<task_tb>(sql).ToList();

            pool.Put(con);

            return datas;
        }

        public void DeleteTask(int id,string url)
        {
            MySqlConnection con = pool.Get();
            
            string sql1 = string.Format(@"update task_tb set delete_flag = 1 where id = {0}", id);
            string sql2 = string.Format(@"update link_tb set delete_flag = 1 where url = '{0}' ", url);
            MySqlTransaction tran =  con.BeginTransaction();
            try
            {
                con.Execute(sql1);
                con.Execute(sql2);

                tran.Commit();
            }catch(Exception ex)
            {
                tran.Rollback();
            }

            

            pool.Put(con);
        }


        public IList<link_tb> SelectLink(string key)
        {
            MySqlConnection con = pool.Get();

            string sql = string.Format(@"select * from link_tb where url = '{0}' ", key);
            IList<link_tb> datas = con.Query<link_tb>(sql).ToList();

            pool.Put(con);

            return datas;
        }

        public void UpdateLink(string url, string reg)
        {
            MySqlConnection con = pool.Get();
            
            string sql = string.Format(@"update link_tb set link_tb.reg = '{1}' where url = '{0}' ", url,reg);
            con.Execute(sql);
            

            pool.Put(con);
        }

        public void EnableAllTask()
        {
            MySqlConnection con = pool.Get();

            string sql1 = string.Format(@"update task_tb set delete_flag = 0 where delete_flag = 1");
            string sql2 = string.Format(@"update link_tb set delete_flag = 0 where delete_flag = 1");
            MySqlTransaction tran = con.BeginTransaction();
            try
            {
                con.Execute(sql1);
                con.Execute(sql2);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            pool.Put(con);
        }

        public void Close()
        {
            pool.FreeAll();
        }
    }
}
