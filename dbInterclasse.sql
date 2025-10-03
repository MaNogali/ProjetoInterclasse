create database dbInterclasse;
use dbInterclasse;

create table tbEstatistica
(RM smallint,
idModalidade smallint,
primary key (RM, idModalidade)
gol smallint not null,
cartaoAmarelo smallint not null,
cartaoVermelho smallint not null);

create table tbAluno
(RM smallint primary key,
nome varchar(100) not null,
periodo varchar(30) not null,
idade smallint not null,
numeroCamisa smallint not null,
curso varchar(50) not null);

create table tbArbitro
(podeApitar varchar(3) not null,
idArbitro smallint not null,
RM smallint primary key);


create table tbtime
(pagamento bit not null,
ano date not null,
idtime smallint not null,
nomeSala varchar(40) not null,
camisa varchar(3) not null,
curso varchar(40) not null,
periodo varchar(30) not null,
aptoJogo varchar(3) not null);

create table tbChaveamento
(idPartida smallint not null,
idChave smallint not null,
idChave smallint not null,
fase varchar(50) not null,
time1 smallint not null,
time2 smallint not null);

create table modalidade
(idModalidade smallint primary key,
NomeModalidade varchar(50) not null);

create table tbGrupo
(idModalidade smallint primary key,
time1 smallint not null,
time2 smallint not null,
time3 smallint not null,
time4 smallint not null,
idGrupo smallint primary key);

create table Partida
(idPartida smallint primary key,
placar varchar(10) not null,
horarioDia datetime not null,
descricao varchar(300) not null,
aulaOcorrida varchar(80) not null);

create table tbclassicacao
(cartaoAmarelo smallint not null,
cartaoVermelho smallint not null,
golsMarcados smallint not null,
golsSofridos smallint not null,
saldoGols smallint not null,
statusTime varchar(25) not null,
pontos smallint not null,
grupo varchar(10) not null,
idtime samallint not null,
idmodalidade smallint not null
)