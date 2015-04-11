CREATE TABLE [dbo].[PracticeAppointment] (
    [PracticeAppointmentId] INT IDENTITY (1, 1) NOT NULL,
    [PracticeId]      INT NOT NULL,
    [AppointmentId]         INT NOT NULL,
    CONSTRAINT [PK_PracticeAppointment] PRIMARY KEY CLUSTERED ([PracticeAppointmentId] ASC),
    CONSTRAINT [FK_PracticeAppointment_Appointment] FOREIGN KEY ([AppointmentId]) REFERENCES [dbo].[Appointment] ([AppointmentId]),
    CONSTRAINT [FK_PracticeAppointment_Practice] FOREIGN KEY ([PracticeId]) REFERENCES [dbo].[Practice] ([PracticeId])
);

