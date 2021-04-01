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
using POS.DB;
using POS.dto;

namespace POS.UI
{
    public partial class AllVendorSc : Form
    {
        VendorBal Vend = new VendorBal();
        string id;

        public AllVendorSc()
        {
            InitializeComponent();
        }

        private void DisplayBtn_Click(object sender, EventArgs e)
        {
            new DisplayVendorAcount().ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddVendorSc().ShowDialog();

        }

        private void AllVendorSc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = Vend.listOfVendors();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView.CurrentRow.Cells[0].Value.ToString().Trim();
            //Console.WriteLine(id);
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Vend.deleteVendor(id);
            dataGridView.DataSource= Vend.listOfVendors();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            nameText.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            addressText.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            noreText.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            phoneText.Text= dataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void phoneText_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            VendorDto v = new VendorDto();
            v.ven_id= Int32.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString().Trim());
           
            v.ven_name = nameText.Text;
            v.ven_address = addressText.Text;
            v.ven_note = noreText.Text;
            v.ven_phone = phoneText.Text;

            Vend.updateVendor(v);

            MessageBox.Show("تم تعديل المستخدم");
            this.Close();
            new AllVendorSc().Show();

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            new AddVendorSc().ShowDialog();
        }
    }
}
