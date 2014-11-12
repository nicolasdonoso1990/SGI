
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/09/2014 18:02:22
-- Generated from EDMX file: C:\SGI\Entidades\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Inmobiliaria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Alquileres_Inquilinos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alquileres] DROP CONSTRAINT [FK_Alquileres_Inquilinos];
GO
IF OBJECT_ID(N'[dbo].[FK_Cuenta_corriente_Inquilinos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cuenta_corriente] DROP CONSTRAINT [FK_Cuenta_corriente_Inquilinos];
GO
IF OBJECT_ID(N'[dbo].[FK_Mejoras_Contratistas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mejoras] DROP CONSTRAINT [FK_Mejoras_Contratistas];
GO
IF OBJECT_ID(N'[dbo].[FK_Pagos_alquiler_Alquileres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagos_alquiler] DROP CONSTRAINT [FK_Pagos_alquiler_Alquileres];
GO
IF OBJECT_ID(N'[dbo].[FK_Pagos_seguro_Seguros]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagos_seguro] DROP CONSTRAINT [FK_Pagos_seguro_Seguros];
GO
IF OBJECT_ID(N'[dbo].[FK_Reparaciones_Contratistas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reparaciones] DROP CONSTRAINT [FK_Reparaciones_Contratistas];
GO
IF OBJECT_ID(N'[dbo].[FK_Seguros_Alquileres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Seguros] DROP CONSTRAINT [FK_Seguros_Alquileres];
GO
IF OBJECT_ID(N'[dbo].[FK_Unidades_Propiedades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Unidades] DROP CONSTRAINT [FK_Unidades_Propiedades];
GO
IF OBJECT_ID(N'[dbo].[FK_Valores_mensuales_Contratos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Valores_mensuales] DROP CONSTRAINT [FK_Valores_mensuales_Contratos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Administradores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Administradores];
GO
IF OBJECT_ID(N'[dbo].[Alquileres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alquileres];
GO
IF OBJECT_ID(N'[dbo].[Contratistas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contratistas];
GO
IF OBJECT_ID(N'[dbo].[Contratos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contratos];
GO
IF OBJECT_ID(N'[dbo].[Cuenta_corriente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cuenta_corriente];
GO
IF OBJECT_ID(N'[dbo].[Fotos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fotos];
GO
IF OBJECT_ID(N'[dbo].[Inquilinos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inquilinos];
GO
IF OBJECT_ID(N'[dbo].[Mejoras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mejoras];
GO
IF OBJECT_ID(N'[dbo].[NumeroUltimaFoto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NumeroUltimaFoto];
GO
IF OBJECT_ID(N'[dbo].[Pagos_alquiler]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagos_alquiler];
GO
IF OBJECT_ID(N'[dbo].[Pagos_seguro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagos_seguro];
GO
IF OBJECT_ID(N'[dbo].[Propiedades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Propiedades];
GO
IF OBJECT_ID(N'[dbo].[Reparaciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reparaciones];
GO
IF OBJECT_ID(N'[dbo].[Seguros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Seguros];
GO
IF OBJECT_ID(N'[dbo].[Unidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Unidades];
GO
IF OBJECT_ID(N'[dbo].[Valores_mensuales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Valores_mensuales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Administradores'
CREATE TABLE [dbo].[Administradores] (
    [IDadmin] int IDENTITY(1,1) NOT NULL,
    [usuario] varchar(50)  NULL,
    [contrasena] varchar(50)  NULL,
    [estado] varchar(50)  NULL,
    [tipo] varchar(50)  NULL
);
GO

-- Creating table 'Alquileres'
CREATE TABLE [dbo].[Alquileres] (
    [nro_alquiler] int IDENTITY(1,1) NOT NULL,
    [cod_unidad] int  NOT NULL,
    [nro_inquilino] int IDENTITY(1,1) NOT NULL,
    [estado] varchar(50)  NOT NULL
);
GO

-- Creating table 'Contratistas'
CREATE TABLE [dbo].[Contratistas] (
    [cod_contratista] int  NOT NULL,
    [nombre] varchar(50)  NULL,
    [apellido] varchar(50)  NULL,
    [direccion] varchar(50)  NULL,
    [telefono] varchar(50)  NULL,
    [disponibilidad] varchar(50)  NULL
);
GO

-- Creating table 'Contratos'
CREATE TABLE [dbo].[Contratos] (
    [cod_contrato] int IDENTITY(1,1) NOT NULL,
    [nro_alquiler] int  NOT NULL,
    [cod_unidad] int  NOT NULL,
    [nro_inquilino] int  NOT NULL,
    [fecha_realizacion] datetime  NULL,
    [fecha_caducidad] datetime  NULL,
    [descripcion_unidad] varchar(max)  NULL,
    [anexo] varchar(max)  NULL
);
GO

-- Creating table 'Fotos'
CREATE TABLE [dbo].[Fotos] (
    [cod_unidad] int  NOT NULL,
    [ruta_foto] varchar(max)  NOT NULL,
    [cod_foto] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Inquilinos'
CREATE TABLE [dbo].[Inquilinos] (
    [nro_inquilino] int IDENTITY(1,1) NOT NULL,
    [usuario] varchar(50)  NULL,
    [contrasena] varchar(50)  NULL,
    [nombre] varchar(50)  NULL,
    [apellido] varchar(50)  NULL,
    [direccion] varchar(50)  NULL,
    [telefono] varchar(50)  NULL,
    [dni] varchar(50)  NULL,
    [estado] varchar(50)  NULL,
    [e_mail] varchar(50)  NULL
);
GO

-- Creating table 'Mejoras'
CREATE TABLE [dbo].[Mejoras] (
    [cod_contratista] int  NOT NULL,
    [nro_mejora] int  NOT NULL,
    [fecha] datetime  NULL,
    [valor] int  NULL,
    [cod_unidad] int  NOT NULL,
    [observaciones] varchar(max)  NULL,
    [detalles] varchar(max)  NULL
);
GO

-- Creating table 'Pagos_alquiler'
CREATE TABLE [dbo].[Pagos_alquiler] (
    [nro_alquiler] int  NOT NULL,
    [cod_unidad] int  NOT NULL,
    [nro_inquilino] int  NOT NULL,
    [fecha] datetime  NULL,
    [monto] int  NULL,
    [id_pago] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Pagos_seguro'
CREATE TABLE [dbo].[Pagos_seguro] (
    [cod_seguro] int  NOT NULL,
    [fecha] datetime  NULL,
    [monto] int  NULL
);
GO

-- Creating table 'Propiedades'
CREATE TABLE [dbo].[Propiedades] (
    [cod_propiedad] int IDENTITY(1,1) NOT NULL,
    [ciudad] varchar(50)  NULL,
    [direccion] varchar(50)  NULL,
    [m2] float  NULL,
    [descripcion] varchar(max)  NULL,
    [estado] varchar(50)  NULL
);
GO

-- Creating table 'Reparaciones'
CREATE TABLE [dbo].[Reparaciones] (
    [nro_reparacion] int  NOT NULL,
    [cod_contratista] int  NOT NULL,
    [cod_unidad] int  NOT NULL,
    [fecha] datetime  NULL,
    [valor] int  NULL,
    [detalles] varchar(max)  NULL,
    [observaciones] varchar(max)  NULL
);
GO

-- Creating table 'Seguros'
CREATE TABLE [dbo].[Seguros] (
    [cod_seguro] int  NOT NULL,
    [nro_alquiler] int  NOT NULL,
    [cod_unidad] int  NOT NULL,
    [nro_inquilino] int  NOT NULL,
    [fecha_desde] datetime  NULL,
    [fecha_hasta] datetime  NULL,
    [aseguradora] varchar(max)  NULL,
    [tipo_seguro] varchar(max)  NULL,
    [descripcion] varchar(max)  NULL
);
GO

-- Creating table 'Unidades'
CREATE TABLE [dbo].[Unidades] (
    [cod_unidad] int IDENTITY(1,1) NOT NULL,
    [cod_propiedad] int  NOT NULL,
    [m2] float  NULL,
    [descripcion] varchar(max)  NULL,
    [estado] varchar(50)  NULL
);
GO

-- Creating table 'Valores_mensuales'
CREATE TABLE [dbo].[Valores_mensuales] (
    [cod_contrato] int  NOT NULL,
    [valor] float  NULL,
    [fechaDesde] datetime  NULL,
    [fechaHasta] datetime  NULL,
    [cod_ValorMensual] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'NumeroUltimaFoto'
CREATE TABLE [dbo].[NumeroUltimaFoto] (
    [NumeroFoto] int  NOT NULL,
    [numero] int  NOT NULL
);
GO

-- Creating table 'Cuentas_corrientes'
CREATE TABLE [dbo].[Cuentas_corrientes] (
    [nro_inquilino] int  NOT NULL,
    [fecha] datetime  NULL,
    [saldo] float  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDadmin] in table 'Administradores'
ALTER TABLE [dbo].[Administradores]
ADD CONSTRAINT [PK_Administradores]
    PRIMARY KEY CLUSTERED ([IDadmin] ASC);
GO

-- Creating primary key on [nro_alquiler], [cod_unidad], [nro_inquilino] in table 'Alquileres'
ALTER TABLE [dbo].[Alquileres]
ADD CONSTRAINT [PK_Alquileres]
    PRIMARY KEY CLUSTERED ([nro_alquiler], [cod_unidad], [nro_inquilino] ASC);
GO

-- Creating primary key on [cod_contratista] in table 'Contratistas'
ALTER TABLE [dbo].[Contratistas]
ADD CONSTRAINT [PK_Contratistas]
    PRIMARY KEY CLUSTERED ([cod_contratista] ASC);
GO

-- Creating primary key on [cod_contrato] in table 'Contratos'
ALTER TABLE [dbo].[Contratos]
ADD CONSTRAINT [PK_Contratos]
    PRIMARY KEY CLUSTERED ([cod_contrato] ASC);
GO

-- Creating primary key on [cod_foto] in table 'Fotos'
ALTER TABLE [dbo].[Fotos]
ADD CONSTRAINT [PK_Fotos]
    PRIMARY KEY CLUSTERED ([cod_foto] ASC);
GO

-- Creating primary key on [nro_inquilino] in table 'Inquilinos'
ALTER TABLE [dbo].[Inquilinos]
ADD CONSTRAINT [PK_Inquilinos]
    PRIMARY KEY CLUSTERED ([nro_inquilino] ASC);
GO

-- Creating primary key on [nro_mejora] in table 'Mejoras'
ALTER TABLE [dbo].[Mejoras]
ADD CONSTRAINT [PK_Mejoras]
    PRIMARY KEY CLUSTERED ([nro_mejora] ASC);
GO

-- Creating primary key on [id_pago] in table 'Pagos_alquiler'
ALTER TABLE [dbo].[Pagos_alquiler]
ADD CONSTRAINT [PK_Pagos_alquiler]
    PRIMARY KEY CLUSTERED ([id_pago] ASC);
GO

-- Creating primary key on [cod_seguro] in table 'Pagos_seguro'
ALTER TABLE [dbo].[Pagos_seguro]
ADD CONSTRAINT [PK_Pagos_seguro]
    PRIMARY KEY CLUSTERED ([cod_seguro] ASC);
GO

-- Creating primary key on [cod_propiedad] in table 'Propiedades'
ALTER TABLE [dbo].[Propiedades]
ADD CONSTRAINT [PK_Propiedades]
    PRIMARY KEY CLUSTERED ([cod_propiedad] ASC);
GO

-- Creating primary key on [nro_reparacion] in table 'Reparaciones'
ALTER TABLE [dbo].[Reparaciones]
ADD CONSTRAINT [PK_Reparaciones]
    PRIMARY KEY CLUSTERED ([nro_reparacion] ASC);
GO

-- Creating primary key on [cod_seguro] in table 'Seguros'
ALTER TABLE [dbo].[Seguros]
ADD CONSTRAINT [PK_Seguros]
    PRIMARY KEY CLUSTERED ([cod_seguro] ASC);
GO

-- Creating primary key on [cod_unidad] in table 'Unidades'
ALTER TABLE [dbo].[Unidades]
ADD CONSTRAINT [PK_Unidades]
    PRIMARY KEY CLUSTERED ([cod_unidad] ASC);
GO

-- Creating primary key on [cod_ValorMensual] in table 'Valores_mensuales'
ALTER TABLE [dbo].[Valores_mensuales]
ADD CONSTRAINT [PK_Valores_mensuales]
    PRIMARY KEY CLUSTERED ([cod_ValorMensual] ASC);
GO

-- Creating primary key on [NumeroFoto] in table 'NumeroUltimaFoto'
ALTER TABLE [dbo].[NumeroUltimaFoto]
ADD CONSTRAINT [PK_NumeroUltimaFoto]
    PRIMARY KEY CLUSTERED ([NumeroFoto] ASC);
GO

-- Creating primary key on [nro_inquilino] in table 'Cuentas_corrientes'
ALTER TABLE [dbo].[Cuentas_corrientes]
ADD CONSTRAINT [PK_Cuentas_corrientes]
    PRIMARY KEY CLUSTERED ([nro_inquilino] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [nro_inquilino] in table 'Alquileres'
ALTER TABLE [dbo].[Alquileres]
ADD CONSTRAINT [FK_Alquileres_Inquilinos]
    FOREIGN KEY ([nro_inquilino])
    REFERENCES [dbo].[Inquilinos]
        ([nro_inquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquileres_Inquilinos'
CREATE INDEX [IX_FK_Alquileres_Inquilinos]
ON [dbo].[Alquileres]
    ([nro_inquilino]);
GO

-- Creating foreign key on [cod_unidad] in table 'Alquileres'
ALTER TABLE [dbo].[Alquileres]
ADD CONSTRAINT [FK_Alquileres_Unidades]
    FOREIGN KEY ([cod_unidad])
    REFERENCES [dbo].[Unidades]
        ([cod_unidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Alquileres_Unidades'
CREATE INDEX [IX_FK_Alquileres_Unidades]
ON [dbo].[Alquileres]
    ([cod_unidad]);
GO

-- Creating foreign key on [nro_alquiler], [cod_unidad], [nro_inquilino] in table 'Contratos'
ALTER TABLE [dbo].[Contratos]
ADD CONSTRAINT [FK_Contratos_Alquileres]
    FOREIGN KEY ([nro_alquiler], [cod_unidad], [nro_inquilino])
    REFERENCES [dbo].[Alquileres]
        ([nro_alquiler], [cod_unidad], [nro_inquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Contratos_Alquileres'
CREATE INDEX [IX_FK_Contratos_Alquileres]
ON [dbo].[Contratos]
    ([nro_alquiler], [cod_unidad], [nro_inquilino]);
GO

-- Creating foreign key on [nro_alquiler], [cod_unidad], [nro_inquilino] in table 'Pagos_alquiler'
ALTER TABLE [dbo].[Pagos_alquiler]
ADD CONSTRAINT [FK_Pagos_alquiler_Alquileres]
    FOREIGN KEY ([nro_alquiler], [cod_unidad], [nro_inquilino])
    REFERENCES [dbo].[Alquileres]
        ([nro_alquiler], [cod_unidad], [nro_inquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Pagos_alquiler_Alquileres'
CREATE INDEX [IX_FK_Pagos_alquiler_Alquileres]
ON [dbo].[Pagos_alquiler]
    ([nro_alquiler], [cod_unidad], [nro_inquilino]);
GO

-- Creating foreign key on [nro_alquiler], [cod_unidad], [nro_inquilino] in table 'Seguros'
ALTER TABLE [dbo].[Seguros]
ADD CONSTRAINT [FK_Seguros_Alquileres]
    FOREIGN KEY ([nro_alquiler], [cod_unidad], [nro_inquilino])
    REFERENCES [dbo].[Alquileres]
        ([nro_alquiler], [cod_unidad], [nro_inquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Seguros_Alquileres'
CREATE INDEX [IX_FK_Seguros_Alquileres]
ON [dbo].[Seguros]
    ([nro_alquiler], [cod_unidad], [nro_inquilino]);
GO

-- Creating foreign key on [cod_contratista] in table 'Mejoras'
ALTER TABLE [dbo].[Mejoras]
ADD CONSTRAINT [FK_Mejoras_Contratistas]
    FOREIGN KEY ([cod_contratista])
    REFERENCES [dbo].[Contratistas]
        ([cod_contratista])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Mejoras_Contratistas'
CREATE INDEX [IX_FK_Mejoras_Contratistas]
ON [dbo].[Mejoras]
    ([cod_contratista]);
GO

-- Creating foreign key on [cod_contratista] in table 'Reparaciones'
ALTER TABLE [dbo].[Reparaciones]
ADD CONSTRAINT [FK_Reparaciones_Contratistas]
    FOREIGN KEY ([cod_contratista])
    REFERENCES [dbo].[Contratistas]
        ([cod_contratista])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Reparaciones_Contratistas'
CREATE INDEX [IX_FK_Reparaciones_Contratistas]
ON [dbo].[Reparaciones]
    ([cod_contratista]);
GO

-- Creating foreign key on [cod_contrato] in table 'Valores_mensuales'
ALTER TABLE [dbo].[Valores_mensuales]
ADD CONSTRAINT [FK_Valores_mensuales_Contratos]
    FOREIGN KEY ([cod_contrato])
    REFERENCES [dbo].[Contratos]
        ([cod_contrato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Valores_mensuales_Contratos'
CREATE INDEX [IX_FK_Valores_mensuales_Contratos]
ON [dbo].[Valores_mensuales]
    ([cod_contrato]);
GO

-- Creating foreign key on [cod_unidad] in table 'Fotos'
ALTER TABLE [dbo].[Fotos]
ADD CONSTRAINT [FK_Fotos_Unidades]
    FOREIGN KEY ([cod_unidad])
    REFERENCES [dbo].[Unidades]
        ([cod_unidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Fotos_Unidades'
CREATE INDEX [IX_FK_Fotos_Unidades]
ON [dbo].[Fotos]
    ([cod_unidad]);
GO

-- Creating foreign key on [cod_unidad] in table 'Mejoras'
ALTER TABLE [dbo].[Mejoras]
ADD CONSTRAINT [FK_Mejoras_Unidades]
    FOREIGN KEY ([cod_unidad])
    REFERENCES [dbo].[Unidades]
        ([cod_unidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Mejoras_Unidades'
CREATE INDEX [IX_FK_Mejoras_Unidades]
ON [dbo].[Mejoras]
    ([cod_unidad]);
GO

-- Creating foreign key on [cod_seguro] in table 'Pagos_seguro'
ALTER TABLE [dbo].[Pagos_seguro]
ADD CONSTRAINT [FK_Pagos_seguro_Seguros]
    FOREIGN KEY ([cod_seguro])
    REFERENCES [dbo].[Seguros]
        ([cod_seguro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [cod_propiedad] in table 'Unidades'
ALTER TABLE [dbo].[Unidades]
ADD CONSTRAINT [FK_Unidades_Propiedades]
    FOREIGN KEY ([cod_propiedad])
    REFERENCES [dbo].[Propiedades]
        ([cod_propiedad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Unidades_Propiedades'
CREATE INDEX [IX_FK_Unidades_Propiedades]
ON [dbo].[Unidades]
    ([cod_propiedad]);
GO

-- Creating foreign key on [cod_unidad] in table 'Reparaciones'
ALTER TABLE [dbo].[Reparaciones]
ADD CONSTRAINT [FK_Reparaciones_Unidades]
    FOREIGN KEY ([cod_unidad])
    REFERENCES [dbo].[Unidades]
        ([cod_unidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Reparaciones_Unidades'
CREATE INDEX [IX_FK_Reparaciones_Unidades]
ON [dbo].[Reparaciones]
    ([cod_unidad]);
GO

-- Creating foreign key on [nro_inquilino] in table 'Cuentas_corrientes'
ALTER TABLE [dbo].[Cuentas_corrientes]
ADD CONSTRAINT [FK_Cuenta_corriente_Inquilinos1]
    FOREIGN KEY ([nro_inquilino])
    REFERENCES [dbo].[Inquilinos]
        ([nro_inquilino])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------