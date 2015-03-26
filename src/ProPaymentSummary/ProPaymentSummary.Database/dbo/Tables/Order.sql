CREATE TABLE [dbo].[Order] (
    [OrderId]                   INT           IDENTITY (1, 1) NOT NULL,
    [HealthInsuranceProviderId] INT           NOT NULL,
    [OrderNumber]               INT           NOT NULL,
    [PatientName]               VARCHAR (250) NOT NULL,
    [AttentionDate]             DATE          NOT NULL,
    [PatientDNI]                INT           NULL,
    [PatientBirthDate]          DATE          NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([OrderId] ASC),
    CONSTRAINT [FK_Order_HealthInsuranceProvider] FOREIGN KEY ([HealthInsuranceProviderId]) REFERENCES [dbo].[HealthInsuranceProvider] ([HealthInsuranceProviderId])
);

