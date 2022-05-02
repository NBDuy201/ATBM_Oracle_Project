-- TC#2 ---
-- CHUA DUOC --
EXEC Create_Role ('BAC_SI','123');
EXEC Create_Role ('Y_TE','123');
EXEC Create_Role ('CoSo_YTe','123');
EXEC Create_Role ('NGHIEN_CUU','123');
EXEC Create_Role ('BENH_NHAN','123');

Insert into NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV69','Lom','Male',to_date('01-JAN-90','DD-MON-RR'),'ID010','Leon','722-6220','CS3','Thanh tra','');

Insert into NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV101','Ladw','Male',to_date('19-JAN-91','DD-MON-RR'),'ID011','Leo','700-6220','CS3', 'Cơ sở y tế','');

GRANT CREATE SESSION TO THANH_TRA;
GRANT SELECT ON BENHNHAN TO THANH_TRA;
GRANT SELECT ON CSYT TO THANH_TRA;
GRANT SELECT ON HSBA TO THANH_TRA;
GRANT SELECT ON HSBA_DV TO THANH_TRA;
GRANT SELECT ON NHANVIEN TO THANH_TRA;

EXEC Grant_NewUser('NV69','NV69');

exec GRANT_ROLE_TO_USER ('THANH_TRA', 'NV69', '');

-- CHAY DUOC --
CREATE ROLE THANH_TRA;

GRANT CREATE SESSION TO THANH_TRA;
GRANT SELECT ON BENHNHAN TO THANH_TRA;
GRANT SELECT ON CSYT TO THANH_TRA;
GRANT SELECT ON HSBA TO THANH_TRA;
GRANT SELECT ON HSBA_DV TO THANH_TRA;
GRANT SELECT ON NHANVIEN TO THANH_TRA;

CREATE USER NV69 identified by NV69;

GRANT CREATE SESSION TO THANH_TRA;

GRANT THANH_TRA TO NV69;

-- TC#3 --
---- TC#3
CREATE OR REPLACE VIEW NHANVIEN_CSYT_HSBA
AS 
(
  SELECT HS.*
  FROM HSBA HS
  WHERE HS.MACSYT = (SELECT NV.CSYT
                    FROM NHANVIEN NV
                    WHERE NV.MANV = 'USER')
);

CREATE OR REPLACE VIEW NHANVIEN_CSYT_HSBA_DV
AS 
(
  SELECT DV.*
  FROM NHANVIEN NV, CSYT CS, HSBA HS, HSBA_DV DV
  WHERE NV.CSYT = CS.MACSYT
  AND CS.MACSYT = HS.MACSYT
  AND HS.MAHSBA = DV.MAHSBA
  AND NV.MANV = 'USER'
);

SELECT * FROM NHANVIEN;
SELECT * FROM CSYT;
SELECT * FROM HSBA;
SELECT * FROM HSBA_DV;
SELECT * FROM BENHNHAN;

drop role CoSo_YTe;

CREATE ROLE CoSo_YTe;

GRANT CREATE SESSION TO CoSo_YTe;
GRANT INSERT, DELETE ON NHANVIEN_CSYT_HSBA TO CoSo_YTe;
GRANT INSERT, DELETE ON NHANVIEN_CSYT_HSBA_DV TO CoSo_YTe;

CREATE USER NV93 identified by NV93;

GRANT CREATE SESSION TO NV93;

GRANT CoSo_YTe TO NV93;


--tc4
CREATE OR REPLACE VIEW xem_HSBA
AS 
(
  SELECT HS.*
  FROM HSBA HS
  WHERE HS.MABS = USER
);

CREATE OR REPLACE VIEW xem_ket_qua_HSBA_DV
AS
(
  SELECT dv.*
  FROM HSBA_DV dv, HSBA hs
  WHERE dv.MAHSBA = hs.MAHSBA
  AND hs.MABS = USER
);

CREATE OR REPLACE VIEW xem_thong_tin_benh_nhan_cung_CSYT
AS
(
  SELECT bn.*
  FROM NHANVIEN nv, BENHNHAN bn, HSBA hs
  WHERE hs.MABN = bn.MABN
  AND hs.MABS = nv.MANV
  AND nv.CSYT = USER
);

CREATE ROLE BAC_SI;

GRANT CREATE SESSION TO BAC_SI;
GRANT SELECT ON BENHNHAN TO BAC_SI;

GRANT SELECT ON xem_thong_tin_benh_nhan_cung_CSYT TO BAC_SI;
GRANT SELECT ON xem_ket_qua_HSBA_DV TO BAC_SI;
GRANT SELECT ON xem_HSBA TO BAC_SI;

--CREATE USER bacsitest identified by 123;

GRANT CREATE SESSION TO BAC_SI;
GRANT CREATE SESSION TO bacsitest;
GRANT BAC_SI TO bacsitest;

select * from BENHNHAN;
select * from NHANVIEN;
select * from HSBA;
select * from HSBA_DV;
select * from CSYT;
--tc 5

CREATE OR REPLACE VIEW xem_HSBA_cung_CSYT
AS 
(
  SELECT HS.*
  FROM HSBA HS , CSYT cs
  WHERE hs.MACSYT = cs.MACSYT
  and HS.MABS = USER
);


CREATE ROLE NGHIEN_CUU;

GRANT CREATE SESSION TO NGHIEN_CUU;

GRANT SELECT ON xem_HSBA_cung_CSYT TO NGHIEN_CUU;



CREATE USER nghiencuutest identified by 123;

GRANT CREATE SESSION TO NGHIEN_CUU;
GRANT CREATE SESSION TO nghiencuutest;
GRANT NGHIEN_CUU TO nghiencuutest;


--tc6
select * from Nhanvien
CREATE OR REPLACE VIEW NV_xem_thong_tin
AS 
(
  SELECT nv.*
  FROM NHANVIEN nv
  WHERE nv.MANV = USER
);

select * from BENHNHAN
CREATE OR REPLACE VIEW BN_xem_thong_tin
AS 
(
  SELECT bn.*
  FROM BENHNHAN bn
  WHERE bn.MABN = USER
);

CREATE ROLE BENHNHAN;
CREATE USER benhnhantest identified by 123;
GRANT CREATE SESSION TO BENHNHAN;
GRANT SELECT ON BN_xem_thong_tin TO BENHNHAN;

GRANT CREATE SESSION TO BENHNHAN;
GRANT CREATE SESSION TO benhnhantest;
GRANT NGHIEN_CUU TO benhnhantest;

CREATE ROLE NHANVIEN;
CREATE USER nhanvientest identified by 123;
GRANT CREATE SESSION TO NHANVIEN;
GRANT SELECT ON NV_xem_thong_tin TO NHANVIEN;

GRANT CREATE SESSION TO NHANVIEN;
GRANT CREATE SESSION TO nhanvientest;
GRANT NGHIEN_CUU TO nhanvientest;



