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
namespace POS.UI
{
    public partial class AllSillingBillSc : Form
    {
        DB.Point_Of_SaleEntities1 db = new POS.DB.Point_Of_SaleEntities1();
        SillingBillDal sdal = new SillingBillDal();
        List<Util.bill> lis = new List<Util.bill>();
        public AllSillingBillSc()
        {
            InitializeComponent();
        }

        private void AllSillingBillSc_Load(object sender, EventArgs e)
        {
            if (Util.MySession.userRole == "مدير")
            {
                deleteBtn.Enabled = true;
            }
            lis = sdal.getALLSellingBills();
            dataGridView1.DataSource =lis ;
            double sumTotal = 0;
            double sumPaid = 0;
            double sumLate = 0;
            if (dataGridView1.Rows.Count != 0)
            {


                dateTime1.Value = lis[0].date;
                dateTime2.Value = lis[lis.Count - 1].date;
                foreach (var i in lis)
                {
                    sumTotal += i.total;
                    sumPaid += i.paid;
                    sumLate += i.late;
                }
                totaltext.Text = sumTotal.ToString();
                lateText.Text = sumLate.ToString();
                paidText.Text = sumPaid.ToString();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

             lis = sdal.getSearchedSellingBills(dateTime1.Value, dateTime2.Value);
            dataGridView1.DataSource = lis;
            double sumTotal = 0;
            double sumPaid = 0;
            double sumLate = 0;
            totaltext.Text = sumTotal.ToString();
            lateText.Text = sumLate.ToString();
            paidText.Text = sumPaid.ToString();
            if (dataGridView1.Rows.Count != 0)
            {

                dateTime1.Value = lis[0].date;
                dateTime2.Value = lis[lis.Count - 1].date;
                foreach (var i in lis)
                {
                    sumTotal += i.total;
                    sumPaid += i.paid;
                    sumLate += i.late;
                }
                totaltext.Text = sumTotal.ToString();
                lateText.Text = sumLate.ToString();
                paidText.Text = sumPaid.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialogResult = MessageBox.Show("هل تريد تعديل الكمية وحساب العميل ؟", "رسالة تأكيد", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int res = sdal.deletesllingBill(id,"yes");
                    if (res == 1)
                    {
                        this.Close();
                        MessageBox.Show(" تم حذف الفاتورة وتعديل الكمية وحساب العميل");
                        new AllSillingBillSc().Show();
                        //dataGridView1.DataSource = pdal.getAllProducts();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حذف الفاتورة ");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    int res = sdal.deletesllingBill(id, "no");
                    if (res == 1)
                    {
                        this.Close();
                        MessageBox.Show(" تم حذف الفاتورة وتعديل الكمية وحساب العميل");
                        new AllSillingBillSc().Show();
                        //dataGridView1.DataSource = pdal.getAllProducts();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حذف الفاتورة ");
                    }
                }

              

               
            }
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Reporting.sellingBill srpt = new Reporting.sellingBill();
                Reporting.printSc frm = new Reporting.printSc();

                //MessageBox.Show(sb.bill_id.ToString());
                srpt.SetDataSource(db.getSellingBill(id).ToList());
                frm.crystalReportViewer1.ReportSource = srpt;
                frm.ShowDialog();
            }
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            Reporting.sellingAll sell = new Reporting.sellingAll();
            Reporting.printSc frm = new Reporting.printSc();
            sell.SetDataSource(lis);
            frm.crystalReportViewer1.ReportSource = sell;
            frm.ShowDialog();
        }
    }
}
