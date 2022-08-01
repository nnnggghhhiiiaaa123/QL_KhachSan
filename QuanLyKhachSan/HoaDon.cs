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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            dataGridView_HoaDon.DataSource = xl.getHoaDon();
        }
    }
}
