CREATE TABLE [dbo].[Appointment] (
    [AppointmentId]  INT           IDENTITY (1, 1) NOT NULL,
    [PatientId]      INT           NOT NULL,
    [MedicalOrderId] INT           NOT NULL,
    [Plus]           MONEY         NULL,
    [StartDate]      DATETIME2 (7) NOT NULL,
    [EndDate]        DATETIME2 (7) NULL,
    [State]          INT           NOT NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([AppointmentId] ASC),
    CONSTRAINT [FK_Appointment_MedicalOrder] FOREIGN KEY ([MedicalOrderId]) REFERENCES [dbo].[MedicalOrder] ([MedicalOrderId]),
    CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patient] ([PatientId])
);



