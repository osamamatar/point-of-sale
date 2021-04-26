using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.dto;
using POS.DB;
using POS.Util;
using POS.DAL;
using System.Windows.Forms;

namespace POS.DAL
{
    class DeadProdcutDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        UserDalImpl user = new UserDalImpl();
        CustomerDal cdal = new CustomerDal();
        SillingBillDal sdal = new SillingBillDal();
        
        ProductDal pdal = new ProductDal();

        //create dead product
        public int createDeadProduct(DeadProductDto dead)
        {

            Dead_Products d = new Dead_Products();
            d.bill_id = dead.sillingBillId;
            d.note = dead.note;
            d.quantity = dead.quntity;
            d.user_id = user.getUserIdByName(dead.user_name.Trim());
            d.product_id = pdal.getProductIdByName(dead.name.Trim());
            d.process_date = dead.processDate;
            Selling_Bill_Details billDetails = sdal.getBillDetailsByBillId(dead.sillingBillId, d.product_id);
            Selling_Bill bil = sdal.getSellingBillByid(dead.sillingBillId);
            Customer cu = cdal.getCustomerById(bil.cust_id);
            //to do edit bill and client balance 
            try
            {
               // MessageBox.Show(bil.cust_id + " " + cu.cust_id);
                if (d.quantity <= billDetails.product_quantity)
                {
                   
                    Product p = pdal.getProductById(dead.name.Trim());
                    p.product_quantity += dead.quntity;
                  
                    billDetails.product_quantity -= dead.quntity;
                   // billDetails.product_price -= dead.quntity * p.product_price;
                    bil.total -= dead.quntity * (billDetails.product_price-billDetails.profuct_discount);

                    cu.cust_balance -= dead.quntity * (billDetails.product_price - billDetails.profuct_discount);
                    cdal.updateCutomer(cu);
                    sdal.updateSellingBil(bil);
                    sdal.updateSellingBillDetails(billDetails);
                    pdal.updateProduct(p);
                    db.Dead_Products.Add(d);
                    db.SaveChanges();
                    return 1;
                }else
                {

                    return 0;
                }

               
                
            }
            catch
            {
                return 0;
            }


        }

        //select all dead product
        public List<DeadProductDto> getAllDeadProducts()
        {

            List<DeadProductDto> li = new List<DeadProductDto>();

            try
            {
                List<Dead_Products> l = db.Dead_Products.ToList();
                foreach (var i in l)
                {
                    DeadProductDto ddto = new DeadProductDto();
                    ddto.id =i.id;
                    ddto.name =pdal.getProductNameById(i.product_id);
                    ddto.note = i.note;
                    ddto.quntity =(int) i.quantity;
                    ddto.user_name = user.getUserNameById((int)i.user_id);
                    ddto.processDate =i.process_date;
                    ddto.sillingBillId = (int)i.bill_id;

                    li.Add(ddto);
                }
                return li;
            }
            catch(Exception e)
            {
                MessageBox.Show("error happend "+ e.Message);
                return null;
            }

        }

        //update dead product 
        public int updateDeadProduct(DeadProductDto dead)
        {
            return 0;
        }

    }
}
