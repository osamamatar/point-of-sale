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
using POS.dto;
using POS.Util;
namespace POS.UI
{
    public partial class AddSillingBillSc : Form
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        UserBalImpl user = new UserBalImpl();
        UserDalImpl userD = new UserDalImpl();
        CustomerDal cus = new CustomerDal();
        ProductBal pro = new ProductBal();
        SillingBillBal sbbal = new SillingBillBal();
        List<SillBillDetails> sdList = new List<SillBillDetails>();
        List<ProductDto> L = new List<ProductDto>();
        Selling_Bill sb = new Selling_Bill();
        public AddSillingBillSc()
        {
            InitializeComponent();
            L= pro.getListOfProducts();
        }
        private void AddSillingBillSc_Load(object sender, EventArgs e)
        {
            userText.DataSource = user.listOfUsers();
            userText.DisplayMember = "user_full_name";
            userText.ValueMember = "user_id";
            userText.Text = MySession.userName;
            cutText.DataSource = cus.getAllCutomers();
            cutText.DisplayMember = "cust_name";
            cutText.ValueMember = "cust_id";
            cutText.Select();
            cutText.Focus();
            prodText.DataSource = L;
            prodText.DisplayMember = "name";
            prodText.ValueMember = "price";
            if (prodText.SelectedValue != null)
            {
                PiecePriceT.Text = prodText.SelectedValue.ToString();

            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Selling_Bill sb = new Selling_Bill();
            calcBtn.PerformClick();
            sb.bill_date = dateInput.Value;
            sb.user_id = userD.getUserIdByName(userText.Text.ToString());
            sb.total =Convert.ToDouble(allTotalText.Text.Trim());
            sb.cust_id =new CustomerDal().getCutomerIdByName(cutText.Text.ToString());
            sb.bill_notes = noteText.Text;
            sb.bill_discount= Convert.ToDouble(BillDisInput.Text.Trim());
            sb.bill_other_costs= Convert.ToDouble(otherInput.Text.Trim());
            sb.bill_paid= Convert.ToDouble(PaidInput.Text.Trim());

            if (sb.total!=0&& dataGridView.Rows.Count!=0 && sb.total >= sb.bill_paid) {

                int res = sbbal.createSillingBill(sdList, sb);
                if (res == 1)
                {
                    MessageBox.Show("تم حفظ الفاتوره");
                    PrintBtn.Enabled = false;
                    AddBtn.Enabled = false;
                    calcBtn.Enabled = false;
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
                MessageBox.Show(" من فضلك ادخل بيانات الفاتورة بشكل صحيح");
            }
          


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (L.Count != 0 && cus.getAllCutomers().Count!=0)
            {
                SillBillDetails row = new SillBillDetails();
                row.Product_name = prodText.Text.ToString();
                row.Product_price = float.Parse(PiecePriceT.Text.ToString());
                row.Product_quent = Convert.ToInt32(quntInput.Value);
                if (PieceDisInput.Text.ToString().Length != 0){
                    row.Product_dicound = float.Parse(PieceDisInput.Text.ToString().Trim());
                }
                else
                {
                    row.Product_dicound = 0;
                }
                row.Product_total = (row.Product_price * row.Product_quent) - (row.Product_dicound * row.Product_quent);
                string name = row.Product_name;
                string price = row.Product_price.ToString();
                string qu = row.Product_quent.ToString();
                string d = row.Product_dicound.ToString();
                string t = row.Product_total.ToString();
                if (row.Product_name.Length != 0&& prodText.SelectedIndex>-1&&userText.SelectedIndex>-1&&cutText.SelectedIndex>-1)
                {
                    var p = L.First(a => a.name == row.Product_name);
                    if (p.quantity >= row.Product_quent && row.Product_price > row.Product_dicound)
                    {
                      //  p.quantity -= row.Product_quent;
                        if (dataGridView.Rows.Count != 0)
                        {
                            SillBillDetails f = sdList.Find(a => a.Product_name == name);
                            Console.Write(f);
                            if (f != null)
                            {
                                return;
                            }
                            else
                            {
                                object[] data = { name, price, qu, d, t };
                                dataGridView.Rows.Add(data);
                                sdList.Add(row);
                                PieceDisInput.Text = "0";
                                BillDisInput.Text = "0";
                                totalText.Text = (Convert.ToDouble(totalText.Text.ToString()) + row.Product_total) + "";
                            }
                        }
                        else
                        {
                            object[] data = { name, price, qu, d, t };
                            dataGridView.Rows.Add(data);
                            sdList.Add(row);
                            PieceDisInput.Text = "0";
                            BillDisInput.Text = "0";
                            totalText.Text = (Convert.ToDouble(totalText.Text.ToString()) + row.Product_total) + "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("تأكد من ادخال المنتج و الكمية المتاحه ");
                    }

                }
                else
                {
                    MessageBox.Show("تاكد من ادخال البيانات بشكل صحيح");
                }
            }
             





        }

        private void prodText_SelectedIndexChanged(object sender, EventArgs e)
        {
            PiecePriceT.Text= prodText.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                totalText.Text = (Convert.ToDouble(totalText.Text.ToString()) - Convert.ToDouble(dataGridView.CurrentRow.Cells[4].Value.ToString())) + "";
                int indx = sdList.FindIndex(a => a.Product_name == dataGridView.CurrentRow.Cells[0].Value.ToString());
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                sdList.RemoveAt(indx);
            }
        
              //  L[indx].quantity=
            

        }

        private void totalText_TextChanged(object sender, EventArgs e)
        {
            
           // latText.Text = (float.Parse(totalText.Text) - float.Parse(PaidInput.Value.ToString()))+"";
        }

        private void otherInput_ValueChanged(object sender, EventArgs e)
        {
           // totalText.Text = ((float.Parse(totalText.Text) +float.Parse(otherInput.Value.ToString()))) + "";
        }

        private void PaidInput_ValueChanged(object sender, EventArgs e)
        {
          // latText.Text= ((float.Parse(totalText.Text) - float.Parse(PaidInput.Value.ToString()))) + "";
        }

        private void BillDisInput_ValueChanged(object sender, EventArgs e)
        {
            
            //totalText.Text = ((float.Parse(totalText.Text) - float.Parse(BillDisInput.Value.ToString()))) + "";
            //latText.Text = ((float.Parse(totalText.Text) - float.Parse(PaidInput.Value.ToString()))) + "";
        }

        private void latText_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if(BillDisInput.Text.ToString().Length != 0)
            {
                if (float.Parse(totalText.Text.Trim()) > float.Parse(BillDisInput.Text.ToString()))
                {
                    allTotalText.Text = ((float.Parse(totalText.Text) + float.Parse(otherInput.Value.ToString()) - float.Parse(BillDisInput.Text.ToString()))) + "";
                    latText.Text = ((float.Parse(allTotalText.Text) - float.Parse(PaidInput.Value.ToString()))) + "";
                    disTextDisplay.Text = BillDisInput.Text.ToString();
                    paidTextDisplay.Text = PaidInput.Value.ToString();
                    totBeforText.Text = (float.Parse(totalText.Text) + float.Parse(otherInput.Value.ToString())) + "";
                }
                else
                {
                    MessageBox.Show("  تأكد من الخصم علي الفاتورة ");
                }
            }
            else
            {
                MessageBox.Show("  تأكد من الخصم علي الفاتورة ");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            
            Reporting.sellingBill srpt = new Reporting.sellingBill();
            Reporting.printSc frm = new Reporting.printSc();

            //MessageBox.Show(sb.bill_id.ToString());
            srpt.SetDataSource(db.getSellingBill(sb.bill_id).ToList());
            frm.crystalReportViewer1.ReportSource = srpt;
            frm.ShowDialog();
        }

        private void BillDisInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PieceDisInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
