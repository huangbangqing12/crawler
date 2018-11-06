using CrawlHelper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlHelper
{
    public partial class TaskHelper : Form
    {
        public DAO dao = new DAO();
        public TaskHelper(string _url)
        {
            InitializeComponent();
            this.txt_url.Text = _url;
            this.RefershDataSet(_url);
        }


        public void RefershDataSet(string url)
        {
            IList<link_tb> datas = dao.SelectLink(url);
            if(datas != null && datas.Count > 0)
            {
                this.txt_reg.Text = datas[0].reg;
            }
            
            this.dgview_link.DataSource = (from d in datas
                                           select new { id = d.id, href = d.href, craw_flag = d.craw_flag, reg = d.reg }).ToList();
            
        }

        private void TaskHelper_FormClosing(object sender, FormClosingEventArgs e)
        {
            dao.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            dao.UpdateLink(this.txt_url.Text, this.txt_reg.Text);
            RefershDataSet(this.txt_url.Text);
        }
}
}
