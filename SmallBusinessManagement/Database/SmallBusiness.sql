USE [SmallBusiness]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 10/16/2019 11:32:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/16/2019 11:32:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Loyality] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/16/2019 11:32:12 PM ******/
SET ANSI_NULLS ON
GO
SELECT pu.Date as PurchaseDate ,Categories.Name AS Category, Products.Code ,Products.Name As Product, SUM(pu.Quantity)-(Select Sum(sa.Quantity))As Available ,
SUM(pu.Quantity)*(SELECT SUM(Pu.UnitPrice) FROM Purchase AS Pu WHERE Pu.ProductId=sa.ProductId
 GROUP BY Pu.ProductId)/COUNT(*) AS CP,
SUM(sa.Quantity)*(SELECT SUM(Pu.MRP) FROM Purchase AS Pu WHERE Pu.ProductId=sa.ProductId
 GROUP BY Pu.ProductId)/COUNT(*) AS Sales_Price,
SUM(sa.Quantity)*(SELECT SUM(MRP) FROM Purchase as Pu WHERE Pu.ProductId=sa.ProductId 
GROUP BY Pu.ProductId)/COUNT(*)-SUM(sa.Quantity)*(SELECT SUM(Pu.UnitPrice) FROM Purchase as Pu 
WHERE Pu.ProductId=sa.ProductId GROUP BY Pu.ProductId)/COUNT(*) AS Profit
FROM Purchase AS pu
LEFT OUTER JOIN Products ON sa.ProductId=Products.Id
LEFT OUTER JOIN Categories ON Products.CategoryId=Categories.Id
Group by sa.Date, sa.ProductId,Products.Name,Products.Code, Categories.Name

Create View SalesReport
As
SELECT sa.Date as SalesDate ,Categories.Name AS Category, Products.Code ,Products.Name As Product, SUM(sa.Quantity) AS Sold_Qty,
SUM(sa.Quantity)*(SELECT SUM(Pu.UnitPrice) FROM Purchase AS Pu WHERE Pu.ProductId=sa.ProductId
 GROUP BY Pu.ProductId)/COUNT(*) AS CP,
SUM(sa.Quantity)*(SELECT SUM(Pu.MRP) FROM Purchase AS Pu WHERE Pu.ProductId=sa.ProductId
 GROUP BY Pu.ProductId)/COUNT(*) AS Sales_Price,
SUM(sa.Quantity)*(SELECT SUM(MRP) FROM Purchase as Pu WHERE Pu.ProductId=sa.ProductId 
GROUP BY Pu.ProductId)/COUNT(*)-SUM(sa.Quantity)*(SELECT SUM(Pu.UnitPrice) FROM Purchase as Pu 
WHERE Pu.ProductId=sa.ProductId GROUP BY Pu.ProductId)/COUNT(*) AS Profit
FROM Sales AS sa
LEFT OUTER JOIN Products ON sa.ProductId=Products.Id
LEFT OUTER JOIN Categories ON Products.CategoryId=Categories.Id
Group by sa.Date, sa.ProductId,Products.Name,Products.Code, Categories.Name

Select * From SalesReport

Drop View SalesReport


SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[RecordLevel] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 10/16/2019 11:32:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Bill] [varchar](50) NOT NULL,
	[SupplierId] [int] NULL,
	[CategoryId] [int] NULL,
	[ProductId] [int] NULL,
	[Code] [int] NOT NULL,
	[AvailableQuantity] [int] NULL,
	[ManufacturedDate] [date] NULL,
	[ExpireDate] [date] NULL,
	[PurchasedQuantity] [int] NULL,
	[UnitPrice] [int] NULL,
	[Remarks] [varchar](max) NULL,
 CONSTRAINT [PK_Purchase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/16/2019 11:32:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[ContactPerson] [varchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Email], [Contact], [Loyality]) VALUES (1, 3123, N'Ariful Islam', N'Uttara', N'ariful.funny@gmail.com', N'01773611681', 10)
INSERT [dbo].[Customers] ([Id], [Code], [Name], [Address], [Email], [Contact], [Loyality]) VALUES (2, 4324, N'Arif Hasan', N'Dhaka', N'abc@gmail.com', N'01957884309', 100)
SET IDENTITY_INSERT [dbo].[Customers] OFF
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Categories]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Products]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Suppliers] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Suppliers] ([Id])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Suppliers]
GO
