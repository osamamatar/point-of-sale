using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.dto
{
    class VendorDto
    {
        public int ven_id { get; set; }
        public string ven_name { get; set; }
        public string ven_address { get; set; }
        public string ven_note { get; set; }
        public double ven_balance { get; set; }
        public string ven_phone { get; set; }

    }
}
