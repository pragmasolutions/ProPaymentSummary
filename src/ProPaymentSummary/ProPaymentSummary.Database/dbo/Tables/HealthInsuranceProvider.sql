CREATE TABLE [dbo].[HealthInsuranceProvider] (
    [HealthInsuranceProviderId] INT             IDENTITY (1, 1) NOT NULL,
    [Name]                      VARCHAR (250)   NOT NULL,
    [Address]                   VARCHAR (250)   NULL,
    [NBU]                       DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_HealthInsuranceProvider] PRIMARY KEY CLUSTERED ([HealthInsuranceProviderId] ASC)
);

