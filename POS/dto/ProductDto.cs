using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.dto
{
    class ProductDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string color { get; set; }
        public  string cat { get; set; }
        public int quantity { get; set; }
        public float cost { get; set; }
        public float price { get; set; }
        public DateTime expire_date { get; set; }
        public float end_price { get; set; }

    }
}
