
Create database DB_Banvexekhach
go

Use DB_Banvexekhach
go

SET DATEFORMAT DMY
go

-----------------------------------------------------
--------------------Create Table---------------------
-----------------------------------------------------

Create table KhachHang
(
	CCCD char(12) primary key,
	TenKH nvarchar(50),
	NgaySinh date,
	SDT char(11),
	Email char(50),
	Password_kh char(50)
)
go

create table ChucVu
(
	MaCV char(10) primary key,
	TenCV nchar(15),
)
go

create table Nhanvien
(
	MaNV char(10) primary key,
	SDT char(11) UNIQUE ,
	MatKhau varchar(20) default '',
	TenNV nvarchar(50),
	NgaySinhNV date,
	DiaChiNV nvarchar(50),
	MaCV char(10),
	constraint FK_NV_CV foreign key(MACV) references ChucVu(MaCV)
)
go


Create table TuyenXe
(
	MaTuyen char(30) primary key,
	TenTuyen nvarchar(30),
	GiaVe int
)
go

create table Xe
(
	TTXe varchar(30) primary key,
	MaNV char(10),
	constraint FK_XE_NV foreign key(MaNV) references Nhanvien(MaNV)
)
go
create table ChuyenXe
(
	MaChuyen char(10) primary key ,
	TenChuyen nvarchar(50),
	MaTuyen char(30),
	TTXe varchar(30) unique,
	GioXuatPhat char(5),
	constraint FK_CX_TX foreign key (MaTuyen) references TuyenXe(MaTuyen),
	constraint FK_CX_XE foreign key (TTXe) references Xe(TTXe)
)
go
create table VeXe
(
	MaVe int identity(1,1),
	CCCD Char(12),
	MaChuyen char(10),
	NgayDi date,
	ViTri char(3) ,
	constraint PK_VEXE primary key(MaVe,CCCD),
	constraint FK_VE_KH foreign key(CCCD) references KhachHang(CCCD),
	constraint FK_VE_CX foreign key(MaChuyen) references ChuyenXe(MaChuyen)	
)
go


-----------------------------------------------------
--------------------Insert Data---------------------
-----------------------------------------------------


Insert into KhachHang
values('012345678921',N'Nguyễn Văn A','23/03/1989','09876543212','haha@gmail.com','123456'),
		('032145678912',N'Nguyễn Văn B','13/07/1991','09876543233','hihi@gmail.com','123456'),
		('021345678921',N'Nguyễn Văn C','03/05/1987','09876543244','huhu@gmail.com','123456'),
		('031245678921',N'Nguyễn Văn D','30/06/1992','09876543255','hehe@gmail.com','123456'),
		('045612378912',N'Nguyễn Văn E','12/08/1994','09876543266','kaka@gmail.com','123456'),
		('012345678901',N'Nguyễn Văn F','11/08/1992','09876543277','leuleu@gmail.com','123456'),
		('012345678902',N'Nguyễn Văn G','14/04/1997','09876543288','henie@gmail.com','123456'),
		('012345678903',N'Nguyễn Văn H','27/07/1995','09876543299','bubuchacha@gmail.com','123456'),
		('012345678904',N'Nguyễn Văn I','22/05/1981','09876543242','bento@gmail.com','123456'),
		('012345678905',N'Nguyễn Văn L','18/08/1990','09876543278','hahuhi@gmail.com','123456'),
		('012345678906',N'Nguyễn Văn K','09/01/1995','09876543288','lelme@gmail.com','123456')
go

Insert into ChucVu
values('ADMIN',N'ADMIN'),('NV',N'Nhân viên'),('TX',N'Tài xế')
go

Insert into Nhanvien
values('ADMIN','01234567891','admin',N'Trần Văn A','20/04/1992',N'36 Tây Thạnh','ADMIN'),
		('NV001','01234567892','1234',N'Nguyễn Thị B','14/07/1987',N'145 Lê Lợi','NV'),
		('NV002','01234567893','1234',N'Trịnh Thị M','18/03/1993',N'137 Tây Sơn','NV'),
		('NV003','01234567894','1234',N'Nguyễn Quang P','21/10/1989',N'63 Tân Thắng','NV'),
		('TX001','01234567895','',N'Nguyễn Quốc C','31/05/1983',N'48 Bình Lợi','TX'),
		('TX002','01234567896','',N'Lê Anh D','07/11/1990',N'128 Cầu Giấy','TX'),
		('TX003','01234567897','',N'Trần Minh E','20/05/1984',N'45 Nguyễn Trãi','TX'),
		('TX004','01234567898','',N'Nguyễn Văn F','30/08/1986',N'23 Đông Hưng','TX'),
		('TX005','01234567899','',N'Nguyễn Anh G','20/09/1991',N'1137 Lê Đức Thọ','TX'),
		('TX006','01234567810','',N'Đỗ Quốc H','03/02/1989',N'366 Quang Trung','TX'),
		('TX007','01234567811','',N'Trần Văn K','27/06/1981',N'29/2 Nguyễn Văn Quá',N'TX')
go		

Insert into TuyenXe
values('SGVT',N'Sài Gòn - Vũng Tàu',150),
		('SGBT',N'Sài Gòn - Bình Thuận',250),
		('SGNT',N'Sài Gòn - Ninh Thuận',300),
		('SGNTR',N'Sài Gòn - Nha Trang',350)
go

Insert into Xe
values('BS 51F-000.01','TX001'),
		('BS 51F-000.02','TX002'),
		('BS 51F-000.03','TX003'),
		('BS 51F-000.04','TX004'),
		('BS 51F-000.05','TX005'),
		('BS 51F-000.06','TX006')
go


Insert into ChuyenXe
values('SGVT16H',N'Sài Gòn - Vũng Tàu 16h','SGVT','BS 51F-000.01','16h'),
		('SGVT17H',N'Sài Gòn - Vũng Tàu 17h','SGVT','BS 51F-000.02','17h'),
		('SGBT16H',N'Sài Gòn - Bình Thuận 16h','SGBT','BS 51F-000.03','16h'),
		('SGNT17H',N'Sài Gòn - Ninh Thuận 17h','SGNT','BS 51F-000.04','17h'),
		('SGNT18H',N'Sài Gòn - Ninh Thuận 18h','SGNT','BS 51F-000.05','18h'),
		('SGNTR14H',N'Sài Gòn - Nha Trang 14h','SGNTR','BS 51F-000.06','14h')
go

Insert into VeXe
values('012345678921','SGVT17H','19/12/2022','A1'),
		('032145678912','SGVT17H','19/12/2022','A3'),
		('021345678921','SGBT16H','21/12/2022','A2'),
		('031245678921','SGNT17H','20/12/2022','A1'),
		('045612378912','SGNT17H','22/12/2022','A1'),
		('012345678901','SGNTR14H','18/12/2022','A2'),
		('012345678902','SGNTR14H','18/12/2022','A3'),
		('012345678903','SGVT17H','20/12/2022','A5')
go

