CREATE OR REPLACE PROCEDURE USP_CreateUserThanhtra
AS
    CURSOR CUR IS (SELECT MANV
                   FROM NHANVIEN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS)
                   AND NHANVIEN.VAITRO = 'Thanh tra');
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE USP_CreateUserBacSi
AS
    CURSOR CUR IS (SELECT MANV
                   FROM NHANVIEN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS)
                   AND NHANVIEN.VAITRO = 'Bác sĩ');
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE USP_CreateUserYTe
AS
    CURSOR CUR IS (SELECT MANV
                   FROM NHANVIEN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS)
                   AND NHANVIEN.VAITRO = 'Nhân viên y tế');
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE USP_CreateUserNghienCuu
AS
    CURSOR CUR IS (SELECT MANV
                   FROM NHANVIEN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS)
                   AND NHANVIEN.VAITRO = 'Nghiên cứu');
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE USP_CreateUserCSYT
AS
    CURSOR CUR IS (SELECT MANV
                   FROM NHANVIEN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS)
                   AND NHANVIEN.VAITRO = 'Cơ sở y tế');
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/

CREATE OR REPLACE PROCEDURE USP_CreateUserBenhNhan
AS
    CURSOR CUR IS (SELECT MABM
                   FROM BENHNHAN
                   WHERE MANV NOT IN (SELECT USERNAME FROM ALL_USERS));
    strSQL VARCHAR(300);
    usr VARCHAR2(30);
BEGIN
    OPEN CUR;
    LOOP
        FETCH CUR INTO Usr;
        EXIT WHEN CUR%NOTFOUND;
        
        strSQL := 'CREATE USER ' || Usr || ' IDENTIFIED BY ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
        strSQL := 'GRANT CREATE SESSION TO ' || Usr;
        EXECUTE IMMEDIATE (strSQL);
    END LOOP;
END;
/
