-- DBA TC2 --
-- Tạo user với vai trò
create or replace procedure Grant_NewUser(User_name in varchar2, Pass_Word in varchar2, vaitro in NVARCHAR2, CoSoYTe in VARCHAR2)
authid current_user 
is
    Tmp_count int;
    Tmp_query varchar2(100);
Begin
    select count(*) into Tmp_count from all_users where username=upper(User_name);
    if(Tmp_count!=0) then 
        RAISE_APPLICATION_ERROR(-20000,'User da ton tai');
    end if;
    
    -- Create User
    Tmp_query:='Create user '|| User_name||' identified by '||Pass_Word;
    --DBMS_OUTPUT.PUT_LINE(Tmp_query);
    execute immediate(Tmp_query);
    
    Tmp_query:='grant create session to '|| User_name;
    --DBMS_OUTPUT.PUT_LINE(Tmp_query);
    execute immediate(Tmp_query);
         
     -- Insert User in table
    if(vaitro = N'Bệnh Nhân') then
        Tmp_query:='insert into BENHNHAN(MABN, MACSYT) Values(:ma, :cs)';
         execute immediate(Tmp_query)
            using User_name, CoSoYTe;
     else
        Tmp_query:='insert into NHANVIEN(MANV, CSYT, VAITRO) Values(:ma, :cs, :vt)';
        execute immediate(Tmp_query)
            using User_name, CoSoYTe, vaitro;
    End if;
End;
/
--exec Grant_NewUser('Test02', 'Test02', N'Bệnh Nhân', 'CS0');

-- Xóa user với vai trò
create or replace procedure Drop_NewUser (User_Name in varchar2, vaitro in NVARCHAR2)
authid current_user is
    Tmp_query varchar(100);
    Tmp_count int;
    Tmp_count2 int;
Begin
    select count(*) into Tmp_count from all_users where username=upper(User_name);
    if(Tmp_count!=0) then        
        -- Check BN or NV
        select count(*) into Tmp_count from BENHNHAN where upper(MABN) = upper(User_name);
        select count(*) into Tmp_count2 from NHANVIEN where upper(MANV) = upper(User_name);
        
        if(vaitro = N'Bệnh Nhân' and Tmp_count != 0) then
            Tmp_query:='Delete From BENHNHAN where upper(MABN) = upper(:ma)';
        elsif(vaitro != N'Bệnh Nhân' and Tmp_count2 != 0) then
            Tmp_query:='Delete From NHANVIEN where upper(MANV) = upper(:ma)';
        else
            RAISE_APPLICATION_ERROR(-20000, N'User không đúng vai trò');
        end if;
        -- Exec
        -- Delete from table
        execute immediate(Tmp_query)
                using User_name;
        -- Drop user       
        Tmp_query:='Drop user '||User_Name; 
        execute IMMEDIATE (Tmp_query);
    else 
        RAISE_APPLICATION_ERROR(-20000, N'User chưa tồn tại');
    end if;
End;
/
--exec Drop_NewUser('Test02', N'Bệnh Nhân');