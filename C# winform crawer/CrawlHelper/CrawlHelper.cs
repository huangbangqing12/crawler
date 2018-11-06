using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrawlHelper.Models;

namespace CrawlHelper
{
    public partial class CrawHelper : Form
    {
        public static DAO dao = new DAO();
        public CrawHelper()
        {
            InitializeComponent();
            this.btn_search_Click(null, null);
        }


        private void CrawHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            //dao.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_url.Text = string.Empty;
            this.txt_mark.Text = string.Empty;
            this.type_list.SelectedIndex = -1;
            this.txt_now_reg.Text = string.Empty;
            this.txt_next_reg.Text = string.Empty;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            task_tb site = new task_tb()
            {
                url = this.txt_url.Text,
                mark = this.txt_mark.Text,
                link_reg = this.txt_now_reg.Text,
                next_reg = this.txt_next_reg.Text,
                craw_flag = 0,
                type = this.type_list.SelectedIndex
            };

            #region 验证参数
            if (!site.url.Contains("http"))
            {
                MessageBox.Show("提示","URL 不合法");
                this.txt_url.Text = string.Empty;
                this.txt_url.Focus();
                return;
            }

            if(site.type == -1)
            {
                MessageBox.Show("提示","请选择一种类型");
                this.type_list.Focus();
                return;
            }

            if(site.link_reg == string.Empty)
            {
                MessageBox.Show("提示","当前页面解析规则为空");
                this.txt_now_reg.Focus();
                return;
            }

            if (site.link_reg == string.Empty)
            {
                MessageBox.Show("提示","下一个页面解析规则为空");
                this.txt_next_reg.Focus();
                return;
            }
            #endregion

            dao.InsertTask(site);
            MessageBox.Show("提示","添加成功");

            this.btn_clear_Click(null, null);
            this.btn_search_Click(null, null);
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = this.txt_keyword.Text.Trim();
            this.dgview_data.DataSource = dao.SelectTask(keyword);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows =  this.dgview_data.SelectedRows;
            if(rows == null || rows.Count == 0)
            {
                MessageBox.Show("提示","请选择一行");
                return;
            }

            int id = Convert.ToInt32(rows[0].Cells[0].Value.ToString());
            string url = rows[0].Cells[1].Value.ToString();
            dao.DeleteTask(id,url);

            this.btn_search_Click(null, null);
        }


        private void btn_enable_Click(object sender, EventArgs e)
        {
            dao.EnableAllTask();
            this.btn_search_Click(null, null);
        }

        private void btn_link_list_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = this.dgview_data.SelectedRows;
            if (rows == null || rows.Count == 0)
            {
                MessageBox.Show("提示", "请选择一行");
                return;
            }

            string url = rows[0].Cells[1].Value.ToString();
            TaskHelper hform = new TaskHelper(url);
            hform.Show();
        }


    }
}
