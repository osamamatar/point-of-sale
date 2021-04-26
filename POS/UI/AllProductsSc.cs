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
using POS.dto;
namespace POS.UI
{
    public partial class AllProductsSc : Form
    {
        ProductBal pbal = new ProductBal();
        ProductDal pdal = new ProductDal();
        
        public AllProductsSc()
        {
            InitializeComponent();
        }

        private void AllProductsSc_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = pbal.getListOfProducts();
           
               // dataGridView1.Rows[0].Cells[0].Selected = false;
            
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0) {

                nametext.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                brandText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                colorText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                quntInput.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                costInput.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                priceInput.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                minQuntInput.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[6].Value.ToString());
                //dateTimeInput.Value= Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                endPriceInput.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                catText.DataSource = pdal.getAllCategorys();
                catText.DisplayMember = "cat_description";
                catText.ValueMember = "cat_id";
                catText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
         

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddProductSc().ShowDialog();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0&& catText.SelectedIndex>-1&& costInput.Text.Trim().Length!=0&& endPriceInput.Text.Trim().Length!=0&&priceInput.Text.Trim().Length!=0)
            {
                ProductDto pdto = new ProductDto();
                pdto.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim());
                pdto.name = nametext.Text;
                pdto.cat = catText.Text;
                pdto.color = colorText.Text;

                pdto.cost = float.Parse(costInput.Text.Trim());
                pdto.end_price = float.Parse(endPriceInput.Text.Trim());
                pdto.price = float.Parse(priceInput.Text.Trim());
                pdto.quantity = Convert.ToInt32(quntInput.Value);

                pdto.brand = brandText.Text;
                pdto.minQunt = Convert.ToInt32(minQuntInput.Value);
                pdto.expire_date = dateTimeInput.Value;
                if (pdto.name.Length != 0 && pdto.brand.Length != 0 && pdto.price > pdto.cost && pdto.end_price > pdto.cost && pdto.end_price >= pdto.price)
                {
                    int res = pbal.updateProduct(pdto);
                    if (res == 1)
                    {
                        MessageBox.Show("تم حفظ المنتج");
                        dataGridView1.DataSource = pbal.getListOfProducts();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم الحفظ");
                    }

                }
                else
                {
                    MessageBox.Show("من فضل ادخل البيانات بشكل صحيح");
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                int res = pbal.deleteProduct(id);
                if (res == 1)
                {
                    this.Close();
                    MessageBox.Show("تم حذف المنتج");
                    new AllProductsSc().Show();
                    //dataGridView1.DataSource = pdal.getAllProducts();
                }
                else
                {
                    MessageBox.Show(" لم يتم حذف المنتج ");
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = searchText.Text.Trim();
          List<ProductDto> l=   pbal.getSearchList(s);
            if (l != null)
            {
                dataGridView1.DataSource = l;
              //  MessageBox.Show(l[1].color);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void costInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void priceInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void endPriceInput_KeyPress(object sender, KeyPressEventArgs e)
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
