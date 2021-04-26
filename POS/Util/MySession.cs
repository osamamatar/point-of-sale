using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Util
{
   static class  MySession
    {
        public static string userName { get; set; }
        public static string userPass { get; set; }
        public static string userRole { get; set; }
        public static int userId { get; set; }
    }
}
