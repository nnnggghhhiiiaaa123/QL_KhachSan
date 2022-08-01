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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            if (txtMatKhau.Text == string.Empty || txtTK.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
           
            DataTable tb = xl.KiemTraDangNhap(txtTK.Text,txtMatKhau.Text);
           
            if (tb.Rows.Count==0)
            {
                MessageBox.Show("Đăng Nhập Thất Bại");
                return;
            }
            else
            {
                //MessageBox.Show("Đăng Nhập Thành công");
                FormMain m = new FormMain();
                getData.manv = xl.getMANV(txtTK.Text);
                m.Show();
                this.Hide();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
