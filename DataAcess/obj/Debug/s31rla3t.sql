IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Categorias] (
    [CategoriaId] int NOT NULL IDENTITY,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_Categorias] PRIMARY KEY ([CategoriaId])
);

GO

CREATE TABLE [Estoques] (
    [EstoqueId] int NOT NULL IDENTITY,
    [Quantidade] int NOT NULL,
    [ProdutoId] int NOT NULL,
    CONSTRAINT [PK_Estoques] PRIMARY KEY ([EstoqueId])
);

GO

CREATE TABLE [Fornecedores] (
    [FornecedorId] int NOT NULL IDENTITY,
    [Empresa] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Fornecedores] PRIMARY KEY ([FornecedorId])
);

GO

CREATE TABLE [Produtos] (
    [ProdutoId] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NOT NULL,
    [Descricao] nvarchar(max) NULL,
    [CategoriaId] int NOT NULL,
    [FornecedorId] int NOT NULL,
    [Preco] decimal(18,2) NOT NULL,
    [EstoqueId] int NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([ProdutoId]),
    CONSTRAINT [FK_Produtos_Categorias_CategoriaId] FOREIGN KEY ([CategoriaId]) REFERENCES [Categorias] ([CategoriaId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Produtos_Estoques_EstoqueId] FOREIGN KEY ([EstoqueId]) REFERENCES [Estoques] ([EstoqueId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Produtos_Fornecedores_FornecedorId] FOREIGN KEY ([FornecedorId]) REFERENCES [Fornecedores] ([FornecedorId]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Produtos_CategoriaId] ON [Produtos] ([CategoriaId]);

GO

CREATE INDEX [IX_Produtos_EstoqueId] ON [Produtos] ([EstoqueId]);

GO

CREATE INDEX [IX_Produtos_FornecedorId] ON [Produtos] ([FornecedorId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201231171700_Initi', N'3.1.10');

GO

ALTER TABLE [Produtos] DROP CONSTRAINT [FK_Produtos_Estoques_EstoqueId];

GO

DROP INDEX [IX_Produtos_EstoqueId] ON [Produtos];
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Produtos]') AND [c].[name] = N'EstoqueId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Produtos] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Produtos] ALTER COLUMN [EstoqueId] int NOT NULL;
CREATE INDEX [IX_Produtos_EstoqueId] ON [Produtos] ([EstoqueId]);

GO

ALTER TABLE [Produtos] ADD CONSTRAINT [FK_Produtos_Estoques_EstoqueId] FOREIGN KEY ([EstoqueId]) REFERENCES [Estoques] ([EstoqueId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20201231172459_Initial', N'3.1.10');

GO

