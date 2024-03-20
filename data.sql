USE [TraoDoiHang]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/19/2024 9:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[ID] [int] NOT NULL,
	[UserName] [varchar](100) NULL,
	[Pass] [varchar](50) NULL,
	[Position] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 3/19/2024 9:52:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[ID] [int] NOT NULL,
	[FullName] [nvarchar](150) NULL,
	[Phone] [varchar](13) NULL,
	[CCCD] [varchar](13) NULL,
	[Gender] [nvarchar](10) NULL,
	[Bith] [date] NULL,
	[Email] [varchar](100) NULL,
	[Avarta] [varchar](300) NULL,
	[Addr] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([ID], [UserName], [Pass], [Position]) VALUES (1, N'duy', N'123', N'User')
INSERT [dbo].[Account] ([ID], [UserName], [Pass], [Position]) VALUES (2, N'Lam', N'123', N'User')
INSERT [dbo].[Account] ([ID], [UserName], [Pass], [Position]) VALUES (3, N'DuyPham', N'1', N'User')
INSERT [dbo].[Account] ([ID], [UserName], [Pass], [Position]) VALUES (4, N'huong', N'123', N'User')
GO
INSERT [dbo].[Person] ([ID], [FullName], [Phone], [CCCD], [Gender], [Bith], [Email], [Avarta], [Addr]) VALUES (1, N'duy', N'123', N'123', N'Nam', CAST(N'2024-03-12' AS Date), N'123', N'', N'123')
INSERT [dbo].[Person] ([ID], [FullName], [Phone], [CCCD], [Gender], [Bith], [Email], [Avarta], [Addr]) VALUES (2, N'Pham Duy', N'123', N'123', N'N?', CAST(N'2024-03-12' AS Date), N'123', N'', N'123')
INSERT [dbo].[Person] ([ID], [FullName], [Phone], [CCCD], [Gender], [Bith], [Email], [Avarta], [Addr]) VALUES (3, N'Pham Ngoc Duy', N'123', N'01858115', N'Nam', CAST(N'2024-03-21' AS Date), N'123', N'', N'ktx')
INSERT [dbo].[Person] ([ID], [FullName], [Phone], [CCCD], [Gender], [Bith], [Email], [Avarta], [Addr]) VALUES (4, N'Huong', N'123', N'014881481', N'N?', CAST(N'2005-07-13' AS Date), N'123', N'', N'ktx d2')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Person] ([ID])
GO
