CREATE TABLE [dbo].[Professional] (
    [ProfessionalId] INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       VARCHAR (50)  NOT NULL,
    [FirstName]      VARCHAR (50)  NOT NULL,
    [Address]        VARCHAR (250) NOT NULL,
    [Phone]          VARCHAR (50)  NOT NULL,
    [CUIT]           VARCHAR (50)  NOT NULL,
    [DNI]            INT           NOT NULL,
    [MP]             VARCHAR (50)  NULL,
    [MN]             VARCHAR (50)  NULL,
    [Province]       VARCHAR (50)  NULL,
    CONSTRAINT [PK_Professional] PRIMARY KEY CLUSTERED ([ProfessionalId] ASC)
);

