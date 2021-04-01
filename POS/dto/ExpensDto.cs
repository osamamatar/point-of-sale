using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.dto
{
    class ExpensDto
    {
        public int id { get; set; }
        public string user_name { get; set; }
        public float cost { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
    }
}
