CREATE TABLE [dbo].[Orders] (
    [Id]           INT                IDENTITY (1, 1) NOT NULL,
    [CreationDate] DATETIMEOFFSET (7) NOT NULL,
    [Gamer_Id]     INT                NULL,
    CONSTRAINT [PK_dbo.Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Orders_dbo.Gamers_Gamer_Id] FOREIGN KEY ([Gamer_Id]) REFERENCES [dbo].[Gamers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Gamer_Id]
    ON [dbo].[Orders]([Gamer_Id] ASC);

