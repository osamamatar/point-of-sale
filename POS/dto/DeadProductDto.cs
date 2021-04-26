using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.dto
{
    class DeadProductDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int quntity { get; set; }
        public string user_name {get;set;}
        public string note{ get; set; }
        public DateTime processDate { get; set; }
        public int sillingBillId { get; set; }
    }
}
