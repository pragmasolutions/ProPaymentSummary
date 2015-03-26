CREATE TABLE [dbo].[PracticeOrder] (
    [PracticeOrderId] INT IDENTITY (1, 1) NOT NULL,
    [PracticeId]      INT NOT NULL,
    [OrderId]         INT NOT NULL,
    CONSTRAINT [PK_PracticeOrder] PRIMARY KEY CLUSTERED ([PracticeOrderId] ASC),
    CONSTRAINT [FK_PracticeOrder_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([OrderId]),
    CONSTRAINT [FK_PracticeOrder_Practice] FOREIGN KEY ([PracticeId]) REFERENCES [dbo].[Practice] ([PracticeId])
);

