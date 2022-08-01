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
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void Phong_Load(object sender, EventArgs e)
        {
            dataGridView_Phong.DataSource = xl.getPhong();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Phong.ReadOnly = false;

                dataGridView_Phong.AllowUserToAddRows = true;

                for (int i = 0; i < dataGridView_Phong.Rows.Count - 1; i++)
                {
                    dataGridView_Phong.Rows[i].ReadOnly = true;
                }
                // Khoa column   Khoá chính
                dataGridView_Phong.Columns[0].ReadOnly = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi");
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView_Phong.SelectedRows)
                {
                    dataGridView_Phong.Rows.RemoveAt(item.Index);
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

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_Phong.AllowUserToAddRows = false;
                dataGridView_Phong.ReadOnly = false;
                //Không du?c s?a các dòng trên datagridview dã có dữa liệu
                for (int i = 0; i < dataGridView_Phong.Rows.Count - 1; i++)
                {
                    dataGridView_Phong.Rows[i].ReadOnly = false;
                }
                // Khoa column   Khoá chính
                dataGridView_Phong.Columns[0].ReadOnly = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Lõi Rồi");
            }
        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (xl.luuPhong())
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
