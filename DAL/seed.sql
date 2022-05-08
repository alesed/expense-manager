CREATE DATABASE ExpenseManagerDB;
GO

USE [ExpenseManagerDB]
GO

CREATE TABLE [dbo].Users(
	[Id][int] IDENTITY(1,1) NOT NULL,
	[Name][varchar](150),
	[Surname][varchar](150),
	CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].Payments(
	[Id][int] IDENTITY(1,1) NOT NULL,
	[IsIncome][bit],
	[Amount][float],
	[UserId][int],
	CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_PersonOrder] FOREIGN KEY ([UserId]) REFERENCES Users([Id])
)

GO

INSERT INTO [Users] VALUES ('Alfred', 'Johnson');
INSERT INTO [Users] VALUES ('John', 'Doe');
INSERT INTO [Users] VALUES ('Bo', 'Ris');

INSERT INTO [Payments] VALUES (1, 500, 1);
INSERT INTO [Payments] VALUES (1, 342, 1);
INSERT INTO [Payments] VALUES (0, 213, 1);
