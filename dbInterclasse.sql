create database dbInterclasse;
use dbInterclasse;

create table tbTime
(pagamento bit not null,
ano date not null,
idTime smallint  primary key,
nomeSala varchar(40) not null,
camisa varchar(3) not null,
curso varchar(40) not null,
periodo varchar(30) not null,
aptoJogo varchar(3) not null);

create table tbModalidade
(idModalidade smallint primary key,
NomeModalidade varchar(50) not null);

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
RM smallint primary key,
constraint fk_Arbitro_RM
foreign key (RM)
references tbAluno(RM));

create table tbEstatistica
(RM smallint,
idModalidade smallint,
primary key (RM, idModalidade),
gol smallint not null,
cartaoAmarelo smallint not null,
cartaoVermelho smallint not null,
constraint fk_Aluno_RM
foreign key (RM)
references tbAluno (RM),

constraint fk_Modalidade_Id
foreign key(IdModalidade)
references tbModalidade(idModalidade));

create table tbPartida
(idPartida smallint primary key,
placar varchar(10) not null,
horarioDia datetime not null,
descricao varchar(300) not null,
aulaOcorrida varchar(80) not null);

create table tbChaveamento
(idPartida smallint not null,
idChave smallint not null,
fase varchar(50) not null,
time1 smallint not null,
time2 smallint not null,
constraint fk_Chaveamento_IdPartida
foreign key(idPartida)
references tbPartida(idPartida));

create table tbGrupo
(idModalidade smallint primary key,
time1 smallint not null,
time2 smallint not null,
time3 smallint not null,
time4 smallint not null,
idGrupo smallint primary key,
constraint fk_Grupo_IdM
foreign key(idModalidade)
references tbModalidade(idModalidade));

create table tbClassificacao
(cartaoAmarelo smallint not null,
cartaoVermelho smallint not null,
golsMarcados smallint not null,
golsSofridos smallint not null,
saldoGols smallint not null,
statusTime varchar(25) not null,
pontos smallint not null,
grupo varchar(10) not null,
idTime smallint not null,
idModalidade smallint not null);