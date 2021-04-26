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
namespace POS.UI
{
    public partial class DashboardSc : Form
    {
        DB.Point_Of_SaleEntities1 db = new DB.Point_Of_SaleEntities1();
        public DashboardSc()
        {
            InitializeComponent();
            panel.Visible = false;
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardSc_Load(object sender, EventArgs e)
        {
            if (Util.MySession.userRole == "مدير")
            {
                المستخدمينToolStripMenuItem.Enabled = true;
            }
            List<string> np = new ProductBal().getNotifyProducts();
            if (np.Count != 0)
            {
                panel.Visible = true;
               foreach(var i in np)
                {
                    dataGridView1.Rows.Add(i.ToString());
                }
              
            }
              
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ExpensesSc().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AllSillingBillSc().ShowDialog();
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
            System.Windows.Forms.Application.Exit();
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

        private void المنتجاتالتالفهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllDeadProductSc().ShowDialog();
        }

        private void اضافةمنتجتالفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddDeadProduct().ShowDialog();
        }

        private void مبيعاتجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddSillingBillSc().ShowDialog();
        }

        private void مبيعاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AllSillingBillSc().ShowDialog();
        }

        private void مشترياتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AllBuyingBillSc().ShowDialog();
        }

        private void مشترياتجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddBuyingBillSc().ShowDialog();
        }

        private void أجلالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new VendorLateSc().ShowDialog();
        }

        private void أجلالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CutomerLateSc().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AllBuyingBillSc().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddBuyingBillSc().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new AddSillingBillSc().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new AllCustomerSc().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AllVendorSc().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new AddProductSc().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new AddCustomerSc().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new AddVendorSc().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new AllProductsSc().ShowDialog();
          
        }

        private void سداداجلالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayVendorAcount().ShowDialog();
        }

        private void مبيعاتشهريهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DisplayCustomerAcount().ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new AllDeadProductSc().ShowDialog();
        }

        private void exitPanal_Click(object sender, EventArgs e)
        {
            panel.Hide();
        }

        private void قائمةاسعارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporting.priceList pl = new Reporting.priceList();
            Reporting.printSc frm = new Reporting.printSc();
            pl.SetDataSource(db.Products.OrderBy(a => a.product_name).ToList());
            frm.crystalReportViewer1.ReportSource = pl;
            frm.ShowDialog();
        }

        private void مشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllBuyingBillSc().ShowDialog();
        }

        private void مبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AllSillingBillSc().ShowDialog();
        }

        private void أرباحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new totalsSc().ShowDialog();
        }

        private void حركةالسدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PaingMotionSc().ShowDialog();
        }
    }
}
