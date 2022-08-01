using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.getKhachHang();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
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
            DataTable tb = xl.getKhachHang();

         //   int row = dataGridView1.RowCount-2;
            //string str = dataGridView1.Rows[row].Cells[0].Value.ToString();
            string str = tb.Rows[tb.Rows.Count-1][0].ToString();
            string makh = xl.MaKhachHangTuTang(str);
            string gioitinh=checkGioiTinh();
            if (gioitinh==null)
            {
                MessageBox.Show("Mời Bạn chọn giới Tính ");
                return;
            }
            else
            {
                bool kq = xl.ThemKhachHang(makh, txtTenKH.Text, gioitinh, txtDienThoai.Text, txtCMND.Text, txtDiaChi.Text);
                if (kq)
                {
                    MessageBox.Show("Thêm Thành công");
                    
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại");
                }
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
                bool kq = xl.LuuKhachHang();
                if (kq)
                {
                    MessageBox.Show("Lưu Thành công");
                }
                else
                {
                    MessageBox.Show("Lưu Thất bại");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi Rồi");
            }
          
        }

        private void sữaToolStripMenuItem_Click(object sender, EventArgs e)
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
            //-Chọn button Sửa
            //+Button Luu có hiệu lực
          
            //+Cho phép sửa các thông tin trên DatagridView
            
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDienThoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCMND.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        
       
    }
}
