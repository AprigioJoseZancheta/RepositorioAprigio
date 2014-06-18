CREATE TABLE [dbo].[LIVRO] (
    [Id]             INT          NOT NULL,
    [TITULO]         VARCHAR (50) NULL,
    [ANO_PUBLICACAO] DATE         NULL,
    [AUTOR_ID]       INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AUTOR_ID]) REFERENCES [dbo].[AUTOR] ([Id])
);

