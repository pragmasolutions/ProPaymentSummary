CREATE TABLE [dbo].[Appointment] (
    [AppointmentId]                   INT           IDENTITY (1, 1) NOT NULL,
    [HealthInsuranceProviderId] INT           NOT NULL,
    [OrderNumber]               INT           NOT NULL,
    [PatientName]               VARCHAR (250) NOT NULL,
    [AttentionDate]             DATE          NOT NULL,
    [PatientId] INT NULL, 
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([AppointmentId] ASC),
    CONSTRAINT [FK_Appointment_HealthInsuranceProvider] FOREIGN KEY ([HealthInsuranceProviderId]) REFERENCES [dbo].[HealthInsuranceProvider] ([HealthInsuranceProviderId]),
	CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patient] ([PatientId])
);

