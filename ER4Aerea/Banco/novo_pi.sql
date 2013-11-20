create table AVIAO
(
  id_aviao    NUMBER not null,
  qtd_assento NUMBER,
  nom_modelo  VARCHAR2(100)
)
;
alter table AVIAO
  add primary key (ID_AVIAO);

create table CIDADE
(
  id_cidade  NUMBER not null,
  nom_cidade VARCHAR2(100),
  num_cep    NUMBER,
  nom_uf     VARCHAR2(2)
)
;
alter table CIDADE
  add primary key (ID_CIDADE);

create table CLIENTE
(
  id_cliente     NUMBER not null,
  flg_promocao   VARCHAR2(100),
  nom_cliente    VARCHAR2(100),
  nom_email      VARCHAR2(100),
  nom_endereco   VARCHAR2(100),
  num_cpf        NUMBER,
  id_cidade      NUMBER,
  num_celular    VARCHAR2(100),
  val_renda      NUMBER,
  nom_ocupacao   VARCHAR2(100),
  flg_especial   VARCHAR2(100),
  num_rg         VARCHAR2(100),
  sexo           VARCHAR2(100),
  dta_nascimento DATE,
  num_end        NUMBER,
  nom_bairro     VARCHAR2(100),
  cad_cep        VARCHAR2(100),
  num_telefone   VARCHAR2(100)
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
  nom_usuario VARCHAR2(100),
  nom_senha   VARCHAR2(100),
  nom_login   VARCHAR2(100)
)
;
alter table USUARIO
  add primary key (ID_USUARIO);

create table VOO
(
  dat_partida DATE,
  id_aviao    NUMBER,
  id_voo      NUMBER not null,
  val_preco   NUMBER,
  id_origem   NUMBER,
  id_destino  NUMBER
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
  id_cliente  NUMBER,
  id_usuario  NUMBER,
  val_preco   NUMBER,
  qtd_assento NUMBER,
  id_voo      NUMBER
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

create sequence SQ_CLIENTE;

create sequence SQ_RESERVA;

create sequence SQ_USUARIO;

create sequence SQ_VOO;