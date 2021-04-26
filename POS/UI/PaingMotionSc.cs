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
namespace POS.UI
{
    public partial class PaingMotionSc : Form
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        public PaingMotionSc()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.getCustPaying().OrderBy(a=>a.C_اسم_العميل).ToList();
            dataGridView2.DataSource = db.getVendPaying().OrderBy(v =>v.اسم_المورد).ToList();
        }

        private void PaingMotionSc_Load(object sender, EventArgs e)
        {
       


        }
    }
}
