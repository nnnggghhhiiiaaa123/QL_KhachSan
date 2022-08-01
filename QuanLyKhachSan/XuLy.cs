using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
  public class XuLy
    {
      SqlConnection conn = new SqlConnection("Data Source = 117.2.159.103,14333; Initial Catalog=QLKS; User ID=sa;Password=sa2012");
      DataSet QL_KhachSan = new DataSet();
      
      public XuLy() 
      {
          loadData();
      
      }
      public void loadData() 
      {
          LoadKhachHang();
          LoadPhong();
          loadDichVu();
          LoadNhanVien();
          LoadThuePhong();
          LoadHoaDon();
          LoadHDDV();
          LoadTaiKhoan();
      }
      public void LoadKhachHang() 
      {
          string sql = "select * from KhachHang ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "KhachHang");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["KhachHang"].Columns[0];
          QL_KhachSan.Tables["KhachHang"].PrimaryKey = key;
      }
      public DataTable getKhachHang() 
      {
          return QL_KhachSan.Tables["KhachHang"];
      }
      public bool LuuKhachHang()
      {
          try
          {
              string sql = "select*from khachhang";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "KhachHang");
                
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public string MaKhachHangTuTang(string makh) 
      {
          string str2 = makh.Substring(3);
          int stt = int.Parse(str2);
          stt++;
          return "KH0" + stt;
      
      }
      public bool ThemKhachHang(string makh,string tenkh,string gioitinh,string dienthoai,string cnnd,string diachi) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["KhachHang"].NewRow();
              dt_data["Makh"] = makh;
              dt_data["HoTen"] = tenkh;
              dt_data["GioiTinh"] = gioitinh;
              dt_data["DT"] = dienthoai;
              dt_data["CMND"] = cnnd;
              dt_data["DiaChi"] = diachi;
              QL_KhachSan.Tables["KhachHang"].Rows.Add(dt_data);
              string sql = "Select * from KhachHang";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);

              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan,"KhachHang");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public void LoadPhong() 
      {
          string sql = "select * from Phong ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "Phong");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["Phong"].Columns[0];
          QL_KhachSan.Tables["Phong"].PrimaryKey = key;
      
      }
      public DataTable getPhong() 
      {
          return QL_KhachSan.Tables["Phong"];
      
      }
      public void loadDichVu() 
      {
          string sql = "select * from DichVu ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "DichVu");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["DichVu"].Columns[0];
          QL_KhachSan.Tables["DichVu"].PrimaryKey = key;
      
      }
      public DataTable getDichVu() 
      {
          return QL_KhachSan.Tables["DichVu"];
      }
      public void LoadNhanVien() 
      {
          string sql = "select * from NhanVien ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "NhanVien");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["NhanVien"].Columns[0];
          QL_KhachSan.Tables["NhanVien"].PrimaryKey = key;
      
      }
      public DataTable getNhanVien() 
      {
          return QL_KhachSan.Tables["NhanVien"];
      }
      public DataTable KiemTraDangNhap(string tk,string mk) 
      {
          DataTable tb = new DataTable();
          string sql = "select * from account where tenTK='"+tk+"' and mk='"+mk+"'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      
      }
      public string getMANV(string tentk) 
      {
          DataTable dt = new DataTable();
          string sql = "select MANV from account where tentk='" + tentk + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(dt);
          string kq = dt.Rows[0][0].ToString();
          return kq;
      
      }
      public string getChucVu(string manv) 
      {
          DataTable dt = new DataTable();
          string sql = "select ChucVu from NhanVien where manv='" + manv + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(dt);
          string kq = dt.Rows[0][0].ToString();
          return kq;
      
      }
      public DataTable getPhongTrong() 
      {
          DataTable d = new DataTable();
          string sql = "select *from phong where tinhtrang=N'Còn'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(d);
          return d;
      }
      public void LoadThuePhong() 
      {
          string sql = "select * from thuephong ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "ThuePhong");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["ThuePhong"].Columns[0];
          QL_KhachSan.Tables["ThuePhong"].PrimaryKey = key;
      
      }
      public DataTable getThuePhong() 
      {
          return QL_KhachSan.Tables["ThuePhong"];
      }
      public DataTable getNameCusomer() 
      {
          DataTable tb = new DataTable();
          string sql = "select HoTen from KhachHang";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      
      }
      public string getMAKHfromName(string name) 
      {
         
          try
          {
              DataTable tb = new DataTable();
              string sql = "select * from khachhang where hoten=N'" + name + "'";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              da.Fill(tb);

              string makh = tb.Rows[0][0].ToString();
              return makh;
          }
          catch (Exception)
          {

              return null;
          }
      
      }
      public DataTable getKhachHangFromTenKH(string makh) 
      {
          DataTable tb = new DataTable();
          string sql = "select * from khachHang where makh='"+makh+"'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      }
      public bool ThemThuePhong(string matp,string manv,string makh,string ngayden,string ngaydi,string maph) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["ThuePhong"].NewRow();
              dt_data["MaTP"] = matp;
              dt_data["MaNV"] = manv;
              dt_data["MAKH"] = makh;
              dt_data["NgayDen"] = ngayden;
              dt_data["NgayDi"] = ngaydi;
              dt_data["MaPH"] = maph;
              QL_KhachSan.Tables["ThuePhong"].Rows.Add(dt_data);
              string sql = "Select * from ThuePhong";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);

              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "ThuePhong");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public string MaTPTuTang(string matp) 
      {

          string str2 = matp.Substring(3);
          int stt = int.Parse(str2);
          stt++;
          return "TP0" + stt;
      }
      public void updateTinhTrangThuePhong(string maph) 
      {
          DataRow dt_r = QL_KhachSan.Tables["Phong"].Rows.Find(maph);
          dt_r["TinhTrang"] = "Hết";
          string sql = "select * from Phong";
          SqlDataAdapter da_a = new SqlDataAdapter(sql, conn);
          SqlCommandBuilder cmd = new SqlCommandBuilder(da_a);
          da_a.Update(QL_KhachSan, "Phong");
      }
      public bool luuThuePhong() 
      {
          try
          {
              string sql = "select* from ThuePhong";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "ThuePhong");

              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public void updateTinhTrangThuePhongXoa(string maph) 
      {
          DataRow dt_r = QL_KhachSan.Tables["Phong"].Rows.Find(maph);
          dt_r["TinhTrang"] = "Còn";
          string sql = "select * from Phong";
          SqlDataAdapter da_a = new SqlDataAdapter(sql, conn);
          SqlCommandBuilder cmd = new SqlCommandBuilder(da_a);
          da_a.Update(QL_KhachSan, "Phong");
      
      }
      public DataTable getGiaThuePhong() 
      {

          DataTable tb = new DataTable();
          string sql = "select LoaiPH,Giaph from phong group by loaiPH,GiaPH";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      }
      public DataTable getNameKhachHangThuePhong() 
      {
          DataTable tb = new DataTable();
          string sql = "select hoten  from thuephong p,khachhang kh where   p.makh=kh.makh";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      }

      public DataTable getThuePhongFromName(string makh) 
      {
          DataTable tb = new DataTable();
          string sql = "select *  from thuephong where makh='"+makh+"'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      
      }
      public string getMakhFromName(string tenkh) 
      {
          DataTable tb = new DataTable();
          string sql = "select makh  from khachhang where hoten=N'" + tenkh + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          string makh = tb.Rows[0][0].ToString();
          return makh;
      }
      public string getLoaiPhongFromMaPH(string maph) 
      {
          DataTable tb = new DataTable();
          string sql = "select loaiPH  from phong where maph='" + maph + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          string makh = tb.Rows[0][0].ToString();
          return makh;
      
      }
      public string getTenKhachHangFromMaKH(string makh) 
      {
          DataTable tb = new DataTable();
          string sql = "select hoten  from khachHang where makh='" + makh + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          string tenkh = tb.Rows[0][0].ToString();
          return tenkh;
      }
      public string getGiaPhongFormMaPH(string maph) 
      {

          DataTable tb = new DataTable();
          string sql = "select giaph  from phong where maph='" + maph + "'";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          string tenkh = tb.Rows[0][0].ToString();
          return tenkh;
      }
      public void LoadHoaDon() 
      {
          string sql = "select * from HoaDon ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "HoaDon");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["HoaDon"].Columns[0];
          QL_KhachSan.Tables["HoaDon"].PrimaryKey = key;
      
      }
      public DataTable getHoaDon() 
      {
          return QL_KhachSan.Tables["HoaDon"];
      }
      public bool ThemHoaDon(string mahd, string matp, string manv, string makh, string maph, string ngaythanhtoan, string tienphong) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["HoaDon"].NewRow();
              dt_data["MaHD"] = mahd;
              dt_data["MaTP"] = matp;
              dt_data["MaNV"] = manv;
              dt_data["MaKH"] = makh;
              dt_data["MaPH"] = maph;
              dt_data["NgaythanhToan"] = ngaythanhtoan;
              dt_data["TienPhong"] = tienphong;
              dt_data["TinhTrang"] = "Đã Thanh Toán";
              QL_KhachSan.Tables["HoaDon"].Rows.Add(dt_data);
              string sql = "Select * from HoaDon";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);

              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "HoaDon");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public bool XoaThuePhong(string matp) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["ThuePhong"].Rows.Find(matp);
              dt_data.Delete();
              string sql = "Select * from ThuePhong";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "ThuePhong");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public bool KiemTraMaHoaDon() 
      {
          DataTable tb = new DataTable();
          string sql = "select * from HoaDon";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          if (tb.Rows.Count==0)
          {
              return true;
          }
          return false;
      
      }
      public string maHoaDonTuTang(string mahd) 
      {
          string str2 = mahd.Substring(3);
          int stt = int.Parse(str2);
          stt++;
          return "HD0" + stt;
      
      }
      public DataTable getNameKH() 
      {
          DataTable tb = new DataTable();
          string sql = "select Hoten from khachHang";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          return tb;
      
      }
      public DataTable getKHfromMAKH(string makh) 
      {
          DataTable tb = new DataTable();
          string sq = "select * from khachhang where makh='"+makh+"'";
          SqlDataAdapter da = new SqlDataAdapter(sq, conn);
          da.Fill(tb);
          return tb;
      }
      public void LoadHDDV() 
      {
          string sql = "select * from HDDV ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "HoaDonDV");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["HoaDonDV"].Columns[0];
          QL_KhachSan.Tables["HoaDonDV"].PrimaryKey = key;
      
      }
      public DataTable getHDDV() 
      {
          return QL_KhachSan.Tables["HoaDonDV"];
      }
      public bool ThemHDDV(string mahhdv, string madv, string manv, string giadv, string soluong, string tongtien) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["HoaDonDV"].NewRow();
              dt_data["MaHDDV"] = mahhdv;
              dt_data["MaDV"] = madv;
              dt_data["MaNV"] = manv;
              dt_data["GiaDV"] = giadv;
              dt_data["SoLuong"] = soluong;
              dt_data["TongTien"] = tongtien;

              QL_KhachSan.Tables["HoaDonDV"].Rows.Add(dt_data);
              string sql = "Select * from HDDV";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);

              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "HoaDonDV");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      
      }
      public bool KiemTraMaHoaDonDV()
      {
          DataTable tb = new DataTable();
          string sql = "select * from HDDV";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          if (tb.Rows.Count == 0)
          {
              return true;
          }
          return false;

      }
      public string maHoaDonDVTuTang(string mahd)
      {
          string str2 = mahd.Substring(5);
          int stt = int.Parse(str2);
          stt++;
          return "HDDV0" + stt;

      }
      public bool ThemNhanVien(string manv ,string tennv,string gioitinh,string ngaysinh,string chucvu,string diachi,string cmnd,string sdt)
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["NhanVien"].NewRow();
              dt_data["MaNV"] = manv;
              dt_data["TenNV"] = tennv;
              dt_data["GioiTinh"] = gioitinh;
              dt_data["NgaySinh"] = ngaysinh;
              dt_data["ChucVu"] = chucvu;
              dt_data["DiaChi"] = diachi;
              dt_data["CMND"] = cmnd;
              dt_data["SDT"] = sdt;
              QL_KhachSan.Tables["NhanVien"].Rows.Add(dt_data);
              string sql = "Select * from NhanVien";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);

              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "NhanVien");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public string maNhanVienTuTang(string manv) 
      {
          string str2 = manv.Substring(3);
          int stt = int.Parse(str2);
          stt++;
          return "NV0" + stt;
      }
      public bool KiemTraMaNhanVien() 
      {
          DataTable tb = new DataTable();
          string sql = "select * from NhanVien";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          if (tb.Rows.Count == 0)
          {
              return true;
          }
          return false;
      
      }
      public bool LuuNhanVien() 
      {
          try
          {
              string sql = "select*from NhanVien";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "NhanVien");

              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public bool ThemDichVu(string madv,string tendv,string dvt,string gia) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["DichVu"].NewRow();
              dt_data["MaDV"] = madv;
              dt_data["TenDV"] = tendv;
              dt_data["DVT"] = dvt;
              dt_data["Gia"] = gia;
              QL_KhachSan.Tables["DichVu"].Rows.Add(dt_data);
              string sql = "Select * from DichVu";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "DichVu");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      
      }
      public bool KiemTraMaDV() 
      {

          DataTable tb = new DataTable();
          string sql = "select * from DichVu";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(tb);
          if (tb.Rows.Count == 0)
          {
              return true;
          }
          return false;
      }
      public string maDichVTuTang(string madv) 
      {
          string str2 = madv.Substring(3);
          int stt = int.Parse(str2);
          stt++;
          return "DV0" + stt;
      }
      public bool LuuDichVu() 
      {
          try
          {
              string sql = "select*from DichVu";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "DichVu");

              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public bool luuPhong() 
      {
          try
          {
              string sql = "select*from Phong";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "Phong");

              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public void LoadTaiKhoan() 
      {
          string sql = "select * from account ";
          SqlDataAdapter da = new SqlDataAdapter(sql, conn);
          da.Fill(QL_KhachSan, "TaiKhoan");
          DataColumn[] key = new DataColumn[1];
          key[0] = QL_KhachSan.Tables["TaiKhoan"].Columns[1];
          QL_KhachSan.Tables["TaiKhoan"].PrimaryKey = key;
      
      }
      public DataTable getTaiKhoan() 
      {
          return QL_KhachSan.Tables["TaiKhoan"];
      }
      public bool ThemTaiKhoan(string manv,string tenk,string mk) 
      {
          try
          {
              DataRow dt_data = QL_KhachSan.Tables["TaiKhoan"].NewRow();
              dt_data["MaNV"] = manv;
              dt_data["TenTK"] = tenk;
              dt_data["MK"] = mk;
             
              QL_KhachSan.Tables["TaiKhoan"].Rows.Add(dt_data);
              string sql = "Select * from account";
              SqlDataAdapter da_data = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder build_makhoa = new SqlCommandBuilder(da_data);
              da_data.Update(QL_KhachSan, "TaiKhoan");
              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
      public bool luuTaiKhoan() 
      {

          try
          {
              string sql = "select*from account";
              SqlDataAdapter da = new SqlDataAdapter(sql, conn);
              SqlCommandBuilder buid = new SqlCommandBuilder(da);
              da.Update(QL_KhachSan, "TaiKhoan");

              return true;
          }
          catch (Exception)
          {

              return false;
          }
      }
    }

}
