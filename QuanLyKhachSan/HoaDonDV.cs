using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class HoaDonDV : Form
    {
        public HoaDonDV()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void HoaDonDV_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.getHDDV();
        }
    }
}
