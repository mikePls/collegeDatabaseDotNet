USE [master]
GO
/****** Object:  Database [CollegeDB]    Script Date: 08/06/2022 15:28:45 ******/
CREATE DATABASE [CollegeDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CollegeDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CollegeDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CollegeDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CollegeDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CollegeDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CollegeDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CollegeDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CollegeDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CollegeDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CollegeDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CollegeDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CollegeDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CollegeDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CollegeDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CollegeDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CollegeDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CollegeDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CollegeDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CollegeDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CollegeDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CollegeDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CollegeDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CollegeDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CollegeDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CollegeDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CollegeDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CollegeDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CollegeDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CollegeDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CollegeDB] SET  MULTI_USER 
GO
ALTER DATABASE [CollegeDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CollegeDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CollegeDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CollegeDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CollegeDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CollegeDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CollegeDB', N'ON'
GO
ALTER DATABASE [CollegeDB] SET QUERY_STORE = OFF
GO
USE [CollegeDB]
GO
/****** Object:  User [UserTwo]    Script Date: 08/06/2022 15:28:45 ******/
CREATE USER [UserTwo] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [mike]    Script Date: 08/06/2022 15:28:45 ******/
CREATE USER [mike] FOR LOGIN [application] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[course]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[course](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[department_code] [int] NOT NULL,
	[description] [text] NULL,
	[course_type] [nchar](10) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[department_name] [varchar](50) NOT NULL,
	[campus_location] [varchar](50) NOT NULL,
 CONSTRAINT [PK_department] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[available_courses]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[available_courses]
AS
SELECT dbo.course.course_id, dbo.course.title, dbo.department.department_name, dbo.course.course_type, dbo.department.campus_location
FROM   dbo.course INNER JOIN
             dbo.department ON dbo.course.department_code = dbo.department.department_id
GO
/****** Object:  Table [dbo].[module]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[module](
	[module_id] [int] IDENTITY(104,1) NOT NULL,
	[module_title] [nvarchar](50) NOT NULL,
	[module_description] [nvarchar](50) NULL,
 CONSTRAINT [PK_module] PRIMARY KEY CLUSTERED 
(
	[module_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grade]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grade](
	[student_id] [int] NOT NULL,
	[module_id] [int] NOT NULL,
	[class_test] [int] NOT NULL,
	[assignment] [int] NOT NULL,
	[final_score] [int] NOT NULL,
 CONSTRAINT [PK_grade] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC,
	[module_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[student]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[student](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[date_of_birth] [varchar](10) NULL,
	[address] [varchar](50) NOT NULL,
	[country] [varchar](50) NULL,
	[postcode] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
	[is_enrolled] [bit] NOT NULL,
 CONSTRAINT [PK_student_1] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[student_progress]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[student_progress]
AS
SELECT dbo.student.student_id, dbo.student.first_name, dbo.student.last_name, dbo.module.module_id, dbo.module.module_title, dbo.grade.class_test, dbo.grade.assignment, dbo.grade.final_score
FROM   dbo.grade INNER JOIN
             dbo.module ON dbo.grade.module_id = dbo.module.module_id INNER JOIN
             dbo.student ON dbo.grade.student_id = dbo.student.student_id
GO
/****** Object:  Table [dbo].[enrollment]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[enrollment](
	[student_id] [int] NOT NULL,
	[course_id] [int] NOT NULL,
	[enrollment_date] [varchar](10) NOT NULL,
 CONSTRAINT [PK_enrollment_1] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[enrollment_details]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[enrollment_details]
AS
SELECT dbo.student.student_id, dbo.student.first_name, dbo.student.last_name, dbo.enrollment.course_id, dbo.course.title
FROM   dbo.student INNER JOIN
             dbo.enrollment ON dbo.student.student_id = dbo.enrollment.student_id INNER JOIN
             dbo.course ON dbo.enrollment.course_id = dbo.course.course_id
GO
/****** Object:  Table [dbo].[lecturer]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lecturer](
	[lecturer_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[teaching_field] [nchar](20) NOT NULL,
	[Qualifications] [text] NULL,
 CONSTRAINT [PK_lecturer] PRIMARY KEY CLUSTERED 
(
	[lecturer_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_login]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_login](
	[user_id] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user_login] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 08/06/2022 15:28:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nchar](30) NOT NULL,
	[last_name] [nchar](30) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[student] ADD  CONSTRAINT [DF_student_is_enrolled]  DEFAULT ((0)) FOR [is_enrolled]
GO
ALTER TABLE [dbo].[course]  WITH CHECK ADD  CONSTRAINT [FK_course_department] FOREIGN KEY([department_code])
REFERENCES [dbo].[department] ([department_id])
GO
ALTER TABLE [dbo].[course] CHECK CONSTRAINT [FK_course_department]
GO
ALTER TABLE [dbo].[enrollment]  WITH CHECK ADD  CONSTRAINT [FK_enrollment_student] FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[enrollment] CHECK CONSTRAINT [FK_enrollment_student]
GO
ALTER TABLE [dbo].[grade]  WITH CHECK ADD  CONSTRAINT [FK_grade_module] FOREIGN KEY([module_id])
REFERENCES [dbo].[module] ([module_id])
GO
ALTER TABLE [dbo].[grade] CHECK CONSTRAINT [FK_grade_module]
GO
ALTER TABLE [dbo].[lecturer]  WITH CHECK ADD  CONSTRAINT [FK_lecturer_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[lecturer] CHECK CONSTRAINT [FK_lecturer_user]
GO
ALTER TABLE [dbo].[user_login]  WITH CHECK ADD  CONSTRAINT [FK_user_login_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[user_login] CHECK CONSTRAINT [FK_user_login_user]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "course"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 300
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "department"
            Begin Extent = 
               Top = 9
               Left = 357
               Bottom = 206
               Right = 605
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'available_courses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'available_courses'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "student"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "enrollment"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 567
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "course"
            Begin Extent = 
               Top = 9
               Left = 624
               Bottom = 206
               Right = 867
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'enrollment_details'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'enrollment_details'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "student"
            Begin Extent = 
               Top = 22
               Left = 93
               Bottom = 219
               Right = 315
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "module"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 179
               Right = 596
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "grade"
            Begin Extent = 
               Top = 9
               Left = 653
               Bottom = 206
               Right = 875
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'student_progress'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'student_progress'
GO
USE [master]
GO
ALTER DATABASE [CollegeDB] SET  READ_WRITE 
GO
