IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    CREATE TABLE [Filmes] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(200) NOT NULL,
        [DataCriacao] datetime2 NOT NULL,
        [Ativo] int NOT NULL,
        [Genero] nvarchar(max) NULL,
        CONSTRAINT [PK_Filmes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    CREATE TABLE [Generos] (
        [Id] int NOT NULL IDENTITY,
        [Nome] nvarchar(100) NOT NULL,
        [DataCriacao] datetime2 NOT NULL,
        [Ativo] int NOT NULL,
        CONSTRAINT [PK_Generos] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    CREATE TABLE [Locacoes] (
        [Id] int NOT NULL IDENTITY,
        [ListaFilmes] nvarchar(max) NOT NULL,
        [CPFCliente] nvarchar(14) NOT NULL,
        [DataLocacao] datetime2 NOT NULL,
        CONSTRAINT [PK_Locacoes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ativo', N'DataCriacao', N'Genero', N'Nome') AND [object_id] = OBJECT_ID(N'[Filmes]'))
        SET IDENTITY_INSERT [Filmes] ON;
    EXEC(N'INSERT INTO [Filmes] ([Id], [Ativo], [DataCriacao], [Genero], [Nome])
    VALUES (1, 1, ''2021-05-30T18:25:31.0243118-03:00'', N''Terror'', N''Filme1''),
    (2, 1, ''2021-05-30T18:25:31.0255303-03:00'', N''Comedia'', N''Filme2''),
    (3, 0, ''2021-05-30T18:25:31.0255321-03:00'', N''Aventura'', N''Filme3''),
    (4, 0, ''2021-05-30T18:25:31.0255323-03:00'', N''Ficcao'', N''Filme4''),
    (5, 1, ''2021-05-30T18:25:31.0255325-03:00'', N''Romance'', N''Filme5'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ativo', N'DataCriacao', N'Genero', N'Nome') AND [object_id] = OBJECT_ID(N'[Filmes]'))
        SET IDENTITY_INSERT [Filmes] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ativo', N'DataCriacao', N'Nome') AND [object_id] = OBJECT_ID(N'[Generos]'))
        SET IDENTITY_INSERT [Generos] ON;
    EXEC(N'INSERT INTO [Generos] ([Id], [Ativo], [DataCriacao], [Nome])
    VALUES (1, 1, ''2021-05-30T18:25:31.0268794-03:00'', N''Terror''),
    (2, 1, ''2021-05-30T18:25:31.0269502-03:00'', N''Comedia''),
    (3, 0, ''2021-05-30T18:25:31.0269508-03:00'', N''Aventura''),
    (4, 0, ''2021-05-30T18:25:31.0269510-03:00'', N''Ficcao''),
    (5, 1, ''2021-05-30T18:25:31.0269512-03:00'', N''Romance'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Ativo', N'DataCriacao', N'Nome') AND [object_id] = OBJECT_ID(N'[Generos]'))
        SET IDENTITY_INSERT [Generos] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CPFCliente', N'DataLocacao', N'ListaFilmes') AND [object_id] = OBJECT_ID(N'[Locacoes]'))
        SET IDENTITY_INSERT [Locacoes] ON;
    EXEC(N'INSERT INTO [Locacoes] ([Id], [CPFCliente], [DataLocacao], [ListaFilmes])
    VALUES (1, N''69874521830'', ''2021-05-30T18:25:31.0271003-03:00'', N''Filme 1, Filme 2, Filme 3''),
    (2, N''12457865420'', ''2021-05-30T18:25:31.0271359-03:00'', N''Filme 1''),
    (3, N''98563258741'', ''2021-05-30T18:25:31.0271364-03:00'', N''Filme 2, Filme 3''),
    (4, N''98633365792'', ''2021-05-30T18:25:31.0271366-03:00'', N''Filme 3''),
    (5, N''11478569831'', ''2021-05-30T18:25:31.0271367-03:00'', N''Filme 5, Filme 6'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CPFCliente', N'DataLocacao', N'ListaFilmes') AND [object_id] = OBJECT_ID(N'[Locacoes]'))
        SET IDENTITY_INSERT [Locacoes] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210530212531_Inicial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210530212531_Inicial', N'5.0.6');
END;
GO

COMMIT;
GO

