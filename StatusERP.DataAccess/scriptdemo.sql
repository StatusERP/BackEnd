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

CREATE TABLE [Conjuntos] (
    [Id] int NOT NULL IDENTITY,
    [Conjunto] nvarchar(10) NOT NULL,
    [Nombre] nvarchar(150) NOT NULL,
    [Direccion] nvarchar(max) NOT NULL,
    [Telefono] nvarchar(30) NOT NULL,
    [Logo] nvarchar(250) NOT NULL,
    [DobleMoneda] bit NOT NULL,
    [DobleContabilidad] bit NOT NULL,
    [UsaLotes] bit NOT NULL,
    [UsaCentroCosto] bit NOT NULL,
    [UsuarioUltMod] nvarchar(max) NOT NULL,
    [FechaUltMod] datetime2 NOT NULL,
    [Notas] nvarchar(max) NOT NULL,
    [VersionBD] nvarchar(8) NOT NULL,
    [UsuarioModBd] nvarchar(max) NOT NULL,
    [FechaHoraModBd] datetime2 NOT NULL,
    [VersionInstalad] nvarchar(8) NOT NULL,
    [NIT] nvarchar(20) NOT NULL,
    [PAIS] nvarchar(20) NOT NULL,
    [UsaSucursales] bit NOT NULL,
    [MascaraSucursal] nvarchar(10) NOT NULL,
    [DireccionWeb] nvarchar(150) NOT NULL,
    [CorreoDocEletronico] nvarchar(250) NOT NULL,
    [NumeroRegistro] nvarchar(25) NOT NULL,
    [ActividadComercial] nvarchar(max) NOT NULL,
    [AgentePerseccion] bit NOT NULL,
    [CalPerscVentas] bit NOT NULL,
    [AgenteRetencionn] bit NOT NULL,
    [IsDeleted] bit NOT NULL,
    [Createby] nvarchar(250) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [Updateby] nvarchar(250) NOT NULL,
    [UpdateDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Conjuntos] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220215170636_InitialMigration', N'6.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Vendedores] (
    [Id] int NOT NULL IDENTITY,
    [Vendedor] nvarchar(4) NOT NULL,
    [Nombre] nvarchar(40) NOT NULL,
    [Email] nvarchar(250) NOT NULL,
    [Activo] bit NOT NULL,
    [ConjuntoId] int NOT NULL,
    [IsDeleted] bit NOT NULL,
    [Createby] nvarchar(36) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [Updateby] nvarchar(36) NOT NULL,
    [UpdateDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Vendedores] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Vendedores_Conjuntos_ConjuntoId] FOREIGN KEY ([ConjuntoId]) REFERENCES [Conjuntos] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Vendedores_ConjuntoId] ON [Vendedores] ([ConjuntoId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220215235636_MigrationVendedor', N'6.0.2');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

EXEC sp_rename N'[Vendedores].[Updateby]', N'Updatedby', N'COLUMN';
GO

EXEC sp_rename N'[Vendedores].[Createby]', N'Createdby', N'COLUMN';
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vendedores]') AND [c].[name] = N'Email');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Vendedores] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Vendedores] ALTER COLUMN [Email] nvarchar(250) NULL;
GO

CREATE TABLE [Sucursal] (
    [Id] int NOT NULL IDENTITY,
    [CodSucursal] nvarchar(4) NOT NULL,
    [Descripcion] nvarchar(150) NOT NULL,
    [Activa] bit NOT NULL,
    [IsDeleted] bit NOT NULL,
    [Createdby] nvarchar(36) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [Updatedby] nvarchar(36) NOT NULL,
    [UpdateDate] datetime2 NOT NULL,
    [ConjuntoId] int NOT NULL,
    CONSTRAINT [PK_Sucursal] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Sucursal_Conjuntos_ConjuntoId] FOREIGN KEY ([ConjuntoId]) REFERENCES [Conjuntos] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Bodega] (
    [Id] int NOT NULL IDENTITY,
    [CodBodega] nvarchar(4) NOT NULL,
    [Nombre] nvarchar(40) NOT NULL,
    [Tipo] nvarchar(1) NOT NULL,
    [Activa] bit NOT NULL,
    [Telefono] nvarchar(15) NOT NULL,
    [Direccion] nvarchar(250) NULL,
    [SucursalId] int NULL,
    [IsDeleted] bit NOT NULL,
    [Createdby] nvarchar(36) NOT NULL,
    [CreateDate] datetime2 NOT NULL,
    [Updatedby] nvarchar(36) NOT NULL,
    [UpdateDate] datetime2 NOT NULL,
    [ConjuntoId] int NOT NULL,
    CONSTRAINT [PK_Bodega] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Bodega_Conjuntos_ConjuntoId] FOREIGN KEY ([ConjuntoId]) REFERENCES [Conjuntos] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Bodega_Sucursal_SucursalId] FOREIGN KEY ([SucursalId]) REFERENCES [Sucursal] ([Id])
);
GO

CREATE INDEX [IX_Bodega_ConjuntoId] ON [Bodega] ([ConjuntoId]);
GO

CREATE INDEX [IX_Bodega_SucursalId] ON [Bodega] ([SucursalId]);
GO

CREATE INDEX [IX_Sucursal_ConjuntoId] ON [Sucursal] ([ConjuntoId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220217144824_MigrationBodega', N'6.0.2');
GO

COMMIT;
GO

