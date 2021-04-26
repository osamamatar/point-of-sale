using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DAL;
using POS.BAL;
using POS.dto;
using POS.DB;

namespace POS.UI
{
    public partial class DisplayVendorAcount : Form
    {
        VendorBal vbal = new VendorBal();
       
        List<VendorDto> l = new List<VendorDto>();
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        Paying_Motion pmv = new Paying_Motion();
        public DisplayVendorAcount()
        {
            InitializeComponent();
        }

        private void DisplayVendorAcount_Load(object sender, EventArgs e)
        {

             l = vbal.listOfVendors();
            vendText.DataSource = l;
            vendText.DisplayMember = "ven_name";
            vendText.ValueMember = "ven_balance";
            try {
                balanceText.Text = vendText.SelectedValue.ToString();
            } catch { }
            


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try {
                var v = l.First(a => a.ven_name == vendText.Text.ToString());
                if (Convert.ToDouble(newVendBal.Value) <= v.ven_balance)
                {
                    v.ven_balance -= Convert.ToDouble(newVendBal.Value);
                    // Console.Write(v.ven_balance);
                    try
                    {
                        vbal.updateVendor(v);
                        pmv.entity_id = v.ven_id;
                        pmv.entity_type = 1;
                        pmv.paid_value = Convert.ToDouble(newVendBal.Value);
                        pmv.user_id = Util.MySession.userId;
                        pmv.paying_date = DateTime.Now;
                        pmv.paying_note = noteText.Text;
                        db.Paying_Motion.Add(pmv);
                        db.SaveChanges();

                        MessageBox.Show("تم تعديل حساب المورد  واصبح ==>   " + v.ven_balance);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("حدث خطأ ");
                        this.Close();
                    }


                }
                else
                {
                    MessageBox.Show("القيمة المدخلة اكبر من حساب المورد");
                    newVendBal.Text = "0";
                }
            } catch {
                return;
            }
         
           
        }

        private void vendText_SelectedIndexChanged(object sender, EventArgs e)
        {
            balanceText.Text = vendText.SelectedValue.ToString();
        }
    }
}
