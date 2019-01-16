USE [master]
GO
/****** Object:  Database [One]    Script Date: 15/01/2019 16:45:29 ******/
CREATE DATABASE [One]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'One', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\One.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'One_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\One_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [One] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [One].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [One] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [One] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [One] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [One] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [One] SET ARITHABORT OFF 
GO
ALTER DATABASE [One] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [One] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [One] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [One] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [One] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [One] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [One] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [One] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [One] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [One] SET  DISABLE_BROKER 
GO
ALTER DATABASE [One] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [One] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [One] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [One] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [One] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [One] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [One] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [One] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [One] SET  MULTI_USER 
GO
ALTER DATABASE [One] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [One] SET DB_CHAINING OFF 
GO
ALTER DATABASE [One] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [One] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [One] SET DELAYED_DURABILITY = DISABLED 
GO
USE [One]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACAluno]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACAluno](
	[CodigoALuno] [int] IDENTITY(1,1) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[CodigoEndereco] [int] NOT NULL,
	[CodigoResponsavel] [int] NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACAluno] PRIMARY KEY CLUSTERED 
(
	[CodigoALuno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACCategoria]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACCategoria](
	[CodigoCategoria] [int] IDENTITY(1,1) NOT NULL,
	[DescricaoCategoria] [nvarchar](30) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoFaixaEtaria] [int] NOT NULL,
 CONSTRAINT [PK_ACCategoria] PRIMARY KEY CLUSTERED 
(
	[CodigoCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACFaixaEtaria]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACFaixaEtaria](
	[CodigoFaixaEtaria] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[IdadeMinima] [int] NOT NULL,
	[IdadeMaxima] [int] NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_ACFaixaEtaria] PRIMARY KEY CLUSTERED 
(
	[CodigoFaixaEtaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACMatricula]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACMatricula](
	[CoodigoMatricula] [int] IDENTITY(1,1) NOT NULL,
	[CodigoIdentificador] [nvarchar](max) NOT NULL,
	[CodigoAluno] [int] NOT NULL,
 CONSTRAINT [PK_ACMatricula] PRIMARY KEY CLUSTERED 
(
	[CoodigoMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACProfessor]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACProfessor](
	[CodigoProfessor] [int] IDENTITY(1,1) NOT NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[CPF] [nvarchar](11) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACProfessor] PRIMARY KEY CLUSTERED 
(
	[CodigoProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACResponsavel]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACResponsavel](
	[CodigoResponsavel] [int] IDENTITY(1,1) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoEndereco] [int] NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACResponsavel] PRIMARY KEY CLUSTERED 
(
	[CodigoResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACTurma]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACTurma](
	[CodigoTurma] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](100) NOT NULL,
	[DataInicio] [datetime2](7) NOT NULL,
	[DataFim] [datetime2](7) NOT NULL,
	[ValorBase] [decimal](18, 2) NOT NULL,
	[CodigoIdentificador] [nvarchar](max) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoCategoria] [int] NOT NULL,
	[CodigoProfessor] [int] NOT NULL,
 CONSTRAINT [PK_ACTurma] PRIMARY KEY CLUSTERED 
(
	[CodigoTurma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FIMensalidade]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FIMensalidade](
	[CodigoMensalidade] [int] IDENTITY(1,1) NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [datetime2](7) NOT NULL,
	[Valor] [decimal](18, 2) NOT NULL,
	[MesCompetencia] [int] NOT NULL,
	[AnoCompetencia] [int] NOT NULL,
	[flSituacao] [nvarchar](1) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoMatricula] [int] NOT NULL,
 CONSTRAINT [PK_FIMensalidade] PRIMARY KEY CLUSTERED 
(
	[CodigoMensalidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GEBairro]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GEBairro](
	[CodigoBairro] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [nvarchar](50) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoCidade] [int] NOT NULL,
 CONSTRAINT [PK_GEBairro] PRIMARY KEY CLUSTERED 
(
	[CodigoBairro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GECidade]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GECidade](
	[CodigoCidade] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](50) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoUF] [int] NOT NULL,
 CONSTRAINT [PK_GECidade] PRIMARY KEY CLUSTERED 
(
	[CodigoCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GEEndereco]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GEEndereco](
	[CodigoEndereco] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[Logradouro] [nvarchar](300) NOT NULL,
	[Cep] [nvarchar](10) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoBairro] [int] NOT NULL,
 CONSTRAINT [PK_GEEndereco] PRIMARY KEY CLUSTERED 
(
	[CodigoEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GETelefone]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETelefone](
	[CodigoTelefone] [int] IDENTITY(1,1) NOT NULL,
	[NumeroTelefone] [nvarchar](20) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoTipoTelefone] [int] NOT NULL,
 CONSTRAINT [PK_GETelefone] PRIMARY KEY CLUSTERED 
(
	[CodigoTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GETipoTelefone]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETipoTelefone](
	[CodigoTipoTelefone] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_GETipoTelefone] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GEUF]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GEUF](
	[CodigoUF] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[Sigla] [nvarchar](2) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_GEUF] PRIMARY KEY CLUSTERED 
(
	[CodigoUF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEGPerfil]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGPerfil](
	[CoigoPerfil] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_SEGPerfil] PRIMARY KEY CLUSTERED 
(
	[CoigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEGUsuario]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGUsuario](
	[CodigoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [nvarchar](200) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[Login] [nvarchar](100) NOT NULL,
	[CPF] [nvarchar](11) NULL,
	[Sexo] [nvarchar](1) NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_SEGUsuario] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEGUsuarioPerfil]    Script Date: 15/01/2019 16:45:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGUsuarioPerfil](
	[CodigoUsuarioPerfil] [int] IDENTITY(1,1) NOT NULL,
	[CodigoPerfilPadrao] [int] NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
	[CodigoPerfil] [int] NOT NULL,
 CONSTRAINT [PK_SEGUsuarioPerfil] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuarioPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190115192803_inicio-identity', N'2.1.4-rtm-31024')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190115192918_inicio-one', N'2.1.4-rtm-31024')
SET IDENTITY_INSERT [dbo].[GECidade] ON 

INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (1, N'Abaetetuba', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (2, N'Abel Figueiredo', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (3, N'Acará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (4, N'Afuá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (5, N'Água Azul do Norte', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (6, N'Alenquer', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (7, N'Almeirim', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (8, N'Altamira', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (9, N'Anajás', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (10, N'Ananindeua', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (11, N'Anapu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (12, N'Augusto Corrêa', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (13, N'Aurora do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (14, N'Aveiro', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (15, N'Bagre', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (16, N'Baião', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (17, N'Bannach', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (18, N'Barcarena', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (19, N'Belém', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (20, N'Belterra', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (21, N'Benevides', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (22, N'Bom Jesus do Tocan', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (23, N'Bonito', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (24, N'Bragança', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (25, N'Brasil Novo', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (26, N'Brejo Grande do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (27, N'Breu Branco', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (28, N'Breves', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (29, N'Bujaru', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (30, N'Cachoeira do Arari', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (31, N'Cachoeira do Piriá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (32, N'Cametá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (33, N'Canaã dos Carajás', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (34, N'Capanema', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (35, N'Capitão Poço', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (36, N'Castanhal', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (37, N'Chaves', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (38, N'Colares', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (39, N'Conceição do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (40, N'Concórdia do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (41, N'Cumaru do Norte', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (42, N'Curionópolis', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (43, N'Curralinho', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (44, N'Curuá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (45, N'Curuçá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (46, N'Dom Eliseu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (47, N'Eldorado dos Carajás', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (48, N'Faro', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (49, N'Floresta do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (50, N'Garrafão do Norte', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (51, N'Goianésia do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (52, N'Gurupá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (53, N'Igarapé-Açu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (54, N'Igarapé-Miri', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (55, N'Inhangapi', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (56, N'Ipixuna do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (57, N'Irituia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (58, N'Itaituba', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (59, N'Itupiranga', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (60, N'Jacareacanga', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (61, N'Jacundá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (62, N'Juruti', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (63, N'Limoeiro do Ajuru', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (64, N'Mãe do Rio', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (65, N'Magalhães Barata', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (66, N'Marabá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (67, N'Maracanã', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (68, N'Marapanim', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (69, N'Marituba', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (70, N'Medicilândia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (71, N'Melgaço', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (72, N'Mocajuba', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (73, N'Moju', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (74, N'Monte', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (75, N'Muaná', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (76, N'Nova Esperança do Piriá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (77, N'Nova Ipixuna', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (78, N'Nova Timboteua', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (79, N'Novo Progresso', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (80, N'Novo Repartimento', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (81, N'Óbidos', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (82, N'Oeiras do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (83, N'Oriximiná', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (84, N'Ourém', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (85, N'Ourilândia do Norte', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (86, N'Pacajá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (87, N'Palestina do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (88, N'Paragominas', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (89, N'Parauapebas', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (90, N'Pau D', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (91, N'Peixe-Boi', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (92, N'Piçarra', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (93, N'Placas', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (94, N'Ponta de Pedras', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (95, N'Portel', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (96, N'Porto de Moz', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (97, N'Prainha', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (98, N'Primavera', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (99, N'Quatipuru', N'A', 15)
GO
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (100, N'Redenção', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (101, N'Rio Maria', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (102, N'Rondon do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (103, N'Rurópolis', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (104, N'Salinópolis', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (105, N'Salvaterra', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (106, N'Santa Bárbara do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (107, N'Santa Cruz do Arari', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (108, N'Santa Isabel do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (109, N'Santa Luzia do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (110, N'Santa Maria das Barreiras', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (111, N'Santa Maria do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (112, N'Santana do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (113, N'Santarém', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (114, N'Santarém Novo', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (115, N'Santo Antônio do Tauá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (116, N'São Caetano de Odivelas', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (117, N'São Domingos do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (118, N'São Domingos do Capim', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (119, N'São Félix do Xingu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (120, N'São Francisco do Pará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (121, N'São Geraldo do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (122, N'São João da Ponta', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (123, N'São João de Pirabas', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (124, N'São João do Araguaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (125, N'São Miguel do Guamá', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (126, N'São Sebastião da Boa', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (127, N'Sapucaia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (128, N'Senador José Porfírio', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (129, N'Soure', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (130, N'Tailândia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (131, N'Terra Alta', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (132, N'Terra Santa', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (133, N'Tomé-Açu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (134, N'Tracuateua', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (135, N'Trairão', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (136, N'Tucumã', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (137, N'Tucuruí', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (138, N'Ulianópolis', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (139, N'Uruará', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (140, N'Vigia', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (141, N'Viseu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (142, N'Vitória do Xingu', N'A', 15)
INSERT [dbo].[GECidade] ([CodigoCidade], [Descricao], [flAtivo], [CodigoUF]) VALUES (143, N'Xinguara', N'A', 15)
SET IDENTITY_INSERT [dbo].[GECidade] OFF
SET IDENTITY_INSERT [dbo].[GEUF] ON 

INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (1, N'Rondônia', N'RO', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (2, N'Acre', N'AC', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (3, N'Amazonas', N'AM', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (4, N'Roraima', N'RR', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (5, N'Pará', N'PA', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (6, N'Amapá', N'AP', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (7, N'Tocantins', N'TO', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (8, N'Maranhão', N'MA', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (9, N'Piauí', N'PI', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (10, N'Ceará', N'CE', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (11, N'Rio Grande do Norte', N'RN', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (12, N'Paraíba', N'PB', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (13, N'Pernambuco', N'PE', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (14, N'Alagoas', N'AL', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (15, N'Sergipe', N'SE', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (16, N'Bahia', N'BA', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (17, N'Minas Gerais', N'MG', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (18, N'Espírito Santo', N'ES', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (19, N'Rio de Janeiro', N'RJ', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (20, N'São Paulo', N'SP', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (21, N'Paraná', N'PR', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (22, N'Santa Catarina', N'SC', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (23, N'Rio Grande do Sul', N'RS', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (24, N'Mato Grosso do Sul', N'MS', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (25, N'Mato Grosso', N'MT', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (26, N'Goiás', N'GO', N'A')
INSERT [dbo].[GEUF] ([CodigoUF], [Descricao], [Sigla], [flAtivo]) VALUES (27, N'Distrito Federal', N'DF', N'A')
SET IDENTITY_INSERT [dbo].[GEUF] OFF
SET IDENTITY_INSERT [dbo].[SEGPerfil] ON 

INSERT [dbo].[SEGPerfil] ([CoigoPerfil], [Descricao], [flAtivo]) VALUES (1, N'Administrador', N'A')
INSERT [dbo].[SEGPerfil] ([CoigoPerfil], [Descricao], [flAtivo]) VALUES (2, N'Professor', N'A')
INSERT [dbo].[SEGPerfil] ([CoigoPerfil], [Descricao], [flAtivo]) VALUES (3, N'Aluno', N'A')
INSERT [dbo].[SEGPerfil] ([CoigoPerfil], [Descricao], [flAtivo]) VALUES (4, N'Responsável', N'A')
SET IDENTITY_INSERT [dbo].[SEGPerfil] OFF
/****** Object:  Index [IX_ACAluno_CodigoEndereco]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACAluno_CodigoEndereco] ON [dbo].[ACAluno]
(
	[CodigoEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACAluno_CodigoResponsavel]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACAluno_CodigoResponsavel] ON [dbo].[ACAluno]
(
	[CodigoResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACAluno_CodigoUsuario]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACAluno_CodigoUsuario] ON [dbo].[ACAluno]
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACCategoria_CodigoFaixaEtaria]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACCategoria_CodigoFaixaEtaria] ON [dbo].[ACCategoria]
(
	[CodigoFaixaEtaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACMatricula_CodigoAluno]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACMatricula_CodigoAluno] ON [dbo].[ACMatricula]
(
	[CodigoAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACProfessor_CodigoUsuario]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACProfessor_CodigoUsuario] ON [dbo].[ACProfessor]
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACResponsavel_CodigoEndereco]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACResponsavel_CodigoEndereco] ON [dbo].[ACResponsavel]
(
	[CodigoEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACResponsavel_CodigoUsuario]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACResponsavel_CodigoUsuario] ON [dbo].[ACResponsavel]
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACTurma_CodigoCategoria]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACTurma_CodigoCategoria] ON [dbo].[ACTurma]
(
	[CodigoCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ACTurma_CodigoProfessor]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_ACTurma_CodigoProfessor] ON [dbo].[ACTurma]
(
	[CodigoProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 15/01/2019 16:45:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 15/01/2019 16:45:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FIMensalidade_CodigoMatricula]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_FIMensalidade_CodigoMatricula] ON [dbo].[FIMensalidade]
(
	[CodigoMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GEBairro_CodigoCidade]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_GEBairro_CodigoCidade] ON [dbo].[GEBairro]
(
	[CodigoCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GECidade_CodigoUF]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_GECidade_CodigoUF] ON [dbo].[GECidade]
(
	[CodigoUF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GEEndereco_CodigoBairro]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_GEEndereco_CodigoBairro] ON [dbo].[GEEndereco]
(
	[CodigoBairro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GETelefone_CodigoTipoTelefone]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_GETelefone_CodigoTipoTelefone] ON [dbo].[GETelefone]
(
	[CodigoTipoTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SEGUsuarioPerfil_CodigoPerfil]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_SEGUsuarioPerfil_CodigoPerfil] ON [dbo].[SEGUsuarioPerfil]
(
	[CodigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_SEGUsuarioPerfil_CodigoUsuario]    Script Date: 15/01/2019 16:45:29 ******/
CREATE NONCLUSTERED INDEX [IX_SEGUsuarioPerfil_CodigoUsuario] ON [dbo].[SEGUsuarioPerfil]
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ACAluno]  WITH CHECK ADD  CONSTRAINT [FK_ACAluno_ACResponsavel_CodigoResponsavel] FOREIGN KEY([CodigoResponsavel])
REFERENCES [dbo].[ACResponsavel] ([CodigoResponsavel])
GO
ALTER TABLE [dbo].[ACAluno] CHECK CONSTRAINT [FK_ACAluno_ACResponsavel_CodigoResponsavel]
GO
ALTER TABLE [dbo].[ACAluno]  WITH CHECK ADD  CONSTRAINT [FK_ACAluno_GEEndereco_CodigoEndereco] FOREIGN KEY([CodigoEndereco])
REFERENCES [dbo].[GEEndereco] ([CodigoEndereco])
GO
ALTER TABLE [dbo].[ACAluno] CHECK CONSTRAINT [FK_ACAluno_GEEndereco_CodigoEndereco]
GO
ALTER TABLE [dbo].[ACAluno]  WITH CHECK ADD  CONSTRAINT [FK_ACAluno_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACAluno] CHECK CONSTRAINT [FK_ACAluno_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACCategoria]  WITH CHECK ADD  CONSTRAINT [FK_ACCategoria_ACFaixaEtaria_CodigoFaixaEtaria] FOREIGN KEY([CodigoFaixaEtaria])
REFERENCES [dbo].[ACFaixaEtaria] ([CodigoFaixaEtaria])
GO
ALTER TABLE [dbo].[ACCategoria] CHECK CONSTRAINT [FK_ACCategoria_ACFaixaEtaria_CodigoFaixaEtaria]
GO
ALTER TABLE [dbo].[ACMatricula]  WITH CHECK ADD  CONSTRAINT [FK_ACMatricula_ACAluno_CodigoAluno] FOREIGN KEY([CodigoAluno])
REFERENCES [dbo].[ACAluno] ([CodigoALuno])
GO
ALTER TABLE [dbo].[ACMatricula] CHECK CONSTRAINT [FK_ACMatricula_ACAluno_CodigoAluno]
GO
ALTER TABLE [dbo].[ACProfessor]  WITH CHECK ADD  CONSTRAINT [FK_ACProfessor_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACProfessor] CHECK CONSTRAINT [FK_ACProfessor_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACResponsavel_GEEndereco_CodigoEndereco] FOREIGN KEY([CodigoEndereco])
REFERENCES [dbo].[GEEndereco] ([CodigoEndereco])
GO
ALTER TABLE [dbo].[ACResponsavel] CHECK CONSTRAINT [FK_ACResponsavel_GEEndereco_CodigoEndereco]
GO
ALTER TABLE [dbo].[ACResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACResponsavel_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACResponsavel] CHECK CONSTRAINT [FK_ACResponsavel_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACTurma]  WITH CHECK ADD  CONSTRAINT [FK_ACTurma_ACCategoria_CodigoCategoria] FOREIGN KEY([CodigoCategoria])
REFERENCES [dbo].[ACCategoria] ([CodigoCategoria])
GO
ALTER TABLE [dbo].[ACTurma] CHECK CONSTRAINT [FK_ACTurma_ACCategoria_CodigoCategoria]
GO
ALTER TABLE [dbo].[ACTurma]  WITH CHECK ADD  CONSTRAINT [FK_ACTurma_ACProfessor_CodigoProfessor] FOREIGN KEY([CodigoProfessor])
REFERENCES [dbo].[ACProfessor] ([CodigoProfessor])
GO
ALTER TABLE [dbo].[ACTurma] CHECK CONSTRAINT [FK_ACTurma_ACProfessor_CodigoProfessor]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[FIMensalidade]  WITH CHECK ADD  CONSTRAINT [FK_FIMensalidade_ACMatricula_CodigoMatricula] FOREIGN KEY([CodigoMatricula])
REFERENCES [dbo].[ACMatricula] ([CoodigoMatricula])
GO
ALTER TABLE [dbo].[FIMensalidade] CHECK CONSTRAINT [FK_FIMensalidade_ACMatricula_CodigoMatricula]
GO
ALTER TABLE [dbo].[GEBairro]  WITH CHECK ADD  CONSTRAINT [FK_GEBairro_GECidade_CodigoCidade] FOREIGN KEY([CodigoCidade])
REFERENCES [dbo].[GECidade] ([CodigoCidade])
GO
ALTER TABLE [dbo].[GEBairro] CHECK CONSTRAINT [FK_GEBairro_GECidade_CodigoCidade]
GO
ALTER TABLE [dbo].[GECidade]  WITH CHECK ADD  CONSTRAINT [FK_GECidade_GEUF_CodigoUF] FOREIGN KEY([CodigoUF])
REFERENCES [dbo].[GEUF] ([CodigoUF])
GO
ALTER TABLE [dbo].[GECidade] CHECK CONSTRAINT [FK_GECidade_GEUF_CodigoUF]
GO
ALTER TABLE [dbo].[GEEndereco]  WITH CHECK ADD  CONSTRAINT [FK_GEEndereco_GEBairro_CodigoBairro] FOREIGN KEY([CodigoBairro])
REFERENCES [dbo].[GEBairro] ([CodigoBairro])
GO
ALTER TABLE [dbo].[GEEndereco] CHECK CONSTRAINT [FK_GEEndereco_GEBairro_CodigoBairro]
GO
ALTER TABLE [dbo].[GETelefone]  WITH CHECK ADD  CONSTRAINT [FK_GETelefone_GETipoTelefone_CodigoTipoTelefone] FOREIGN KEY([CodigoTipoTelefone])
REFERENCES [dbo].[GETipoTelefone] ([CodigoTipoTelefone])
GO
ALTER TABLE [dbo].[GETelefone] CHECK CONSTRAINT [FK_GETelefone_GETipoTelefone_CodigoTipoTelefone]
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_SEGUsuarioPerfil_SEGPerfil_CodigoPerfil] FOREIGN KEY([CodigoPerfil])
REFERENCES [dbo].[SEGPerfil] ([CoigoPerfil])
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil] CHECK CONSTRAINT [FK_SEGUsuarioPerfil_SEGPerfil_CodigoPerfil]
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_SEGUsuarioPerfil_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil] CHECK CONSTRAINT [FK_SEGUsuarioPerfil_SEGUsuario_CodigoUsuario]
GO
USE [master]
GO
ALTER DATABASE [One] SET  READ_WRITE 
GO
