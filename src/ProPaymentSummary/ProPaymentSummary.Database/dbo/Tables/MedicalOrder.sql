CREATE TABLE [dbo].[MedicalOrder] (
    [MedicalOrderId]                INT             IDENTITY (1, 1) NOT NULL,
    [HealthInsuranceProviderPlanId] INT             NOT NULL,
    [Number]                        VARCHAR (50)    NOT NULL,
    [NBU]                           DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_MedicalOrder] PRIMARY KEY CLUSTERED ([MedicalOrderId] ASC),
    CONSTRAINT [FK_MedicalOrder_HealthInsuranceProviderPlan] FOREIGN KEY ([HealthInsuranceProviderPlanId]) REFERENCES [dbo].[HealthInsuranceProviderPlan] ([HealthInsuranceProviderPlanId])
);

