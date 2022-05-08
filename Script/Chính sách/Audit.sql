-- CHECK POLICY DA DUOC CAU HINH
select * from dba_audit_policies;

-- KIEM TRA LICH SU
select* from  dba_fga_audit_trail
WHERE TIMESTAMP > SYSDATE-1 ORDER BY timestamp DESC;

-- sql command 
---Thiet lap audit voi tham so db,extended 
alter system set audit_trail=non scope=spfile; --enable audit
shutdown immediate;
startup
alter system set audit_trail=db,extended scope=spfile; -- disable audit

-- AUDIT BINH THUONG 
audit insert CSYT by access;

--- CAI DAT FGA AUDIT
BEGIN
  DBMS_FGA.ADD_POLICY(
   object_schema      => 'TUAN',
   object_name        => 'CSYT',
   policy_name        => 'Track_CSYT',
   statement_types    => 'INSERT, UPDATE'
   );
END;
/

--- TEST
SELECT * FROM CSYT;
Insert into CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS22','IOL Group','DeLTA','721-5190');

DELETE FROM CSYT WHERE macsyt = 'CS22';