using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlHelper.Models
{
    public class link_tb
    {
        public int id { get; set; }

        public string url { get; set; }

        public string href { get; set; }

        public string reg { get; set; }

        public int craw_flag { get; set; }
    }
}
