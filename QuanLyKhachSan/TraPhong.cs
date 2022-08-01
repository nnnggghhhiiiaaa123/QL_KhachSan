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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }
        XuLy xl = new XuLy();
        string maphong="";
        string makhachhang="";
        private void TraPhong_Load(object sender, EventArgs e)
        {
            dataGridView_GiaPhong.DataSource = xl.getGiaThuePhong();
            dataGridView_ThuePhong.DataSource = xl.getThuePhong();
            DataTable tb = xl.getNameKhachHangThuePhong();
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
            if (makh==null)
            {
                return;
            }
            dataGridView_ThuePhong.DataSource = xl.getThuePhongFromName(makh);
            
        }

        private void dataGridView_ThuePhong_SelectionChanged(object sender, EventArgs e)
        {
            string ngayden = dataGridView_ThuePhong.CurrentRow.Cells[3].Value.ToString();
            string ngaydi=dataGridView_ThuePhong.CurrentRow.Cells[4].Value.ToString();
            txtNgayDen.Text = ngayden;
            txtNgayDi.Text = ngaydi;
            string maph = dataGridView_ThuePhong.CurrentRow.Cells[5].Value.ToString();
            maphong = maph;
            txtLoaiPhong.Text = xl.getLoaiPhongFromMaPH(maph);
            string makh = dataGridView_ThuePhong.CurrentRow.Cells[2].Value.ToString();
            makhachhang = makh;
            txtNameKH.Text = xl.getTenKhachHangFromMaKH(makh);
            DateTime ngay1 = DateTime.Parse(ngayden);
            DateTime ngay2 = DateTime.Parse(ngaydi);
            TimeSpan date = ngay2.Subtract(ngay1);
            string songay = date.Days.ToString();
            txtSoNgayO.Text = songay;
            int giaphong = int.Parse(xl.getGiaPhongFormMaPH(maph));
            txtGiaPhong.Text = giaphong.ToString();
            int tonggiaphong = int.Parse(songay) * giaphong;
            txtTongTien.Text = tonggiaphong.ToString();
            txtMATP.Text = dataGridView_ThuePhong.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            xl.updateTinhTrangThuePhongXoa(maphong);
            
                DateTime dt=DateTime.Now;
                if (xl.KiemTraMaHoaDon())
                {
                    bool kq1 = xl.ThemHoaDon("HD01", txtMATP.Text, txtMaNV.Text, makhachhang, maphong, dt.ToShortDateString(), txtTongTien.Text);
                    if (!kq1)
                    {
                        MessageBox.Show("Trả Phòng Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Trả phòng thất bại");
                    }
                }
                else
                {
                    DataTable tb1 = xl.getHoaDon();
                    string mahd = tb1.Rows[tb1.Rows.Count - 1][0].ToString();
                    string hd1 = xl.maHoaDonTuTang(mahd);
                    bool kq2 = xl.ThemHoaDon(hd1, txtMATP.Text, txtMaNV.Text, makhachhang, maphong, dt.ToShortDateString(), txtTongTien.Text);
                    if (!kq2)
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                }
               
            
        }
    }
}
