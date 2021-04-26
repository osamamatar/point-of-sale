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
using POS.dto;
namespace POS.UI
{
    public partial class VendorLateSc : Form
    {
        DB.Point_Of_SaleEntities1 db = new DB.Point_Of_SaleEntities1();
        public VendorLateSc()
        {
            InitializeComponent();
        }

        private void VendorLateSc_Load(object sender, EventArgs e)
        {
            double sum = 0;
            List<VendorDto> l = new VendorBal().listOfVendors();
            dataGridView1.DataSource =l ;
            foreach(var i in l)
            {
                sum += i.ven_balance;
            }
            total.Text = sum.ToString();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Reporting.vendLateRep srpt = new Reporting.vendLateRep();
            Reporting.printSc frm = new Reporting.printSc();

            //MessageBox.Show(sb.bill_id.ToString());
            srpt.SetDataSource(db.Vendors.Where(a=>a.vend_balance>0).ToList());
            frm.crystalReportViewer1.ReportSource = srpt;
            frm.ShowDialog();
        }
    }
}
