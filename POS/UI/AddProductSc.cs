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
using POS.dto;
using POS.BAL;
namespace POS.UI
{
    public partial class AddProductSc : Form
    {
        ProductDal pdal = new ProductDal();
        ProductBal pbal = new ProductBal();

        public AddProductSc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        void empty()
        {

        }
        private void AddProductSc_Load(object sender, EventArgs e)
        {
            catText.DataSource = pdal.getAllCategorys();
            catText.DisplayMember = "cat_description";
            catText.ValueMember = "cat_id";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var l = pdal.getAllProducts();
            ProductDto pdto = new ProductDto();
            bool isExcet = false;
           foreach(var i in l)
            {
                if (nametext.Text == i.product_name)
                {
                    isExcet = true;
                    break;
                }
            }
            if (costInput.Text.Length!=0 &&endPriceInput.Text.Length!=0 &&priceInput.Text.Length!=0) {
                if (!isExcet)
                {
                    pdto.name = nametext.Text;
                    pdto.cat = catText.Text;
                    pdto.color = colorText.Text;
                    pdto.cost = float.Parse(costInput.Text.Trim());
                    pdto.end_price = float.Parse(endPriceInput.Text);
                    pdto.price = float.Parse(priceInput.Text);
                    pdto.quantity = Convert.ToInt32(quntInput.Value);
                    pdto.brand = brandText.Text;
                    pdto.expire_date = dateTimeInput.Value;
                    pdto.minQunt = Convert.ToInt32(minquntInput.Value);
                    if (pdto.name.Length != 0 && pdto.brand.Length != 0 && pdto.price > pdto.cost && pdto.end_price > pdto.cost && pdto.end_price >= pdto.price)
                    {
                        int res = pbal.createProduct(pdto);
                        if (res == 1)
                        {
                            MessageBox.Show("تم حفظ المنتج");
                            this.Close();
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
                else
                {
                    MessageBox.Show("هذا الاسم موجود من قبل ");
                }
            }
       
          
          
           

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
