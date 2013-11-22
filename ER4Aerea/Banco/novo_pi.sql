conn System/oracle@xe
--tablespace
create SMALLFILE tablespace PI_DAT 
datafile 'C:\ORACLEXE\ORADATA\XE\PI_DAT.DBF' 
SIZE 100M 
--AUTOEXTEND ON NEXT 10M MAXSIZE UNLIMITED NOLLOGING 
EXTENT MANAGEMENT LOCAL 
AUTOALLOCATE SEGMENT SPACE MANAGEMENT AUTO;

CREATE USER PI IDENTIFIED BY PI
DEFAULT TABLESPACE PI_DAT
QUOTA UNLIMITED ON PI_DAT;

GRANT DBA,CONNECT,create trigger TO PI;

GRANT CREATE TRIGGER,CREATE SEQUENCE TO PI;

CONN PI/PI@XE;

DROP TABLE AVIAO CASCADE CONSTRAINTS;
DROP TABLE CIDADE CASCADE CONSTRAINTS;
DROP TABLE CLIENTE CASCADE CONSTRAINTS;
DROP TABLE RESERVA CASCADE CONSTRAINTS;
DROP TABLE USUARIO CASCADE CONSTRAINTS;
DROP TABLE VOO CASCADE CONSTRAINTS;

DROP Sequence SQ_AVIAO;
DROP Sequence SQ_CIDADE;
DROP Sequence SQ_CLIENTE;
DROP Sequence SQ_RESERVA;
DROP Sequence SQ_USUARIO;
DROP Sequence SQ_VOO;


create table AVIAO
(
  id_aviao    NUMBER not null,
  qtd_assento NUMBER not null,
  nom_modelo  VARCHAR2(100) not null
)
;
alter table AVIAO
  add primary key (ID_AVIAO);

create table CIDADE
(
  id_cidade  NUMBER not null,
  nom_cidade VARCHAR2(100) not null,
  num_cep    NUMBER not null
)
;
alter table CIDADE
  add primary key (ID_CIDADE);

create table CLIENTE
(
  id_cliente     NUMBER not null,
  flg_promocao   VARCHAR2(100) not null,
  nom_cliente    VARCHAR2(100) not null,
  nom_email      VARCHAR2(100) not null,
  nom_endereco   VARCHAR2(100) not null,
  num_cpf        NUMBER not null,
  id_cidade      NUMBER not null,
  num_celular    VARCHAR2(100) not null,
  val_renda      NUMBER not null,
  nom_ocupacao   VARCHAR2(100) not null,
  flg_especial   VARCHAR2(100) not null,
  num_rg         VARCHAR2(100) not null,
  sexo           VARCHAR2(100) not null,  
  num_end        NUMBER not null,
  nom_bairro     VARCHAR2(100) not null,
  cad_cep        VARCHAR2(100) not null,
  num_telefone   VARCHAR2(100) not null,
  PER_DESCONTO   NUMBER not null
)
;
alter table CLIENTE
  add primary key (ID_CLIENTE);
alter table CLIENTE
  add foreign key (ID_CIDADE)
  references CIDADE (ID_CIDADE);

create table USUARIO
(
  id_usuario  NUMBER not null,
  nom_usuario VARCHAR2(100) not null,
  nom_senha   VARCHAR2(100) not null,
  nom_login   VARCHAR2(100) not null,
  NUM_CPF     NUMBER not null,
  NOM_ENDERECO VARCHAR2(100) not null,
  NUM_ENDERE  NUMBER not null,
  ID_CIDADE   NUMBER not null
)
;
alter table USUARIO
  add primary key (ID_USUARIO);

ALTER TABLE USUARIO  
  add foreign key (ID_CIDADE)
   references CIDADE (ID_CIDADE);
   
create table VOO
(
  dat_partida DATE not null,
  dat_chegada date not null,
  id_aviao    NUMBER not null,
  id_voo      NUMBER not null,
  val_preco   NUMBER not null,
  id_origem   NUMBER not null,
  id_destino  NUMBER not null,
  FLG_PROMOCAO VARCHAR2(100) not null
)
;
alter table VOO
  add primary key (ID_VOO);
alter table VOO
  add constraint FK_CAD_CIDADE#ID_DESTINO foreign key (ID_DESTINO)
  references CIDADE (ID_CIDADE);
alter table VOO
  add constraint FK_CAD_CIDADE#ID_ORIGEM foreign key (ID_ORIGEM)
  references CIDADE (ID_CIDADE);
alter table VOO
  add foreign key (ID_AVIAO)
  references AVIAO (ID_AVIAO);

create table RESERVA
(
  id_reserva  NUMBER not null,
  id_cliente  NUMBER not null,
  id_usuario  NUMBER not null,
  val_preco   NUMBER not null,
  qtd_assento NUMBER not null,
  id_voo      NUMBER not null
)
;
alter table RESERVA
  add primary key (ID_RESERVA);
alter table RESERVA
  add constraint FK_VOO#ID_VOO foreign key (ID_VOO)
  references VOO (ID_VOO);
alter table RESERVA
  add foreign key (ID_CLIENTE)
  references CLIENTE (ID_CLIENTE);
alter table RESERVA
  add foreign key (ID_USUARIO)
  references USUARIO (ID_USUARIO);

create sequence SQ_AVIAO;

create sequence SQ_CIDADE;

create sequence SQ_CLIENTE start with 2;

create sequence SQ_RESERVA;

create sequence SQ_USUARIO start with 2;

create sequence SQ_VOO;

create or replace view vw_posicao_voo as
select 
A.ID_VOO ID,
B.NOM_CIDADE ORIGEM,
C.NOM_CIDADE DESTINO,
A.DAT_PARTIDA PARTIDA,
A.DAT_CHEGADA CHEGADA,
D.NOM_MODELO,
D.QTD_ASSENTO CAPACIDADE,
(SELECT sum(QTD_ASSENTO)
  FROM RESERVA X
  WHERE X.ID_VOO = A.ID_VOO) OCUPACAO
from 
VOO A,
CIDADE B,
CIDADE C,
AVIAO D
WHERE
A.ID_ORIGEM = B.ID_CIDADE AND
A.ID_DESTINO = C.ID_CIDADE AND
A.ID_AVIAO = D.ID_AVIAO ; 

INSERT INTO CIDADE(
ID_CIDADE,
NOM_CIDADE,
NUM_CEP) VALUES (1,
'RIBEIRAO PRETO',
14100);

insert into USUARIO(ID_USUARIO,
NOM_LOGIN,
NOM_USUARIO,
NOM_SENHA,
NUM_CPF,
NUM_ENDERE,
ID_CIDADE,
NOM_UF,
NOM_ENDERECO) VALUES (1,
'PI',
'PI',
'PI',
12345678901,
256,
1,
'SP',
'RUA');


Commit;