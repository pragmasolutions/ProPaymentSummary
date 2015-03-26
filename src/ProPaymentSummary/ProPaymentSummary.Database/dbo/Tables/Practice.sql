CREATE TABLE [dbo].[Practice] (
    [PracticeId]  INT             IDENTITY (1, 1) NOT NULL,
    [Code]        INT             NOT NULL,
    [Description] VARCHAR (250)   NOT NULL,
    [Nomenclator] VARCHAR (50)    NOT NULL,
    [UB]          DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_PracticeId] PRIMARY KEY CLUSTERED ([PracticeId] ASC)
);

