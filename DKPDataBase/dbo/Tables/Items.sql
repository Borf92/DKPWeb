CREATE TABLE [dbo].[Items] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX)  NULL,
    [Cost]     DECIMAL (18, 2) NOT NULL,
    [Order_Id] INT             NULL,
    CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Items_dbo.Orders_Order_Id] FOREIGN KEY ([Order_Id]) REFERENCES [dbo].[Orders] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Order_Id]
    ON [dbo].[Items]([Order_Id] ASC);

