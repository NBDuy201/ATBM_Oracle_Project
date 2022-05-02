-- Delete item from recycle bin --
purge recyclebin;

-- Disable constraints --
begin
  for cur in 
    (select owner, constraint_name , table_name 
    from all_constraints
    where owner = 'DBA_BV')
    loop
     execute immediate 'ALTER TABLE '||cur.owner||'.'||cur.table_name||' MODIFY CONSTRAINT "'||cur.constraint_name||'" DISABLE ';
     --dbms_output.put_line('ALTER TABLE '||cur.owner||'.'||cur.table_name||' MODIFY CONSTRAINT "'||cur.constraint_name||'" DISABLE ');
  end loop;
end;
/

--------------------------------------------------------
--  File created - Wednesday-April-27-2022   
--------------------------------------------------------
-- INSERTING into DBA_BV.BENHNHAN
SET DEFINE OFF;
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN95092889','CS79212387214637','Abraham Acevedo','11638',to_date('01-JAN-70','DD-MON-RR'),432,'7 Bridgeman Street','2','HA NOI','In respect that the grand strategy and growth opportunities of it are quite high.','That is to say a huge improvement of the strategic decision provides a deep insight into the conceptual design.  ','Bayfazon');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN9','CS09336147568','Retta Lord','86148',to_date('17-JUL-97','DD-MON-RR'),36,'9 Fortis Green Road','THU DUC','DA NANG','In respect of a description of the matrix of available should keep its influence over the internal network.','For instance, a descriptive action of a number of the emergency planning the operating speed model the high performance of the entire picture.  ','Venlamalol');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN2038648','CS472365','Treena Lind','52432',to_date('04-JAN-13','DD-MON-RR'),96,'44B Acre Lane','7','HAI PHONG','It is often said that final stages of the valuable information highlights the importance of the preliminary action plan.  ','Which seems to confirm the idea that any further consideration commits resources to the first-class package. Thus a complete understanding is missing.','Naposoprofen');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN1521','CS57','Hong Beaudoin','37879',to_date('23-MAY-05','DD-MON-RR'),272,'66 A-D Claylands Road','10','CAN THO','To sort everything out, it is worth mentioning that details of the basic feature provides benefit from complete failure of the supposed theory.','One cannot deny that any further consideration the strategic management.','Novotamsol');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN3248','CS0','Jason Blackmon','87267',to_date('15-SEP-99','DD-MON-RR'),551,'33-27 Philpot Street','BINH TAN','CAN THO','Perhaps we should also point out the fact that a closer study of the systolic approach should focus on the irrelevance of access.  ','It may reveal how the emergency planning successfully the major and minor objectives.','Lidohydrozon');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN67','CS79212387214637','Tiny Card','24206',to_date('10-MAY-01','DD-MON-RR'),2,'7 Cale Street','5','HA NOI','Which seems to confirm the idea that the results of the development process  impacts immensely on every vital decisions.','As a matter of fact the portion of the mechanism can turn out to be a result of the structural comparison, based on sequence analysis.','Irebutamde');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN50249752789','CS6','Carroll Binder','22554',to_date('03-JUN-83','DD-MON-RR'),355,'7 Upper Brook Street','8','HAI PHONG','It should rather be regarded as an integral part of the operations research.','There is no evidence that the evaluation of reliability activities for any of the first-class package can hardly be compared with the key factor.','Baytamdar');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN0','CS445','Maynard Brockman','93854',to_date('26-NOV-01','DD-MON-RR'),657,'41-46 Ada Street','3','DA NANG','The majority of examinations of the present impacts show that the progress of the essence the benefits of data integrity.','Everyone understands what it takes to the conceptual design what is conventionally known as standards control.','Laxospocose');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN927746','CS472365','Peggy Charlton','99298',to_date('01-JAN-70','DD-MON-RR'),63,'14 New Quebec Street','1','HA NOI','In respect of the structure of the technical terms must be compatible with the key factor.','By all means, within the framework of the the profit must take into account the possibility of the preliminary action plan.  ','Acyclomuc');
Insert into DBA_BV.BENHNHAN (MABN,MACSYT,TENBN,CMND,NGAYSINH,SONHA,"TENĐUONG",QUANHUYEN,TINHTP,TIENSUBENH,TIENSUBENHGD,DIUNGTHUOC) values ('BN83048','CS472365','Selene Cartwright','74883',to_date('23-APR-01','DD-MON-RR'),283,'4-9 Vale Lane','6','DA NANG','Curiously, the pursuance of hardware maintenance becomes extremely important for what is conventionally known as major and minor objectives.  ','One of the most striking features of this problem is that any further consideration benefits from permanent interrelation with the internal network.','Baszodar');
-- INSERTING into DBA_BV.CSYT
SET DEFINE OFF;
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS6','Australian High-Technologies Inc.','Tring','279-3549');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS57','International Telecom Group','Deal','721-5108');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS0','Western High-Technologies Co.','Blackpool','865-0016');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS09336147568','Australian Software Inc.','Nelson','454-9619');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS3','Home High-Technologies Corporation','Gloucester','115-6697');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS472365','Special High-Technologies Corp.','Abingdon','403-1635');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS4542637776','Creative Thermal Resources Group','Blackwood','693-4038');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS490','Australian Space Research Corp.','Longhope','410-3386');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS79212387214637','North Telemetrics Group','Ystrad Meurig','114-3354');
Insert into DBA_BV.CSYT (MACSYT,TENCSYT,DCCSYT,SDTCSYT) values ('CS445','Creative V-Mobile Corp.','Rhayader','325-5419');
-- INSERTING into DBA_BV.HSBA
SET DEFINE OFF;
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS98','BN2038648',to_date('10-SEP-14','DD-MON-RR'),'Even so, a number of brand new approaches has been tested during the the improvement of the well-known practice.','NV93','K8105QA62CA','CS490','It may reveal how the grand strategy habitually the general features and possibilities of the crucial development skills the questionable thesis.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS84','BN0',to_date('16-MAR-02','DD-MON-RR'),'In any case, segments of the formal action cannot rely only on the ability bias.','NV96','K91','CS57','Moreover, the advantage of the formal action the potential role models.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS278','BN83048',to_date('09-JAN-21','DD-MON-RR'),'In a loose sense any criterion boosts the growth of every contradiction between the production cycle and the specific decisions.  ','NV93','KU4EU349M','CS4542637776','In a word, discussions of the treatment can hardly be compared with the market tendencies.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS5337','BN3248',to_date('20-MAR-00','DD-MON-RR'),'The real reason of the critical thinking differently this individual elements.','NV914','KHZ65P02','CS6','Besides, the unification of the primary element has the potential to improve or transform the irrelevance of data.  ');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS2','BN0',to_date('02-MAR-84','DD-MON-RR'),'One cannot deny that final stages of the individual elements should set clear rules regarding the quality guidelines.','NV727','K8U6X7X2839C','CS0','The majority of examinations of the evident impacts show that the design patterns provides benefit from the first-class package.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS4489235','BN67',to_date('01-JAN-70','DD-MON-RR'),'In respect that the independent knowledge and growth opportunities of it are quite high.','NV136292','KAKRMPHH','CS4542637776','Naturally, a closer study of the best practice patterns provides a glimpse at the irrelevance of factor.  ');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS4','BN927746',to_date('07-MAY-04','DD-MON-RR'),'It is necessary to point out that some of the basic feature is getting more complicated against the backdrop of the minor details of user interface.  ','NV93','K8T','CS0','That is to say the conventional notion of a significant portion of the specific decisions gives us a clear notion of this major outcomes.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS13','BN50249752789',to_date('17-SEP-80','DD-MON-RR'),'In particular, the optimization of the skills becomes a key factor of the significant improvement.','NV32','KI','CS4542637776','Quite possibly, there is a direct relation between the fundamental problem and a description of the individual elements.');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS7168','BN927746',to_date('14-FEB-73','DD-MON-RR'),'Looking it another way, any further consideration is recognized by the system mechanism on a modern economy.  ','NV5','K6EXSJ4','CS6','In a loose sense one of the deep analysis reveals the patterns of the general features and possibilities of the network development.  ');
Insert into DBA_BV.HSBA (MAHSBA,MABN,NGAY,"CHANĐOAN",MABS,MAKHOA,MACSYT,KETLUAN) values ('HS344407','BN50249752789',to_date('04-JUL-21','DD-MON-RR'),'As concerns in the context of relational approach, it can be quite risky.','NV32','K2S3M4K6OXA','CS57','Doubtless, the framework of the treatment becomes even more complex when compared with the positive influence of any ground-breaking technology.  ');
-- INSERTING into DBA_BV.HSBA_DV
SET DEFINE OFF;
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS344407','DV58',to_date('12-MAR-19','DD-MON-RR'),'NV5','In respect that any part of the structured technology analysis represents basic principles of the bilateral act.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS2','DV436',to_date('19-DEC-13','DD-MON-RR'),'NV93','To be honest, violations of the big impact becomes a serious problem.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS98','DV4649810',to_date('13-SEP-94','DD-MON-RR'),'NV115081','From these facts, one may conclude that components of the interpretation of the predictable behavior must be compatible with any productivity boost.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS4489235','DV5305544858717',to_date('13-MAY-72','DD-MON-RR'),'NV5','It is stated that the raw draft of the flexible production planning should help in resolving present challenges.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS84','DV390108',to_date('05-DEC-99','DD-MON-RR'),'NV32','Another way of looking at this problem is to admit that discussions of the basic feature should correlate with this predictable behavior.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS4','DV4829913790853078404',to_date('14-JUL-02','DD-MON-RR'),'NV4739063975','For instance, the optimization of the basic feature gives a complete experience of the more technical requirements of the final draft.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS278','DV98276557035588',to_date('06-OCT-07','DD-MON-RR'),'NV96','In a loose sense a number of brand new approaches has been tested during the the improvement of the subsequent actions.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS13','DV334',to_date('04-AUG-77','DD-MON-RR'),'NV4739063975','On the other hand, we can observe that after the completion of the technical terms is heavily considerable.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS5337','DV48',to_date('13-SEP-94','DD-MON-RR'),'NV914','In a more general sense, the edge of the strategic decisions impacts automatically on every individual elements.');
Insert into DBA_BV.HSBA_DV (MAHSBA,MADV,NGAY,MAKTV,KETQUA) values ('HS7168','DV5607249227',to_date('05-DEC-99','DD-MON-RR'),'NV5','In a word, the raw draft of the structure absorption becomes a serious problem.');
-- INSERTING into DBA_BV.NHANVIEN
SET DEFINE OFF;
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV84546617973','Christian Laporte','Nam',to_date('01-JAN-70','DD-MON-RR'),'ID000','Ireland','309-5085','CS09336147568','Cơ Sở Y Tế','Da liễu');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV5','Reynaldo Ackerman','Nam',to_date('23-DEC-96','DD-MON-RR'),'ID001','Afghanistan','593-0812','CS0','Thanh Tra','Gây mê');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV727','Adalberto Aldrich','Nữ',to_date('15-OCT-18','DD-MON-RR'),'ID002','Philippines','452-5384','CS6','Bác Sĩ','Da liễu');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV93','Temeka Higgs','Nam',to_date('08-MAR-72','DD-MON-RR'),'ID003','Thailand','844-8614','CS4542637776','Nghiên Cứu','Da liễu');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV115081','Antonio Batson','Nam',to_date('16-JUN-95','DD-MON-RR'),'ID004','Jordan','836-3030','CS0','Nghiên Cứu','Gây mê');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV32','Rick Speer','Nữ',to_date('08-NOV-02','DD-MON-RR'),'ID005','Ireland','895-1196','CS490','Cơ Sở Y Tế','Gây mê');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV4739063975','Gary Penn','Nữ',to_date('05-NOV-07','DD-MON-RR'),'ID006','Nepal','447-4898','CS09336147568','Cơ Sở Y Tế','Da liễu');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV914','Kent Crittenden','Nam',to_date('01-JAN-70','DD-MON-RR'),'ID007','Suriname','522-1512','CS490','Cơ Sở Y Tế','Gây mê');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV96','Larry Grissom','Nữ',to_date('01-JAN-70','DD-MON-RR'),'ID008','Lebanon','722-6550','CS3','Nghiên Cứu','Gây mê');
Insert into DBA_BV.NHANVIEN (MANV,HOTEN,PHAI,NGAYSINH,CMND,QUEQUAN,SODT,CSYT,VAITRO,CHUYENKHOA) values ('NV136292','Abe Hatley','Nam',to_date('22-FEB-05','DD-MON-RR'),'ID009','Albania','092-5487','CS57','Bác Sĩ','Da liễu');

-- Enable constraints --
begin
  for cur in 
    (select owner, constraint_name , table_name 
    from all_constraints
    where owner = 'DBA_BV') 
    loop
     execute immediate 'ALTER TABLE '||cur.owner||'.'||cur.table_name||' MODIFY CONSTRAINT "'||cur.constraint_name||'" ENABLE ';
  end loop;
end;