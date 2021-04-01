using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using POS.dto;

namespace POS.DAL
{
    class VendorDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();

      public  void createVendor(Vendor v)
        {
            try
            {
               // db.Vendors.
                db.Vendors.Add(v);
                db.SaveChanges();
                
            }
            catch(Exception e)
            {
                throw e;
                
            }
           
        }

      public void deleteVendor(string id)
        {
            
                try
                {
                    db.Vendors.Remove(this.getVendorById(id));
                db.SaveChanges();
                }
                catch (Exception e){
                
                    throw e;
            }

        }

      public  List<Vendor> listOfvendors()
        {
            return db.Vendors.ToList();
        }


    
     
   
        public Vendor getVendorById(string id)
        {

            int ven_id = Convert.ToInt32(id);

            Vendor ve = db.Vendors.First(v => v.vend_id == ven_id);
            return ve;
        }
          /*  public List<Vendor> getSearchList(String name)
            {
                List<Vendor> li = new List<Vendor>();
                  db.Vendors.Select
            
                return li;
            }*/
        public void updateVendor(VendorDto ven)
        {
            Vendor result = db.Vendors.SingleOrDefault(v => v.vend_id == ven.ven_id);
            if (result != null)
            {
                result.vend_name = ven.ven_name;
                result.vend_address = ven.ven_address;
                result.vend_note = ven.ven_note;
                result.vend_phone = ven.ven_phone;
                
                db.SaveChanges();
            }
        }

    }
}
