using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using POS.DAL;

namespace POS.BAL
{
    class SillingBillBal
    {
        SillingBillDal sdal = new SillingBillDal();
        ProductDal pdal = new ProductDal();
        public int createSillingBill(List<Util.SillBillDetails> l ,Selling_Bill s)
        {
            
            List<Selling_Bill_Details> li = new List<Selling_Bill_Details>();
            foreach(var i in l)
            {
                Selling_Bill_Details sbd = new Selling_Bill_Details();
                sbd.bill_id = s.bill_id;
                sbd.product_id = pdal.getProductIdByName(i.Product_name);
                sbd.product_quantity = i.Product_quent;
                sbd.profuct_discount = i.Product_dicound;
                sbd.product_price = i.Product_price;

                li.Add(sbd);
            }

            return sdal.createSillingBill(s, li); ;
        }
    }
}
