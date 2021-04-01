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

namespace POS.UI
{
    public partial class AllUsersSc : Form
    {


        UserBalImpl u = new UserBalImpl();
        RolDal role = new RolDal();
        string id;
        public AllUsersSc()
        {
            InitializeComponent();
        }
    
        private void AllUsersSc_Load(object sender, EventArgs e)
        {

           
            dataGridView.AutoGenerateColumns=false;

            dataGridView.DataSource = u.listOfUsers();

            //dataGridView.ClearSelection();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            id = dataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

         
           u.deleteUser(id);
            MessageBox.Show("تم حذف المستخدم");
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = u.listOfUsers();

         

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userDto user = new userDto();
            user.user_id = Int32.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString().Trim());
            user.user_full_name = nameText.Text;
            user.user_name = userNameText.Text;
            user.user_pass = passwordText.Text;
            user.user_role =jobVal.Text;
            u.updateUser(user);
           
            MessageBox.Show("تم تعديل المستخدم");
            this.Close();
            new AllUsersSc().Show();
          

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            nameText.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            userNameText.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            passwordText.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();

            jobVal.DataSource = new DAL.RolDal().getAllRoll();
            jobVal.DisplayMember = "role_description";
            jobVal.ValueMember = "role_id";
            jobVal.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();




        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddUserSc().ShowDialog();
        }
    }
}
