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
namespace POS.UI
{
    public partial class ExpensesSc : Form
    {
        UserDalImpl user = new UserDalImpl();
        ExpensDal ex = new ExpensDal();
        public ExpensesSc()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            ExpensDto expen = new ExpensDto();
            expen.cost = (float) costText.Value;
            expen.description = destext.Text;
            expen.date = dateText.Value;
            expen.user_name = usersNames.Text;
            if (expen.user_name != null&& expen.cost!=0&&expen.description.Length!=0&& expen.description.Length<=50 && usersNames.SelectedIndex>-1)
            {
                ex.createExpense(expen);
                dataGridView.DataSource = ex.getListOfExpenses();
                total.Text = Convert.ToString(ex.getTotalExpens());
                costText.Value = 0;
                destext.Text = "";
                dateText.Value = DateTime.Now;
              

            }
            else
            {
                MessageBox.Show("من فضل ادخل البيات بشكل صحيح");
            }

           
        }

        private void ExpensesSc_Load(object sender, EventArgs e)
        {
            var lis = ex.getListOfExpenses();
            usersNames.DataSource = user.getListOfUsersNames();
            dataGridView.DataSource =lis ;
            if (dataGridView.Rows.Count != 0)
            {
                total.Text = Convert.ToString(ex.getTotalExpens());

                dateTimePicker1.Value = lis[0].date;
                dateTimePicker2.Value = lis[lis.Count - 1].date;
            }
          


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
           
            
            if (dataGridView.Rows.Count != 0)
            {
                ExpensDto expens = new ExpensDto();

                expens.id = Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString());

                ex.deleteEpense(expens);
                dataGridView.DataSource = ex.getListOfExpenses();
                try {
                    total.Text = Convert.ToString(ex.getTotalExpens());
                } catch { }
              
            }
           
        }

        private void periodBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count != 0)
            {
                float sum = 0;
                var l = ex.getSearchedListOfExpenses(dateTimePicker1.Value, dateTimePicker2.Value);
                dataGridView.DataSource = l;
                foreach (var i in l)
                {
                    sum += i.cost;
                }
                total.Text = sum.ToString();
            }
           
        }
    }
}
