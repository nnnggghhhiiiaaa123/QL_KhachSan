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
    public partial class SuDungDichVu : Form
    {
        public SuDungDichVu()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        string madvv;
        private void SuDungDichVu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xl.getDichVu();
            dataGridView2.DataSource = xl.getKhachHang();
            DataTable tb = xl.getNameKH();
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

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            string makh = xl.getMAKHfromName(txtTenKH.Text);
            if (makh == null)
            {
                return;
            }
            dataGridView2.DataSource = xl.getKHfromMAKH(makh);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               
                txtGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDVT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTongTien.Text = (int.Parse(txtSoLuong.Text) * int.Parse(txtGia.Text)).ToString();
                madvv = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }

            catch (Exception)
            {

                return;
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            txtMAKH.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int gia = int.Parse(txtGia.Text);
                int sl = int.Parse(txtSoLuong.Text);
                txtTongTien.Text = (gia * sl).ToString();
            }
            catch (Exception)
            {

                txtTongTien.Text = "";
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (xl.KiemTraMaHoaDonDV())
                {
                    bool kq = xl.ThemHDDV("HHDV01", madvv, txtMaNV.Text, txtGia.Text, txtSoLuong.Text, txtTongTien.Text);
                    if (kq)
                    {
                        MessageBox.Show("thêm Hóa Đơn thành Công");
                    }
                    else
                    {
                        MessageBox.Show("thêm Hóa Đơn Thất Bại");
                    }
                }
                else
                {
                    DataTable tb = xl.getHDDV();
                    string mahddv = tb.Rows[tb.Rows.Count - 1][0].ToString();
                    string mahddvtutang = xl.maHoaDonDVTuTang(mahddv);
                    bool kq = xl.ThemHDDV(mahddvtutang, madvv, txtMaNV.Text, txtGia.Text, txtSoLuong.Text, txtTongTien.Text);
                    if (kq)
                    {
                        MessageBox.Show("thêm Hóa Đơn thành Công");
                    }
                    else
                    {
                        MessageBox.Show("thêm Hóa Đơn Thất Bại");
                    }
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lỗi");
            }
           
        }
    }
}
