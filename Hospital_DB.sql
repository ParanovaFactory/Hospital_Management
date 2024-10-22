USE [master]
GO
/****** Object:  Database [HospitalDB]    Script Date: 9/7/2024 2:15:49 PM ******/
CREATE DATABASE [HospitalDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HospitalDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HospitalDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HospitalDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\HospitalDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [HospitalDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HospitalDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HospitalDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HospitalDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HospitalDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HospitalDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HospitalDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HospitalDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HospitalDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HospitalDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HospitalDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HospitalDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HospitalDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HospitalDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HospitalDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HospitalDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HospitalDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HospitalDB] SET RECOVERY FULL 
GO
ALTER DATABASE [HospitalDB] SET  MULTI_USER 
GO
ALTER DATABASE [HospitalDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HospitalDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HospitalDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HospitalDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HospitalDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HospitalDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HospitalDB', N'ON'
GO
ALTER DATABASE [HospitalDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [HospitalDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HospitalDB]
GO
/****** Object:  Table [dbo].[TblAnouncement]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAnouncement](
	[anouncementId] [int] IDENTITY(1,1) NOT NULL,
	[anouncementText] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblAppointments]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAppointments](
	[appointmentId] [int] IDENTITY(1,1) NOT NULL,
	[appointmentDate] [varchar](15) NULL,
	[appointmentHour] [varchar](10) NULL,
	[appointmentDepartment] [tinyint] NULL,
	[appointmentDoctor] [tinyint] NULL,
	[appointmentPatient] [varchar](50) NULL,
	[appointmentComlaint] [varchar](100) NULL,
	[appointmentStatus] [bit] NULL,
 CONSTRAINT [PK_TblAppointmentS] PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDepartments]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDepartments](
	[departmentId] [tinyint] IDENTITY(1,1) NOT NULL,
	[departmentName] [varchar](30) NULL,
 CONSTRAINT [PK_TblDepartments] PRIMARY KEY CLUSTERED 
(
	[departmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDoctors]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDoctors](
	[doctorId] [tinyint] IDENTITY(1,1) NOT NULL,
	[docName] [varchar](20) NULL,
	[docSurname] [varchar](20) NULL,
	[docDepartment] [tinyint] NULL,
	[docIdNo] [char](11) NULL,
	[docPassword] [varchar](15) NULL,
 CONSTRAINT [PK_TblDoctors] PRIMARY KEY CLUSTERED 
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPatients]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPatients](
	[patientId] [smallint] IDENTITY(1,1) NOT NULL,
	[patientName] [varchar](20) NULL,
	[patientSurname] [varchar](20) NULL,
	[patientIdNo] [char](11) NULL,
	[patientPhoneNo] [varchar](15) NULL,
	[patientPassword] [varchar](20) NULL,
	[patientGender] [varchar](5) NULL,
 CONSTRAINT [PK_TblPatients] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSecretaries]    Script Date: 9/7/2024 2:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSecretaries](
	[secretaryId] [tinyint] IDENTITY(1,1) NOT NULL,
	[secName] [varchar](20) NULL,
	[secSurname] [varchar](20) NULL,
	[secIdNo] [char](11) NULL,
	[secPassword] [varchar](20) NULL,
 CONSTRAINT [PK_TblSecreraries] PRIMARY KEY CLUSTERED 
(
	[secretaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TblAppointments_TblDepartments] FOREIGN KEY([appointmentDepartment])
REFERENCES [dbo].[TblDepartments] ([departmentId])
GO
ALTER TABLE [dbo].[TblAppointments] CHECK CONSTRAINT [FK_TblAppointments_TblDepartments]
GO
ALTER TABLE [dbo].[TblAppointments]  WITH CHECK ADD  CONSTRAINT [FK_TblAppointments_TblDoctors] FOREIGN KEY([appointmentDoctor])
REFERENCES [dbo].[TblDoctors] ([doctorId])
GO
ALTER TABLE [dbo].[TblAppointments] CHECK CONSTRAINT [FK_TblAppointments_TblDoctors]
GO
ALTER TABLE [dbo].[TblDoctors]  WITH CHECK ADD  CONSTRAINT [FK_TblDoctors_TblDepartments] FOREIGN KEY([docDepartment])
REFERENCES [dbo].[TblDepartments] ([departmentId])
GO
ALTER TABLE [dbo].[TblDoctors] CHECK CONSTRAINT [FK_TblDoctors_TblDepartments]
GO
USE [master]
GO
ALTER DATABASE [HospitalDB] SET  READ_WRITE 
GO
