-- Policy function
CREATE OR REPLACE FUNCTION XemThongTin_func
(
    p_schema varchar2,
    p_obj varchar2 
)
return varchar2
as
    user_login varchar2(100);
    role_login NHANVIEN.VAITRO%Type;
begin
    -- login of user
    user_login := SYS_CONTEXT('userenv','session_user');
        
    if (user_login = 'DBA_BV') then
        return null;
    else
        -- role of user
        select VAITRO into role_login from NHANVIEN where upper(MANV) = '''||user_login||''';
        if(role_login = N'Thanh Tra') then
            return null;
        else
            return 'upper(MANV) = '''||user_login||'''';
        end if;
    end if;
end;

-- Add policy
BEGIN 
dbms_rls.add_policy (
  object_schema => 'DBA_BV',
  object_name => 'NHANVIEN',
  policy_name => 'policy2',
--  function_schema => 'DBA_BV',
  policy_function => 'XemThongTin_func',
  statement_types => 'select');
END;

-- Drop policy
BEGIN
    DBMS_RLS.DROP_POLICY (
       object_schema => 'DBA_BV',
       object_name => 'NHANVIEN',
       policy_name => 'policy2');
END;