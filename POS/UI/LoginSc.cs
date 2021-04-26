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
using POS.Util;
using System.Threading;

namespace POS.UI
{
    public partial class LoginSc : Form
    {
        UserBalImpl user = new UserBalImpl();
        List<userDto> ul = new List<userDto>();
       // MySession session = new MySession();
        public LoginSc()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void splashStart()
        {
            Application.Run(new splashSc());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userNameText.Text.Length!=0 && passText.Text.Length!=0)
            {
                bool isAuth = false;
                foreach(var i in ul)
                {

                    if (i.user_name== userNameText.Text&&i.user_pass==passText.Text)
                    {
                      
                        MySession.userRole = i.user_role;
                        MySession.userName = i.user_full_name;
                        MySession.userPass = i.user_pass;
                        MySession.userId = i.user_id;
                        //this.Hide();
                        isAuth = true;
                        break;
                    }
                    else
                    {
                        isAuth = false;
                    }
                }
                if (isAuth)
                {
                    Hide();
                    new DashboardSc().ShowDialog();
                   
                }else
                {
                    MessageBox.Show(" اسم المستخدم او الرقم السري خاطئ");
                }
             



            }
       
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginSc_Load(object sender, EventArgs e)
        {
             ul = user.listOfUsers();

        }

        private void passText_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void passText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
