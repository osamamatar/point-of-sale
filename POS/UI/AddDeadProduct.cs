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
using POS.Util;

namespace POS.UI
{
    public partial class AddDeadProduct : Form
    {
        ProductBal pbal = new ProductBal();
        UserBalImpl ubal = new UserBalImpl();
        SillingBillDal sdal = new SillingBillDal();
        DeadProdcutDal dpdal = new DeadProdcutDal();
        List<ProductDto> pl = new List<ProductDto>();
        List<userDto> ul = new List<userDto>();
        List<bill> bl = new List<bill>();

        public AddDeadProduct()
        {
            InitializeComponent();
        }

      

        private void AddDeadProduct_Load(object sender, EventArgs e)
        {
             pl = pbal.getListOfProducts();
             ul= ubal.listOfUsers();
            bl = sdal.getALLSellingBills();

            userText.DataSource = ul;
            userText.DisplayMember = "user_full_name";
            userText.ValueMember = "user_id";

            nameText.DataSource = pl;
            nameText.DisplayMember = "name";
            nameText.ValueMember = "id";

            billText.DataSource = bl;
            billText.DisplayMember = "id";
            billText.ValueMember = "id";


        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
          
           
         //   var q = bl.First(a => a.id == dd.sillingBillId);
            if (Convert.ToInt32(quntInput.Value) > 0&& nameText.SelectedIndex > -1 &&userText.SelectedIndex>-1&&billText.SelectedIndex>-1)
            {
                DeadProductDto dd = new DeadProductDto();

                dd.sillingBillId = Convert.ToInt32(billText.Text.ToString().Trim());

                dd.name = nameText.Text.Trim();
                dd.quntity = Convert.ToInt32(quntInput.Value);
                dd.processDate = dateText.Value;
                dd.user_name = userText.Text.Trim();
                dd.note = noteText.Text;
                int res= dpdal.createDeadProduct(dd);
                if (res == 1)
                {
                    MessageBox.Show("تم اضافة المنتج للمرتجعات");
                    this.Close();
                }else
                {
                    MessageBox.Show("حدث خطأ  ", "رسالة" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ادخل البيانات بشكل صحيح ");
            }
        }
    }
}
