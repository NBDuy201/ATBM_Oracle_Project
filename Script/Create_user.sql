-- DBA (Phân hệ 1)
CREATE USER DBA_BV IDENTIFIED BY DBA_BV;
GRANT CREATE SESSION TO DBA_BV;
Grant DBA to DBA_BV;

-- Thanh Tra --
CREATE USER NV32 IDENTIFIED BY NV32;
GRANT CREATE SESSION TO NV32;

-- Cơ Sở Y Tế --
CREATE USER CS57 IDENTIFIED BY CS57;
GRANT CREATE SESSION TO CS57;

-- Bác sĩ --
CREATE USER NV5 IDENTIFIED BY NV5;
GRANT CREATE SESSION TO NV5;

-- Bệnh Nhân --
CREATE USER BN0 IDENTIFIED BY BN0;
GRANT CREATE SESSION TO BN0;

-- Nghiên cứu --
CREATE USER NV96 IDENTIFIED BY NV96;
GRANT CREATE SESSION TO NV96;

-- DBA 2 (Phân hệ 2)
CREATE USER DBA2 IDENTIFIED BY DBA2;
GRANT CREATE SESSION TO DBA2 with admin option;
Grant select, insert on BENHNHAN to DBA2;
Grant select, insert on NHANVIEN to DBA2;
Grant select, insert, update on CSYT to DBA2;
GRANT EXECUTE on Grant_NewUser to DBA2;
CREATE OR REPLACE PUBLIC SYNONYM Grant_NewUser FOR DBA_BV.Grant_NewUser;
Grant create user to DBA2;
