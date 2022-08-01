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
    public partial class ThuePhong : Form
    {
        public ThuePhong()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        private void ThuePhong_Load(object sender, EventArgs e)
        {
            dataGridView_PhongTrong.DataSource = xl.getPhongTrong();
            dataGridView_ThuePhong.DataSource = xl.getThuePhong();
            dataGridView_KhachHang.DataSource = xl.getKhachHang();
            DataTable tb = xl.getNameCusomer();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                auto.Add(tb.Rows[i][0].ToString());
            }
           
            txtTenKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTenKH.AutoCompleteCustomSource = auto;
            txtMaNV.Text = getData.manv;
        }
        public bool kietraToanKhoangTrang(string str) 
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text==string.Empty)
            {
                MessageBox.Show("Mời bạn nhập tên khách hàng");
                return;
            }
            //DateTime date = new DateTime();
            //date = DateTime.Now;
            //MessageBox.Show(date.ToShortDateString());
            
            
            int row = dataGridView_ThuePhong.RowCount - 2;
            string str = dataGridView_ThuePhong.Rows[row].Cells[0].Value.ToString();
            string matp = xl.MaTPTuTang(str);
            DateTime datenow=new DateTime();
            datenow=DateTime.Now;
            int songayo=int.Parse(txtNgayThue.Text);
            DateTime ngaythue=new DateTime();
            ngaythue=datenow.AddDays(songayo);
            bool kq=xl.ThemThuePhong(matp,txtMaNV.Text,txtMaKH.Text,datenow.ToShortDateString(),ngaythue.ToShortDateString(),txtMaPhong.Text);
            if (kq)
            {
                MessageBox.Show("Thuê Thành công");
                xl.updateTinhTrangThuePhong(txtMaPhong.Text);
                dataGridView_PhongTrong.DataSource = xl.getPhongTrong();
            }
            else
            {
                MessageBox.Show("thuê Thất bại");
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            string makh = xl.getMAKHfromName(txtTenKH.Text);
            if (makh==null)
            {
                return;
            }
            dataGridView_KhachHang.DataSource = xl.getKhachHangFromTenKH(makh);
            txtMaKH.Text = makh;
            
        }

        private void dataGridView_KhachHang_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void ThuePhong_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ThuePhong_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView_KhachHang.DataSource = xl.getKhachHang();
        }

        private void dataGridView_PhongTrong_SelectionChanged(object sender, EventArgs e)
        {
            txtMaPhong.Text = dataGridView_PhongTrong.CurrentRow.Cells[0].Value.ToString();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView_ThuePhong.SelectedRows)
            {
                dataGridView_ThuePhong.Rows.RemoveAt(item.Index);
            }
            bool kq = xl.luuThuePhong();
            if (!kq)
            {
                MessageBox.Show("Xóa thất bại");
            }
            else
            {
                MessageBox.Show("Xóa thành công");
                xl.updateTinhTrangThuePhongXoa(txtMaPhong.Text);
                dataGridView_ThuePhong.DataSource = xl.getThuePhong();
            }
        }
    }
}
