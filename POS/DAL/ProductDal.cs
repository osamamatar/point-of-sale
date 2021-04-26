using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using System.Windows.Forms;

namespace POS.DAL
{
    class ProductDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        //create new product 
        public int createProduct(Product p)
        {

            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                return 1;
            }catch( Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
          
        }

        // select list of all products
        public List<Product> getAllProducts()
        {
            return db.Products.OrderBy(a => a.product_name).ToList();
        }

        //delete product by id
        public int deleteProduct(int prod_id)
        {
            int res = 0;
            try {
                Product prod = db.Products.Find(prod_id);
                db.Products.Remove(prod);
                db.SaveChanges();
                res = 1;
                return res;
            }
            catch(Exception e)
            {
                MessageBox.Show("خطأ في قاعدة البيانات");
                  Console.WriteLine(e.Message);
                return res;
            }
         
        }
        //update product
        public int updateProduct(Product pro)
        {
            int res = 0;
            try
            {
                Product prod = db.Products.SingleOrDefault(pr=>pr.product_id==pro.product_id);
                if (prod != null)
                {
                    prod.product_name = pro.product_name;
                    prod.brand_name = pro.brand_name;
                    prod.cat_id = pro.cat_id;
                    prod.expire_date = pro.expire_date;
                    prod.product_cost = pro.product_cost;
                    prod.product_price = pro.product_price;
                    prod.product_quantity = pro.product_quantity;
                    prod.end_user_price = pro.end_user_price;
                    prod.product_color = pro.product_color;
                    prod.minQunt = pro.minQunt;
                    db.SaveChanges();
                    res = 1;
                }
             
                return res;
            }
            catch (Exception e)
            {
                MessageBox.Show("خطأ في قاعدة البيانات");
                Console.WriteLine(e.Message);
                return res;
            }
        }


        //select category id by its name
        public int getCategoryIdByName(string name)
        {
         Category ca= db.Categories.First(c => c.cat_description == name);
           // Console.WriteLine(ca.cat_id);
            return ca.cat_id;
        }

        //select category name by its id
        public string getCategorynameById(int id)
        {
            Category ca = db.Categories.First(c => c.cat_id == id);
           
            return ca.cat_description;
        }

        //select all categoryes 
        public List<Category> getAllCategorys()
        {
         
            return db.Categories.ToList();
        }
        public List<Product> getSearchProducts(string s)
        {
            List<Product> li = new List<Product>() ;
            try
            {
             li=  db.Products.SqlQuery("select * from Product where product_name  LIKE N'%" + s + "%' or product_price LIKE '%" + s + "%' or brand_name  LIKE N'%" + s + "%'  ").ToList();
                
                if (li.Count == 0)
                {
                    MessageBox.Show("من فضلك ادخل اسم المنتج بشكل صحيح");
                }
               
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
              
            }
           


            return li;
        }
        public int getProductIdByName(string na)
        {
            Product p = db.Products.First(a => a.product_name == na);
            return p.product_id;
        }
        public string getProductNameById(int id)
        {
            try
            {
            Product p =   db.Products.Find(id);
                return p.product_name;
            }
            catch
            {
                //MessageBox.Show("")
                return null;
            }
        }
        public Product getProductById(string n)
        {
            try
            {
                Product p = db.Products.First(a => a.product_name == n);
                return p;
            }catch
            {
                MessageBox.Show("خطأ في جلب بعض البيانات ");
                return null;
            }
        }
    }

}
