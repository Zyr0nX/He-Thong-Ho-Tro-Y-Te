USE [YTe]
GO
/****** Object:  Table [dbo].[About]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[About](
	[ID] [bigint] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](250) NULL,
	[Detail] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[MetaKeywords] [nvarchar](250) NULL,
	[MetaDescriptions] [nchar](250) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_About] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[IdBill] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](15) NULL,
	[DeliveryAddress] [nvarchar](max) NULL,
	[DeliveryTime] [nchar](50) NULL,
	[TotalMoney] [int] NULL,
	[Status] [nvarchar](50) NULL,
	[CreatedDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[IdBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[ParentId] [int] NULL,
	[DisplayOrder] [int] NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[CreatedTime] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[MetaKeywords] [nvarchar](250) NULL,
	[MetaDescriptions] [nchar](250) NULL,
	[Status] [bit] NULL,
	[ShowOnHome] [bit] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ID] [int] NOT NULL,
	[Content] [ntext] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] NULL,
	[FullName] [nvarchar](50) NULL,
	[UserName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailBill]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailBill](
	[IdBill] [nvarchar](50) NOT NULL,
	[IdProduct] [int] NULL,
	[NumberProduct] [int] NULL,
	[TotalMoney] [nvarchar](50) NULL,
 CONSTRAINT [PK_DetailBill] PRIMARY KEY CLUSTERED 
(
	[IdBill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[IdDoctor] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[IdDoctor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedback](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Content] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[ID] [bigint] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[MetaTitle] [varchar](250) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](250) NULL,
	[CategoryID] [bigint] NULL,
	[Detail] [ntext] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[MetaKeywords] [nvarchar](250) NULL,
	[MetaDescriptions] [nchar](250) NULL,
	[Status] [bit] NOT NULL,
	[ViewCount] [int] NULL,
	[Tags] [nvarchar](500) NULL,
	[Language] [varchar](2) NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[IdPatient] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[IdPatient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[UserGroupID] [varchar](20) NULL,
	[RoleID] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Code] [varchar](50) NULL,
	[Amount] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[ImportPrice] [int] NULL,
	[Image] [varchar](250) NULL,
	[MoreImages] [xml] NULL,
	[Describe] [ntext] NULL,
	[Detail] [ntext] NULL,
	[CategoryID] [int] NULL,
	[Status] [nchar](10) NULL,
	[MetaTitel] [varchar](250) NULL,
	[CreatedTime] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedBy] [varchar](50) NULL,
	[MetaKeywords] [nvarchar](250) NULL,
	[MetaDescriptions] [nchar](250) NULL,
	[ViewCount] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](32) NOT NULL,
	[GroupID] [varchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Sex] [bit] NULL,
	[DateOfBirth] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [varchar](50) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserGroup]    Script Date: 12/05/2021 8:30:28 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroup](
	[Id] [varchar](20) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName], [MetaTitle], [ParentId], [DisplayOrder], [SeoTitle], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [Status], [ShowOnHome]) VALUES (1, N'Gout', NULL, NULL, 0, NULL, CAST(N'2021-05-03T19:17:51.400' AS DateTime), NULL, NULL, NULL, NULL, 1, 0)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [MetaTitle], [ParentId], [DisplayOrder], [SeoTitle], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [Status], [ShowOnHome]) VALUES (2, N'Mụn', NULL, NULL, 0, NULL, CAST(N'2021-05-03T19:17:51.400' AS DateTime), NULL, NULL, NULL, NULL, 1, 0)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [MetaTitle], [ParentId], [DisplayOrder], [SeoTitle], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [Status], [ShowOnHome]) VALUES (3, N'Dạ dày', NULL, NULL, 0, NULL, CAST(N'2021-05-03T19:17:51.400' AS DateTime), NULL, NULL, NULL, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (2, N'Nano Fast viên sủi trị Gout', NULL, NULL, CAST(1580000.00 AS Decimal(18, 2)), 790000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (3, N'Cao gắm nguyên chất (Cao khô)', NULL, NULL, CAST(250000.00 AS Decimal(18, 2)), 220000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (4, N'Trà an gút 25 túi lọc 5 gam', NULL, NULL, CAST(45000.00 AS Decimal(18, 2)), 40000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (5, N'Viên Khớp OSA Break Học Viện Quân Y chính hãng hộp 30 viên', NULL, NULL, CAST(165000.00 AS Decimal(18, 2)), 125000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (6, N'Hoàng Thống Phong', NULL, NULL, CAST(250000.00 AS Decimal(18, 2)), 220000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (7, N'
 
SANGU Tinh Chất Tiêu Gout Số Một Nhật Bản', NULL, NULL, CAST(860000.00 AS Decimal(18, 2)), 800000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (8, N'Trị Gout Của Nhật', NULL, NULL, CAST(800000.00 AS Decimal(18, 2)), 745000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (11, N'Swisse Viên Uống Điều Trị Gout Từ Cần Tây 5000mg 50 Viên', NULL, NULL, CAST(555000.00 AS Decimal(18, 2)), 490000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (12, N'Viên uống hỗ trợ thận Swanson Uric Acid Cleanse Kidney Support 60 viên', NULL, NULL, CAST(395000.00 AS Decimal(18, 2)), 300000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (13, N'Viên Uống Trankal Thái Lan Hỗ Trợ Thấp Khớp', NULL, NULL, CAST(1520000.00 AS Decimal(18, 2)), 300000, NULL, NULL, NULL, NULL, 1, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (14, N'Make p:rem', NULL, NULL, CAST(5000000.00 AS Decimal(18, 2)), 300000, NULL, NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (15, N'Make p:rem', NULL, 3, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'p2.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (16, N'Make p:rem', NULL, 4, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'p2.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (17, N'Make p:rem', NULL, 5, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'p2.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (18, N'Make p:rem', NULL, 5, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'p2.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (19, N'Make p:rem', NULL, 5, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'171489307_4304661672917156_5869776947333136536_n.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (20, N'Make p:rem', NULL, 5, CAST(5000000.00 AS Decimal(18, 2)), 300000, N'172248460_4304266146290042_8042747718693016873_n.jpg', NULL, NULL, NULL, 2, NULL, NULL, CAST(N'2021-05-03T19:17:51.700' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (21, N'thuốc', NULL, 2, CAST(12345.00 AS Decimal(18, 2)), NULL, N'171489307_4304661672917156_5869776947333136536_n.jpg', NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (22, N'thuốc không đường', NULL, 2, CAST(1233.00 AS Decimal(18, 2)), NULL, N'172731196_285971033114595_4839493641539071816_n.jpg', NULL, NULL, NULL, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Product] ([Id], [Name], [Code], [Amount], [Price], [ImportPrice], [Image], [MoreImages], [Describe], [Detail], [CategoryID], [Status], [MetaTitel], [CreatedTime], [CreatedBy], [ModifiedBy], [MetaKeywords], [MetaDescriptions], [ViewCount]) VALUES (23, N'thuốc', NULL, 2, CAST(1.00 AS Decimal(18, 2)), NULL, N'172248460_4304266146290042_8042747718693016873_n.jpg', NULL, NULL, NULL, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[User] ([ID], [UserName], [Password], [GroupID], [Name], [Address], [Email], [Phone], [Sex], [DateOfBirth], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (0, N'14214', N'1', NULL, N'khoong ten', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'fu.jpg', NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [GroupID], [Name], [Address], [Email], [Phone], [Sex], [DateOfBirth], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (1, N'admin', N'123456', N'ADMIN', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2021-05-03T20:35:10.230' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [GroupID], [Name], [Address], [Email], [Phone], [Sex], [DateOfBirth], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (2, N'nguyenquockhai', N'29102000', N'DOCTOR', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2021-05-03T20:35:24.453' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([ID], [UserName], [Password], [GroupID], [Name], [Address], [Email], [Phone], [Sex], [DateOfBirth], [CreatedDate], [CreatedBy], [ModifiedDate], [ModifiedBy], [Status]) VALUES (3, N'nguyenvantri', N'123456', N'PATIENT', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2021-05-03T20:35:39.987' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[UserGroup] ([Id], [Name]) VALUES (N'ADMIN', N'Quản trị')
INSERT [dbo].[UserGroup] ([Id], [Name]) VALUES (N'DOCTOR', N'Bác sĩ')
INSERT [dbo].[UserGroup] ([Id], [Name]) VALUES (N'PATIENT', N'Bệnh nhân')
GO
ALTER TABLE [dbo].[About] ADD  CONSTRAINT [DF_About_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[About] ADD  CONSTRAINT [DF_About_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_DisplayOrder]  DEFAULT ((0)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_CreatedTime]  DEFAULT (getdate()) FOR [CreatedTime]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_ShowOnHome]  DEFAULT ((0)) FOR [ShowOnHome]
GO
ALTER TABLE [dbo].[Feedback] ADD  CONSTRAINT [DF_Feedback_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_CreatedDate_1]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_Status_1]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[News] ADD  CONSTRAINT [DF_News_ViewCount_1]  DEFAULT ((0)) FOR [ViewCount]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreatedTime]  DEFAULT (getdate()) FOR [CreatedTime]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_GroupID]  DEFAULT ('MEMBER') FOR [GroupID]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[DetailBill]  WITH CHECK ADD  CONSTRAINT [FK_DetailBill_Bill] FOREIGN KEY([IdBill])
REFERENCES [dbo].[Bill] ([IdBill])
GO
ALTER TABLE [dbo].[DetailBill] CHECK CONSTRAINT [FK_DetailBill_Bill]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category1] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category1]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Account_Login]    Script Date: 12/05/2021 8:30:29 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Account_Login]
	 @UserName varchar(50),
	 @Password varchar(50)

as
begin 
	declare @count int
	declare @res bit
	select @count = count(*) 
	from Account
	where UserName = @UserName and Password = @Password
	if @count>0 
		set @res = 1
	else 
		set @res=0

	select @res
end
GO
