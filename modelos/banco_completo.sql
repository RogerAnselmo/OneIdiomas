USE [One]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[ACAluno]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACAluno](
	[CodigoAluno] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [nvarchar](200) NOT NULL,
	[RG] [nvarchar](20) NULL,
	[CPF] [nvarchar](11) NULL,
	[Sexo] [nvarchar](1) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[DiaVencimento] [int] NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACAluno] PRIMARY KEY CLUSTERED 
(
	[CodigoAluno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACAlunoResponsavel]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACAlunoResponsavel](
	[CodigoAlunoResponsavel] [int] IDENTITY(1,1) NOT NULL,
	[CodigoAluno] [int] NOT NULL,
	[CodigoResponsavel] [int] NOT NULL,
	[CodigoParentesco] [int] NOT NULL,
 CONSTRAINT [PK_ACAlunoResponsavel] PRIMARY KEY CLUSTERED 
(
	[CodigoAlunoResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACAvaliacao]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACAvaliacao](
	[CodigoAvaliacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](500) NOT NULL,
	[DataAvaliacao] [datetime2](7) NOT NULL,
	[flSituacao] [nvarchar](1) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[NotaAvaliacao] [decimal](18, 2) NOT NULL,
	[CodigoMatricula] [int] NOT NULL,
 CONSTRAINT [PK_ACAvaliacao] PRIMARY KEY CLUSTERED 
(
	[CodigoAvaliacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACEstagio]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACEstagio](
	[CodigoEstagio] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoFaixaEtaria] [int] NOT NULL,
 CONSTRAINT [PK_ACEstagio] PRIMARY KEY CLUSTERED 
(
	[CodigoEstagio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACFaixaEtaria]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[ACFrequencia]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACFrequencia](
	[Codigofrequencia] [int] IDENTITY(1,1) NOT NULL,
	[flSituacao] [nvarchar](1) NOT NULL,
	[DataFrequencia] [datetime2](7) NOT NULL,
	[Observacao] [nvarchar](500) NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoMatricula] [int] NOT NULL,
 CONSTRAINT [PK_ACFrequencia] PRIMARY KEY CLUSTERED 
(
	[Codigofrequencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACMatricula]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACMatricula](
	[CodigoMatricula] [int] IDENTITY(1,1) NOT NULL,
	[CodigoIdentificador] [nvarchar](max) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoAluno] [int] NOT NULL,
	[CodigoTurma] [int] NOT NULL,
 CONSTRAINT [PK_ACMatricula] PRIMARY KEY CLUSTERED 
(
	[CodigoMatricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACProfessor]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACProfessor](
	[CodigoProfessor] [int] IDENTITY(1,1) NOT NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACProfessor] PRIMARY KEY CLUSTERED 
(
	[CodigoProfessor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACResponsavel]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ACResponsavel](
	[CodigoResponsavel] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [nvarchar](200) NOT NULL,
	[RG] [nvarchar](20) NULL,
	[CPF] [nvarchar](11) NULL,
	[Sexo] [nvarchar](1) NULL,
	[DataNascimento] [datetime2](7) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_ACResponsavel] PRIMARY KEY CLUSTERED 
(
	[CodigoResponsavel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ACTurma]    Script Date: 28/02/2019 16:23:57 ******/
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
	[CodigoEstagio] [int] NOT NULL,
	[CodigoProfessor] [int] NOT NULL,
 CONSTRAINT [PK_ACTurma] PRIMARY KEY CLUSTERED 
(
	[CodigoTurma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[FIMensalidade]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FIMensalidade](
	[CodigoMensalidade] [int] IDENTITY(1,1) NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [datetime2](7) NOT NULL,
	[DataPagamento] [datetime2](7) NOT NULL,
	[DataEmissao] [datetime2](7) NOT NULL,
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
/****** Object:  Table [dbo].[GEBairro]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[GECidade]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[GEEndereco]    Script Date: 28/02/2019 16:23:57 ******/
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
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_GEEndereco] PRIMARY KEY CLUSTERED 
(
	[CodigoEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GEParentesco]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GEParentesco](
	[CodigoParentesco] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](60) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_GEParentesco] PRIMARY KEY CLUSTERED 
(
	[CodigoParentesco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GETelefone]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GETelefone](
	[CodigoTelefone] [int] IDENTITY(1,1) NOT NULL,
	[NumeroTelefone] [nvarchar](20) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
	[CodigoTipoTelefone] [int] NOT NULL,
	[CodigoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_GETelefone] PRIMARY KEY CLUSTERED 
(
	[CodigoTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GETipoTelefone]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[GEUF]    Script Date: 28/02/2019 16:23:57 ******/
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
/****** Object:  Table [dbo].[SEGPerfil]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGPerfil](
	[CodigoPerfil] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](30) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_SEGPerfil] PRIMARY KEY CLUSTERED 
(
	[CodigoPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEGUsuario]    Script Date: 28/02/2019 16:23:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGUsuario](
	[CodigoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NomeCompleto] [nvarchar](200) NOT NULL,
	[Login] [nvarchar](100) NOT NULL,
	[flAtivo] [nvarchar](1) NOT NULL,
 CONSTRAINT [PK_SEGUsuario] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SEGUsuarioPerfil]    Script Date: 28/02/2019 16:23:57 ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190228191241_inicio', N'2.1.4-rtm-31024')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4915e4ac-69c5-4a20-95a9-99356e481c89', N'cranselmo', N'CRANSELMO', N'cranselmo', N'CRANSELMO', 0, N'AQAAAAEAACcQAAAAECKlygxXLnLXbJ+Y2OP7q0y2rPy4D9oF4b7MyejPvfsDF7AZGNZ1m4tImxbo+E/V5w==', N'XPOG6DNDNACNQAQOKPZUP5RW3FJFPVYI', N'bffda5bc-bbcf-4e37-83a4-96431bed27f2', NULL, 0, 0, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[GEBairro] ON 

INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (1, N'Centro', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (2, N'Aviação', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (3, N'Angélica', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (4, N'Cristo Redentor', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (5, N'São Lourenço', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (6, N'Algodoal', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (7, N'Colônia Velha', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (8, N'São Sebastião', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (9, N'Francilândia', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (10, N'Multirão', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (11, N'São José', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (12, N'Santa Rosa', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (13, N'Vila de Beja', N'A', 1)
INSERT [dbo].[GEBairro] ([CodigoBairro], [descricao], [flAtivo], [CodigoCidade]) VALUES (14, N'Zona Rural', N'A', 1)
SET IDENTITY_INSERT [dbo].[GEBairro] OFF
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

INSERT [dbo].[SEGPerfil] ([CodigoPerfil], [Descricao], [flAtivo]) VALUES (1, N'Administrador', N'A')
INSERT [dbo].[SEGPerfil] ([CodigoPerfil], [Descricao], [flAtivo]) VALUES (2, N'Professor', N'A')
INSERT [dbo].[SEGPerfil] ([CodigoPerfil], [Descricao], [flAtivo]) VALUES (3, N'Aluno', N'A')
INSERT [dbo].[SEGPerfil] ([CodigoPerfil], [Descricao], [flAtivo]) VALUES (4, N'Responsável', N'A')
SET IDENTITY_INSERT [dbo].[SEGPerfil] OFF
SET IDENTITY_INSERT [dbo].[SEGUsuario] ON 

INSERT [dbo].[SEGUsuario] ([CodigoUsuario], [NomeCompleto], [Login], [flAtivo]) VALUES (2, N'Carlos Rogério Campos Anselmo', N'cranselmo', N'A')
INSERT [dbo].[SEGUsuario] ([CodigoUsuario], [NomeCompleto], [Login], [flAtivo]) VALUES (3, N'Neto Costa', N'neto.costa', N'A')
INSERT [dbo].[SEGUsuario] ([CodigoUsuario], [NomeCompleto], [Login], [flAtivo]) VALUES (4, N'Rogério Anselmo', N'rogerio.anselmo', N'A')
INSERT [dbo].[SEGUsuario] ([CodigoUsuario], [NomeCompleto], [Login], [flAtivo]) VALUES (5, N'Fábio Vale', N'fabio.vale', N'A')
SET IDENTITY_INSERT [dbo].[SEGUsuario] OFF
SET IDENTITY_INSERT [dbo].[SEGUsuarioPerfil] ON 

INSERT [dbo].[SEGUsuarioPerfil] ([CodigoUsuarioPerfil], [CodigoPerfilPadrao], [CodigoUsuario], [CodigoPerfil]) VALUES (2, 1, 2, 1)
INSERT [dbo].[SEGUsuarioPerfil] ([CodigoUsuarioPerfil], [CodigoPerfilPadrao], [CodigoUsuario], [CodigoPerfil]) VALUES (3, 1, 3, 1)
SET IDENTITY_INSERT [dbo].[SEGUsuarioPerfil] OFF
ALTER TABLE [dbo].[ACAluno]  WITH CHECK ADD  CONSTRAINT [FK_ACAluno_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACAluno] CHECK CONSTRAINT [FK_ACAluno_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACAlunoResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACAlunoResponsavel_ACAluno_CodigoAluno] FOREIGN KEY([CodigoAluno])
REFERENCES [dbo].[ACAluno] ([CodigoAluno])
GO
ALTER TABLE [dbo].[ACAlunoResponsavel] CHECK CONSTRAINT [FK_ACAlunoResponsavel_ACAluno_CodigoAluno]
GO
ALTER TABLE [dbo].[ACAlunoResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACAlunoResponsavel_ACResponsavel_CodigoResponsavel] FOREIGN KEY([CodigoResponsavel])
REFERENCES [dbo].[ACResponsavel] ([CodigoResponsavel])
GO
ALTER TABLE [dbo].[ACAlunoResponsavel] CHECK CONSTRAINT [FK_ACAlunoResponsavel_ACResponsavel_CodigoResponsavel]
GO
ALTER TABLE [dbo].[ACAlunoResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACAlunoResponsavel_GEParentesco_CodigoParentesco] FOREIGN KEY([CodigoParentesco])
REFERENCES [dbo].[GEParentesco] ([CodigoParentesco])
GO
ALTER TABLE [dbo].[ACAlunoResponsavel] CHECK CONSTRAINT [FK_ACAlunoResponsavel_GEParentesco_CodigoParentesco]
GO
ALTER TABLE [dbo].[ACAvaliacao]  WITH CHECK ADD  CONSTRAINT [FK_ACAvaliacao_ACMatricula_CodigoMatricula] FOREIGN KEY([CodigoMatricula])
REFERENCES [dbo].[ACMatricula] ([CodigoMatricula])
GO
ALTER TABLE [dbo].[ACAvaliacao] CHECK CONSTRAINT [FK_ACAvaliacao_ACMatricula_CodigoMatricula]
GO
ALTER TABLE [dbo].[ACEstagio]  WITH CHECK ADD  CONSTRAINT [FK_ACEstagio_ACFaixaEtaria_CodigoFaixaEtaria] FOREIGN KEY([CodigoFaixaEtaria])
REFERENCES [dbo].[ACFaixaEtaria] ([CodigoFaixaEtaria])
GO
ALTER TABLE [dbo].[ACEstagio] CHECK CONSTRAINT [FK_ACEstagio_ACFaixaEtaria_CodigoFaixaEtaria]
GO
ALTER TABLE [dbo].[ACFrequencia]  WITH CHECK ADD  CONSTRAINT [FK_ACFrequencia_ACMatricula_CodigoMatricula] FOREIGN KEY([CodigoMatricula])
REFERENCES [dbo].[ACMatricula] ([CodigoMatricula])
GO
ALTER TABLE [dbo].[ACFrequencia] CHECK CONSTRAINT [FK_ACFrequencia_ACMatricula_CodigoMatricula]
GO
ALTER TABLE [dbo].[ACMatricula]  WITH CHECK ADD  CONSTRAINT [FK_ACMatricula_ACAluno_CodigoAluno] FOREIGN KEY([CodigoAluno])
REFERENCES [dbo].[ACAluno] ([CodigoAluno])
GO
ALTER TABLE [dbo].[ACMatricula] CHECK CONSTRAINT [FK_ACMatricula_ACAluno_CodigoAluno]
GO
ALTER TABLE [dbo].[ACMatricula]  WITH CHECK ADD  CONSTRAINT [FK_ACMatricula_ACTurma_CodigoTurma] FOREIGN KEY([CodigoTurma])
REFERENCES [dbo].[ACTurma] ([CodigoTurma])
GO
ALTER TABLE [dbo].[ACMatricula] CHECK CONSTRAINT [FK_ACMatricula_ACTurma_CodigoTurma]
GO
ALTER TABLE [dbo].[ACProfessor]  WITH CHECK ADD  CONSTRAINT [FK_ACProfessor_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACProfessor] CHECK CONSTRAINT [FK_ACProfessor_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACResponsavel]  WITH CHECK ADD  CONSTRAINT [FK_ACResponsavel_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[ACResponsavel] CHECK CONSTRAINT [FK_ACResponsavel_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[ACTurma]  WITH CHECK ADD  CONSTRAINT [FK_ACTurma_ACEstagio_CodigoEstagio] FOREIGN KEY([CodigoEstagio])
REFERENCES [dbo].[ACEstagio] ([CodigoEstagio])
GO
ALTER TABLE [dbo].[ACTurma] CHECK CONSTRAINT [FK_ACTurma_ACEstagio_CodigoEstagio]
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
REFERENCES [dbo].[ACMatricula] ([CodigoMatricula])
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
ALTER TABLE [dbo].[GEEndereco]  WITH CHECK ADD  CONSTRAINT [FK_GEEndereco_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[GEEndereco] CHECK CONSTRAINT [FK_GEEndereco_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[GETelefone]  WITH CHECK ADD  CONSTRAINT [FK_GETelefone_GETipoTelefone_CodigoTipoTelefone] FOREIGN KEY([CodigoTipoTelefone])
REFERENCES [dbo].[GETipoTelefone] ([CodigoTipoTelefone])
GO
ALTER TABLE [dbo].[GETelefone] CHECK CONSTRAINT [FK_GETelefone_GETipoTelefone_CodigoTipoTelefone]
GO
ALTER TABLE [dbo].[GETelefone]  WITH CHECK ADD  CONSTRAINT [FK_GETelefone_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[GETelefone] CHECK CONSTRAINT [FK_GETelefone_SEGUsuario_CodigoUsuario]
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_SEGUsuarioPerfil_SEGPerfil_CodigoPerfil] FOREIGN KEY([CodigoPerfil])
REFERENCES [dbo].[SEGPerfil] ([CodigoPerfil])
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil] CHECK CONSTRAINT [FK_SEGUsuarioPerfil_SEGPerfil_CodigoPerfil]
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil]  WITH CHECK ADD  CONSTRAINT [FK_SEGUsuarioPerfil_SEGUsuario_CodigoUsuario] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[SEGUsuario] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[SEGUsuarioPerfil] CHECK CONSTRAINT [FK_SEGUsuarioPerfil_SEGUsuario_CodigoUsuario]
GO
