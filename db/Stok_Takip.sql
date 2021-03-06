USE [master]
GO
/****** Object:  Database [Stok_Takip]    Script Date: 3.12.2021 13:59:14 ******/
CREATE DATABASE [Stok_Takip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stok_Takip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Stok_Takip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stok_Takip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Stok_Takip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Stok_Takip] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stok_Takip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stok_Takip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stok_Takip] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stok_Takip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stok_Takip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stok_Takip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stok_Takip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stok_Takip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stok_Takip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stok_Takip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stok_Takip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stok_Takip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stok_Takip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stok_Takip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stok_Takip] SET  MULTI_USER 
GO
ALTER DATABASE [Stok_Takip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stok_Takip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stok_Takip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stok_Takip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stok_Takip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stok_Takip] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Stok_Takip] SET QUERY_STORE = OFF
GO
USE [Stok_Takip]
GO
/****** Object:  Table [dbo].[kategoribilgileri]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kategoribilgileri](
	[kategori] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciBilgileri]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciBilgileri](
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[markabilgileri]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[markabilgileri](
	[kategori] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[müşteri]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[müşteri](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sepet]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sepet](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[barkodno] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[toplamfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[urun]    Script Date: 3.12.2021 13:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[urun](
	[barkodno] [nvarchar](50) NOT NULL,
	[kategori] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[urunadi] [nvarchar](50) NOT NULL,
	[miktari] [int] NOT NULL,
	[alisfiyati] [decimal](18, 2) NOT NULL,
	[satisfiyati] [decimal](18, 2) NOT NULL,
	[tarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'ÇİMENTO')
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'TUĞLA')
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'ÇİVİ')
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'BOYA')
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'ALÇI')
INSERT [dbo].[kategoribilgileri] ([kategori]) VALUES (N'DERZ DOLGU')
GO
INSERT [dbo].[KullaniciBilgileri] ([KullaniciAdi], [Sifre]) VALUES (N'gökhan', N'7')
GO
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Çimento', N'Nuh ')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'FAYANS', N'KARE FAYANS')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Alçı', N'X MARKASI')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Çimento', N'A Markası')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'TESTERE', N'X MARKASI')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Kum', N'B Markası')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Çivi', N'C Markası')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Vida', N'D Markası')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Menteşe', N'E Markası')
INSERT [dbo].[markabilgileri] ([kategori], [marka]) VALUES (N'Tuğla', N'F Markası')
GO
INSERT [dbo].[müşteri] ([tc], [adsoyad], [telefon], [adres]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'İstanbul')
INSERT [dbo].[müşteri] ([tc], [adsoyad], [telefon], [adres]) VALUES (N'98765432111', N'Ender İmen', N'05397842314', N'İstanbul')
INSERT [dbo].[müşteri] ([tc], [adsoyad], [telefon], [adres]) VALUES (N'96784632891', N'Ahmet Ertağ', N'05422804937', N'İstanbul')
INSERT [dbo].[müşteri] ([tc], [adsoyad], [telefon], [adres]) VALUES (N'11987654321', N'Erdi İmen', N'05386459874', N'İstanbul')
GO
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'101', N'Baca Tuğlası', 100, CAST(5.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), N'5.06.2021 20:00:42')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 100, CAST(15.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), N'5.06.2021 21:26:29')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'102', N'10'' luk Çivi', 100, CAST(1.50 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), N'5.06.2021 21:26:29')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'7 '' lik vida', 249, CAST(2.00 AS Decimal(18, 2)), CAST(498.00 AS Decimal(18, 2)), N'13.04.2021 16:47:31')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'7 '' lik vida', 1, CAST(0.75 AS Decimal(18, 2)), CAST(0.75 AS Decimal(18, 2)), N'13.04.2021 16:49:01')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'11987654321', N'Erdi İmen', N'05386459874', N'100', N'Çimento', 10, CAST(15.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), N'21.04.2021 16:49:02')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'45678912394', N'Ender İmen', N'05319046694', N'100', N'Çimento', 30, CAST(15.00 AS Decimal(18, 2)), CAST(450.00 AS Decimal(18, 2)), N'21.04.2021 16:51:19')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 5, CAST(15.00 AS Decimal(18, 2)), CAST(75.00 AS Decimal(18, 2)), N'11.05.2021 16:10:29')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'101', N'Baca Tuğlası', 11, CAST(5.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), N'11.05.2021 16:10:29')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 5, CAST(15.00 AS Decimal(18, 2)), CAST(75.00 AS Decimal(18, 2)), N'3.06.2021 15:13:11')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 1, CAST(15.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), N'3.06.2021 15:26:24')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 1, CAST(15.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), N'3.06.2021 15:28:15')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'100', N'Çimento 50 Kg', 1, CAST(15.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), N'3.06.2021 16:03:04')
INSERT [dbo].[satis] ([tc], [adsoyad], [telefon], [barkodno], [urunadi], [miktari], [satisfiyati], [toplamfiyati], [tarih]) VALUES (N'12643803030', N'Gökhan İmen', N'05319046694', N'101', N'Baca Tuğlası', 100, CAST(5.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), N'5.06.2021 21:26:29')
GO
INSERT [dbo].[urun] ([barkodno], [kategori], [marka], [urunadi], [miktari], [alisfiyati], [satisfiyati], [tarih]) VALUES (N'100', N'ÇİMENTO', N'Nuh ', N'50Kg Çimento', 100, CAST(40.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), N'5.06.2021 21:27:32')
INSERT [dbo].[urun] ([barkodno], [kategori], [marka], [urunadi], [miktari], [alisfiyati], [satisfiyati], [tarih]) VALUES (N'101', N'TUĞLA', N'F Markası', N'Baca Tuğlası', 500, CAST(3.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), N'5.06.2021 21:28:03')
INSERT [dbo].[urun] ([barkodno], [kategori], [marka], [urunadi], [miktari], [alisfiyati], [satisfiyati], [tarih]) VALUES (N'102', N'ÇİVİ', N'C Markası', N'Cam Çivisi', 250, CAST(5.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'5.06.2021 21:28:50')
GO
USE [master]
GO
ALTER DATABASE [Stok_Takip] SET  READ_WRITE 
GO
