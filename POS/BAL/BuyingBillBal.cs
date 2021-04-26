using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using POS.DAL;
namespace POS.BAL
{
    class BuyingBillBal
    {
        BuyingBillDal bdal = new BuyingBillDal();
        ProductDal pdal = new ProductDal();
        public int createBuyingBill(List<Util.BuyingBillDetails> l, Buying_Bill b)
        {

            List<Buying_Bill_Details> li = new List<Buying_Bill_Details>();
            foreach (var i in l)
            {
              Buying_Bill_Details sbd = new Buying_Bill_Details();
                sbd.bill_id = b.bill_id;
                sbd.product_id = pdal.getProductIdByName(i.Product_name);
                sbd.product_quantity = i.Product_quent;      
                sbd.product_price = i.Product_price;

                li.Add(sbd);
            }

            return bdal.createBuyingBill(b, li); ;
        }
    }
}
