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
namespace POS.UI
{
    public partial class AllDeadProductSc : Form
    {
        public AllDeadProductSc()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void AllDeadProductSc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DeadProdcutDal().getAllDeadProducts();
        }
    }
}
