using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.DB;
using POS.DAL;

namespace POS.UI
{
    public partial class DisplayCustomerAcount : Form
    {
        CustomerDal cdal = new CustomerDal();
        List<Customer> l = new List<Customer>();
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        Paying_Motion pmc = new Paying_Motion();
        public DisplayCustomerAcount()
        {
            InitializeComponent();
        }

        private void CustomerName_Click(object sender, EventArgs e)
        {

        }

      

        private void DisplayCustomerAcount_Load(object sender, EventArgs e)
        {


            l = cdal.getAllCutomers();
            custText.DataSource = l;
            custText.DisplayMember = "cust_name";
            custText.ValueMember = "cust_balance";
            try {
                balanceText.Text = custText.SelectedValue.ToString();
            } catch { }
          
        }

     

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try {
                var v = l.First(a => a.cust_name == custText.Text.ToString());
                if (Convert.ToDouble(newVendBal.Value) <= v.cust_balance)
                {
                    v.cust_balance -= Convert.ToDouble(newVendBal.Value);
                    // Console.Write(v.ven_balance);
                    int res = cdal.updateCutomer(v);
                    pmc.entity_id = v.cust_id;
                    pmc.entity_type = 2;
                    pmc.paid_value = Convert.ToDouble(newVendBal.Value);
                    pmc.user_id = Util.MySession.userId;
                    pmc.paying_date = DateTime.Now;
                    pmc.paying_note = noteText.Text;
                    db.Paying_Motion.Add(pmc);
                    db.SaveChanges();
                    if (res == 1)
                    {
                        MessageBox.Show("تم تعديل حساب العميل  واصبح ==>   " + v.cust_balance);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ ");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("القيمة المدخلة اكبر من حساب العميل");
                    newVendBal.Text = "0";
                }

            } catch {
                return;
            }
          
        }

        private void vendText_SelectedIndexChanged(object sender, EventArgs e)
        {
            balanceText.Text = custText.SelectedValue.ToString();
        }
    }
}
