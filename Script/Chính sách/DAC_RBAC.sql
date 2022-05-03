-- TC#2 ---
EXEC Create_Role ('THANH_TRA', null);
EXEC Create_Role ('BAC_SI', null);
EXEC Create_Role ('NGHIEN_CUU', null);
EXEC Create_Role ('BENH_NHAN', null);

GRANT SELECT ON BENHNHAN TO THANH_TRA;
GRANT SELECT ON CSYT TO THANH_TRA;
GRANT SELECT ON HSBA TO THANH_TRA;
GRANT SELECT ON HSBA_DV TO THANH_TRA;
GRANT SELECT ON NHANVIEN TO THANH_TRA;

--exec Grant_NewUser('Test02', 'Test02', N'Thanh Tra', 'CS6');

--exec GRANT_ROLE_TO_USER ('THANH_TRA', 'Test02', null);

-- TC#3 --
CREATE OR REPLACE VIEW NHANVIEN_CSYT_HSBA
AS 
(
  SELECT HS.*
  FROM HSBA HS
  WHERE HS.MACSYT = (SELECT NV.CSYT
                    FROM NHANVIEN NV
                    WHERE upper(NV.MANV) = USER)
);
/
CREATE OR Replace PUBLIC SYNONYM NHANVIEN_CSYT_HSBA FOR DBA_BV.NHANVIEN_CSYT_HSBA;

CREATE OR REPLACE VIEW NHANVIEN_CSYT_HSBA_DV
AS 
(
  Select * 
  from HSBA_DV
  where MAHSBA in (Select MAHSBA
                    from NHANVIEN_CSYT_HSBA)
);
/
CREATE PUBLIC SYNONYM NHANVIEN_CSYT_HSBA_DV FOR DBA_BV.NHANVIEN_CSYT_HSBA_DV;

EXEC Create_Role ('CoSo_YTe', null);

GRANT SELECT, INSERT, DELETE ON NHANVIEN_CSYT_HSBA TO CoSo_YTe;
GRANT SELECT, INSERT, DELETE ON NHANVIEN_CSYT_HSBA_DV TO CoSo_YTe;

CREATE USER NV93 identified by NV93;

GRANT CREATE SESSION TO NV93;

GRANT CoSo_YTe TO NV93;

SELECT * FROM USER_ROLE_PRIVS where role = upper('CoSo_YTe');

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
CREATE OR REPLACE VIEW NV_xem_thong_tin
AS 
(
  SELECT nv.*
  FROM NHANVIEN nv
  WHERE upper(nv.MANV) = USER
);
/
CREATE OR Replace PUBLIC SYNONYM NV_xem_thong_tin FOR DBA_BV.NV_xem_thong_tin;

CREATE OR REPLACE VIEW BN_xem_thong_tin
AS 
(
  SELECT bn.*
  FROM BENHNHAN bn
  WHERE upper(bn.MABN) = USER
);
/
CREATE OR Replace PUBLIC SYNONYM BN_xem_thong_tin FOR DBA_BV.BN_xem_thong_tin;

GRANT SELECT ON BN_xem_thong_tin TO BENHNHAN;

GRANT SELECT, UPDATE ON NV_xem_thong_tin TO CoSo_YTe;
GRANT SELECT, UPDATE ON NV_xem_thong_tin TO THANH_TRA;



