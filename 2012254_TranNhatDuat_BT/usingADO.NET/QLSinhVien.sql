CREATE DATABASE QLSinhVien
GO
USE QLSinhVien
GO
CREATE TABLE Lop (
ID int identity(1,1) primary key,
TenLop nvarchar(20) not null)

CREATE TABLE SinhVien(
ID int IDENTITY(1,1) primary key,
HoTen nvarchar(100) NOT NULL,
MaLop int foreign key references Lop(ID)
);

INSERT INTO  Lop VALUES('CTK43')
INSERT INTO  Lop VALUES('CTK44A')
INSERT INTO  Lop VALUES('CTK44B')
INSERT INTO  Lop VALUES('CTK45A')

INSERT INTO  SinhVien VALUES (N'Trần Văn Thái', 1)
INSERT INTO  SinhVien VALUES (N'Mai Thành Công', 2)
INSERT INTO  SinhVien VALUES (N'Phạm Thanh Thảo', 2)
INSERT INTO  SinhVien VALUES (N'Trần Quốc Bảo', 3)
INSERT INTO  SinhVien VALUES (N'Thái Thành Lam', 3)
INSERT INTO  SinhVien VALUES (N'Trần Văn Tám', 3)
INSERT INTO  SinhVien VALUES (N'Nguyễn Công Thành', 4)
GO

CREATE PROC InsertStudent
	@HoTen nvarchar(100),
	@MaLop int
AS
BEGIN
	INSERT INTO SinhVien
	VALUES (@HoTen, @MaLop)
END
GO
1