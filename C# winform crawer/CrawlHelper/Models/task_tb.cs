using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlHelper.Models
{
    public class task_tb
    {
        public int id { get; set; }

        public string url { get; set; }

        public string mark { get; set; }

        public int type { get; set; }

        public string link_reg { get; set; }

        public string next_reg { get; set; }

        public int craw_flag { get; set; }
    }
}
