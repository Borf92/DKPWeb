CREATE TABLE [dbo].[Gamers] (
    [Id]           INT                IDENTITY (1, 1) NOT NULL,
    [NickName]     NVARCHAR (MAX)     NULL,
    [CreationDate] DATETIMEOFFSET (7) NOT NULL,
    CONSTRAINT [PK_dbo.Gamers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

