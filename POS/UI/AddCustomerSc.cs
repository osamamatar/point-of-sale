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
    public partial class AddCustomerSc : Form
    {
        CustomerDal cdal = new CustomerDal();
        public AddCustomerSc()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.cust_name = nameText.Text;
            c.cust_address = addText.Text;
            c.cust_note = noteText.Text;
            c.cust_phone = phoneText.Text;
            c.cust_balance =(float) balanceInput.Value;
            c.cust_score = (int)scoreInput.Value;
            if (c.cust_name.Length!=0&&c.cust_address.Length!=0)
            {
                int res = cdal.createCustomer(c);
                if (res == 1)
                {
                    MessageBox.Show(" تم حفظ العميل");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" لم يتم حفظ العميل");
                }
            }
            
        }
    }
}
