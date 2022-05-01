-- CHECK POLICY DA DUOC CAU HINH
select * from dba_audit_policies;

show parameter audit;


-- sql command 
---Thiet lap audit voi tham so db,extended 
alter system set audit_trail=non scope=spfile; --enable audit
shutdown immediate;
startup
alter system set audit_trail=db,extended scope=spfile; -- disable audit

-- AUDIT BINH THUONG 
audit select,insert,update, delete on SINHVIEN by access;

--- CAI DAT FGA AUDIT
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_BV',
   object_name        => 'CSYT',
   policy_name        => 'Track_CSYT',
   statement_types    => 'INSERT, UPDATE, DELETE'
   );
END;
/

BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_BV',
   object_name        => 'BENHNHAN',
   policy_name        => 'Track_BENHNHAN',
   statement_types    => 'SELECT, INSERT, UPDATE, DELETE'
   );
END;
/

BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_BV',
   object_name        => 'NHANVIEN',
   policy_name        => 'Track_NHANVIEN',
   statement_types    => 'SELECT, INSERT, UPDATE, DELETE'
   );
END;
/

BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_BV',
   object_name        => 'HSBA',
   policy_name        => 'Track_HSBA',
   statement_types    => 'SELECT, INSERT, UPDATE, DELETE'
   );
END;
/
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'DBA_BV',
   object_name        => 'HSBA_DV',
   policy_name        => 'Track_HSBA_DV',
   statement_types    => 'SELECT, INSERT, UPDATE, DELETE'
   );
END;
/

-- TEST
select * from NHANVIEN;
Insert into NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV20','LoDWm','Male',to_date('01-JAN-90','DD-MON-RR'),'ID010','Leon','722-6220','CS3','Thanh tra','');

-- KIEM TRA LICH SU
select* from  dba_fga_audit_trail
WHERE TIMESTAMP > SYSDATE-1 ORDER BY timestamp DESC;

select * from SYS.fga_log$ WHERE NTIMESTAMP# > SYSDATE-1 ORDER BY ntimestamp# DESC;



