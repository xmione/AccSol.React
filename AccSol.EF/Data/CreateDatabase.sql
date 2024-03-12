IF NOT EXISTS (
    SELECT [name] 
    FROM sys.databases 
    WHERE [name] = N'aspnet-AccSol-4e738ad6-a4fd-4a62-8afa-6641a1ee333c'
)
BEGIN
    CREATE DATABASE [aspnet-AccSol-4e738ad6-a4fd-4a62-8afa-6641a1ee333c]
END
GO

USE [aspnet-AccSol-4e738ad6-a4fd-4a62-8afa-6641a1ee333c]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserTokens]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetUserTokens] DROP CONSTRAINT IF EXISTS [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT IF EXISTS [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserRoles]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT IF EXISTS [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserLogins]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT IF EXISTS [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetUserClaims]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT IF EXISTS [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AspNetRoleClaims]') AND type in (N'U'))
ALTER TABLE [dbo].[AspNetRoleClaims] DROP CONSTRAINT IF EXISTS [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
/****** Object:  Index [IX_PettyCashes_PCFNo]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [IX_PettyCashes_PCFNo] ON [dbo].[PettyCashes]
GO
/****** Object:  Index [UserNameIndex]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [UserNameIndex] ON [dbo].[AspNetUsers]
GO
/****** Object:  Index [EmailIndex]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [EmailIndex] ON [dbo].[AspNetUsers]
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [RoleNameIndex] ON [dbo].[AspNetRoles]
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP INDEX IF EXISTS [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
GO
/****** Object:  Table [dbo].[ProjectCategorys]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[ProjectCategorys]
GO
/****** Object:  Table [dbo].[PettyCashes]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[PettyCashes]
GO
/****** Object:  Table [dbo].[JournalEntries]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[JournalEntries]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[Employees]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[Departments]
GO
/****** Object:  Table [dbo].[Coas]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[Coas]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[Clients]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetUserTokens]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetUsers]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetUserRoles]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetUserLogins]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetUserClaims]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetRoles]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[AspNetRoleClaims]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/25/2024 10:38:49 AM ******/
DROP TABLE IF EXISTS [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 1/25/2024 10:38:49 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coas]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](max) NULL,
	[SubCategory] [nvarchar](max) NULL,
	[AccountName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Coas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[MiddleName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[DepartmentID] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JournalEntries]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JournalEntries](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PettyCashID] [int] NULL,
	[CoaID] [int] NULL,
	[Debit] [decimal](18, 2) NULL,
	[Credit] [decimal](18, 2) NULL,
 CONSTRAINT [PK_JournalEntries] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PettyCashes]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PettyCashes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PCFNo] [nvarchar](255) NOT NULL,
	[Date] [datetime2](7) NULL,
	[Payee] [nvarchar](max) NULL,
	[Particulars] [nvarchar](max) NULL,
	[ClientID] [int] NULL,
	[ProjectCategoryID] [int] NULL,
	[Amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_PettyCashes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectCategorys]    Script Date: 1/25/2024 10:38:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectCategorys](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProjectCategorys] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240105031633_InitialCreate', N'8.0.0')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'217b866d-86bc-44e6-bc37-fa73546a8dc2', N'solomiosisante@gmail.com', N'SOLOMIOSISANTE@GMAIL.COM', N'solomiosisante@gmail.com', N'SOLOMIOSISANTE@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAELC440+IgiPmgMLnxtWeCLh4c3uogVJh6a936RrbP2JCDKoJjBBd5/WzUund2MfP2Q==', N'LO7OZUBK2XSPHZNVOO4KJDI3GJ426WOJ', N'7fce0d99-6d77-469b-8f92-315bb7dcbb36', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (16, N'ABOITIZ POWER CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (17, N'AGRICULTURAL TRAINING INSTITUTE')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (18, N'AMMIC PHILIPPINES, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (19, N'ANTI-MONEY LAUNDERING COUNCIL')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (20, N'AP RENEWABLES INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (21, N'ARMED FORCES AND POLICIES SAVINGS AND LOAN ASSOCIATION INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (22, N'ASCENDER INNOVATION, OPC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (23, N'ASEANA HOLDINGS INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (24, N'ASSURED ASSET MANAGEMENT LIMITED')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (25, N'BALAMBAN ENERZONE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (26, N'BANCNET, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (27, N'BDO UNIBANK, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (28, N'BUREAU OF INTERNAL REVENUE')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (29, N'CASTILLO CUI LAW OFFICE')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (30, N'CENTURY PACIFIC FOOD INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (31, N'CHINA BANKING CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (32, N'CHIYODA PHILIPPINES CORP')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (33, N'CHONG HUA HOSPITAL')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (34, N'CONVERGE INFORMATION TECHNOLOGY SOLUTIONS, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (35, N'COTABATO LIGHT AND POWER COMPANY')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (36, N'DAVAO LIGHT AND POWER CO, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (37, N'DEPARTMENT OF INFORMATION AND COMMUNICATIONS TECHNOLOGY')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (38, N'DEPARTMENT OF NATIONAL DEFENSE')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (39, N'DITO TELECOMMUNITY CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (40, N'DUTY FREE PHILIPPINES INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (41, N'ENTREGO FULFILLMENT SOLUTIONS INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (42, N'FIRST OCEANIC PROPERTY MANAGEMENT INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (43, N'GATMAYTAN YAP PATACSIL GUTIRREZ AND PROTACIO')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (44, N'GOVERNANCE COMMISSION FOR GOVERNMENT OWNED OR CONTROLLED CORPS')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (45, N'GUR LAVI CORP.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (46, N'G-XCHANGE, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (47, N'H VILLARICA PAWNSHOP INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (48, N'HEDCOR BUKIDNON, INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (49, N'HEDCOR SABANGAN, INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (50, N'HEDCOR SIBULAN, INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (51, N'HEDCOR, INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (52, N'HL VILLARICA PAWNSHOP INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (53, N'HRV VILLARICA PAWNSHOP INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (54, N'INFINIT-O GLOBAL LIMITED')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (55, N'INSPIRO RELIA INCORPORATED')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (56, N'INSULAR HEALTH CARE INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (57, N'JG SUMMIT HOLDINGS INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (58, N'KAREILA MANAGEMENT CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (59, N'KUMUMEDIA INTERNATIONAL PTE. LTD')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (60, N'LIMA ENERZONE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (61, N'LUZON HYDRO CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (62, N'MACTAN ENERZONE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (63, N'MALVAR ENERZONE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (64, N'MANILA-OSLO RENEWABLE ENTERPRISE INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (65, N'METRO PACIFIC TOLLWAYS DIGITAL INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (66, N'MOONRICH SOLUTIONS LTD')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (67, N'NATIONAL CENTER FOR MENTAL HEALTH')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (68, N'NATIONAL INTELLIGENCE COORDINATING AGENCY (NICA)')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (69, N'NATIONAL PRIVACY COMMISSION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (70, N'ONCO CARE PHARMA CORP')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (71, N'ONE ALPHA COMM INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (72, N'ORIENT CAPITAL VENTURES INC. (MSW Madison Square)')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (73, N'ORIENT CAPITAL VENTURES INC. (MSW Olongapo)')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (74, N'ORIENT CAPITAL VENTURES INC. (MSW Tomas Morato)')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (75, N'ORIENT CAPITAL VENTURES INC. (ROYAL PLACE)')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (76, N'PEARL GRACE SHIP MANAGEMENT INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (77, N'PHILIPPINE AIRLINES')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (78, N'PHILIPPINE ASSOCIATED SMELTING AND REFINING CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (79, N'PHILIPPINE BRITISH ASSURANCE COMPANY, INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (80, N'PHILIPPINE DIGITAL ASSET EXCHANGE (PDAX) INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (81, N'PHILIPPINE NATIONAL POLICE')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (82, N'PIONEER INSURANCE & SURETY CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (83, N'PRIME INFRASTRUCTURE CAPITAL INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (84, N'PRIME METRO BMD CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (85, N'PUNONGBAYAN & ARAULLO')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (86, N'PV SINAG POWER INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (87, N'ROBINSONS BANK CORP.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (88, N'SAN CARLOS SUN POWER INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (89, N'SAN MIGUEL CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (90, N'SCIENCE EDUC INST')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (91, N'SECURITY BANK CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (92, N'SEMIRARA MINING AND POWER CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (93, N'SENATE ELECTORAL TRIBUNAL')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (94, N'SHOPBACK COMPANY PHILIPPINES INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (95, N'SKY CABLE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (96, N'SM HOTELS AND CONVENTIONS CORP')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (97, N'SM PRIME HOLDINGS INC-NORTH EDSA')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (98, N'SM PRIME HOLDINGS INC-PICO SANDS')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (99, N'SM PRIME HOLDINGS INC-TAAL VISTA')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (100, N'SMITS INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (101, N'SN ABOITIZ POWER - BENGUET INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (102, N'SN ABOITIZ POWER - MAGAT INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (103, N'SOCIAL SECURITY SYSTEM')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (104, N'SPECIALTY PULP MANUFACTURING INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (105, N'STERLING INSURANCE COMPANY INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (106, N'STRADCOM CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (107, N'SUBIC ENERZONE CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (108, N'THE INSULAR LIFE ASSURANCE COMPANY LTD.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (109, N'THERMA LUZON, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (110, N'THERMA MOBILE, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (111, N'TIGER RESORT, LEISURE & ENTERTAINMENT, INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (112, N'TPSC PHILIPPINES CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (113, N'TRAXION PAY INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (114, N'TRAXION TECH INC')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (115, N'TSM SHIPPING (PHILS.), INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (116, N'UBX PHILIPPINES CORPORATION')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (117, N'UNION DIGITAL BANK INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (118, N'UNIONBANK OF THE PHILIPPINES')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (119, N'UNIVERSAL ACCESS & SYSTEMS SOLUTIONS INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (120, N'UNIVERSITY OF THE PHILIPPINES DILIMAN')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (121, N'VENN BIOSCIENCES INCORPORATED')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (122, N'VILLARICA PAWNSHOP INC.')
GO
INSERT [dbo].[Clients] ([ID], [Name]) VALUES (123, N'VISAYAN ELECTRIC CO, INC.')
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[Coas] ON 
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (1, N'ASSETS', N' CASH  ', N'Cash in bank - AUB USD')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (2, N'ASSETS', N' CASH  ', N'Cash in bank - AUB Savings')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (3, N'ASSETS', N' CASH  ', N'Cash in bank - BDO')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (4, N'ASSETS', N' CASH  ', N'Cash in bank - BPI')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (5, N'ASSETS', N' CASH  ', N'Cash in bank - Eastwest bank')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (6, N'ASSETS', N' CASH  ', N'Cash in bank - PBCom')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (7, N'ASSETS', N' CASH  ', N'Cash in bank - PNB Savings')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (8, N'ASSETS', N' CASH  ', N'Petty Cash Fund- Office')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (9, N'ASSETS', N' CASH  ', N'Cash in bank - RCBC')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (10, N'ASSETS', N' CASH  ', N'Cash on hand')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (11, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Accounts receivable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (12, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Accounts Receivable-Employees')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (13, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Advances from employees')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (14, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Other receivable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (15, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Advances to suppliers')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (16, N'ASSETS', N' TRADE AND OTHER RECEIVABLES ', N'Cash Advance')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (17, N'ASSETS', N' INVENTORIES ', N'Inventory asset')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (18, N'ASSETS', N' INVENTORIES ', N'Training Kit')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (19, N'ASSETS', N' INVENTORIES ', N'Office supplies inventory')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (20, N'ASSETS', N'OTHER CURRENT ASSETS', N'Input VAT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (21, N'ASSETS', N'OTHER CURRENT ASSETS', N'Deferred Input VAT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (22, N'ASSETS', N'OTHER CURRENT ASSETS', N'Creditable income tax')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (23, N'ASSETS', N'OTHER CURRENT ASSETS', N'Creditable input VAT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (24, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Expenses')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (25, N'ASSETS', N'OTHER CURRENT ASSETS', N'Security Deposit')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (26, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Rental')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (27, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Taxes')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (28, N'ASSETS', N'OTHER CURRENT ASSETS', N'Prepaid Insurance')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (29, N'ASSETS', N'OTHER CURRENT ASSETS', N'Rental Deposit')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (30, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Computer Equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (31, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accumulated Depreciation - comp. equip.')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (32, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Furniture and Fixtures')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (33, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - furnitures and fixtures')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (34, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Leasehold Improvement')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (35, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - leasehold improvement')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (36, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Office equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (37, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - office equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (38, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Transportation equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (39, N'ASSETS', N'PROPERTY AND EQUIPMENT', N'Accum. Dep. - transportation equip.')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (40, N'ASSETS', N'OTHER NON - CURRENT ASSETS', N'Deferred tax asset')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (41, N'ASSETS', N'OTHER NON - CURRENT ASSETS', N'Bonds-Refundable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (42, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Accounts payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (43, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Salaries Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (44, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Accounts payable - USD')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (45, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Advances - Others')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (46, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Security deposit - Converge')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (47, N' LIABILITIES ', N'ACCOUNTS PAYABLE', N'Advances from Customers')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (48, N' LIABILITIES ', N'OTHER PAYABLES', N'Income tax payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (49, N' LIABILITIES ', N'OTHER PAYABLES', N'HDMF Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (50, N' LIABILITIES ', N'OTHER PAYABLES', N'HDMF Loan Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (51, N' LIABILITIES ', N'OTHER PAYABLES', N'SSS Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (52, N' LIABILITIES ', N'OTHER PAYABLES', N'SSS Loan Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (53, N' LIABILITIES ', N'OTHER PAYABLES', N'Philhealth Payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (54, N' LIABILITIES ', N'OTHER PAYABLES', N'Expanded withholding tax payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (55, N' LIABILITIES ', N'OTHER PAYABLES', N'Withholding tax payable - compensation')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (56, N' LIABILITIES ', N'OTHER PAYABLES', N'Deferred output VAT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (57, N' LIABILITIES ', N'OTHER PAYABLES', N'Output VAT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (58, N' LIABILITIES ', N'OTHER PAYABLES', N'Output VAT payable')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (59, N' LIABILITIES ', N'ADVANCES FROM STOCKHOLDERS', N'Advances from Stockholders')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (60, N'STOCKHOLDERS EQUITY', N'Equity', N'Capital stock')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (61, N'STOCKHOLDERS EQUITY', N'Equity', N'Retained earnings')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (62, N'STOCKHOLDERS EQUITY', N'Equity', N'Net Income')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (63, N'STOCKHOLDERS EQUITY', N'Equity', N'Prior period adjustment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (64, N'REVENUES', N'', N'Sales - Hardware')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (65, N'REVENUES', N' ', N'Sales - Software')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (66, N'REVENUES', N' ', N'Internet Service Provider')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (67, N'REVENUES', N' ', N'Vulnerability Assessment and Penetration Testing')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (68, N'REVENUES', N' ', N'Technical support')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (69, N'REVENUES', N' ', N'Consultancy')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (70, N'REVENUES', N' ', N'Web Hosting and Management')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (71, N'REVENUES', N' ', N'Installation')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (72, N'REVENUES', N' ', N'Training services')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (73, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Training kit')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (74, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Hardware')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (75, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Software')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (76, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - ISP')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (77, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Web Support')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (78, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Technical Support')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (79, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Training ')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (80, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Consultancy')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (81, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - Installation services')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (82, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'CoS - VAPT')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (83, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Advertising expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (84, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Association dues')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (85, N'COST OF GOODS SOLD', N'Cost of Goods Sold', N'Freight Costs')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (86, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Salaries and wages')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (87, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - SSS Premium')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (88, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - HDMF expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (89, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Philhealth expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (90, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - De-minimis benefits')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (91, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - Employee benefits')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (92, N'COST OF GOODS SOLD', N'Direct Labor (salary)', N'CoS - 13th month pay')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (93, N'OPERATING EXPENSES', N'Salaries and wages', N'Salaries and wages')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (94, N'OPERATING EXPENSES', N'Salaries and wages', N'SSS premium expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (95, N'OPERATING EXPENSES', N'Salaries and wages', N'HDMF expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (96, N'OPERATING EXPENSES', N'Salaries and wages', N'Philhealth expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (97, N'OPERATING EXPENSES', N'Salaries and wages', N'De-minimis benefits')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (98, N'OPERATING EXPENSES', N'Salaries and wages', N'Employee benefits')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (99, N'OPERATING EXPENSES', N'Salaries and wages', N'Employee benefits - HMO')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (100, N'OPERATING EXPENSES', N'Salaries and wages', N'13th month pay')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (101, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp - leasehold improvement')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (102, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp - furnitures and fixtures')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (103, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Office equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (104, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Computer equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (105, N'OPERATING EXPENSES', N'Depreciation expense', N'Dep. Exp. - Transportation equipment')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (106, N'OPERATING EXPENSES', N'', N'Insurance expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (107, N'OPERATING EXPENSES', N'', N'Miscellaneous expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (108, N'OPERATING EXPENSES', N'', N'Office supplies expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (109, N'OPERATING EXPENSES', N'', N'Professional fee')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (110, N'OPERATING EXPENSES', N'', N'Consultancy fee')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (111, N'OPERATING EXPENSES', N'', N'Directors fee')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (112, N'OPERATING EXPENSES', N'', N'Janitorial expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (113, N'OPERATING EXPENSES', N'', N'Rent expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (114, N'OPERATING EXPENSES', N'', N'Repairs and maintenance ')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (115, N'OPERATING EXPENSES', N'', N'Representation expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (116, N'OPERATING EXPENSES', N'', N'Commission expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (117, N'OPERATING EXPENSES', N'', N'Travel and accomodation expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (118, N'OPERATING EXPENSES', N'', N'Taxes and licenses')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (119, N'OPERATING EXPENSES', N'', N'Trainings and seminar')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (120, N'OPERATING EXPENSES', N'', N'Parking and toll fees')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (121, N'OPERATING EXPENSES', N'', N'Gas and Oil')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (122, N'OPERATING EXPENSES', N'', N'Food and meals')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (123, N'OPERATING EXPENSES', N'', N'Transportation expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (124, N'OPERATING EXPENSES', N'', N'Communication expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (125, N'OPERATING EXPENSES', N'', N'Light and water')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (126, N'OTHER INCOME (EXPENSE)', N'', N'Interest income')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (127, N'OTHER INCOME (EXPENSE)', N'', N'Rental Income')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (128, N'OTHER INCOME (EXPENSE)', N'', N'Other income')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (129, N'OTHER INCOME (EXPENSE)', N'', N'Unrealized foreign exchange gain (loss)')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (130, N'OTHER INCOME (EXPENSE)', N'', N'Realized foreign exchange gain (loss)')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (131, N'OTHER INCOME (EXPENSE)', N'', N'Bank service charge')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (132, N'OTHER INCOME (EXPENSE)', N'', N'Income tax expense')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (133, N'ASSET', N'Expenses', N'sol''s beers')
GO
INSERT [dbo].[Coas] ([ID], [Category], [SubCategory], [AccountName]) VALUES (134, N'ASSET', N'Expenses', N'sol''s 2x2')
GO
SET IDENTITY_INSERT [dbo].[Coas] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (1, N'Ma. Divine Grace Valencia', N'C.', N'ABESAMIS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (2, N'Mark Anthony', N'S.', N'ALAURIN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (3, N'Jonhvic', N'O.', N'ALVAREZ', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (4, N'Ma. Rose Anne', N'F.', N'ANCHETA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (5, N'Joselino', N'B.', N'ANG', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (6, N'Karl Patrick', N'C.', N'AÑO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (7, N'Joeffrey Edriel', N'F.', N'BALANGATAN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (8, N'Carl Marvin', N'B.', N'BANCIFRA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (9, N'Angelica', N'F.', N'BAYONA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (10, N'Jimy Henry', N'B.', N'CANLAS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (11, N'Carla Kristel', N'N.', N'CARDENAS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (12, N'Christian', N'M.', N'CIUDADANO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (13, N'Mhark Lawrence', N'L.', N'DICHOS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (14, N'Threcia Mharie', N'S.', N'ESTROPIGAN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (15, N'Norman', N'R.', N'FLORDELIZ', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (16, N'Ryan Merck', N'F.', N'FONTANILLA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (17, N'John Aaron', N'U.', N'GAPAYAO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (18, N'Karl Angelo', N'L.', N'GARAIS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (19, N'James Louis', N'D.', N'GARAY', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (20, N'John Ardy', N'T.', N'GONZAGA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (21, N'Philip Ceasar', N'J.', N'HALLARCES', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (22, N'Newera Lyn', N'F.', N'HIPOLITO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (23, N'Blair Benjamin', N'DC.', N'IGNACIO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (24, N'Honey Grace', N'C.', N'LARA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (25, N'Eric Gerard', N'C.', N'LAREZA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (26, N'Art Benedict', N'C.', N'LIBRE', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (27, N'Timothy Spencer', N'P.', N'LOPEZ', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (28, N'Adreian', N'E."', N'LUCIANO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (29, N'Stephen', N'D.', N'MAGUDDAYAO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (30, N'Rafael Antonio', N'B.', N'MANZANO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (31, N'Jolly', N'B.', N'MANZANO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (32, N'Sante', N'B.', N'MARISCOTES', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (33, N'Justin Ernesto', N'T.', N'MENDOZA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (34, N'O Nam Naomi', N'W.', N'NG', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (35, N'Sze Yu Famous', N'W.', N'NG', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (36, N'Mark Cidric', N'L.', N'PABLO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (37, N'Kenny Rey', N'B.', N'PALADAN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (38, N'Leah Rose', N'C.', N'PALOGAN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (39, N'Earlson Christian Leo', N'C.', N'PAVO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (40, N'Patricia', N'Cake', N'RAMIREZ', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (41, N'Reymond', N'A.', N'RELLON', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (42, N'Emmanuel Jr.', N'B.', N'REYES', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (43, N'Neil Patrick', N'Q.', N'REYES', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (44, N'John Vincent', N'', N'ROSALI', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (45, N'Krizza Mae', N'T.', N'SABULARSE', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (46, N'Lester', N'A.', N'SAHAGUN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (47, N'Jenny Lyn', N'P.', N'SALIMO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (48, N'Peter', N'', N'SANTIAGO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (49, N'John Moises', N'R.', N'SANTOS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (50, N'Paulo Luiz', N'D.', N'SANTOS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (51, N'John Glenn', N'R.', N'SAPA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (52, N'Carl Jamesy', N'O.', N'SENIA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (53, N'Herminia', N'R.', N'SISANTE', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (54, N'Allyn', N'M.', N'TACUD', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (55, N'Ron Daniel', N'F.', N'TAGUDIN', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (56, N'Bryan-Charles', N'B.', N'TENERIFE', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (57, N'Nathankissam Roy', N'A.', N'TUBIS', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (58, N'Chrysler', N'Boyd', N'VELASCO', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (59, N'Ma. Bernadette', N'G.', N'VERGARA', NULL)
GO
INSERT [dbo].[Employees] ([ID], [FirstName], [MiddleName], [LastName], [DepartmentID]) VALUES (60, N'Federico III', N'Z.', N'VILLAREAL', NULL)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[PettyCashes] ON 
GO
INSERT [dbo].[PettyCashes] ([ID], [PCFNo], [Date], [Payee], [Particulars], [ClientID], [ProjectCategoryID], [Amount]) VALUES (1, N'111111111111111', CAST(N'2024-01-18T00:00:00.0000000' AS DateTime2), N'Herminia', N'nothing in particular', 16, 4, CAST(35345.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[PettyCashes] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectCategorys] ON 
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (1, N'ITCM', N'IT Commodities')
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (2, N'PSEC', N'Physical Security Products')
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (3, N'LISP', N'LightSpeed ISP Solution')
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (4, N'ICTS', N'Infrastracture Services')
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (5, N'ISEC', N'Infrastracture Security Products')
GO
INSERT [dbo].[ProjectCategorys] ([ID], [Code], [Description]) VALUES (6, N'RTSG', N'Security Services')
GO
SET IDENTITY_INSERT [dbo].[ProjectCategorys] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 1/25/2024 10:38:49 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PettyCashes_PCFNo]    Script Date: 1/25/2024 10:38:50 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_PettyCashes_PCFNo] ON [dbo].[PettyCashes]
(
	[PCFNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
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
