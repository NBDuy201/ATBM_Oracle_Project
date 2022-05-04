-- TC#2 ---
EXEC Create_Role ('THANH_TRA', null);

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

--exec Grant_NewUser('Test02', 'Test02', N'Cơ Sở Y Tế', 'CS6');
--exec GRANT_ROLE_TO_USER ('CoSo_YTe', 'Test02', null);

--tc4
CREATE OR REPLACE VIEW xem_HSBA
AS 
(
  SELECT HS.*
  FROM HSBA HS
  WHERE upper(HS.MABS) = USER
);
CREATE OR Replace PUBLIC SYNONYM xem_HSBA FOR DBA_BV.xem_HSBA;

CREATE OR REPLACE VIEW xem_ket_qua_HSBA_DV
AS
(
  SELECT dv.*
  FROM HSBA_DV dv, HSBA hs
  WHERE dv.MAHSBA = hs.MAHSBA
  AND upper(hs.MABS) = USER
);
CREATE OR Replace PUBLIC SYNONYM xem_ket_qua_HSBA_DV FOR DBA_BV.xem_ket_qua_HSBA_DV;

CREATE OR REPLACE VIEW xem_thong_tin_benh_nhan_cung_CSYT
AS
(
  SELECT bn.*
  FROM NHANVIEN nv, BENHNHAN bn
  WHERE 
    upper(nv.MANV) = USER and
    upper(nv.CSYT) = bn.MACSYT
);
CREATE OR Replace PUBLIC SYNONYM xem_thong_tin_benh_nhan_cung_CSYT FOR DBA_BV.xem_thong_tin_benh_nhan_cung_CSYT;

EXEC Create_Role ('BAC_SI', null);

GRANT SELECT ON xem_thong_tin_benh_nhan_cung_CSYT TO BAC_SI;
GRANT SELECT ON xem_ket_qua_HSBA_DV TO BAC_SI;
GRANT SELECT ON xem_HSBA TO BAC_SI;

--exec Grant_NewUser('Test03', 'Test03', N'Bác Sĩ', 'CS6');
--exec GRANT_ROLE_TO_USER ('BAC_SI', 'Test03', null);

--tc 5
EXEC Create_Role ('NGHIEN_CUU', null);

GRANT SELECT ON NHANVIEN_CSYT_HSBA TO NGHIEN_CUU;
GRANT SELECT ON NHANVIEN_CSYT_HSBA_DV TO NGHIEN_CUU;

--exec Grant_NewUser('Test04', 'Test04', N'Nghiên Cứu', 'CS6');
--exec GRANT_ROLE_TO_USER ('NGHIEN_CUU', 'Test04', null);

--tc6
CREATE OR REPLACE VIEW NV_xem_thong_tin
AS 
(
  SELECT nv.*
  FROM NHANVIEN nv
  WHERE upper(nv.MANV) = USER
);
CREATE OR Replace PUBLIC SYNONYM NV_xem_thong_tin FOR DBA_BV.NV_xem_thong_tin;

CREATE OR REPLACE VIEW BN_xem_thong_tin
AS 
(
  SELECT bn.*
  FROM BENHNHAN bn
  WHERE upper(bn.MABN) = USER
);
CREATE OR Replace PUBLIC SYNONYM BN_xem_thong_tin FOR DBA_BV.BN_xem_thong_tin;

EXEC Create_Role ('BENH_NHAN', null);
GRANT SELECT, UPDATE ON BN_xem_thong_tin TO BENH_NHAN;

GRANT SELECT, UPDATE ON NV_xem_thong_tin TO CoSo_YTe;
GRANT SELECT, UPDATE ON NV_xem_thong_tin TO THANH_TRA;
GRANT SELECT, UPDATE ON NV_xem_thong_tin TO BAC_SI;
GRANT SELECT, UPDATE ON NV_xem_thong_tin TO NGHIEN_CUU;

-- Misc --
-- Benh nhan thuoc CSYT

-- Bac si thuoc CSYT

-- HSBA thuoc CSYT

-- HSBA thuoc CSYT