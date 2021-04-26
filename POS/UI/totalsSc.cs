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
namespace POS.UI
{
    public partial class totalsSc : Form
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        public totalsSc()
        {
            InitializeComponent();
        }
        void empty()
        {
            sPaid.Text = "";
            sellPaid.Text = "";
            sellTotal.Text = "";
            sellLate.Text = "";
            bPaid.Text = "";
            buyPaid.Text = "";
            buyTotal.Text = "";
            buyLate.Text = "";
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double cPaidLate = 0;
            double cPaid = 0;
            double totSell = 0;
            try {
                 cPaidLate =(double)db.Paying_Motion.Where(a => a.paying_date <= dateTime2.Value && dateTime1.Value <= a.paying_date && a.entity_type == 2).Sum(a => a.paid_value);
                // المسدد
                sPaid.Text = cPaidLate.ToString();
            } catch { }
            try {
                 cPaid = db.Selling_Bill.Where(a => a.bill_date <= dateTime2.Value && dateTime1.Value <= a.bill_date).Sum(a => a.bill_paid);
                //الموع نقدا
                sellPaid.Text = cPaid.ToString();
            } catch { }
            try {
                 totSell = db.Selling_Bill.Where(a => a.bill_date <= dateTime2.Value && dateTime1.Value <= a.bill_date).Sum(a => a.total);
                //الاجمالي
                sellTotal.Text = totSell.ToString();
                var slate = totSell - (cPaid + cPaidLate);

                //المتبقي
                sellLate.Text = slate.ToString();
            }
            catch { }
            try {
                expnse.Text = db.Expenses.Where(a => a.exp_date <= dateTime2.Value && dateTime1.Value <= a.exp_date).Sum(a => a.exp_cost).ToString();
            } catch {
            }



            double vPaidLate = 0;
            double vPaid  = 0;
            double totBuy = 0;


            try {
                 vPaidLate =(double) db.Paying_Motion.Where(a => a.paying_date <= dateTime2.Value && dateTime1.Value <= a.paying_date && a.entity_type == 1).Sum(a => a.paid_value);
                // المسدد
                bPaid.Text = vPaidLate.ToString();
            } catch { }
            try {
                 vPaid = db.Buying_Bill.Where(a => a.bill_date <= dateTime2.Value && dateTime1.Value <= a.bill_date).Sum(a => a.bill_paid);
                //الموع نقدا
                buyPaid.Text = vPaid.ToString();
            } catch { }
            try {
                 totBuy = db.Buying_Bill.Where(a => a.bill_date <= dateTime2.Value && dateTime1.Value <= a.bill_date).Sum(a => a.total);
                //الاجمالي
                buyTotal.Text = totBuy.ToString();

                var blate = totBuy - (vPaid + vPaidLate);

                //المتبقي
                buyLate.Text = blate.ToString();

            }
            catch { }
          

           
           
       
        }

        private void totalsSc_Load(object sender, EventArgs e)
        {
            
        }
    }
}
