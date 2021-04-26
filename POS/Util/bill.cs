using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Util
{
    class bill
    {
        public int id { get; set; }
        public string Client_name { get; set; }
        public double paid { get; set; }
        public double late { get; set; }
        public double total { get; set; }
        public string note { get; set; }
        public DateTime date { get; set; }
    }
}
