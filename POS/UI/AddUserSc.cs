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
using POS.BAL;

namespace POS.UI
{
    public partial class AddUserSc : Form
    {
        User u = new User();
        UserBalImpl userBal = new UserBalImpl();
        public AddUserSc()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            u.user_full_name = nameText.Text.Trim();
            u.user_name = userNameText.Text.Trim();
            u.role_id = (jobVal.Text== "مدير") ? 1 : 2;
            u.user_pass = passwordText.Text.Trim();
            int valid=userBal.createUser(u);
            if (valid == 1)
            {
                MessageBox.Show(" تم حفظ المستخدم");
               
                this.Close();
            }
            else
            {
                MessageBox.Show("لم يتم الحفظ");
            }
           
            
           



        }

        private void AddUserSc_Load(object sender, EventArgs e)
        {
            jobVal.DataSource = new DAL.RolDal().getAllRoll();
            jobVal.DisplayMember = "role_description";
            jobVal.ValueMember = "role_id";
            


        }
    }
}
