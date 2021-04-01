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
    public partial class AllCustomerSc : Form
    {
        public AllCustomerSc()
        {
            InitializeComponent();
        }

        private void DisplayCusBtn_Click(object sender, EventArgs e)
        {
            new DisplayCustomerAcount().ShowDialog();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            new AddCustomerSc().ShowDialog();

        }

        private void AllCustomerSc_Load(object sender, EventArgs e)
        {

        }
    }
}
