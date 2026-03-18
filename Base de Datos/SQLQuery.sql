--Domingo 15/3/26
CREATE DATABASE A2BankibgDB;
GO

USE A2BankibgDB;
GO

-- ============================================================
--  TABLAS
-- ============================================================

-- Rol
CREATE TABLE Rol (
    RolId       INT           IDENTITY(1,1) PRIMARY KEY,
    Nombre      NVARCHAR(50)  NOT NULL,
    Descripcion NVARCHAR(200) NULL
);
GO

-- Usuario
CREATE TABLE Usuario (
    UsuarioId  INT           IDENTITY(1,1) PRIMARY KEY,
    RolId      INT           NOT NULL,
    Nombre     NVARCHAR(100) NOT NULL,
    Usuario    NVARCHAR(50)  NOT NULL UNIQUE,
    Contrasena NVARCHAR(255) NOT NULL,
    CONSTRAINT FK_Usuario_Rol FOREIGN KEY (RolId) REFERENCES Rol(RolId)
);
GO

-- Comision
CREATE TABLE Comision (
    ComisionId  INT            IDENTITY(1,1) PRIMARY KEY,
    Cantidad    DECIMAL(5,4)   NOT NULL,   -- e.g. 0.0015 = 0.15%
    Descripcion NVARCHAR(200)  NULL
);
GO

-- Banco
CREATE TABLE Banco (
    BancoId     INT           IDENTITY PRIMARY KEY,
    Nombre      NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(200) NULL,
    Ubicacion   NVARCHAR(200) NULL,
    ComisionId  INT           NULL,
    CONSTRAINT FK_Banco_Comision FOREIGN KEY (ComisionId) REFERENCES Comision(ComisionId)
);
GO

-- Estado
CREATE TABLE Estado (
    EstadoID    INT          IDENTITY(1,1) PRIMARY KEY,
    Nombre      NVARCHAR(50) NOT NULL,
    Descripcion NVARCHAR(200) NULL
);
GO

-- Titular
CREATE TABLE Titular (
    TitularId  INT            PRIMARY KEY,
    Nombre     NVARCHAR(100) NOT NULL,
    Edad       INT           NULL,
    Sexo       CHAR(1)       NULL,        -- 'M' / 'F'
    Ocupacion  NVARCHAR(100) NULL
);
GO

-- Cuenta
CREATE TABLE Cuenta (
    CuentaId      INT            IDENTITY(1,1) PRIMARY KEY,
    BancoId       INT            NOT NULL,
    NumeroCuenta  INT            NOT NULL UNIQUE,
    TitularId     INT            NOT NULL,
    Balance       DECIMAL(18,2)  NOT NULL DEFAULT 0,
    FechaCreacion DATE           NOT NULL DEFAULT GETDATE(),
    EstadoId      INT            NOT NULL,
    CodigoPin     NVARCHAR(10)   NULL,
    CodigoHuella  VARBINARY(MAX) NULL,    -- plantilla biométrica DigitalPersona 4500
    CONSTRAINT FK_Cuenta_Banco   FOREIGN KEY (BancoId)   REFERENCES Banco(BancoId),
    CONSTRAINT FK_Cuenta_Titular FOREIGN KEY (TitularId) REFERENCES Titular(TitularId),
    CONSTRAINT FK_Cuenta_Estado  FOREIGN KEY (EstadoId)  REFERENCES Estado(EstadoID)
);
GO

-- Deposito
CREATE TABLE Deposito (
    DepositoId INT           IDENTITY(1,1) PRIMARY KEY,
    CuentaId   INT           NOT NULL,
    Fecha      DATETIME      NOT NULL DEFAULT GETDATE(),
    Cantidad   DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Deposito_Cuenta FOREIGN KEY (CuentaId) REFERENCES Cuenta(CuentaId)
);
GO

-- Retiro
CREATE TABLE Retiro (
    RetiroId INT           IDENTITY(1,1) PRIMARY KEY,
    CuentaId INT           NOT NULL,
    Fecha    DATETIME      NOT NULL DEFAULT GETDATE(),
    Cantidad DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Retiro_Cuenta FOREIGN KEY (CuentaId) REFERENCES Cuenta(CuentaId)
);
GO

-- Transferencia
CREATE TABLE Transferencia (
    TransferenciaId  INT           IDENTITY(1,1) PRIMARY KEY,
    CuentaOrigenId   INT           NOT NULL,
    CuentaDestinoId  INT           NOT NULL,
    Monto            DECIMAL(18,2) NOT NULL,
    Comision         DECIMAL(18,2) NOT NULL DEFAULT 0,
    Fecha            DATETIME      NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Transferencia_Origen  FOREIGN KEY (CuentaOrigenId)  REFERENCES Cuenta(NumeroCuenta),
    CONSTRAINT FK_Transferencia_Destino FOREIGN KEY (CuentaDestinoId) REFERENCES Cuenta(NumeroCuenta)
);
GO

--martes 17/3/26

select * from Rol
select * from Usuario

insert into Rol select 'Encargado/a de Depósitos', 'Personal que realiza los depositos de las cuentas'

update rol set Nombre = 'Administrador General', Descripcion = 'Personal encargado del sistema bancario'  where rolid = 1
go

insert into Usuario select 1, 'Halveys', 'sa', 'sa'
go


create or alter proc spExisteUsuario
(
@NombreUsuario NVARCHAR(100),
@Contrasena NVARCHAR(50)
)
as
set nocount on
begin
declare @RolId int = 0
select @RolId = ISNULL(RolId, 0) from usuario where NombreUsuario = @NombreUsuario and Contrasena = @Contrasena
SELECT @RolId
end
go


create proc spVerRoles
as
set nocount on
begin
select RolId, Nombre, Descripcion from Rol
end
go


select * from Titular

--Miercoles 17/3/26

create proc spInsertarTitular
(
@TitularId int,
@Nombre nvarchar(100),
@Edad int,
@Sexo char(1),
@Ocupacion nvarchar(100)
)
as
set nocount on
begin
insert into Titular select @TitularId, @Nombre, @Edad, @Sexo, @Ocupacion
end
go

create proc spVerTitulares
as
set nocount on
begin
select TitularId, Nombre, Edad, Sexo, Ocupacion from Titular
end
go

exec spVerTitulares


