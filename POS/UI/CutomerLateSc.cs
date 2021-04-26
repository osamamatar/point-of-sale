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
using POS.DB;
namespace POS.UI
{
    public partial class CutomerLateSc : Form
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        public CutomerLateSc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CutomerLateSc_Load(object sender, EventArgs e)
        {
            double sum = 0;
            List<Customer>l= new CustomerDal().getAllCutomers();
            dataGridView1.DataSource = l;
            foreach (var i in l)
            {
                sum +=(double) i.cust_balance;
            }
            total.Text = sum.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Reporting.custLateRpt srpt = new Reporting.custLateRpt();
            Reporting.printSc frm = new Reporting.printSc();

            //MessageBox.Show(sb.bill_id.ToString());
            srpt.SetDataSource(db.Customers.Where(a=>a.cust_balance>0).ToList());
            frm.crystalReportViewer1.ReportSource = srpt;
            frm.ShowDialog();
        }
    }
}
