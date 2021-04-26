using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using POS.DAL;
using System.Windows.Forms;
using POS.dto;

namespace POS.BAL
{
    class VendorBal
    {
        VendorDal vendor = new VendorDal();
       public int createVendor(VendorDto v)
        {
            int res;
            Vendor ven = new Vendor();
            if (v.ven_name.Length!=0&& v.ven_note.Length != 0&& v.ven_phone.Length != 0&& v.ven_phone.Length != 0 && v.ven_name != "" && v.ven_note != "" && v.ven_phone != "" && v.ven_phone != "")
            {
                ven.vend_name = v.ven_name;
                ven.vend_address = v.ven_address;
                ven.vend_note = v.ven_note;
                ven.vend_phone = v.ven_phone;
               

               
                try
                {
                    vendor.createVendor(ven);
                   
                    res = 1;
                    MessageBox.Show(" تم حفظ المورد");
                }
                catch (Exception e)
                {
                   
                    res = 0;
                    MessageBox.Show("   لم يتم الحفظ خطأ في قاعدة البيانات الرجاء الاتصال بالمطور  ");
                    throw e;
                }
                return res;

            }
            else
            {
                res = 0;
                MessageBox.Show("من فضلك ادخل البيانات بشكل صحيح");
                return res;
            }
          

           
        }
        public void deleteVendor(string id)
        {
            try
            {
                 vendor.deleteVendor(id);
                Console.WriteLine(id);
                    MessageBox.Show("تم حذف المورد ");
                 }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("خطأ في قاعدة البيانات الرجاء الاتصال بالمطور");
            }
          
           
        }

       public List<VendorDto> listOfVendors()
        {
            List<VendorDto> li = new List<VendorDto>();
            for (int i = 0; i <=  vendor.listOfvendors().Count() - 1; i++)
            {
                VendorDto vend = new VendorDto();
                
                vend.ven_name = vendor.listOfvendors()[i].vend_name;
                vend.ven_id = vendor.listOfvendors()[i].vend_id;
                vend.ven_phone =vendor.listOfvendors()[i].vend_phone;
                vend.ven_note = vendor.listOfvendors()[i].vend_note;
                
                    vend.ven_balance = (float)(vendor.listOfvendors()[i].vend_balance);
                
               
               
                vend.ven_address = vendor.listOfvendors()[i].vend_address;

                li.Add(vend);

                //Console.WriteLine(user.user_name);


            }
            return li;
        }
        public void updateVendor(VendorDto v)
        {
            
                vendor.updateVendor(v);
          
               
        }
    }
}
