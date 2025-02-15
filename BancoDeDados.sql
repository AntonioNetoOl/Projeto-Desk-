USE [master]
GO
/****** Object:  Database [pim_scripts]    Script Date: 18/01/2025 15:59:37 ******/
CREATE DATABASE [pim_scripts]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'pim_scripts', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\pim_scripts.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'pim_scripts_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\pim_scripts_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [pim_scripts] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [pim_scripts].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [pim_scripts] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [pim_scripts] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [pim_scripts] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [pim_scripts] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [pim_scripts] SET ARITHABORT OFF 
GO
ALTER DATABASE [pim_scripts] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [pim_scripts] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [pim_scripts] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [pim_scripts] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [pim_scripts] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [pim_scripts] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [pim_scripts] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [pim_scripts] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [pim_scripts] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [pim_scripts] SET  ENABLE_BROKER 
GO
ALTER DATABASE [pim_scripts] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [pim_scripts] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [pim_scripts] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [pim_scripts] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [pim_scripts] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [pim_scripts] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [pim_scripts] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [pim_scripts] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [pim_scripts] SET  MULTI_USER 
GO
ALTER DATABASE [pim_scripts] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [pim_scripts] SET DB_CHAINING OFF 
GO
ALTER DATABASE [pim_scripts] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [pim_scripts] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [pim_scripts] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [pim_scripts] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [pim_scripts] SET QUERY_STORE = ON
GO
ALTER DATABASE [pim_scripts] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [pim_scripts]
GO
/****** Object:  User [Terraverde.pim]    Script Date: 18/01/2025 15:59:38 ******/
CREATE USER [Terraverde.pim] FOR LOGIN [Terraverde.pim] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Terraverde.unip.pim]    Script Date: 18/01/2025 15:59:38 ******/
CREATE USER [Terraverde.unip.pim] FOR LOGIN [Terraverde.unip.pim] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[iidCliente] [int] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[CnpjCliente] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iidCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_CnpjCliente] UNIQUE NONCLUSTERED 
(
	[CnpjCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cultivos]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cultivos](
	[CodigoCultivo] [int] NOT NULL,
	[NomeCultivo] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoCultivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPagamento]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPagamento](
	[iidFormaPagamento] [int] NOT NULL,
	[FormaPagamento] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[iidFormaPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insumos]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insumos](
	[CodigoInsumo] [int] NOT NULL,
	[NomeInsumo] [varchar](100) NOT NULL,
	[Origem] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoInsumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[iidProduto] [int] NOT NULL,
	[NomeProduto] [varchar](30) NOT NULL,
	[ValorProduto] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iidProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[iid] [int] NOT NULL,
	[email] [varchar](150) NOT NULL,
	[NomeCompleto] [varchar](150) NOT NULL,
	[NomeUsuario] [varchar](100) NOT NULL,
	[senha] [varchar](100) NOT NULL,
	[tipo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendas]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendas](
	[CodigoVenda] [int] NOT NULL,
	[produto] [varchar](100) NOT NULL,
	[quantidade] [int] NOT NULL,
	[ValorTotal] [decimal](10, 2) NOT NULL,
	[FormaPagamento] [varchar](50) NOT NULL,
	[DataHoraVenda] [datetime] NOT NULL,
	[iid_cliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[vendas]  WITH CHECK ADD FOREIGN KEY([iid_cliente])
REFERENCES [dbo].[cliente] ([iidCliente])
GO
/****** Object:  StoredProcedure [dbo].[CadastroCliente]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CadastroCliente] 
	@RazaoSocial varchar(50),
	@Cnpj Varchar(40) 
	
AS
BEGIN
	
	INSERT INTO cliente (iidcliente, Nome, CnpjCliente)
	Values ((SELECT COALESCE(MAX(iidCliente), 0) + 1 FROM cliente), @RazaoSocial, @Cnpj) 

END
GO
/****** Object:  StoredProcedure [dbo].[InserirInsumo]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirInsumo]
    @NomeInsumo VARCHAR(100),
    @Origem VARCHAR(150)
AS
BEGIN
    DECLARE @CodigoInsumo INT;
    DECLARE @CodigoExistente INT;


    WHILE 1 = 1
    BEGIN
        SET @CodigoInsumo = ABS(CHECKSUM(NEWID())) % 10000;  
        SELECT @CodigoExistente = COUNT(*) FROM insumos WHERE CodigoInsumo = @CodigoInsumo;
        IF @CodigoExistente = 0 BREAK;  
    END

    INSERT INTO insumos (CodigoInsumo, NomeInsumo, Origem)
    VALUES (@CodigoInsumo, @NomeInsumo, @Origem);
END

GO
/****** Object:  StoredProcedure [dbo].[InserirProduto]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InserirProduto] 
	@NomeProduto varchar(30),
	@ValorProduto decimal(10,2)

AS
BEGIN

INSERT INTO PRODUTO (iidProduto, NomeProduto, ValorProduto)
VALUES ((SELECT COALESCE(MAX(iidProduto), 0) + 1 FROM produto), @NomeProduto, @ValorProduto);

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarVenda]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarVenda]
    @NomeCliente VARCHAR(100),
    @Produto VARCHAR(100),
    @Quantidade INT,
    @ValorTotal DECIMAL(10, 2),
    @FormaPagamento VARCHAR(50)
AS
BEGIN
    DECLARE @CodigoVenda INT;  -- Código da venda (aleatório)
    DECLARE @iid_cliente INT;

    -- Gerar um código de venda aleatório entre 1000 e 9999
    SET @CodigoVenda = ABS(CHECKSUM(NEWID())) % 9000 + 1000;

    -- Verifica se o cliente já existe e obtém o iid_cliente
    SELECT @iid_cliente = iidCliente 
    FROM cliente 
    WHERE nome = @NomeCliente;  -- Ajustado para usar 'nome'

    -- Se o cliente não existir, insere um novo cliente
    IF @iid_cliente IS NULL
    BEGIN
        INSERT INTO cliente (iidCliente, nome)
        VALUES ((SELECT COALESCE(MAX(iidCliente), 0) + 1 FROM cliente), @NomeCliente);
        
        -- Captura o iid_cliente do novo cliente inserido
        SELECT @iid_cliente = (SELECT MAX(iidCliente) FROM cliente);
    END

    -- Insere a venda associando ao iid_cliente correto
    INSERT INTO vendas (CodigoVenda, produto, quantidade, ValorTotal, FormaPagamento, DataHoraVenda, iid_cliente)
    VALUES (@CodigoVenda, @Produto, @Quantidade, @ValorTotal, @FormaPagamento, GETDATE(), @iid_cliente);
END
GO
/****** Object:  StoredProcedure [dbo].[RelatorioVendasPorData]    Script Date: 18/01/2025 15:59:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RelatorioVendasPorData]
    @DataInicial DATETIME
AS
BEGIN
    SELECT 
        v.produto,
        v.ValorTotal,
        v.DataHoraVenda,
        c.Nome AS NomeCliente
    FROM vendas v
    INNER JOIN cliente c ON v.iid_cliente = c.iidCliente
    WHERE v.DataHoraVenda >= @DataInicial
    ORDER BY v.DataHoraVenda;
END
GO
USE [master]
GO
ALTER DATABASE [pim_scripts] SET  READ_WRITE 
GO
