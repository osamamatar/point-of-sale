using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.BAL;
using POS.DAL;
using POS.DB;
namespace POS.UI
{ 
    public partial class AllCustomerSc : Form
    {
        CustomerDal cdal = new CustomerDal();
         public AllCustomerSc()
        {
            InitializeComponent();
        }

        private void DisplayCusBtn_Click(object sender, EventArgs e)
        {
            new DisplayCustomerAcount().ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddCustomerSc().ShowDialog();

        }

        private void AllCustomerSc_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = cdal.getAllCutomers();
            if (Util.MySession.userRole == "مدير")
            {
                DeleteBtn.Enabled = true;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                DialogResult r = MessageBox.Show(" هل انت متأكد من حذف العميل ؟ سوف يتم حذف كل الفواتير المتعلقه بهذا العميل", "تحذير", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());
                    int res = cdal.deletecustomer(id);
                    if (res == 1)
                    {
                        dataGridView.DataSource = cdal.getAllCutomers();
                        MessageBox.Show("تم حذف العميل");
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حذف العميل");
                    }
                }
                else
                {
                    MessageBox.Show("لم يتم حذف العميل");
                }
               
            }
          
        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            new AddCustomerSc().ShowDialog();
            this.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            nameText.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            addText.Text= dataGridView.CurrentRow.Cells[2].Value.ToString();
          //  balanceInput.Value=Convert.ToInt32(dataGridView.CurrentRow.Cells[3].Value.ToString());
            scoreInput.Value= Convert.ToInt32(dataGridView.CurrentRow.Cells[4].Value.ToString());
            noteText.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            phoneText.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                Customer cu = new Customer();

                cu.cust_id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString().Trim());

                cu.cust_name = nameText.Text;
                cu.cust_address = addText.Text;
                cu.cust_phone = phoneText.Text;
                cu.cust_score = (int)scoreInput.Value;
                cu.cust_note = noteText.Text;
                // cu.cust_balance = (float)balanceInput.Value;
                int res = cdal.updateCutomer(cu);
                if (res == 1)
                {
                    MessageBox.Show("تم تعديل العميل");
                    dataGridView.DataSource = cdal.getAllCutomers();
                }
                else
                {
                    MessageBox.Show("لم يتم تعديل العميل");
                }
            }
        }
    }
}
