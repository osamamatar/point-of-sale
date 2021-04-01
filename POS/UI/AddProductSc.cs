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

        private void AddProductSc_Load(object sender, EventArgs e)
        {
            catText.DataSource = pdal.getAllCategorys();
            catText.DisplayMember = "cat_description";
            catText.ValueMember = "cat_id";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            ProductDto pdto = new ProductDto();
           
            pdto.name = nametext.Text;
            pdto.cat = catText.Text;
            pdto.color = colorText.Text;
            pdto.cost =(float) costInput.Value;
            pdto.end_price = (float)endPriceInput.Value;
            pdto.price = (float)priceInput.Value;
            pdto.quantity =Convert.ToInt32(quntInput.Value);
            pdto.brand = brandText.Text;
            pdto.expire_date = dateTimeInput.Value;
            if (pdto.name.Length != 0 && pdto.brand.Length != 0)
            {
             int res=   pbal.createProduct(pdto);
                if (res == 1)
                {
                    MessageBox.Show("تم حفظ المنتج");
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
}
