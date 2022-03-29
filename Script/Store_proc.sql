-- Cau 1 --
CREATE OR REPLACE PROCEDURE view_users
(
    out_usersList out SYS_REFCURSOR
)
AS
BEGIN
    Open out_usersList for
        select *
        from all_users
        where COMMON != 'YES';
END view_users;
/

-- Cau 2 --
CREATE OR REPLACE PROCEDURE view_allPrivi
(
    out_priviList out SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    declare sql_str varchar(500);
    Begin
        sql_str := 'select grantee, table_name, privilege, type, grantable
                    from dba_tab_privs';
        dbms_output.put_line(sql_str);
    Open out_priviList for sql_str;
    End;
END view_allPrivi;
/

-- Cau 3 --
-- create User
create or replace procedure Grant_NewUser(User_name in varchar2,Pass_Word in varchar2)
authid current_user 
is
    Tmp_count int;
    Tmp_query varchar2(100);
Begin
    select count(*) into Tmp_count from all_users where username=User_name;
    if(Tmp_count!=0)
    then 
    RAISE_APPLICATION_ERROR(-20000,'User da ton tai');
    end if;
    Tmp_query:='Create user '|| User_name||' identified by '||Pass_Word;
    execute immediate(Tmp_query);
    Tmp_query:='grant create session to'|| User_name;
End;
/

-- Delete User
create or replace procedure Drop_User (User_Name in varchar2)
authid current_user is
    Tmp_query varchar(100);
    Tmp_count int;
Begin
    select count(*) into Tmp_count from all_users where username=User_name;
    if(Tmp_count!=0) then
        Tmp_query:='Drop user '||User_Name; 
        execute IMMEDIATE (Tmp_query);
    else 
        RAISE_APPLICATION_ERROR(-20000,'User chua ton tai');
    end if;
End;
/

--exec Drop_User('TEST');
--Grant create session to TEST;

CREATE OR REPLACE PROCEDURE view_roles
(
    out_rolesList out SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
    sql_str varchar(500);
BEGIN
    sql_str := 'select * from DBA_ROLES where COMMON != ''YES''';
    Open out_rolesList for sql_str;
END view_roles;
/

-- Create role
create or replace procedure Create_Role (Role_Name in varchar2,Pass_Word in varchar2)
authid current_user is
    Tmp_query varchar(100);
Begin
    if(Pass_Word is NULL) 
        then Tmp_query:='Create role '|| Role_Name;
    else 
        Tmp_query:='Create role '|| Role_Name||' identified by '||Pass_Word;
    End if;
    execute IMMEDIATE (Tmp_query);
    exception
    when others then
    RAISE_APPLICATION_ERROR(-20000,'Role da ton tai');
End;
/

-- Delete role
CREATE OR REPLACE PROCEDURE Delete_Role (p_role IN VARCHAR2)
IS
    temp_query varchar(300);
BEGIN
    temp_query := 'DROP ROLE '|| p_Role;  
    EXECUTE IMMEDIATE (temp_query);
END ;
/

--Cau 3 Doi password user:
create or replace procedure Alter_User(User_name in varchar2,Pass_Word in varchar2)
authid current_user
is
    Tmp_count int;
    Tmp_query varchar2(100);
begin
    select count(*) into Tmp_count from all_users where username=User_name;
    if(Tmp_count!=0)then
        Tmp_query :='ALTER USER '|| User_name||' IDENTIFIED BY '||Pass_Word;
        execute immediate(Tmp_query);
    else
        RAISE_APPLICATION_ERROR(-20000, 'User khong ton tai');
    end if;
end;
/

--exec Alter_User('TEST', 'abc');

-- Cau 3 Hieu chinh role
create or replace procedure Alter_Role (Role_name in varchar2, Pass_Word in varchar2)
authid current_user
is
    Tmp_query varchar2(100);
begin
    if(Pass_Word is NULL) then
        Tmp_query := 'ALTER ROLE '|| Role_Name|| ' Not IDENTIFIED';
        execute immediate(Tmp_query);
    else
        Tmp_query := 'ALTER ROLE '|| Role_Name|| ' IDENTIFIED BY'|| Pass_Word;
    end if;
end;
/

-- Cau 4 Cap quyen cho user
CREATE OR REPLACE PROCEDURE GRANT_PRIVILEGES_USER(user_name IN NVARCHAR2, n_pri IN NVARCHAR2, n_col IN NVARCHAR2, n_tab IN NVARCHAR2, n_option IN NVARCHAR2)
IS
   	n_count INTEGER := 0;
BEGIN
    select count(*) into n_count from all_users where username = user_name;
   	if n_count = 0 then
        dbms_output.put_line('User does not exist');
        return;
   	end if;

    if  n_pri = 'UPDATE' and n_pri = 'SELECT' then
        if n_option = 'TRUE' then
            EXECUTE IMMEDIATE ('grant ' || n_pri || '(' || n_col || ') ' || ' on ' || n_tab || ' to ' || user_name || ' with grant option');
        else
            EXECUTE IMMEDIATE ('grant ' || n_pri || '(' || n_col || ') ' || ' on ' || n_tab || ' to ' || user_name);
        end if;
    else
        if n_option = 'TRUE' then
            EXECUTE IMMEDIATE ('grant ' || n_pri || ' on ' || n_tab || ' to ' || user_name || ' with grant option');
        else
            EXECUTE IMMEDIATE ('grant ' || n_pri || ' on ' || n_tab || ' to ' || user_name);
        end if; 
    end if;
END  GRANT_PRIVILEGES_USER;
/

CREATE OR REPLACE PROCEDURE view_all_tables
(
    out_tableList out SYS_REFCURSOR
)
AS
BEGIN
    Open out_tableList for
        select table_name
        from all_tables
        WHERE owner = user;
END view_all_tables;
/

CREATE OR REPLACE PROCEDURE view_all_views
(
    out_viewList out SYS_REFCURSOR
)
AS
BEGIN
    Open out_viewList for
        select view_name
        from all_views
        WHERE owner = user;
END view_all_views;
/

CREATE OR REPLACE PROCEDURE view_all_proc
(
    out_procList out SYS_REFCURSOR
)
AS
BEGIN
    Open out_procList for
        select object_name
        from all_procedures
        WHERE owner = user;
END view_all_proc;
/

-- Cap quyen he thong cho user:
CREATE OR REPLACE PROCEDURE GRANT_PRIVILEGES_SYS_USER(user_name IN NVARCHAR2, n_pri IN NVARCHAR2, n_option IN NVARCHAR2)
authid current_user
IS
   	n_count INTEGER := 0;
BEGIN
    select count(*) into n_count from all_users where username = user_name;
   	if n_count = 0 then
        dbms_output.put_line('User does not exist');
        return;
   	end if;

     if n_option = 'TRUE' then
        EXECUTE IMMEDIATE ('grant ' || n_pri || ' to ' || user_name || ' with grant option');
    else
        EXECUTE IMMEDIATE ('grant ' || n_pri || ' to ' || user_name);
    end if;
END  GRANT_PRIVILEGES_SYS_USER;
/

CREATE OR REPLACE PROCEDURE GRANT_ROLE_TO_USER(role_name IN NVARCHAR2, user_name IN NVARCHAR2, n_option IN NVARCHAR2)
authid current_user
IS
   	n_count INTEGER := 0;
BEGIN
    select count(*) into n_count from all_users where username = user_name;
   	if n_count = 0 then
        dbms_output.put_line('User does not exist');
        return;
   	end if; 

    if n_option = 'TRUE' then
        EXECUTE IMMEDIATE ('grant ' || role_name || ' to ' || user_name || ' with admin option');
    else
        EXECUTE IMMEDIATE ('grant ' || role_name || ' to ' || user_name);
    end if;
END GRANT_ROLE_TO_USER;
/

-- cau 5 thu hoi quyen
--Cau5 Thu hoi quyen trên User
create or replace procedure Revoke_Privs_User(User_Name in varchar2, priv in varchar2, obj in varchar2)
is
    Tmp_query varchar(100);
    Tmp_count int;
exception_username exception;
Begin
    select count(*) into Tmp_count from all_users where UserName = User_Name;
    if(Tmp_count != 0) then
        Tmp_query := 'REVOKE '||priv||' on '||obj||' FROM '||User_name;
        --DBMS_OUTPUT.put_line(Tmp_query);
        execute IMMEDIATE (Tmp_query);
    elsif(Tmp_count=0) then
        raise exception_username;
end if;

Exception 
    when exception_username then 
    RAISE_APPLICATION_ERROR(-20000,'User chua ton tai');
    WHEN OTHERS THEN
    IF SQLCODE != -942 THEN
    RAISE;
END IF;
End;
/
--grant select on CSYT TO GIAOVU;
--Exec Revoke_Privs_User('GIAOVU', 'SELECT', 'CSYT');

--Cau5/* Thu hoi quyen he thong cua 1 role*/
create or replace procedure Revoke_Privs_Role(a_role in varchar2, a_priv in varchar2, a_obj in varchar2)
authid current_user is
    Tmp_query varchar(100);
--    Tmp_count int;
--    Tmp_count2 int;
--    exception_priv exception;
--    exception_role exception;
Begin
    --select count(*) into Tmp_count from role_sys_privs where a_priv = role_sys_privs.privilege;
    --select count(*) into Tmp_count2 from role_sys_privs where a_role = role_sys_privs.role;
--    if(Tmp_count != 0 AND Tmp_count2 != 0) then
--        Tmp_query := 'REVOKE '||a_priv||'on '||a_obj||' FROM '||a_role;
--        execute IMMEDIATE (Tmp_query);
--    elsif(Tmp_count=0) then
--        raise exception_priv;
--    elsif(Tmp_count2=0) then
--        raise exception_role;
--    end if;
--    
--    Tmp_query := 'REVOKE '||a_priv||'on '||a_obj||' FROM '||a_role;
--    execute IMMEDIATE (Tmp_query);
--    
--    Exception 
--    when exception_priv then 
--        RAISE_APPLICATION_ERROR(-20000,'Privilege chua ton tai.');
--    when exception_role then
--        RAISE_APPLICATION_ERROR(-20000,'Role chua ton tai.');
--    WHEN OTHERS THEN
--        IF SQLCODE != -942 THEN
--            RAISE;
--        END IF;
--    End;

    Tmp_query := 'REVOKE '||a_priv||' on '||a_obj||' FROM '||a_role;
    --dbms_output.put_line(Tmp_query);
    execute IMMEDIATE (Tmp_query);
End;
/
--grant select on CSYT TO GIAOVIEN;
--Exec Revoke_Privs_Role('GIAOVIEN', 'SELECT', 'CSYT');

-- cau 6
-- View user granted roles
CREATE OR REPLACE PROCEDURE view_grantedRole
(
	in_user in VARCHAR2,
    out_roleList out SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    declare sql_str varchar(500);
    Begin
        sql_str := 'SELECT grantee, granted_role, admin_option 
                    FROM dba_role_privs 
                    where grantee = '''||in_user||'''';
        dbms_output.put_line(sql_str);
    Open out_roleList for sql_str;
    End;
END view_grantedRole;
/
-- View User granted sys priv
CREATE OR REPLACE PROCEDURE view_sysPrivi
(
	in_user in VARCHAR2,
    out_sysPriviList out SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    declare sql_str varchar(500);
    Begin
        sql_str := 'SELECT GRANTEE, PRIVILEGE, ADMIN_OPTION 
                    FROM dba_sys_privs 
                    where grantee = '''||in_user||'''
                    or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '''||in_user||''')';
        dbms_output.put_line(sql_str);
    Open out_sysPriviList for sql_str;
    End;
END view_sysPrivi;

/
-- View User granted object priv
CREATE OR REPLACE PROCEDURE view_privi
(
	in_user in VARCHAR2,
    out_priviList out SYS_REFCURSOR
)
AUTHID CURRENT_USER
AS
BEGIN
    declare sql_str varchar(500);
    Begin
        sql_str := 'select grantee, table_name, privilege, type, grantable
                    from dba_tab_privs
                    where grantee = '''||in_user||'''
                    or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '''||in_user||''')';
        dbms_output.put_line(sql_str);
    Open out_priviList for sql_str;
    End;
END view_privi;
/

-- cau 7 --
CREATE OR REPLACE PROCEDURE update_priv (old_priv IN VARCHAR2, tab_name IN VARCHAR2, username IN VARCHAR2, new_priv IN VARCHAR2)
IS
    temp VARCHAR2(50);
    temp2 VARCHAR2(50);
BEGIN
    temp:= 'REVOKE ' || old_priv || ' ON ' || tab_name || ' FROM ' || username;
    EXECUTE IMMEDIATE(temp);
    temp2:= 'GRANT ' || new_priv || ' ON ' || tab_name || ' TO ' || username;
    EXECUTE IMMEDIATE(temp2);
END;
/