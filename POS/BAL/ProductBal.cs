using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DAL;
using POS.dto;
using POS.DB;
namespace POS.BAL

{
    class ProductBal
    {
        ProductDal p = new ProductDal();

        //create new product
       public int createProduct(ProductDto pd)
        {
          
            int cat_id=   p.getCategoryIdByName(pd.cat);
            Product prod = new Product();
            prod.product_id = pd.id;
            prod.cat_id = cat_id;
            prod.brand_name = pd.brand;
            prod.product_name = pd.name;
            prod.product_color = pd.color;
            prod.product_cost = pd.cost;
            prod.expire_date = pd.expire_date;
            prod.end_user_price = pd.end_price;
            prod.product_price = pd.price;
            prod.product_quantity = pd.quantity;
        
            int res =  p.createProduct(prod);

            return res;
        }

        //select all products
        public List<ProductDto> getListOfProducts()
        {
            List<ProductDto> li = new List<ProductDto>();
            List<Product> l = p.getAllProducts();
            foreach(Product prod in l)
            {
                ProductDto pd = new ProductDto();
                pd.id = prod.product_id;
                pd.cat = p.getCategorynameById(Convert.ToInt32(prod.cat_id));
                pd.brand = prod.brand_name;
                pd.name = prod.product_name;
                pd.color= prod.product_color;
                pd.cost =(float) prod.product_cost;
                pd.expire_date =(DateTime) prod.expire_date;
                pd.end_price =(float) prod.end_user_price;
                pd.price = (float)prod.product_price;
                pd.quantity = prod.product_quantity;

                li.Add(pd);
            }

            return li; 
        }
        //delete product
        public int deleteProduct(int id)
        {

            return p.deleteProduct(id);
        }

        //ubdate product 
        public int updateProduct(ProductDto pd)
        {
            int cat_id = p.getCategoryIdByName(pd.cat);
            Product prod = new Product();
            prod.product_id = pd.id;
            prod.cat_id = cat_id;
            prod.brand_name = pd.brand;
            prod.product_name = pd.name;
            prod.product_color = pd.color;
            prod.product_cost = pd.cost;
            prod.expire_date = pd.expire_date;
            prod.end_user_price = pd.end_price;
            prod.product_price = pd.price;
            prod.product_quantity = pd.quantity;
         return   p.updateProduct(prod);
        }

        //selected searched list
        public List<ProductDto> getSearchList(String s)
        {
            List<ProductDto> li = new List<ProductDto>();
            List<Product> l = p.getSearchProducts(s);
            foreach (Product prod in l)
            {
                ProductDto pd = new ProductDto();
                pd.id = prod.product_id;
                pd.cat = p.getCategorynameById(Convert.ToInt32(prod.cat_id));
                pd.brand = prod.brand_name;
                pd.name = prod.product_name;
                pd.color = prod.product_color;
                pd.cost = (float)prod.product_cost;
                pd.expire_date = (DateTime)prod.expire_date;
                pd.end_price = (float)prod.end_user_price;
                pd.price = (float)prod.product_price;
                pd.quantity = prod.product_quantity;

                li.Add(pd);
            }

            return li;
        }

    }
   
    
}
