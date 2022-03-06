USE [master]
GO

/****** Object:  Database [PERSONELTRACKING]    Script Date: 2022-03-06 17:57:02 ******/
CREATE DATABASE [PERSONELTRACKING]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PERSONELTRACKING', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PERSONELTRACKING.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PERSONELTRACKING_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PERSONELTRACKING_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PERSONELTRACKING].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PERSONELTRACKING] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET ARITHABORT OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PERSONELTRACKING] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PERSONELTRACKING] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PERSONELTRACKING] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PERSONELTRACKING] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET RECOVERY FULL 
GO

ALTER DATABASE [PERSONELTRACKING] SET  MULTI_USER 
GO

ALTER DATABASE [PERSONELTRACKING] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PERSONELTRACKING] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PERSONELTRACKING] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PERSONELTRACKING] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PERSONELTRACKING] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PERSONELTRACKING] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [PERSONELTRACKING] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PERSONELTRACKING] SET  READ_WRITE 
GO
