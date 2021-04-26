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
using POS.DB;
using POS.Util;
namespace POS.UI
{
    public partial class AddBuyingBillSc : Form
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        UserBalImpl user = new UserBalImpl();
        UserDalImpl userD = new UserDalImpl();
        VendorDal ven = new VendorDal();
        ProductBal pro = new ProductBal();
        BuyingBillBal sbbal = new BuyingBillBal();
        List<BuyingBillDetails> sdList = new List<BuyingBillDetails>();
        Buying_Bill sb = new Buying_Bill();
        public AddBuyingBillSc()
        {
            InitializeComponent();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBuyingBillSc_Load(object sender, EventArgs e)
        {

            userText.DataSource = user.listOfUsers();
            userText.DisplayMember = "user_full_name";
            userText.ValueMember = "user_id";
            userText.Text = MySession.userName;
            VendText.DataSource = ven.listOfvendors();
            VendText.DisplayMember = "vend_name";
            VendText.ValueMember = "vend_id";
            VendText.Select();
            VendText.Focus();

            prodText.DataSource = pro.getListOfProducts();
            prodText.DisplayMember = "name";
            prodText.ValueMember = "cost";
            if (prodText.SelectedValue!=null)
            {
                PiecePriceT.Text = prodText.SelectedValue.ToString();
            }
          
        }

        private void prodText_SelectedIndexChanged(object sender, EventArgs e)
        {
            PiecePriceT.Text = prodText.SelectedValue.ToString();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
           
            if (pro.getListOfProducts().Count != 0 && ven.listOfvendors().Count!=0) {
                BuyingBillDetails row = new BuyingBillDetails();
                row.Product_name = prodText.Text.ToString();
                row.Product_price = float.Parse(PiecePriceT.Text.ToString());
                row.Product_quent = Convert.ToInt32(quntInput.Value);
                row.Product_total = (row.Product_price * row.Product_quent);
                string name = row.Product_name;
                string price = row.Product_price.ToString();
                string qu = row.Product_quent.ToString();
                string t = row.Product_total.ToString();
                
                    if (row.Product_name.Length != 0 && prodText.SelectedIndex > -1 && userText.SelectedIndex > -1 && VendText.SelectedIndex > -1)
                    {
                    if (dataGridView.Rows.Count != 0)
                    {
                        BuyingBillDetails f = sdList.Find(a => a.Product_name == name);
                        Console.Write(f);
                        if (f != null)
                        {
                            return;
                        }
                        else
                        {
                            object[] data = { name, price, qu, t };
                            dataGridView.Rows.Add(data);
                            sdList.Add(row);

                            totalText.Text = (float.Parse(totalText.Text.ToString()) + row.Product_total) + "";
                        }
                    }
                    else
                    {
                        object[] data = { name, price, qu, t };
                        dataGridView.Rows.Add(data);
                        sdList.Add(row);

                        totalText.Text = (float.Parse(totalText.Text.ToString()) + row.Product_total) + "";
                    }
                }
                else
                {
                    MessageBox.Show("تاكد من ادخال البيانات بشكل صحيح");
                }

            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                totalText.Text = (float.Parse(totalText.Text.ToString()) - Convert.ToDouble(dataGridView.CurrentRow.Cells[3].Value.ToString())) + "";
                int indx = sdList.FindIndex(a => a.Product_name == dataGridView.CurrentRow.Cells[0].Value.ToString());
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                sdList.RemoveAt(indx);
            }
       
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
         
                allTotalText.Text = ((float.Parse(totalText.Text) + float.Parse(otherInput.Value.ToString()))) + "";
                latText.Text = ((float.Parse(allTotalText.Text) - float.Parse(PaidInput.Value.ToString()))) + "";
                paidTextDisplay.Text = PaidInput.Value.ToString();
           
         
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //  Buying_Bill sb = new Buying_Bill();
            calcBtn.PerformClick();
            sb.bill_date = dateInput.Value;
            sb.user_id = userD.getUserIdByName(userText.Text.ToString());
            sb.total = Convert.ToDouble(allTotalText.Text.Trim());
            sb.vend_id = new VendorDal().getVendorIdByName(VendText.Text.ToString());
            sb.bill_notes = noteText.Text;         
            sb.bill_other_costs = Convert.ToDouble(otherInput.Value);
            sb.bill_paid = Convert.ToDouble(PaidInput.Value);
            if (sb.total != 0 && dataGridView.Rows.Count != 0&&sb.total>=sb.bill_paid)
            {
                
                int res = sbbal.createBuyingBill(sdList, sb);
                if (res == 1)
                {
                    MessageBox.Show("تم حفظ الفاتوره");
                   
                    AddBtn.Enabled = false;
                    calcBtn.Enabled = false;
                    print.Enabled = true;
                    saveBtn.Enabled = false;
                    print.Enabled = true;
                }
                else
                {
                    MessageBox.Show("لم يتم حفظ الفاتوره ");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("من فضلك ادخل بيانات الفاتورة بشكل صحيح");
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            Reporting.buying brpt = new Reporting.buying();
            Reporting.printSc frm = new Reporting.printSc();

            //MessageBox.Show(sb.bill_id.ToString());
            brpt.SetDataSource(db.getBuyinglingBill(sb.bill_id).ToList());
            frm.crystalReportViewer1.ReportSource = brpt;
            frm.ShowDialog();
        }
    }
}
