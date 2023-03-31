using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL
{
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent();
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
                 }

        private void btnQuanLyCuaHang_Click(object sender, EventArgs e)
        {
            frmHang hang = new frmHang();
            hang= plChuaTatCaForm.Show();
        }

        private void plChuaTatCaForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
