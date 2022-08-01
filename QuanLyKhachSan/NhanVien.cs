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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.getNhanVien();
            cbxChucVu.SelectedIndex = 1;
            DateTime t = new DateTime(2001, 1, 1);
            dateTimePicker1.Value = t;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public string checkGioiTinh()
        {
            if (rdbNam.Checked)
            {
                return rdbNam.Text;
            }
            else if (rdbNu.Checked)
            {
                return rdbNu.Text;
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string goitinh = checkGioiTinh();
                if (xl.KiemTraMaNhanVien())
                {
                    bool kq = xl.ThemNhanVien("NV01", txtTenNhanVien.Text, goitinh, dateTimePicker1.Value.ToShortDateString(), cbxChucVu.SelectedValue.ToString(), txtDiaChi.Text, txtCMND.Text, txtSDT.Text);
                    if (kq)
                    {
                        MessageBox.Show("thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                else
                {
                    DataTable tb = xl.getNhanVien();
                    string manv = tb.Rows[tb.Rows.Count - 1][0].ToString();
                    string manvtutang = xl.maNhanVienTuTang(manv);
                    bool kq = xl.ThemNhanVien(manvtutang, txtTenNhanVien.Text, goitinh, dateTimePicker1.Value.ToShortDateString(), cbxChucVu.SelectedItem.ToString(), txtDiaChi.Text, txtCMND.Text, txtSDT.Text);
                    if (kq)
                    {
                        MessageBox.Show("thêm Thành Công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Mời Bạn Nhập đầy đủ thông tin");
                return;
            }
           
           
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.ReadOnly = false;
                // Dong du lieu thêm m?i nguoi dung se nhap
                dataGridView1.AllowUserToAddRows = true;
                // Khoa cac dong co san
                //Không du?c s?a các dòng trên datagridview dã có d? li?u
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].ReadOnly = true;
                }
                // Khoa column   Khoá chính
                dataGridView1.Columns[0].ReadOnly = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi");
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (xl.LuuNhanVien())
                {
                    MessageBox.Show("Lưu Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lưu Thất bại");
            }
           
            
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.ReadOnly = false;
                //Không du?c s?a các dòng trên datagridview dã có dữa liệu
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    dataGridView1.Rows[i].ReadOnly = false;
                }
                // Khoa column   Khoá chính
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
    }
}
