CREATE TABLE [dbo].[HealthInsuranceProviderPlan] (
    [HealthInsuranceProviderPlanId] INT             IDENTITY (1, 1) NOT NULL,
    [HealthInsuranceProviderId]     INT             NOT NULL,
    [Name]                          VARBINARY (250) NOT NULL,
    CONSTRAINT [PK_HealthInsuranceProviderPlan] PRIMARY KEY CLUSTERED ([HealthInsuranceProviderPlanId] ASC),
    CONSTRAINT [FK_HealthInsuranceProviderPlan_HealthInsuranceProvider] FOREIGN KEY ([HealthInsuranceProviderId]) REFERENCES [dbo].[HealthInsuranceProvider] ([HealthInsuranceProviderId])
);

