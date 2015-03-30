CREATE TABLE [dbo].[Professional] (
    [ProfessionalId] NVARCHAR (128) NOT NULL,
    [LastName]       VARCHAR (50)  NOT NULL,
    [FirstName]      VARCHAR (50)  NOT NULL,
    [Address]        VARCHAR (250) NOT NULL,
    [Phone]          VARCHAR (50)  NOT NULL,
    [CUIT]           VARCHAR (50)  NOT NULL,
    [DNI]            INT           NOT NULL,
    [MP]             VARCHAR (50)  NULL,
    [MN]             VARCHAR (50)  NULL,
    [ProvinceId]       INT  NULL,
    [City]			 VARCHAR(200)  NULL, 
    [ProfileImage] VARBINARY(MAX) NULL, 
    CONSTRAINT [PK_Professional] PRIMARY KEY CLUSTERED ([ProfessionalId] ASC), 
    CONSTRAINT [FK_Professional_Province] FOREIGN KEY ([ProvinceId]) REFERENCES [Province]([ProvinceId])
);

