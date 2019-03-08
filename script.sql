IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Usuario] (
    [Id] bigint NOT NULL IDENTITY,
    [Nome] nvarchar(40) NOT NULL,
    [TypeUser] int NOT NULL,
    [Email] nvarchar(100) NOT NULL,
    [Senha] nvarchar(20) NOT NULL,
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Tarefa] (
    [Id] bigint NOT NULL IDENTITY,
    [Titulo] nvarchar(250) NULL,
    [UsuarioId] bigint NULL,
    [Completo] bit NOT NULL,
    [DateLog] datetime2 NOT NULL,
    CONSTRAINT [PK_Tarefa] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tarefa_Usuario_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuario] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Tarefa_UsuarioId] ON [Tarefa] ([UsuarioId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190307184142_Initial', N'2.2.2-servicing-10034');

GO

