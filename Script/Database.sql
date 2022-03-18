CREATE TABLE "CSYT" 
(
  "MÃCSYT" varchar2(30),
  "TÊNCSYT" NVARCHAR2(50),
  "ĐCCSYT" Nvarchar2(250),
  "SĐTCSYT" varchar(12),
  PRIMARY KEY ("MÃCSYT")
);

CREATE TABLE "BỆNHNHÂN" 
(
  "MÃBN" varchar2(30),
  "MÃCSYT" varchar2(30),
  "TÊNBN" NVARCHAR2(50),
  "CMND" Number(12),
  "NGÀYSINH" date,
  "SỐNHÀ" Number(5),
  "TÊNĐƯỜNG" nvarchar2(50),
  "QUẬNHUYỆN" nvarchar2(50),
  "TỈNHTP" nvarchar2(50),
  "TIỀNSỬBỆNH" nvarchar2(250),
  "TIỀNSỬBỆNHGĐ" nvarchar2(250),
  "DỊỨNGTHUỐC" nvarchar2(250),
  PRIMARY KEY ("MÃBN"),
  CONSTRAINT "FK_BỆNHNHÂN.MÃCSYT"
    FOREIGN KEY ("MÃCSYT")
      REFERENCES "CSYT"("MÃCSYT")
);

CREATE TABLE "NHÂNVIÊN" 
(
  "MÃNV" varchar2(30),
  "HỌTÊN" NVARCHAR2(50),
  "PHÁI" nvarchar2(20),
  "NGÀYSINH" date,
  "CMND" Number(12),
  "QUÊQUÁN" Nvarchar2(50),
  "SỐĐT" varchar(12),
  "CSYT" varchar2(30),
  "VAITRÒ" nvarchar2(50),
  "CHUYÊNKHOA" nvarchar2(50),
  PRIMARY KEY ("MÃNV"),
  CONSTRAINT "FK_NHÂNVIÊN.CSYT"
    FOREIGN KEY ("CSYT")
      REFERENCES "CSYT"("MÃCSYT")
);

CREATE TABLE "HSBA" 
(
  "MÃHSBA" varchar2(30),
  "MÃBN" varchar2(30),
  "NGÀY" date,
  "CHẨNĐOÁN" nvarchar2(250),
  "MÃBS" varchar2(30),
  "MÃKHOA" varchar2(30),
  "MÃCSYT" varchar2(30),
  "KẾTLUẬN" nvarchar2(250),
  PRIMARY KEY ("MÃHSBA"),
  CONSTRAINT "FK_HSBA.MÃBN"
    FOREIGN KEY ("MÃBN")
      REFERENCES "BỆNHNHÂN"("MÃBN"),
  CONSTRAINT "FK_HSBA.MÃCSYT"
    FOREIGN KEY ("MÃCSYT")
      REFERENCES "CSYT"("MÃCSYT")
);

CREATE TABLE "HSBA_DV" 
(
  "MÃHSBA" varchar2(30),
  "MÃDV" varchar2(30),
  "NGÀY" date,
  "MÃKTV" varchar2(30),
  "KẾTQUẢ" nvarchar2(250),
  PRIMARY KEY ("MÃHSBA", "MÃDV", "NGÀY"),
  CONSTRAINT "FK_HSBA_DV.MÃKTV"
    FOREIGN KEY ("MÃKTV")
      REFERENCES "NHÂNVIÊN"("MÃNV"),
  CONSTRAINT "FK_HSBA_DV.MÃHSBA"
    FOREIGN KEY ("MÃHSBA")
      REFERENCES "HSBA"("MÃHSBA")
);