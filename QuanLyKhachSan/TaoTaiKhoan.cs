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
    public partial class TaoTaiKhoan : Form
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.getTaiKhoan();
            cbxMaNV.DataSource = xl.getNhanVien();
            cbxMaNV.DisplayMember = "TenNV";
            cbxMaNV.ValueMember = "MANV";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool kq = xl.ThemTaiKhoan(cbxMaNV.SelectedValue.ToString(), txtTenTK.Text, txtMK.Text);
                if (kq)
                {
                    MessageBox.Show("thêm Thành công");
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = false;
               
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].ReadOnly = false;
                }
              
                dataGridView1.Columns[0].ReadOnly = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Lõi Rồi");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
                bool kq = xl.LuuKhachHang();
                if (!kq)
                {
                    MessageBox.Show("Xóa thất bại");
                }
                else
                {
                    MessageBox.Show("Xóa thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui Lòng Chon đúng dòng càn xóa");
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (xl.luuTaiKhoan())
                {
                    MessageBox.Show("Lưu Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lưu Thất bại");
            }
           
        }
    }
}
