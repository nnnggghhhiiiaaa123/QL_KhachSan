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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void DichVu_Load(object sender, EventArgs e)
        {
            dataGridView_DichVu.DataSource = xl.getDichVu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (xl.KiemTraMaDV())
                {
                    bool kq = xl.ThemDichVu("DV01", txtTenDV.Text, txtDVT.Text, txtGiaDV.Text);
                    if (kq)
                    {
                        MessageBox.Show("Thêm Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    DataTable tb = xl.getDichVu();
                    string madv = tb.Rows[tb.Rows.Count - 1][0].ToString();
                    string madvtang = xl.maDichVTuTang(madv);
                    bool kq = xl.ThemDichVu(madvtang, txtTenDV.Text, txtDVT.Text, txtGiaDV.Text);
                    if (kq)
                    {
                        MessageBox.Show("Thêm Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                    
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_DichVu.AllowUserToAddRows = false;
                dataGridView_DichVu.ReadOnly = false;
                //Không du?c s?a các dòng trên datagridview dã có dữa liệu
                for (int i = 0; i < dataGridView_DichVu.Rows.Count - 1; i++)
                {
                    dataGridView_DichVu.Rows[i].ReadOnly = false;
                }
                // Khoa column   Khoá chính
                dataGridView_DichVu.Columns[0].ReadOnly = true;
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
                if (xl.LuuDichVu())
                {
                    MessageBox.Show("Lưu Thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lưu Thất bại");
            }
           
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView_DichVu.SelectedRows)
                {
                    dataGridView_DichVu.Rows.RemoveAt(item.Index);
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

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_DichVu.ReadOnly = false;
               
                dataGridView_DichVu.AllowUserToAddRows = true;
              
                for (int i = 0; i < dataGridView_DichVu.Rows.Count - 1; i++)
                {
                    dataGridView_DichVu.Rows[i].ReadOnly = true;
                }
                // Khoa column   Khoá chính
                dataGridView_DichVu.Columns[0].ReadOnly = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi");
            }
        }
    }
}
