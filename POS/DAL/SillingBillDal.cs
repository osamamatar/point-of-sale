using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using POS.Util;
using System.Windows.Forms;

namespace POS.DAL
{
    class SillingBillDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        CustomerDal cust = new CustomerDal();

        //create new bill
        public int createSillingBill(Selling_Bill s,List<Selling_Bill_Details> li)
        {
            try {
                db.Selling_Bill.Add(s);
                var cu = db.Customers.Find(s.cust_id);
                cu.cust_balance += s.total - s.bill_paid;
                foreach ( var i in li)
                {
                    db.Selling_Bill_Details.Add(i);
                    var pro = db.Products.First(a => a.product_id == i.product_id);
                    pro.product_quantity -= i.product_quantity;
                }
                db.SaveChanges();
                return 1;
            } catch(Exception e)
            {
                Console.Write(e.StackTrace);
                return 0;
            }
        }

        //get all selling bills
        public List<bill> getALLSellingBills()
        {
            List<bill> li = new List<bill>();
            List<Selling_Bill> l = db.Selling_Bill.ToList();
            foreach (var i in l)
            {
                bill b = new bill();
                b.Client_name = cust.getCustomerById(i.cust_id).cust_name;
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

        // get searched list of buying bill
        public List<bill> getSearchedSellingBills(DateTime t1, DateTime t2)
        {

            string t11 = t1.ToString("yyyy-MM-dd ");
            string t22 = t2.ToString("yyyy-MM-dd ");
            string sql = "select * from Selling_Bill where bill_date >= ' " + t11 + "' AND bill_date <=' " + t22 + " ' ";
            List<bill> li = new List<bill>();
            List<Selling_Bill> l = db.Selling_Bill.SqlQuery(sql).ToList();
            foreach (var i in l)
            {
                bill b = new bill();
                b.Client_name = cust.getCustomerById(i.cust_id).cust_name;
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

        // delete selling bill
        public int deletesllingBill(int id,string s)
        {
            if (s == "no")
            {
                try
                {
                    Selling_Bill c = db.Selling_Bill.Find(id);
                    db.Selling_Bill.Remove(c);
                    db.SaveChanges();
                    return 1;
                }
                catch (Exception e)
                {
                    Console.Write(e.StackTrace);
                    return 0;
                }
            }
            else if(s=="yes")
            {
                try
                {
                    Selling_Bill c = db.Selling_Bill.Find(id);
                    Customer cu = db.Customers.Find(c.cust_id);
                   
                     List<Dead_Products> dp =  db.Dead_Products.Where(a => a.bill_id == c.bill_id).ToList();
                    if (dp.Count == 0)
                    {
                        cu.cust_balance -= c.total - c.bill_paid;
                        cust.updateCutomer(cu);
                        var li = db.Selling_Bill_Details.Where(a => a.bill_id == c.bill_id).ToList();
                        foreach (var i in li)
                        {
                            Product p = db.Products.Find(i.product_id);
                            p.product_quantity += i.product_quantity;
                        }
                        db.Selling_Bill.Remove(c);
                        db.SaveChanges();
                        return 1;
                    }
                    else {
                        MessageBox.Show("هذه الفاتوره عليها مرتجعات ولا يمكن حذفها");
                        return 0;
                    }
                  
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
        //get selling bill details;
        public Selling_Bill_Details getBillDetailsByBillId(int B_id,int p_id)
        {
            try
            {
             return   db.Selling_Bill_Details.First(a => a.bill_id == B_id && a.product_id == p_id);
            }
            catch
            {
                return null;
            }
            
        }
        //get selling bil
        public Selling_Bill getSellingBillByid(int id)
        {
            try
            {
                return db.Selling_Bill.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public int updateSellingBil(Selling_Bill sb)
        {
            try
            {
               Selling_Bill b= db.Selling_Bill.Find(sb.bill_id);
                b.total = sb.total;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int updateSellingBillDetails(Selling_Bill_Details sbd)
        {
            try
            {
                Selling_Bill_Details bd= db.Selling_Bill_Details.Find(sbd.bill_id, sbd.product_id);
                bd.product_quantity = sbd.product_quantity;
                bd.product_price = sbd.product_price;
                db.SaveChanges();
                return 1;
            }catch
            {
                return 0;
            }
        }
    }
}
