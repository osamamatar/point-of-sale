using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DAL;
using POS.BAL;
using POS.DB;
using POS.Util;
namespace POS.DAL
{
    class BuyingBillDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        VendorDal vend = new VendorDal();
       // DeadProdcutDal pdal = new DeadProdcutDal();
        //create buying bill
        public int createBuyingBill(Buying_Bill b,List<Buying_Bill_Details> li)
        {
            try
            {
              
                db.Buying_Bill.Add(b);
               
                foreach (var i in li)
                {

                    db.Buying_Bill_Details.Add(i);
                    
                    var pro= db.Products.First(a => a.product_id == i.product_id);
                    pro.product_quantity += i.product_quantity;

                }
                var ve = db.Vendors.First(a => a.vend_id == b.vend_id);
                ve.vend_balance += b.total - b.bill_paid;
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return 0;
            }
        }
        
        //get all buying bills
        public  List<bill> getALLBuyingBills()
            {
            List<bill> li = new List<bill>();
            List<Buying_Bill> l = db.Buying_Bill.ToList();
            foreach(var i in l)
            {
                bill b = new bill();
                b.Client_name = vend.getVendorById(Convert.ToString(i.vend_id)).vend_name;
                b.id = i.bill_id;
                b.paid = i.bill_paid;
                b.total = i.total;
                b.late = i.total - i.bill_paid;
                b.note = i.bill_notes;
                b.date = i.bill_date;
                li.Add(b);
            }
            return li;
            }

        //delete  buying bill
        public int deleteBuyingBill(int id,string s)
        {
            if (s == "no")
            {
                try
                {
                    Buying_Bill c = db.Buying_Bill.Find(id);
                    db.Buying_Bill.Remove(c);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    Console.Write(e.StackTrace);
                    return 0;
                }
            }else if (s == "yes")
            {
                try
                {

                   
                    Buying_Bill c = db.Buying_Bill.Find(id);
                    Vendor ven = db.Vendors.Find(c.vend_id);
                    ven.vend_balance -= (c.total - c.bill_paid);
                   // string sql = "select product_quantity , product_id from Buying_Bill_Details where bill_id = ' " + c.bill_id +" '";
                    var li = db.Buying_Bill_Details.Where(a=>a.bill_id == c.bill_id).ToList();
                    foreach(var i in li)
                    {
                        Product p = db.Products.Find(i.product_id);
                        if (p.product_quantity>= i.product_quantity)
                        {
                            p.product_quantity -= i.product_quantity;
                        }
                        else
                        {
                            return 0;
                        }
                       
                    }
                    db.Buying_Bill.Remove(c);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    Console.Write(e.StackTrace);
                    return 0;
                }
            }else
            {
                return 0;
            }
          
        }
        // get searched list of buying bill
        public List<bill> getSearchedBuyingBills(DateTime t1, DateTime t2)
        {
          
            string t11 = t1.ToString("yyyy-MM-dd ");
            string t22 = t2.ToString("yyyy-MM-dd ");
            string sql = "select * from Buying_Bill where bill_date >= ' " + t11 + "' AND bill_date <=' " + t22 + " ' ";
            List<bill> li = new List<bill>();
            List<Buying_Bill> l = db.Buying_Bill.SqlQuery(sql).ToList();
            foreach (var i in l)
            {
                bill b = new bill();
                b.Client_name = vend.getVendorById(Convert.ToString(i.vend_id)).vend_name;
                b.id = i.bill_id;
                b.paid = i.bill_paid;
                b.total = i.total;
                b.late = i.total - i.bill_paid;
                b.note = i.bill_notes;
                b.date = i.bill_date;
                li.Add(b);
            }
            return li;
        }
    }
}
