using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UI
{
    public partial class DashboardSc : Form
    {
        public DashboardSc()
        {
            InitializeComponent();
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardSc_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void كلالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllUsersSc().ShowDialog();

        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            new AddUserSc().ShowDialog();

        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void أضافةعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddCustomerSc().ShowDialog();
        }

        private void جميعالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllCustomerSc().ShowDialog();
        }

        private void AddVendorBtn_Click(object sender, EventArgs e)
        {
            new AddVendorSc().ShowDialog();
        }

        private void AllVendorBtn_Click(object sender, EventArgs e)
        {
            new AllVendorSc().ShowDialog();
        }

        private void كلالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void حولالمطورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutDevSc().Show();
        }

        private void مصروفاتشهريهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ExpensesSc().Show();
        }

        private void أضافةمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddProductSc().ShowDialog();
        }

        private void كلالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllProductsSc().ShowDialog();
        }
    }
}
