# QL_KhachSan


--database

create database QLKS

create table KhachHang
(
MaKH char(50) primary key(MaKH),
Hoten nvarchar(100),
GioiTinh nvarchar(5),
DT char(11),
CMND char(20),
DiaChi nvarchar(100),
)	

create table Phong
(
MaPH char(10) primary key(MaPH),
LoaiPH nvarchar(10),
GiaPH int,
DonViTinh nvarchar(20),
TinhTrang nvarchar(10)
)
create table DichVu
(
MaDV char(10) primary key(MADV),
TenDV nvarchar(20),
DVT nvarchar(10),
Gia int 
)


create table NhanVien
(
MANV char(10) primary key(MANV),
TenNV nvarchar(50),
GioiTinh nvarchar(5),
NgaySinh date,
ChucVu nvarchar(10),
DiaChi nvarchar(50),
CMND char(15),
SDT char(11)
)

create table ACCOUNT
(
MANV char(10),
TenTK char(50) primary key(TenTK),
MK char(50)
CONSTRAINT FK_ACC_NV FOREIGN KEY (MANV) REFERENCES NhanVien(MANV)
)

create table ThuePhong
(
MaTP char(50) primary key(MaTP),
MANV char(10),
MAKH char(50),
NgayDen date,
NgayDi date,
MaPH char(10)
CONSTRAINT FK_TP_NV FOREIGN KEY (MANV) REFERENCES NhanVien(MANV),
CONSTRAINT FK_TP_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
CONSTRAINT FK_TP_Phong FOREIGN KEY (MAPH) REFERENCES Phong(MAPH),
)

create table HoaDon
(
MaHD char(10) primary key(MAHD),
MATP char(50),
MANV char(10),
MAKH char(50),
Maph char(10),
NgayThanhToan datetime,
Tienphong int,
TinhTrang nvarchar(50),
CONSTRAINT FK_KhachHang_HoaDon FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
CONSTRAINT FK_Phong_HoaDon FOREIGN KEY (MAPH) REFERENCES Phong(MAPH),
CONSTRAINT FK_NhanVien_HoaDon FOREIGN KEY (MANV) REFERENCES NhanVien(MANV),
CONSTRAINT FK_ThuePhong_HoaDon FOREIGN KEY (MaTP) REFERENCES ThuePhong(MaTP),
)
create table HDDV
(
MAHDDV char(50) primary key(MAHDDV),
MADV char(10),
MANV char(10),
GiaDV int,
Soluong int,
TongTien int
CONSTRAINT FK_DichVu_HDDV FOREIGN KEY (MADV) REFERENCES DichVu(MADV),
CONSTRAINT FK_HDDV_NhanVien FOREIGN KEY (MANV) REFERENCES NhanVien(MANV),
)


insert into Phong
values('P101',N'Thường Đơn',500000,N'Ngày',N'Hết'),
('P102',N'Thường Đơn',500000,N'Ngày',N'Hết'),
('P103',N'Thường Đơn',500000,N'Ngày',N'Còn'),
('P201',N'Thường Đôi',800000,N'Ngày',N'Còn'),
('P202',N'Thường Đôi',800000,N'Ngày',N'Còn'),
('P203',N'Thường Đôi',800000,N'Ngày',N'Còn'),
('P301',N'Vip Đơn',1000000,N'Ngày',N'Còn'),
('P302',N'Vip Đơn',1000000,N'Ngày',N'Còn'),
('P303',N'Vip Đơn',1000000,N'Ngày',N'Còn'),
('P401',N'Vip Đôi',1500000,N'Ngày',N'Còn'),
('P402',N'Vip Đôi',1500000,N'Ngày',N'Còn'),
('P403',N'Vip Đôi',1500000,N'Ngày',N'Còn')
insert into DichVu
values('DV01',N'Bia 333',N'Thùng',300000),
('DV02',N'Nước Ngọt',N'Thùng',150000),
('DV03',N'Trái Cây',N'Dĩa',50000),
('DV04',N'Mát sa',N'Giờ',1000000),
('DV05',N'Bia Heniken',N'Thùng',500000),
('DV06',N'Xá Xị',N'Thùng',150000)
set dateformat DMY
insert into NhanVien
values('NV01',N'Lê Cường Thinh',N'Nam','9/2/2001',N'Quản Lý',N'Long AN','301783161','0967611122'),
('NV02',N'Phạm Ngọc Hân',N'Nữ','16/8/2002',N'Nhân Viên',N'Hậu Giang','301081121','0967612222'),
('NV03',N'Phạm Minh Hiếu',N'Nam','9/12/1999',N'Nhân Viên',N'An Giang','301743261','09676111231')
insert into KhachHang
values
('KH01',N'Nguyễn Khánh Duy',N'Nam','1122332331','334467890',N'Hậu Giang'),
('KH02',N'Lê Cường Thịnh',N'Nam','0967611122','301783161',N'Long An'),
('KH03',N'Nguyễn Duy Nam',N'Nam','09082223311','33990001233',N'Long AN'),
('KH04',N'Trần Phúc Hậu',N'Nam','07955213123','334467823',N'Cần Giờ'),
('KH05',N'Lê An Duy',N'Nữ','086643123','334467891',N'Trà Vinh')

insert into ACCOUNT
values('NV01','Thinh','123'),
('NV02','Han','123'),
('NV03','Hieu','123') 

insert into ThuePhong
values('TP01','NV01','KH01','9/2/2020','10/2/2020','P101'),
('TP02','NV02','KH02','10/2/2020','11/2/2020','P102')


select*from HDDV


