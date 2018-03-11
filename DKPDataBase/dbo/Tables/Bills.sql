CREATE TABLE [dbo].[Bills] (
    [Id]           INT                IDENTITY (1, 1) NOT NULL,
    [Number]       NVARCHAR (MAX)     NULL,
    [CreationDate] DATETIMEOFFSET (7) NOT NULL,
    [Balance]      DECIMAL (18, 2)    NOT NULL,
    [Gamer_Id]     INT                NULL,
    CONSTRAINT [PK_dbo.Bills] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Bills_dbo.Gamers_Gamer_Id] FOREIGN KEY ([Gamer_Id]) REFERENCES [dbo].[Gamers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Gamer_Id]
    ON [dbo].[Bills]([Gamer_Id] ASC);

