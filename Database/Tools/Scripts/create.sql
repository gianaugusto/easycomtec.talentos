IF (NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE (name = 'BancoDeTalentoEasy')))
BEGIN
	CREATE DATABASE BancoDeTalentoEasy
END
GO

USE BancoDeTalentoEasy
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'Talento'))
BEGIN
	DROP TABLE Talento
END 
GO

CREATE TABLE Talento
(
	ID							UNIQUEIDENTIFIER DEFAULT(NEWID()) NOT NULL,
	Nome						VARCHAR(100)		NOT NULL,
	Email						VARCHAR(100)		NOT NULL,
	Skype						VARCHAR(20)		NOT NULL,
	Whatsapp					VARCHAR(20)		NOT NULL,
	Telefone					VARCHAR(20)		NOT NULL,
	LinkedIn					VARCHAR(100)		NOT NULL,
	Cidade						VARCHAR(100)		NOT NULL,
	Estado						VARCHAR(2)		NOT NULL,
	Portfolio					VARCHAR(100)	NULL,
	Pretensao					NUMERIC(7,2)	NOT NULL,
    HorasAteQuatro					BIT	NOT NULL,
    HorasQuatroASeis					BIT	NOT NULL,
    HorasSeisAOito					BIT	NOT NULL,
    HorasAcimaDeOito					BIT	NOT NULL,
    HorasFimDeSemana					BIT	NOT NULL,
    PeriodoManha					BIT	NOT NULL,
    PeriodoTarde					BIT	NOT NULL,
    PeriodoNoite					BIT	NOT NULL,
    PeriodoMadrugada					BIT	NOT NULL,
    PeriodoComercial					BIT	NOT NULL,
	InformacaoBancaria			VARCHAR(100)	NULL,
	LinkCrud					VARCHAR(150)	NULL,
    PRIMARY KEY (ID)
)	
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'Conhecimento'))
BEGIN
	DROP TABLE Conhecimento
END 
GO

CREATE TABLE Conhecimento
(
	ID							UNIQUEIDENTIFIER NOT NULL,
	Titulo						VARCHAR(100) NOT NULL,
	Status						        INTEGER		NOT NULL,
    PRIMARY KEY (ID)
)	
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'TalentoConhecimento'))
BEGIN
	DROP TABLE TalentoConhecimento
END 
GO

CREATE TABLE TalentoConhecimento
(
	TalentoID							UNIQUEIDENTIFIER NOT NULL,
	ConhecimentoID						UNIQUEIDENTIFIER NOT NULL,
	Nivel						        NUMERIC(1)		NOT NULL,
    PRIMARY KEY (TalentoID, ConhecimentoID),
    Foreign key (TalentoID) references Talento(ID), 
    Foreign key (ConhecimentoID) references Conhecimento(ID)
)	
GO

IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'TalentoBanco'))
BEGIN
	DROP TABLE TalentoBanco
END 
GO

CREATE TABLE TalentoBanco
(
    ID							UNIQUEIDENTIFIER DEFAULT(NEWID()) NOT NULL,
	TalentoID							UNIQUEIDENTIFIER NOT NULL,
	Banco						VARCHAR(100) NOT NULL,
	BancoBeneficiario						VARCHAR(100) NOT NULL,
	BancoCpf						VARCHAR(100) NOT NULL,
	BancoNome						VARCHAR(100) NOT NULL,
	BancoAgencia						        NUMERIC(12)		NOT NULL,
	BancoConta						        NUMERIC(12)		NOT NULL,
    BancoContaCorrente						        BIT		NOT NULL,
    BancoContaPoupanca						        BIT		NOT NULL,
    PRIMARY KEY (ID), 
    Foreign key (TalentoID) references Talento(ID)
)	
GO

