-- Cau 1
CREATE OR REPLACE PROCEDURE view_users
(
    out_usersList out SYS_REFCURSOR
)
AS
BEGIN
    Open out_usersList for
        select *
        from all_users;
END;

-- Cau 2
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
        sql_str := 'select grantee, table_name, privilege, type
                    from dba_tab_privs
                    where grantee = '''||in_user||''' 
                    or grantee in (select granted_role from dba_role_privs connect by prior granted_role = grantee start with grantee = '''||in_user||''')';
        dbms_output.put_line(sql_str);
    Open out_priviList for sql_str;
    End;
END view_privi;

--Cau3 create User
create or replace procedure Grant_NewUser(User_name in varchar2,Pass_Word in varchar2)
authid current_user 
is
    Tmp_count int;
    Tmp_query varchar2(100);
Begin
    Tmp_query:='alter session set "_ORACLE_SCRIPT"=true';
    execute immediate(Tmp_query);
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

--Cau 3 Delete User
create or replace procedure Drop_User(User_Name in varchar2)
authid current_user is
    Tmp_query varchar(100);
    Tmp_count varchar(100);
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

--Cau 3 Create role
CREATE OR REPLACE PROCEDURE Create_Role
    ( p_role IN varchar2) 
IS
    temp_query varchar(300);
BEGIN
    execute immediate ('alter session set "_ORACLE_SCRIPT"=true'); 
    temp_query := 'CREATE ROLE ' || p_role;
    EXECUTE IMMEDIATE (temp_query);
END ;
/
--Cau 3 Delete role
CREATE OR REPLACE PROCEDURE Delete_Role
    (p_role IN VARCHAR2)
IS
    temp_query varchar(300);
BEGIN
    execute immediate ('alter session set "_ORACLE_SCRIPT"=true'); 
    temp_query := 'DROP ROLE '|| p_Role;  
    EXECUTE IMMEDIATE (temp_query);
END ;
/