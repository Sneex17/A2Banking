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
ALTER TABLE Deposito
ADD CONSTRAINT CHK_Cantidad CHECK (Cantidad > 0);
go

-- Retiro
CREATE TABLE Retiro (
    RetiroId INT           IDENTITY(1,1) PRIMARY KEY,
    CuentaId INT           NOT NULL,
    ClienteId INT          NOT NULL,
    Nombre NVARCHAR(50)    NOT NULL,
    Fecha    DATETIME      NOT NULL DEFAULT GETDATE(),
    Cantidad DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_Retiro_Cuenta FOREIGN KEY (CuentaId) REFERENCES Cuenta(CuentaId)
);
GO
ALTER TABLE Retiro
ADD CONSTRAINT CHK_CantidadRetiro CHECK (Cantidad > 0);
go


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

--Martes 24/3/26

select * from Comision


insert into Comision values (0.015, 'Tarifa del 0.15% para transferencias entre bancos diferentes')
select * from Banco

insert into Banco values ('A2 Banking', 'Banco nacional de springfield', 'springfield', 1)
go

CREATE PROCEDURE spCrearCuenta
    @BancoId       INT,
    @NumeroCuenta  INT,
    @TitularId     INT,
    @Balance       DECIMAL(18,2),
    @FechaCreacion DATE,
    @EstadoId      INT,
    @CodigoPin     NVARCHAR(10),
    @CodigoHuella  VARBINARY(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Cuenta (
        BancoId,
        NumeroCuenta,
        TitularId,
        Balance,
        FechaCreacion,
        EstadoId,
        CodigoPin,
        CodigoHuella
    )
    VALUES (
        @BancoId,
        @NumeroCuenta,
        @TitularId,
        @Balance,
        @FechaCreacion,
        @EstadoId,
        @CodigoPin,
        @CodigoHuella
    );

END;
GO

select * from Cuenta

select * from Estado

insert into Estado values ('Activa','Cuenta activa, se puede usar con normalidad'),
('Inactiva','Cuenta inactiva, no se puede usar'),
('Cancelada','La cuenta a sigo cancelada permanentemente')


select * from Cuenta where CodigoHuella = 0x00F86C01C82AE3735CC0413709AB71F0D314559260800D199393FA374447497729DB457EFA182B4FF2526F4C92FA090795C0AC60F5F9DB803A42F2C0415F225DC277F87955865E41B1093D4441A2C4C596B005DC79FD15EC6BEBA087802457D9483C02D0C865FED87D9A04EE587801B2FD24A2BBFD8308222350A3F7CFAE0EABF06104856847DE32235BC35F2F386115B1A9A9ABF954FF40BFEF9144E463B682546C16A7E106B55F39344317728CC6AD3336497850AAEBCF7EA9D98EF7993E37E6BFD9C7F3A8504D36390B7BA2E91641F82122BDFD4666CEDFD1782398285AD5891E4D1F2C63D5477D332AE5D903C34B1198DC01D730E15CE95EF9CB77C02E26EEE5BA575AEB3D6188BC6BB2FCB647DA7DDCBF2834724A577B89AE3587EB20D8D1971201E0F889756EFF5C898A412293426968CC222E40A9FDD63AF20508F5C27D0311412AB0E8B55B9CFE505638281541AB6004A44602492471D60F4F977C371BAEE364D7E525364A0F6112C355EEFE6F00F88101C82AE3735CC0413709AB71B0D4145592682BE018E6F59BEC9986936C4D5F9A015B707DBD7F29C0E6EA1C94FD953C2E167E419B8118BB7D10B05EBFB08B0C1D6BE1C2535853FD9AFB092E4961D28025F70FEE1776C2CA9D3DA2C22CD4DB58B97E2693EC2332A99B93D9D6AC873207CEA8218F3A644623830919F8178F7F9E463905C7690F7B5EB55A0133D4AB85E53B00B4BFAED98065C310149443F3713256334DD4D56053D930EFC170D5D1A08DC6DBBCB8CDC12F70F23949F99CF8F7A2196C9ECF979EC58EC34FF16A7907E43D2DF0C65DF92CDC042742A8DC583B404B37248AABF57D5D6CF038533F93B7C11AD5819B5D829AD51492F93E2AAAD186904BCE90BE0075B53FCD97696E7517F5F2DB5A73C82D13EF193E1DBF2260751B098676EB157076FD1D3F95A7CC33D49AEC1DAC1CEB37A2E2E47FE4C6DD66EF265D5B5E10460A19BC77F45B6ADE1291D2BBCB281D03E0D5351C686473DAA0A666756ABF945416A4AD9979E7E6F15F55DEBF46C7003BE7F5B7E0EFA4BAC946B9C33B0304926F00F88001C82AE3735CC0413709AB71B0EA14559238A9B310271D52F14558210FB02988C06876BEB6BD9C60DCDA8F6D589616C569C4E189681657D83687520BFE7D4B4FC6D92876D5DD9696D84F7091174459AD8CCBF9AE772DD99CDE8E008D3DF0B03E6DD175B72BBC4D7721AB43B8844BE07E6D9CA4490AB785D602526455B81B234A2A6384253994A25EBFE079706251EF66583CA9824E6ED0A5296D42054AE88FB50075A415F509B6AC46FCCD927E8F811CB846B5CF96730568DBB4AB71F4AC0CB6AB19069D99C7C65DC3F1D69339A31A731391FF9A432533BE527A630C5B55BC0B1AC1B2FD424ED93ED168D0A6B1120759A9FEC0BCC0E60E2B07C0E76B4E37C04C6F9F4E608F7EBE063861C9B690D442ED330FC2D578F02C280BA667E17233A38D370437E9D045B50875263C1161717117B0E58D1CFB1C678124BDA2A913F59A3FCB347FD6CF3EE917D23AB60C1E80C77F96975F5FFFEE23B3F4BC2F9214915A3CD5F56557B280FFB6F213867398CB4C02014534B046CA1C46B88977E76C5C3588486F00E87E01C82AE3735CC0413709AB71F0E31455928BB73ED6D2D803DAF97E96CBCAD4F711F7538D1F6C7F79AD9F8F128CA79C04C33174DE2AFC0C6470E983B2F9E5DA3F8C6A05B085F4CF5D17C0A6842F5CB904EC6310B947097C57BACC26DD0566422220D150F0B13CF04D6C9166575B330F700130EB1A472333FD367F5E7EE3C4798CB494EE8A6CCDC42F8B25259B454BFBC2E49E6E59FBFB0728E29DDA63653EA5A0E86624665A0AADFBF4E71F285FE7C78DB82FDF6C089BE36C386FC48918CAA4420DDB603E800199D746C61A7CB9EBAE10489D50A401DDCC188CA19A82E20355B918D7243F7FDEC0974BF0BCAF6BE66A4B63ECB1F0D185952ABED9BE4A64D5D9187B42E44B80B9D3AF7B898F2CB23C96E8E989CA7CC83211BA9258998401ABF4C8B318FCF187A48E05EC1332D15280D599B000295E4826A40D62D70BE019147CE66754527A686211EACD7D886460DAACC281AB40DB4C54400D7EDA352C2F95DBEBF74F1FA7E92666CB42AA0BBF852B5C1BEA02D806FEE095E9438CE646E9CB976F00809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000809F28D7F97F0000


select * from Cuenta where CodigoHuella = 0x00F87E01C82AE3735CC0413709AB7130E0145592ACCE79DA1F30BE80D2339DF6F629412759AFC51851DAE72E1C3592711F50729B36EF1838C3409B5F52C6739D370309DC7213CECA45BED456F77EA0FF534B2223FB650CF664AAD30CE80B937993325D7760305DFF9F46BBB463DD30FC4E67CC35BDE5C81061D270519BC6D651F378844B0AA52FA06A0FD17CDD25E070C58E39CD0C37E108F784FFCAD975CCB175B69921DA9C66C9C521C2044504EF0E498401B20767735E78AACBED86457CF7A375008A0950D1054C00A0AC5731183C496ED37BF99CCB13E53FDBAE3AC135D00160479DD840B52FA64EEE3C23E6331F8DA0780FD2EAB77CDF6868AC05924D710F00011DAAD61195D2387415430EC166DC834428C83B4C55D2A26A725DE672C7D41B19B7FD8762D406BA4914899D499FA0315E52C419B2FCB76F5755363378F439623B3968E9926A08E7D23A670486B9EB2BC5165136D11D2BD3EC51E4F84B509B828778B46BE602DC4F11F6F704C30A7682B482D3BA8BD76E155F8BF586C92CCA0E6F00F88101C82AE3735CC0413709AB7170D214559268662935F7EC39724FC20CA6889CC87ABB5F0364652A1CF8271B935FA389BDA2D9B206065FECE72ECF11F9AC5F79A5A3B1A12A22AF20BF55A2234ABFA9BF4FE06A10B011D3D558449921E19F6102F7C77BB184154F1608B82F060B4D877AD669656446E1D1C874D829D9B3561ED94371C661F80CACBDA4C9AEAD208791A0AA21C03C1AB71B46ECE199438ED0A811B16E243461CF42516A2530F9B4787692AE03B49BD3DF1D031D010CCBA859ED0FAC4A5B25895B44974C5549901D9E973620ADB7A1AFEB9A7C85CC005F381B54160153C9A378ACA61E2487B8CF57A70004E882E69041E99DE369C488DC1A2885B6654A075501630C31B1411D2CAABC6F4A02E760309BB3B06F50B7056F062BCDC3C0D8EE0B1682657942F13F3ABADC5A7CCE5D99F1F19AD7E20654EE103F0F3C7674DDB4F158017EEF7F9EFB9F3C8E041FE69C438E6255DACA65DFE12E5C3E1639AA0F3F9DF590DA1CC7DC112B0FE3FE81DADD910659F9605748A52C23193D5C26EE48ED6F00F88001C82AE3735CC0413709AB71B0FE145592FC1EEF29E6631F4418AC2931E63C59D3BBEA255E683BF8EFE67841077193EABD14CD59B01DAA03329475CF31DDF4CE86C038553C91CEA9C7D157699271490F96FC1BAE211FCE0A32F8F308A1FBA49C60918AB6355059409E8A883E58BA268F822AEF142FBDAC75D2B32EEC67109C45BE37E5CA0284B0CD30BA3C6B31106B156274F028B7EE99121F230B720F32B33AD81C60A26C88502BD808E869FF2F21F980D48A105933C068EE9E8C4CF90852B84CFD0BBC77D07B578E1C1E0D9ADFDA4557EF10C6A8D92E20C5D083BBF2A3A83B6ADB0F99388BA495A5B11005B2E144F7653AD2CA2D82BB709FDFFEF06FAA2B8A6B310183FF4718F79535ACEC729564C895BC16BB56AAE8FC60BD9744B770B8B94C79E2B30168384DD34920F94126066A5EECF86735329608D4C716D423DE2A08641FB1A953F75E451350B8D9CDC49CEC222D0B26D15F1561A6FE14367160447839D86FF79662791E0EB9944FFB6F3B8E8B0C1FE92805DB2B4E9693C34CC302FC206F00E88101C82AE3735CC0413709AB7130E4145592DDD007A8CE3B6E9221425799B58A52FEB6D85EBEB927674749692A0E187E7EBB59CE6DE2F2FF8D702C26D2B95D456BCC79A215656EB602040BF370C83B0095D22035735A6CF02278D8FDC0097FBC83B7EAC35F63CDF7D257229B34319BD2C52815F2DCC927980EB6FF0848E8314DA25E33D0042DBB47CACF936149FA0227816485CEB72844363313E257BCEC4B9F345760FEA81F660F4A96D12029624FD689C7AC10B4A8750516725F2DC3289F65DB5A1B51615F6367C64C88B3B0DBAFCF452F59A0F8AF65838A1356AB72FC577272FE92FAD0E21BCE6165B976A755DE93CFEC919CB01DC27C87827BBB5AA6DC09BB77F3F34E66ADF946CD425EACFB16BE03176599B0B7415AB7624183F70C61EF39FD5877429FC00143262915EB3217FD832C978B8E9C23916D8526F91A64FA483F630EC759FB99B6721EB06A86B85BCED99D5E2F41CC50256A2D42AE81133EFD11173BBB882FFAA9BD07292FB4C2A1DE73C910245C2F1C4024A112D4564DDE4E26786D6FE9C0FBFFFF4181CF00080000E95AFDFFFF488B5D10838BB00000002048895D10E901FCFFFF488BCB488B8790000000FF104C8BE8EB4E4C8B4358E9D5FDFFFF488BD0FF15FCCBE2FECC488BCB

--miercoles 25/3/26

select * from Usuario


create proc spVerUsuarios
as
set nocount on
begin

select a.UsuarioId, r.Nombre as Rol, a.Nombre, a.NombreUsuario, a.Contrasena
from Usuario as a
inner join Rol as r on a.RolId = r.RolId

end
go

create view vwListaUsuarios
with schemabinding
as
select a.UsuarioId, r.Nombre as Rol, a.Nombre, a.NombreUsuario, a.Contrasena
from dbo.Usuario as a
inner join dbo.Rol as r on a.RolId = r.RolId
go

select * from Usuario
go

create proc spVerUsuarios
as 
set nocount on
begin
select * from vwListaUsuarios
end
go


CREATE PROCEDURE spAgregarUsuario
    @RolId       INT,
    @Nombre      NVARCHAR(100),
    @NombreUsuario NVARCHAR(50),
    @Contrasena  NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Usuario (RolId, Nombre, NombreUsuario, Contrasena)
    VALUES (@RolId, @Nombre, @NombreUsuario, @Contrasena)
END
GO

CREATE PROCEDURE spActualizarUsuario
    @UsuarioId   INT,
    @RolId       INT,
    @Nombre      NVARCHAR(100),
    @NombreUsuario NVARCHAR(50),
    @Contrasena  NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Usuario
    SET
        RolId          = @RolId,
        Nombre         = @Nombre,
        NombreUsuario  = @NombreUsuario,
        Contrasena     = @Contrasena
    WHERE UsuarioId = @UsuarioId
END
GO

select * from Cuenta


create or alter view vwListaCuenta
with schemabinding
as
select c.CuentaId, b.Nombre as Banco, c.NumeroCuenta,
c.TitularId, t.Nombre as Nombre, c.Balance, c.FechaCreacion, 
e.Nombre as Estado, c.CodigoPin
from dbo.Cuenta as c
inner join dbo.Banco as b on c.BancoId = b.BancoId
inner join dbo.Titular as t on c.TitularId = t.TitularId
inner join dbo.Estado as e on c.EstadoId = e.EstadoID
go

create proc spListaCuentas
as 
set nocount on
begin
select * from vwListaCuenta
end
go


create proc spNumeroCuenta
as
set nocount on
begin
select isnull(max(NumeroCuenta), 100000000) + 1
from Cuenta 
end
go
--transaciones

--depositos

create or alter proc spDepositarBalanceCuenta
(
@NumeroCuenta int,
@ClienteId int,
@Nombre nvarchar(50),
@Balance decimal(18,2),
@Fecha date
)
as
set nocount on
begin
    begin try
        begin tran
            declare @CuentaId int

            set @CuentaId = (select CuentaId from Cuenta where NumeroCuenta = @NumeroCuenta)

            insert into Deposito values (@CuentaId, @ClienteId, @Nombre, @Fecha, @Balance)

            declare @NewBalance decimal(18,2)

            set @NewBalance = (select Balance from Cuenta where NumeroCuenta = @NumeroCuenta) + @Balance

            update Cuenta set Balance = @NewBalance where NumeroCuenta = @NumeroCuenta
        commit tran
    end try
    begin catch
        rollback tran
    end catch
end
go


exec spDepositarBalanceCuenta @NumeroCuenta = 100000001, @ClienteId = 1, @Nombre = 'Homer Simpson', @Balance = 0, @Fecha = '2026-03-25'

select * from Deposito


--update Deposito set clienteid = 1, nombre = 'Homer Simpson'

select * from Retiro
go

--retiros
create or alter proc spRetirarBalanceCuenta
(
@NumeroCuenta int,
@ClienteId int,
@Nombre nvarchar(50),
@Balance decimal(18,2),
@Fecha date
)
as
set nocount on
begin
    begin try
        begin tran
            declare @CuentaId int

            set @CuentaId = (select CuentaId from Cuenta where NumeroCuenta = @NumeroCuenta)

            insert into Retiro values (@CuentaId, @ClienteId, @Nombre, @Fecha, @Balance)

            declare @NewBalance decimal(18,2)

            set @NewBalance = (select Balance from Cuenta where NumeroCuenta = @NumeroCuenta) - @Balance

            update Cuenta set Balance = @NewBalance where NumeroCuenta = @NumeroCuenta
        commit tran
    end try
    begin catch
        rollback tran
    end catch
end
go

select * from Retiro

select * from Cuenta
go
--proc cuenta, cajero

create or alter proc spCuentaExiste
(
@NumeroCuenta int,
@CodigoPin int
)
as
set nocount on
begin
select c.NumeroCuenta, c.Balance, t.Nombre from Cuenta as c
inner join Titular as t on c.TitularId = t.TitularId
where (NumeroCuenta = @NumeroCuenta and CodigoPin = @CodigoPin) and EstadoId = 1
end


select * from vwListaUsuarios


--Viernes 27/3/26
select c.NumeroCuenta, c.Balance, t.Nombre from Cuenta as c
inner join Titular as t on c.TitularId = t.TitularId
where (NumeroCuenta = 1000000001 and CodigoPin = 1234) and EstadoId = 1

select * from Cuenta


SELECT c.*, t.Nombre 
FROM Cuenta c
LEFT JOIN Titular t ON c.TitularId = t.TitularId
WHERE c.NumeroCuenta = 1000000001

select * from Titular


SELECT TitularId FROM Cuenta WHERE NumeroCuenta = 1000000001
                                                  

                                               select   len('100000001')

-- ¿Existe ese TitularId en Titular?
--SELECT * FROM Titular WHERE TitularId = (el número que salió arriba)

--Martes 31/3/26

backup database A2BankibgDB
to disk = 'S:\xrami\OneDrive - Universidad Central del Este\Trabajos de Base de Datos II ISW-212-1\Backups\BackupFull_A2bankingDB.bak'
with init
go

--CLR
sp_configure 'clr enabled',1
go

reconfigure
go

alter database A2BankibgDB set trustworthy on
go

create assembly ComisionTransferenciasCLR
from 'C:\Users\xrami\OneDrive\Documentos\A2Banking\Base de Datos\SqlCLR\CTransferenciasCLR.dll'
with permission_set = external_access
go



SELECT servicename, service_account
FROM sys.dm_server_services;
go

SELECT *
FROM sys.assembly_modules;

SELECT name
FROM sys.assemblies;
go

--funcion para aplicar la comision
CREATE FUNCTION dbo.fnAplicarComision
(
    @monto DECIMAL(18,2),
    @comision DECIMAL(5,4)
)
RETURNS DECIMAL(18,2)
AS EXTERNAL NAME
ComisionTransferenciasCLR.[CTransferenciasCLR.TransferenciaCLR].AplicarComision;
GO

--prueba

declare @comision decimal(5,4) = 
(select c.Cantidad from Banco as b 
inner join Comision as c on b.ComisionId = c.ComisionId)

select dbo.fnAplicarComision(100, @comision)
go

select * from Banco
go
select * from Transferencia
go

--tabla para las ganacias de los bancos
create table GananciaComision
(
GanaciaId bigint primary key identity,
BancoId int not null,
Ganacia decimal(18,2) not null
constraint FK_GananciaBanco foreign key (BancoId) references Banco(BancoId)
)

--proc para las trasferencias
create or alter proc spTransferencias
(
@Monto decimal(18,2),
@CuentaOrigen int,
@CuentaDestino int,
@Concepto nvarchar(max),
@Fecha datetime
)
as
set nocount on
begin
     begin try
        begin tran
         declare @MontoFinal decimal(18,2)
         declare @Comision decimal(5,4)

         set @Comision = 
         (select s.Cantidad from Cuenta as c 
         inner join Banco as b on c.BancoId =  b.BancoId
         inner join Comision as s on b.ComisionId = s.ComisionId
         where c.NumeroCuenta = @CuentaDestino
         )
         set @MontoFinal = dbo.fnAplicarComision(@Monto, @Comision)

         --Retiro del dinero
         declare @ClienteId int
         declare @NombreTitular nvarchar(100)
         declare @CuentaId int
         declare @Balance decimal(18,2)

         set @CuentaId = (select c.CuentaId from vwListaCuenta as c where NumeroCuenta = @CuentaOrigen)
         set @ClienteId = (select c.TitularId from vwListaCuenta as c where NumeroCuenta = @CuentaOrigen)
         set @NombreTitular = (select c.Nombre from vwListaCuenta as c where NumeroCuenta = @CuentaOrigen)
         set @Balance = (select c.Balance from vwListaCuenta as c where NumeroCuenta = @CuentaOrigen)


         --exec spRetirarBalanceCuenta @CuentaOrigen, @ClienteId, @NombreTitular, @Fecha, @MontoFinal

         insert into Retiro select @CuentaId, @ClienteId, @NombreTitular, @Fecha, @MontoFinal
         update Cuenta set Balance = (@Balance - @MontoFinal) where NumeroCuenta =  @CuentaOrigen


         --Transferencia del dinero
         insert into Transferencia select @CuentaOrigen, @CuentaDestino, @Monto, (@Monto * @Comision), @Fecha, @Concepto
         --select * from Transferencia

         --Deposito del dinero
         set @CuentaId = (select c.CuentaId from vwListaCuenta as c where NumeroCuenta = @CuentaDestino)
         set @ClienteId = (select c.TitularId from vwListaCuenta as c where NumeroCuenta = @CuentaDestino)
         set @NombreTitular = (select c.Nombre from vwListaCuenta as c where NumeroCuenta = @CuentaDestino)
         set @Balance = (select c.Balance from vwListaCuenta as c where NumeroCuenta = @CuentaDestino)

         --exec spDepositarBalanceCuenta @CuentaDestino, @ClienteId, @NombreTitular, @Fecha, @Monto

         insert into Deposito select @CuentaId, @ClienteId, @NombreTitular, @Fecha, @Monto
         update Cuenta set Balance = (@Balance + @Monto) where NumeroCuenta = @CuentaDestino


         declare @BancoId int
         set @BancoId = (select BancoId from Cuenta where NumeroCuenta = @CuentaDestino)

         insert into GananciaComision select @BancoId, (@Monto * @Comision)
         

        commit tran
     end try
     begin catch
        rollback tran
        throw
        print @@error
     end catch
 end
 go


 --
    select * from Transferencia
     select * from vwListaCuenta
     select * from Retiro
     select * from Deposito
     select * from GananciaComision
     select * from Cuenta

go

INSERT INTO Comision VALUES (0.017, 'Tarifa del 1.7% para transferencias entre bancos diferentes');
INSERT INTO Comision VALUES (0.025, 'Tarifa del 2.5% para transferencias entre bancos diferentes');
INSERT INTO Comision VALUES (0.020, 'Tarifa del 2.0% para transferencias entre bancos diferentes');
go
INSERT INTO Banco VALUES ('Banco Popular Dominicano', 'Banco líder en servicios financieros del país', 'Santo Domingo', 1);
INSERT INTO Banco VALUES ('Banco de Reservas', 'Banco estatal de la República Dominicana', 'Santo Domingo', 2);
INSERT INTO Banco VALUES ('Scotiabank República Dominicana', 'Banco internacional con operaciones en RD', 'Santiago', 3);
INSERT INTO Banco VALUES ('Banco Santa Cruz', 'Banco dominicano con enfoque en el sur del país', 'San Pedro de Macorís', 4);
go


--exec spTransferencias 1000, 


select * from Cuenta
select * from Banco
select * from Comision



exec spCrearCuenta 4, 100000006 ,26, 1000, '2026-03-31', 1, 3434, 0x00F88101C82AE3735CC0413709AB7170A51455928B5313CF2E319C4D5D254CB7546B16FC6DFA01FDDD498D0FCE64A9CEC098F36EBC13A45407C1A1241EA6C54E12DE91096C179BDE989AF482C7AAA40474EF9C758B2E5E974284B82906955B380527D4B62508A5672D290E05DA79914BF995F912060A4C4EF7C3E112E6AF8E2A5FCAFC2A855B47671C6E70312B35F852337F758910F296A5ACE6FD9CD75215E6872050BEA1C4044427B8C3CF5967328CFD8BEF599E234EB19E7BB703C24F785DC9D66AD9D73F2F5598CDA44A287FF91AB51820FD6B30F2620752F1C6393CD36D8789C1FCFAB22B93DF7A8631096AE250CE2CB24455C3711F3ABE8F88DE2427AE5C650288474260D57E8664139BF49D0CD8570817BFDB599E4B0FD3F21E9CB321740E83B98763211432665995F4C02C5BDF616C95D16498D641DA39C64D725B5609AE70D841654425140B1A2B3D315061F4273FD3FA9398B1FC890651FEFA0BFA37B9BBAA14B51EA9989BA2A569FDA7405AE05066FFE470C5F5497573E78C7504DD2236377D6F00F87F01C82AE3735CC0413709AB71304E155592A269A2162C3E39C7FE7F06083C92C4F7B94A948706379C777ACC897AD5DC846EFE2FA29E971BD970BD88DE0B749910BF4A69B35995EFDE3743CF1E1497CBA6DC311FC292A4D1B139128BA15C1F28B3F742EA4ECAF4607F8C31B6013151E240C321532D44D7B3941B3D2201AB7192E2ECF1A2BDBC831E9DB0B89A22EE064BCD15138C0F60C70A224D915F2F27D69D6D9A29362DBBD7121432C2C8F84EB9DE3B288C56654E37136B4D066459614AB89AA35973CAFE922A72A62ED2C776B75F4A74F4BDA6CB1D0F0F5706E8A88651908CF8F76E20C97081EE7EE281E3ECAEE098D9434A6BD10F0446F91F71B81F5015EDB09B46CC502FDF80CA38A18CF28C319628A56CEC015800D221A29B5DB5724B9DC34DD445EB7D0CA9DEF8BF7C56F030D39676CB402F5DB1A5AC3014BE06BC817993FCFF68BFDAECF35771C941B27305C1D246BBE487B1FA83D9C8683533DECE0EAD98106A902A75A332B0413C821A1CE3C7FED39A5A845C264665028C014F619C6F00F87E01C82AE3735CC0413709AB71B0B6145592218BC6840EB608631D2C1E23DBAEB1BBC060E6ED24172C34EEABC53E6667F8552E2ADC740254BDD0B7D2E5B3BD3E674342071059A6B90116345134AF121697BB2C97521434FC71BF4EE7A109AAEC7A52280BD4A6B9146051CB6C29514D345317E9D15F7272CB95B1A400892DD7BC820A29205B578F54376DDF026612AE26EB171EA38087CE8076D3123CDE62A1524E3926C6A116120BF84DB010A5BDF7B7362822AA9354FFC791B73E174BC7C923C5BEC1BFA310EFD8B7F28C5497D0B5E8747B07A693386A6F682BEB9581E8DEC0E0BA2AE2CD66698CD2B29D9CAA7933959D4104D0C9CCE64D6B4F76D87C2153A7191549ED62C5CD211484A1C946B454F16DBC8535C1B387E1402936064DE38DFD2C3499476ECBAD73524509F57F70A47A9CBE285F33B6AB204516A29B4566DF2F90C35F8534FC4ABB8B06B9833C067BCC83C90D218C63E84C7F26A749699A37BE7FF2AC3FD6CB406EE811E4918BC368122D8728EB4BA3B44187DC2A6253C76D256F00E88101C82AE3735CC0413709AB717040155592593A228F3F490E72BFE9ED78CC7FEC2B7F5B97554114329CE79111BE13AA269506A37DF2F15B193365808B8C71246DC6EE8610424D8E85562CF3174C4DDDEEE9F045B9C1A9484EEA9098FD5C6FDCE864362C17ABB801E7D4B803DEC0B088107286CD06605D9DC964AF76279030402D8D5C092339B6DBB3C1ACB99F9F01B953A3294E284B7B23A34FD4847DFBABE0FF562AF83B5D9AB49FCC3DFFE5C63BF5964AE470FDB91A574DEBDA6DAA02170B28071B4B04C3A98DA359E6602338DD8D97D27DBBDC769E15209ED8800EE630AD00189373AAD65F821715A0165A762C02839D688BC90F6E50D0CABAAF2FE7B4CB2573C788E00B767DC8A7AEC0593D6CB498F9AC18EAD237578384CC9CFAE317E5CB0303A106B96F3C69A4F3A405069FB1DBE61E5442A4C67E9F0352D84C3A3D1B3490EBA09620948A983EFC30EFE5E519061549A8F015B61F1F09FF37B045E2547A7A0D040979BEAE53479D659EB97394A717C10724D82B413BE560EA1CBB379E9289656FEB71010000B0FB13EB7101000048FC81EB7101000068FC81EB7101000068FC81EB7101000048FC81EB71010000C04E81EB7101000068EF81EB7101000068EF81EB7101000090F081EB71010000

--pruebas de las transacciones

exec spTransferencias 1000, 100000004, 100000006, 'Prueba de procedimiento de la transferencia entre cuentas', '2026-03-31'

select * from Retiro
select * from Transferencia
select * from Deposito
select * from GananciaComision


select * from Titular
go

create proc spVerTransferencia
as
 set nocount on
 begin
 select TransferenciaId, CuentaOrigenId, CuentaDestinoId, 
 Monto, Comision, Fecha, Concepto from Transferencia
 end

 --Viernes 2/4/26

 select * from Transferencia


 select * from vwListaCuenta


 select * from GananciaComision