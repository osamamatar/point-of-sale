using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
namespace POS.DAL
{
    class CustomerDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        //create new cutomer
        public int createCustomer(Customer c)
        {
            try
            {
                db.Customers.Add(c);
                db.SaveChanges();
                return 1;
            }catch(Exception e)
            {
                Console.Write(e.StackTrace);
                return 0;
            }
        }
        //get customer by id
        public Customer getCustomerById(int id)
        {
            return db.Customers.First(cu => cu.cust_id == id);
        }

        //delete customer
        public int deletecustomer(int id)
        {
            try
            {
                Customer c= db.Customers.Find(id);
                db.Customers.Remove(c);
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return 0;
            }
        }
        //select all customers
        public List<Customer> getAllCutomers()
        {
            return db.Customers.ToList();
        }
        //update cutomer 
        public int updateCutomer(Customer c)
        {
            try
            {
                Customer cu = db.Customers.Find(c.cust_id);
                cu.cust_name = c.cust_name;
                cu.cust_address = c.cust_address;
                cu.cust_balance = c.cust_balance;
                cu.cust_score = c.cust_score;
                cu.cust_note = c.cust_note;
                cu.cust_phone = c.cust_phone;
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e.StackTrace);
                return 0;
            }
        }
    }
}
