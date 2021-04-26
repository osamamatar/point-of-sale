using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.UI
{
    public partial class AddVendorSc : Form
    {
       
        public AddVendorSc()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameText.Text != "" && nameText.Text.Length != 0)
            {
                dto.VendorDto v = new dto.VendorDto();
                v.ven_name = nameText.Text.Trim();
                v.ven_address = addressText.Text.Trim();
                v.ven_phone = phoneText.Text.Trim();
                v.ven_note = noteText.Text.Trim();

                int valid = new BAL.VendorBal().createVendor(v);
                if (valid == 1)
                {


                    this.Close();
                }
            }
            
          
        }

        private void AddVendorSc_Load(object sender, EventArgs e)
        {

        }
    }
}
