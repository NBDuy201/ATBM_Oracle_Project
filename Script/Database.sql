--select 'drop table "'||table_name||'" cascade constraints;' from user_tables;
drop table "CSYT" cascade constraints;
drop table "BENHNHAN" cascade constraints;
drop table "NHANVIEN" cascade constraints;
drop table "HSBA" cascade constraints;
drop table "HSBA_DV" cascade constraints;

CREATE TABLE "CSYT" (
  "MACSYT" varchar2(30),
  "TENCSYT" NVARCHAR2(50),
  "DCCSYT" Nvarchar2(250),
  "SDTCSYT" varchar(12),
  PRIMARY KEY ("MACSYT")
);

CREATE TABLE "BENHNHAN" (
  "MABN" varchar2(30),
  "MACSYT" varchar2(30),
  "TENBN" NVARCHAR2(50),
  "CMND" varchar(12),
  "NGAYSINH" date,
  "SONHA" Number(5),
  "TENĐUONG" nvarchar2(50),
  "QUANHUYEN" nvarchar2(50),
  "TINHTP" nvarchar2(50),
  "TIENSUBENH" nvarchar2(250),
  "TIENSUBENHGD" nvarchar2(250),
  "DIUNGTHUOC" nvarchar2(250),
  PRIMARY KEY ("MABN"),
  CONSTRAINT "FK_BENHNHAN.MACSYT"
    FOREIGN KEY ("MACSYT")
      REFERENCES "CSYT"("MACSYT")
);

CREATE TABLE "NHANVIEN" (
  "MANV" varchar2(30),
  "HOTEN" NVARCHAR2(50),
  "PHAI" nvarchar2(20),
  "NGAYSINH" date,
  "CMND" varchar(12),
  "QUEQUAN" Nvarchar2(50),
  "SODT" varchar(12),
  "CSYT" varchar2(30),
  "VAITRO" nvarchar2(50),
  "CHUYENKHOA" nvarchar2(50),
  PRIMARY KEY ("MANV"),
  CONSTRAINT "FK_NHANVIEN.CSYT"
    FOREIGN KEY ("CSYT")
      REFERENCES "CSYT"("MACSYT")
);

CREATE TABLE "HSBA" (
  "MAHSBA" varchar2(30),
  "MABN" varchar2(30),
  "NGAY" date,
  "CHANĐOAN" nvarchar2(250),
  "MABS" varchar2(30),
  "MAKHOA" varchar2(30),
  "MACSYT" varchar2(30),
  "KETLUAN" nvarchar2(250),
  PRIMARY KEY ("MAHSBA"),
  CONSTRAINT "FK_HSBA.MABN"
    FOREIGN KEY ("MABN")
      REFERENCES "BENHNHAN"("MABN"),
  CONSTRAINT "FK_HSBA.MABS"
    FOREIGN KEY ("MABS")
      REFERENCES "NHANVIEN"("MANV"),
  CONSTRAINT "FK_HSBA.MACSYT"
    FOREIGN KEY ("MACSYT")
      REFERENCES "CSYT"("MACSYT")
);

CREATE TABLE "HSBA_DV" (
  "MAHSBA" varchar2(30),
  "MADV" varchar2(30),
  "NGAY" date,
  "MAKTV" varchar2(30),
  "KETQUA" nvarchar2(250),
  PRIMARY KEY ("MAHSBA", "MADV", "NGAY"),
  CONSTRAINT "FK_HSBA_DV.MAKTV"
    FOREIGN KEY ("MAKTV")
      REFERENCES "NHANVIEN"("MANV"),
  CONSTRAINT "FK_HSBA_DV.MAHSBA"
    FOREIGN KEY ("MAHSBA")
      REFERENCES "HSBA"("MAHSBA")
);