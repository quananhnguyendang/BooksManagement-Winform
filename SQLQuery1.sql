create database QLNHASACH
go 
use QLNHASACH


go
create table THELOAI
(
	MATHELOAI int identity primary key,
	TenTheLoai nvarchar(50)
)


go
create table SACH
(
	MaSach int identity primary key,
	TenSach nvarchar (50),
	DonGia int,
	SoLuongTon int,
	TacGia nvarchar (50),
	MaTheLoai int references THELOAI (MaTheLoai)
)
drop table SACH


go
--them the loai
create proc sp_ThemTheLoai
@TenTheLoai nvarchar (50)
as
begin
	insert into THELOAI values (@TenTheLoai)
end
go
--them mot sach moi
create proc sp_ThemSach
@TenSach nvarchar (50),
@DonGia int,
@SoLuongTon int,
@TacGia nvarchar (50),
@MaTheLoai int
as
begin
	insert into SACH values(@TenSach,@DonGia,@SoLuongTon,@TacGia,@MaTheLoai)
end
DROP PROCEDURE sp_ThemSach

go
--Ban n cuon sach cua sach co ma @masach
create proc sp_bansach
@MaSach int,
@n int
as
begin
	if exists (select *from SACH where MaSach=@MaSach and SoLuongTon-@n>=0)
	begin
		update SACH set SoLuongTon=SoLuongTon-@n where MaSach=@MaSach
	end
	else
	begin
		return
	end
end
		
go
--Xoa 1 dau sach co @MaSach
create proc sp_XoaSach
@MaSach int
as
begin
	delete from SACH where MaSach=@MaSach
end

go
--Load danh sach tat ca sach
create proc sp_TatCaSach
as
begin
	select *from SACH
end

go
--Tim sach co the loai @MaTheLoai
create proc sp_TimTheLoai
@MaTheLoai int
as
begin
	select *from SACH where SACH.MaTheLoai=@MaTheLoai
end

go
--Tim sach theo tac gia
create proc sp_TimTheoTacGia
@TacGia nvarchar (50)
as
begin
	select *from SACH where SACH.TacGia=@TacGia
end

go
--Danh sach the loai
create proc sp_DanhSachTheLoai
as
begin
	select *from THELOAI
end

select * from Sach