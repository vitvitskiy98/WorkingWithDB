USE [FactoryDB]
GO
/****** Object:  User [Admin]    Script Date: 06.04.2021 18:20:21 ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Vlad]    Script Date: 06.04.2021 18:20:21 ******/
CREATE USER [Vlad] FOR LOGIN [Vlad] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Сотрудник]    Script Date: 06.04.2021 18:20:21 ******/
CREATE USER [Сотрудник] FOR LOGIN [Сотрудник] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Admin]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Admin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Admin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Admin]
GO
ALTER ROLE [db_owner] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Vlad]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Сотрудник]
GO
/****** Object:  Table [dbo].[МалыйГрузовойЛифт]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[МалыйГрузовойЛифт](
	[elevator_id] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [int] NULL,
	[Скорость] [float] NULL,
	[ШиринаКабины] [float] NULL,
	[ГлубинаКабины] [float] NULL,
	[ВысотаКабины] [float] NULL,
	[ШиринаШахты] [float] NULL,
	[ГлубинаШахты] [float] NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [nvarchar](50) NULL,
	[МаксВысотаПодъема] [float] NULL,
	[ОстановокКабины] [int] NULL,
 CONSTRAINT [PK_МалыйГрузовойЛифт] PRIMARY KEY CLUSTERED 
(
	[elevator_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ГрузовойЛифт]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ГрузовойЛифт](
	[freightElevatorID] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [int] NULL,
	[Скорость] [float] NULL,
	[ШиринаКабины] [float] NULL,
	[ГлубинаКабины] [float] NULL,
	[ВысотаКабины] [float] NULL,
	[ШиринаШахты] [float] NULL,
	[ГлубинаШахты] [float] NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [nvarchar](50) NULL,
	[МаксВысотаПодъема] [float] NULL,
	[ОстановокКабины] [int] NULL,
 CONSTRAINT [PK_ГрузовойЛифт] PRIMARY KEY CLUSTERED 
(
	[freightElevatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[FreightElevators]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[FreightElevators] AS
SELECT TOP(1000)
       [ИндексЛифта]
      ,[Грузоподъемность]
      ,[Скорость]
      ,[ШиринаКабины]
      ,[ГлубинаКабины]
      ,[ВысотаКабины]
      ,[ШиринаШахты]
      ,[ГлубинаШахты]
      ,[Противовес]
      ,[ШиринаПроемаДверей]
      ,[МаксВысотаПодъема]
      ,[ОстановокКабины]
FROM   [FactoryDB].[dbo].[ГрузовойЛифт]
UNION ALL
SELECT TOP(1000)
	   [ИндексЛифта]
      ,[Грузоподъемность]
      ,[Скорость]
      ,[ШиринаКабины]
      ,[ГлубинаКабины]
      ,[ВысотаКабины]
      ,[ШиринаШахты]
      ,[ГлубинаШахты]
      ,[Противовес]
      ,[ШиринаПроемаДверей]
      ,[МаксВысотаПодъема]
      ,[ОстановокКабины]
FROM   [FactoryDB].[dbo].[МалыйГрузовойЛифт]
ORDER BY ИндексЛифта
GO
/****** Object:  Table [dbo].[МодельныйРядПегас]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[МодельныйРядПегас](
	[Pegas_id] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [int] NULL,
	[Скорость] [nvarchar](50) NULL,
	[ШиринаКабины] [float] NULL,
	[ГлубинаКабины] [float] NULL,
	[ВысотаКабины] [float] NULL,
	[ШтихмасКабины] [float] NULL,
	[ШиринаШахты] [float] NULL,
	[ГлубинаШахты] [float] NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [float] NULL,
 CONSTRAINT [PK_МодельныйРядПегас] PRIMARY KEY CLUSTERED 
(
	[Pegas_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ModelPegas]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
CREATE VIEW [dbo].[ModelPegas] AS
SELECT TOP (1000) [Pegas_id]
      ,[ИндексЛифта]
      ,[Грузоподъемность]
      ,[Скорость]
      ,[ШиринаКабины]
      ,[ГлубинаКабины]
      ,[ВысотаКабины]
      ,[ШтихмасКабины(мм)]
      ,[ШиринаШахты]
      ,[ГлубинаШахты]
      ,[Противовес]
      ,[ШиринаПроемаДверей]
  FROM [FactoryDB].[dbo].[МодельныйРядПегас]
GO
/****** Object:  Table [dbo].[FreightElevChanged]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreightElevChanged](
	[freightElevatorID_old] [int] NOT NULL,
	[freightElevatorID_new] [int] NOT NULL,
	[ИндексЛифта_old] [nvarchar](50) NULL,
	[ИндексЛифта_new] [nvarchar](50) NULL,
	[Грузоподъемность_old] [int] NULL,
	[Грузоподъемность_new] [int] NULL,
	[Скорость_old] [float] NULL,
	[Скорость_new] [float] NULL,
	[ШиринаКабины_old] [float] NULL,
	[ШиринаКабины_new] [float] NULL,
	[ГлубинаКабины_old] [float] NULL,
	[ГлубинаКабины_new] [float] NULL,
	[ВысотаКабины_old] [float] NULL,
	[ВысотаКабины_new] [float] NULL,
	[ШиринаШахты_old] [float] NULL,
	[ШиринаШахты_new] [float] NULL,
	[ГлубинаШахты_old] [float] NULL,
	[ГлубинаШахты_new] [float] NULL,
	[Противовес_old] [nvarchar](50) NULL,
	[Противовес_new] [nvarchar](50) NULL,
	[ШиринаПроемаДверей_old] [nvarchar](50) NULL,
	[ШиринаПроемаДверей_new] [nvarchar](50) NULL,
	[МаксВысотаПодъема_old] [float] NULL,
	[МаксВысотаПодъема_new] [float] NULL,
	[ОстановокКабины_old] [int] NULL,
	[ОстановокКабины_new] [int] NULL,
	[Дата_изменения] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PegasChanged]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PegasChanged](
	[Pegas_id_old] [int] NOT NULL,
	[Pegas_id_id_new] [int] NOT NULL,
	[ИндексЛифта_old] [nvarchar](50) NULL,
	[ИндексЛифта_new] [nvarchar](50) NULL,
	[Грузоподъемность_old] [int] NULL,
	[Грузоподъемность_new] [int] NULL,
	[Скорость_old] [nvarchar](50) NULL,
	[Скорость_new] [nvarchar](50) NULL,
	[ШиринаКабины_old] [float] NULL,
	[ШиринаКабины_new] [float] NULL,
	[ГлубинаКабины_old] [float] NULL,
	[ГлубинаКабины_new] [float] NULL,
	[ВысотаКабины_old] [float] NULL,
	[ВысотаКабины_new] [float] NULL,
	[ШтихмасКабины_old] [float] NULL,
	[ШтихмасКабины_new] [float] NULL,
	[ШиринаШахты_old] [float] NULL,
	[ШиринаШахты_new] [float] NULL,
	[ГлубинаШахты_old] [float] NULL,
	[ГлубинаШахты_new] [float] NULL,
	[Противовес_old] [nvarchar](50) NULL,
	[Противовес_new] [nvarchar](50) NULL,
	[ШиринаПроемаДверей_old] [float] NULL,
	[ШиринаПроемаДверей_new] [float] NULL,
	[Дата_изменения] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SmallElevChanged]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SmallElevChanged](
	[elevator_id_old] [int] NOT NULL,
	[elevator_id_new] [int] NOT NULL,
	[ИндексЛифта_old] [nvarchar](50) NULL,
	[ИндексЛифта_new] [nvarchar](50) NULL,
	[Грузоподъемность_old] [int] NULL,
	[Грузоподъемность_new] [int] NULL,
	[Скорость_old] [float] NULL,
	[Скорость_new] [float] NULL,
	[ШиринаКабины_old] [float] NULL,
	[ШиринаКабины_new] [float] NULL,
	[ГлубинаКабины_old] [float] NULL,
	[ГлубинаКабины_new] [float] NULL,
	[ВысотаКабины_old] [float] NULL,
	[ВысотаКабины_new] [float] NULL,
	[ШиринаШахты_old] [float] NULL,
	[ШиринаШахты_new] [float] NULL,
	[ГлубинаШахты_old] [float] NULL,
	[ГлубинаШахты_new] [float] NULL,
	[Противовес_old] [nvarchar](50) NULL,
	[Противовес_new] [nvarchar](50) NULL,
	[ШиринаПроемаДверей_old] [nvarchar](50) NULL,
	[ШиринаПроемаДверей_new] [nvarchar](50) NULL,
	[МаксВысотаПодъема_old] [float] NULL,
	[МаксВысотаПодъема_new] [float] NULL,
	[ОстановокКабины_old] [int] NULL,
	[ОстановокКабины_new] [int] NULL,
	[Дата_изменения] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ГрузовойЛифтИстория]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ГрузовойЛифтИстория](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ElevatorIndex] [nvarchar](50) NOT NULL,
	[Operation] [nvarchar](200) NOT NULL,
	[CreateAt] [datetime] NOT NULL,
 CONSTRAINT [PK_ГрузовойЛифтИстория] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ГрузовойЛифтТест]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ГрузовойЛифтТест](
	[freightElevatorID] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [nvarchar](50) NULL,
	[Скорость] [nvarchar](50) NULL,
	[ШиринаКабины] [nvarchar](50) NULL,
	[ГлубинаКабины] [nvarchar](50) NULL,
	[ВысотаКабины] [nvarchar](50) NULL,
	[ШиринаШахты] [nvarchar](50) NULL,
	[ГлубинаШахты] [nvarchar](50) NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [nvarchar](50) NULL,
	[МаксВысотаПодъема] [nvarchar](50) NULL,
	[ОстановокКабины] [nvarchar](50) NULL,
 CONSTRAINT [PK_ГрузовойЛифтТест] PRIMARY KEY CLUSTERED 
(
	[freightElevatorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[МалыйГрузовойЛифтИмпорт]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[МалыйГрузовойЛифтИмпорт](
	[elevator_id] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [nvarchar](50) NULL,
	[Скорость] [nvarchar](50) NULL,
	[ШиринаКабины] [nvarchar](50) NULL,
	[ГлубинаКабины] [nvarchar](50) NULL,
	[ВысотаКабины] [nvarchar](50) NULL,
	[ШиринаШахты] [nvarchar](50) NULL,
	[ГлубинаШахты] [nvarchar](50) NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [nvarchar](50) NULL,
	[МаксВысотаПодъема] [nvarchar](50) NULL,
	[ОстановокКабины] [nvarchar](50) NULL,
 CONSTRAINT [PK_МалыйГрузовойЛифтИмпорт] PRIMARY KEY CLUSTERED 
(
	[elevator_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[МодельныйРядПегасИмпорт]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[МодельныйРядПегасИмпорт](
	[Pegas_id] [int] NOT NULL,
	[ИндексЛифта] [nvarchar](50) NULL,
	[Грузоподъемность] [nvarchar](50) NULL,
	[Скорость] [nvarchar](50) NULL,
	[ШиринаКабины] [nvarchar](50) NULL,
	[ГлубинаКабины] [nvarchar](50) NULL,
	[ВысотаКабины] [nvarchar](50) NULL,
	[ШтихмасКабины(мм)] [nvarchar](50) NULL,
	[ШиринаШахты] [nvarchar](50) NULL,
	[ГлубинаШахты] [nvarchar](50) NULL,
	[Противовес] [nvarchar](50) NULL,
	[ШиринаПроемаДверей] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Pegas_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FreightElevChanged] ([freightElevatorID_old], [freightElevatorID_new], [ИндексЛифта_old], [ИндексЛифта_new], [Грузоподъемность_old], [Грузоподъемность_new], [Скорость_old], [Скорость_new], [ШиринаКабины_old], [ШиринаКабины_new], [ГлубинаКабины_old], [ГлубинаКабины_new], [ВысотаКабины_old], [ВысотаКабины_new], [ШиринаШахты_old], [ШиринаШахты_new], [ГлубинаШахты_old], [ГлубинаШахты_new], [Противовес_old], [Противовес_new], [ШиринаПроемаДверей_old], [ШиринаПроемаДверей_new], [МаксВысотаПодъема_old], [МаксВысотаПодъема_new], [ОстановокКабины_old], [ОстановокКабины_new], [Дата_изменения]) VALUES (2, 2, N'ЛГО-5500К', N'ЛГО-5500К', 500, 700, 0.5, 0.7, 1435, 1535, 2000, 1000, 2000, 1500, 2100, 1100, 2200, 1200, N'справа, слева
', N'слева
', N'1250
', N'1250
', 75, 55, 20, 10, CAST(N'2021-04-04T19:20:48.197' AS DateTime))
INSERT [dbo].[PegasChanged] ([Pegas_id_old], [Pegas_id_id_new], [ИндексЛифта_old], [ИндексЛифта_new], [Грузоподъемность_old], [Грузоподъемность_new], [Скорость_old], [Скорость_new], [ШиринаКабины_old], [ШиринаКабины_new], [ГлубинаКабины_old], [ГлубинаКабины_new], [ВысотаКабины_old], [ВысотаКабины_new], [ШтихмасКабины_old], [ШтихмасКабины_new], [ШиринаШахты_old], [ШиринаШахты_new], [ГлубинаШахты_old], [ГлубинаШахты_new], [Противовес_old], [Противовес_new], [ШиринаПроемаДверей_old], [ШиринаПроемаДверей_new], [Дата_изменения]) VALUES (1, 1, N'П0411', N'П0411gfdgdf', 400, 23123, N'0.71; 1.0; 1.6;', N'0.71; 1.0; 1.6;', 1100, 2312, 1050, 1212, 2100, 3443, 1200, 21321, 1550, 213234, 1550, 1212, N'сзади', N'сзади', 700, 334, CAST(N'2021-04-05T14:47:01.630' AS DateTime))
INSERT [dbo].[SmallElevChanged] ([elevator_id_old], [elevator_id_new], [ИндексЛифта_old], [ИндексЛифта_new], [Грузоподъемность_old], [Грузоподъемность_new], [Скорость_old], [Скорость_new], [ШиринаКабины_old], [ШиринаКабины_new], [ГлубинаКабины_old], [ГлубинаКабины_new], [ВысотаКабины_old], [ВысотаКабины_new], [ШиринаШахты_old], [ШиринаШахты_new], [ГлубинаШахты_old], [ГлубинаШахты_new], [Противовес_old], [Противовес_new], [ШиринаПроемаДверей_old], [ШиринаПроемаДверей_new], [МаксВысотаПодъема_old], [МаксВысотаПодъема_new], [ОстановокКабины_old], [ОстановокКабины_new], [Дата_изменения]) VALUES (2, 2, N'ЛГМ-0101Б', N'ЛГМ-0101В', 100, 1000, 0.5, 0.9, 890, 8900, 630, 6300, 1000, 10000, 1300, 13000, 750, 7500, N'справа,слева', N'справа,слева', N'860/900 верт.', N'860/900 верт.', 45, 45, 14, 14, CAST(N'2021-04-05T13:32:07.880' AS DateTime))
INSERT [dbo].[ГрузовойЛифт] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (1, N'ЛГО-0500К', 500, 0.5, 1435, 2000, 2000, 2100, 2200, N'справа, слева
', N'1250
', 75, 20)
INSERT [dbo].[ГрузовойЛифт] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (2, N'ЛГО-5500К', 700, 0.7, 1535, 1000, 1500, 1100, 1200, N'слева
', N'1250
', 55, 10)
SET IDENTITY_INSERT [dbo].[ГрузовойЛифтИстория] ON 

INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (4, N'2', N'Добавлен лифт с индексомЛГО-0500К категории "Грузовой лифт"', CAST(N'2021-03-25T12:22:52.080' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (5, N'3', N'Добавлен лифт с индексом ЛГО-0550К категории "Грузовой лифт"', CAST(N'2021-03-25T12:31:14.190' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (6, N'2', N'Обновлен лифт с индексом ЛГО-1000К категории "Грузовой лифт"', CAST(N'2021-03-25T12:42:08.367' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (7, N'3', N'Удален лифт с индексом ЛГО-0550К категории "Грузовой лифт"', CAST(N'2021-03-25T12:42:11.387' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (8, N'3', N'Добавлен лифт с индексом ЛГМ-0101В  категории "Грузовой лифт"', CAST(N'2021-03-25T12:55:53.013' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (9, N'3', N'Обновлен лифт с индексом ЛГМ-0101В  категории " Малый Грузовой лифт"', CAST(N'2021-03-25T13:00:44.420' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (10, N'3', N'Удален лифт с индексом ЛГМ-0101В  категории " Малый Грузовой лифт"', CAST(N'2021-03-25T13:00:59.280' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (11, N'2', N'Добавлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:18.300' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (12, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:21.490' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (13, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:24.360' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (14, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:28.803' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (15, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:31.473' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (16, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:34.117' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (17, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:36.987' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (18, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:39.843' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (19, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:43.217' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (20, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:17:48.350' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (21, N'2', N'Обновлен лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:18:00.903' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (22, N'2', N'Удален лифт с индексом П0412  категории " Модельный Ряд Пегас"', CAST(N'2021-03-25T13:18:07.630' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (23, N'2', N'Обновлен лифт с индексом ЛГО-550К категории "Грузовой лифт"', CAST(N'2021-03-25T18:01:17.437' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (24, N'2', N'Обновлен лифт с индексом ЛГО-5500К категории "Грузовой лифт"', CAST(N'2021-03-25T18:25:18.170' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (25, N'3', N'Добавлен лифт с индексом ЛГО-5500А категории "Грузовой лифт"', CAST(N'2021-03-26T10:51:59.793' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (26, N'3', N'Обновлен лифт с индексом ЛГО-5500А категории "Грузовой лифт"', CAST(N'2021-03-26T10:53:48.890' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (27, N'3', N'Удален лифт с индексом ЛГО-5500А категории "Грузовой лифт"', CAST(N'2021-03-26T10:54:55.677' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (28, N'2', N'Обновлен лифт с индексом ЛГО-5500К категории "Грузовой лифт"', CAST(N'2021-04-04T19:20:48.183' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (29, N'2', N'Обновлен лифт с индексом ЛГМ-0101В  категории " Малый Грузовой лифт"', CAST(N'2021-04-05T13:32:07.870' AS DateTime))
INSERT [dbo].[ГрузовойЛифтИстория] ([ID], [ElevatorIndex], [Operation], [CreateAt]) VALUES (39, N'1', N'Обновлен лифт с индексом П0411gfdgdf  категории " Модельный Ряд Пегас"', CAST(N'2021-04-05T14:47:01.620' AS DateTime))
SET IDENTITY_INSERT [dbo].[ГрузовойЛифтИстория] OFF
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (1, N'ЛГО-0500К', N'500', N'0,5', N'1435', N'2000', N'2000', N'2100', N'2200', N'справа, слева', N'1250', N'75', N'20')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (2, N'ЛГО-0520К', N'500', N'0,5', N'1000', N'1500', N'2000', N'1600', N'1700', N'справа, слева', N'850', N'75', N'20')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (3, N'ЛГО-0520КМ', N'500', N'0,5', N'1000', N'1000', N'2000', N'1600', N'1200', N'справа, слева', N'850', N'75', N'20')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (4, N'ЛГО-0550К', N'500', N'0,5', N'1000', N'1500', N'2000', N'1700', N'1700', N'справа, слева', N'850', N'25', N'8')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (5, N'ЛГВ-0570К', N'500', N'0,5', N'1435', N'2000', N'2000', N'2200', N'2200', N'справа, слева', N'1250', N'25', N'8')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (6, N'ЛГО-1000К', N'1000', N'0,5', N'1400', N'2000', N'2200', N'2100', N'2200', N'справа, слева', N'1250', N'75', N'20')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (7, N'ЛГО-1010К', N'1000', N'0,5', N'2000', N'2500', N'2200', N'2600', N'2700', N'справа, слева', N'1650', N'75', N'20')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (8, N'ЛГВ-1050К', N'1000', N'0,5', N'1400', N'2000', N'2200', N'2250', N'2200', N'справа, слева', N'1250', N'25', N'8')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (9, N'ЛГВ-1070К', N'1000', N'0,5', N'2000', N'2500', N'2200', N'2750', N'2700', N'справа, слева', N'1650', N'25', N'8')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (10, N'ЛГО-2000К', N'2000', N'0,5', N'2000', N'2500', N'2200', N'2750', N'2700', N'справа, слева', N'1650', N'45', N'14')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (11, N'ЛГО-2020К', N'2000', N'0,5', N'1900', N'3000', N'2200', N'2750', N'3200', N'справа, слева', N'1650', N'45', N'14')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (12, N'ЛГВ-2050К', N'2000', N'0,5', N'2000', N'2500', N'2200', N'2850', N'2700', N'справа, слева', N'1650', N'25', N'8')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (13, N'ЛГО-3200К-А', N'3200', N'0,5', N'1900', N'3000', N'2200', N'2750', N'3200', N'справа, слева', N'1650', N'45', N'14')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (14, N'ЛГО-3200К-Б', N'3200', N'0,5', N'2400', N'3500', N'2200', N'3250', N'3700', N'справа, слева', N'2050', N'45', N'14')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (15, N'ЛГО-3210К-Б', N'3200', N'0,5', N'2400', N'3500', N'2700', N'3250', N'3700', N'справа, слева', N'2050', N'45', N'14')
INSERT [dbo].[ГрузовойЛифтТест] ([freightElevatorID], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (16, N'ЛГО-5000К', N'5000', N'0,25', N'2900', N'4000', N'2400', N'3750', N'4200', N'справа, слева', N'2450', N'45', N'14')
INSERT [dbo].[МалыйГрузовойЛифт] ([elevator_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (1, N'ЛГМ-0101А', 100, 0.5, 890, 630, 1000, 1544, 914, N'справа,слева', N'860/900 верт.', 5.2, 2)
INSERT [dbo].[МалыйГрузовойЛифт] ([elevator_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (2, N'ЛГМ-0101В', 1000, 0.9, 8900, 6300, 10000, 13000, 7500, N'справа,слева', N'860/900 верт.', 45, 14)
INSERT [dbo].[МалыйГрузовойЛифтИмпорт] ([elevator_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (1, N'ЛГМ-0101А', N'100', N'0,5', N'890', N'630', N'1000', N'1544', N'914', N'справа,слева', N'860/900 верт.', N'5,2', N'2')
INSERT [dbo].[МалыйГрузовойЛифтИмпорт] ([elevator_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей], [МаксВысотаПодъема], [ОстановокКабины]) VALUES (2, N'ЛГМ-0101Б', N'100', N'0,5', N'890', N'630', N'1000', N'1300', N'750', N'справа,слева', N'860/900 верт.', N'45', N'14')
INSERT [dbo].[МодельныйРядПегас] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (1, N'П0411gfdgdf', 23123, N'0.71; 1.0; 1.6;', 2312, 1212, 3443, 21321, 213234, 1212, N'сзади', 334)
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (1, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1050', N'2100', N'1200', N'1550', N'1550', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (2, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1050', N'2100', N'1200', N'1550', N'1650', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (3, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1050', N'2100', N'1200', N'1750', N'1650', N'сзади', N'800')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (4, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1750', N'1650', N'сзади', N'800')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (5, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1550', N'1650', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (6, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1750', N'1650', N'сзади', N'800')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (7, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1600', N'1900', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (8, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1700', N'1550', N'сзади', N'650')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (9, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'1100', N'1100', N'2100', N'1200', N'1600', N'1700', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (10, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1550', N'1520', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (11, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1550', N'1650', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (12, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1550', N'1700', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (13, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1600', N'1900', N'сзади', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (14, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1450', N'1700', N'сзади', N'650')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (15, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1700', N'1500', N'сбоку', N'650')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (16, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1700', N'1550', N'сбоку', N'700')
INSERT [dbo].[МодельныйРядПегасИмпорт] ([Pegas_id], [ИндексЛифта], [Грузоподъемность], [Скорость], [ШиринаКабины], [ГлубинаКабины], [ВысотаКабины], [ШтихмасКабины(мм)], [ШиринаШахты], [ГлубинаШахты], [Противовес], [ШиринаПроемаДверей]) VALUES (17, N'П0411', N'400', N'0.71; 1.0; 1.6;', N'950', N'1100', N'2100', N'1050', N'1600', N'1700', N'сбоку', N'700')
ALTER TABLE [dbo].[ГрузовойЛифтИстория] ADD  DEFAULT (getdate()) FOR [CreateAt]
GO
/****** Object:  StoredProcedure [dbo].[ElevatorsSpecifications]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ElevatorsSpecifications] AS
BEGIN
SELECT ГрузовойЛифт.ИндексЛифта, ГрузовойЛифт.Грузоподъемность FROM [ГрузовойЛифт]
UNION ALL
SELECT МалыйГрузовойЛифт.ИндексЛифта, МалыйГрузовойЛифт.Грузоподъемность FROM  [МалыйГрузовойЛифт]
UNION ALL
SELECT МодельныйРядПегас.ИндексЛифта, МодельныйРядПегас.Грузоподъемность FROM [МодельныйРядПегас]
END
GO
/****** Object:  StoredProcedure [dbo].[FreightElevatorTestDelData]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FreightElevatorTestDelData] AS
BEGIN
 TRUNCATE TABLE [ГрузовойЛифтТест]
END;
GO
/****** Object:  StoredProcedure [dbo].[PegasImportDelData]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PegasImportDelData] AS
BEGIN
 TRUNCATE TABLE [МодельныйРядПегасИмпорт]
END;
GO
/****** Object:  StoredProcedure [dbo].[SmallFreightElevatorTestDelData]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SmallFreightElevatorTestDelData] AS
BEGIN
 TRUNCATE TABLE [МалыйГрузовойЛифтИмпорт]
END;
GO
/****** Object:  Trigger [dbo].[changed_FreightElevator]    Script Date: 06.04.2021 18:20:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[changed_FreightElevator]
ON [dbo].[ГрузовойЛифт]
AFTER UPDATE
AS
BEGIN
DECLARE @freightElevatorID_old INT
DECLARE @freightElevatorID_new INT
DECLARE @ИндексЛифта_old nvarchar(50)
DECLARE @ИндексЛифта_new nvarchar(50)
DECLARE @Грузоподъемность_old INT
DECLARE @Грузоподъемность_new INT
DECLARE @Скорость_old float
DECLARE @Скорость_new float
DECLARE @ШиринаКабины_old float
DECLARE @ШиринаКабины_new float
DECLARE @ГлубинаКабины_old float
DECLARE @ГлубинаКабины_new float
DECLARE @ВысотаКабины_old float
DECLARE @ВысотаКабины_new float
DECLARE @ШиринаШахты_old float
DECLARE @ШиринаШахты_new float
DECLARE @ГлубинаШахты_old float
DECLARE @ГлубинаШахты_new float
DECLARE @Противовес_old nvarchar(50)
DECLARE @Противовес_new nvarchar(50)
DECLARE @ШиринаПроемаДверей_old nvarchar(50)
DECLARE @ШиринаПроемаДверей_new nvarchar(50)
DECLARE @МаксВысотаПодъема_old float
DECLARE @МаксВысотаПодъема_new float
DECLARE @ОстановокКабины_old INT
DECLARE @ОстановокКабины_new INT

SELECT @freightElevatorID_old = (SELECT freightElevatorID FROM DELETED)
SELECT @freightElevatorID_new = (SELECT freightElevatorID FROM INSERTED)
SELECT @ИндексЛифта_old = (SELECT ИндексЛифта FROM DELETED)       
SELECT @ИндексЛифта_new = (SELECT ИндексЛифта FROM INSERTED)
SELECT @Грузоподъемность_old = (SELECT Грузоподъемность FROM DELETED)
SELECT @Грузоподъемность_new = (SELECT Грузоподъемность FROM INSERTED)
SELECT @Скорость_old = (SELECT Скорость FROM DELETED)
SELECT @Скорость_new = (SELECT Скорость FROM INSERTED)
SELECT @ШиринаКабины_old = (SELECT ШиринаКабины FROM DELETED)
SELECT @ШиринаКабины_new = (SELECT ШиринаКабины FROM INSERTED)
SELECT @ГлубинаКабины_old = (SELECT ГлубинаКабины FROM DELETED)
SELECT @ГлубинаКабины_new = (SELECT ГлубинаКабины FROM INSERTED)
SELECT @ВысотаКабины_old = (SELECT ВысотаКабины FROM DELETED)       
SELECT @ВысотаКабины_new = (SELECT ВысотаКабины FROM INSERTED)
SELECT @ШиринаШахты_old = (SELECT ШиринаШахты FROM DELETED)
SELECT @ШиринаШахты_new = (SELECT ШиринаШахты FROM INSERTED)
SELECT @ГлубинаШахты_old = (SELECT ГлубинаШахты FROM DELETED)
SELECT @ГлубинаШахты_new = (SELECT ГлубинаШахты FROM INSERTED)
SELECT @Противовес_old = (SELECT Противовес FROM DELETED)
SELECT @Противовес_new = (SELECT Противовес FROM INSERTED)

SELECT @ШиринаПроемаДверей_old = (SELECT ШиринаПроемаДверей FROM DELETED)
SELECT @ШиринаПроемаДверей_new = (SELECT ШиринаПроемаДверей FROM INSERTED)
SELECT @МаксВысотаПодъема_old = (SELECT МаксВысотаПодъема FROM DELETED)
SELECT @МаксВысотаПодъема_new = (SELECT МаксВысотаПодъема FROM INSERTED)
SELECT @ОстановокКабины_old = (SELECT ОстановокКабины FROM DELETED)
SELECT @ОстановокКабины_new = (SELECT ОстановокКабины FROM INSERTED)

INSERT INTO FreightElevChanged VALUES (@freightElevatorID_old, @freightElevatorID_new, @ИндексЛифта_old,@ИндексЛифта_new,
@Грузоподъемность_old,@Грузоподъемность_new, @Скорость_old, @Скорость_new,@ШиринаКабины_old,@ШиринаКабины_new,@ГлубинаКабины_old,@ГлубинаКабины_new,
@ВысотаКабины_old,@ВысотаКабины_new,@ШиринаШахты_old,@ШиринаШахты_new,@ГлубинаШахты_old, @ГлубинаШахты_new,@Противовес_old, @Противовес_new,
@ШиринаПроемаДверей_old,@ШиринаПроемаДверей_new,@МаксВысотаПодъема_old,@МаксВысотаПодъема_new,@ОстановокКабины_old,@ОстановокКабины_new,GETDATE())
END
GO
ALTER TABLE [dbo].[ГрузовойЛифт] ENABLE TRIGGER [changed_FreightElevator]
GO
/****** Object:  Trigger [dbo].[FreightElevatorDelete]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[FreightElevatorDelete]
  ON [dbo].[ГрузовойЛифт]
  AFTER DELETE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT freightElevatorID ,'Удален лифт с индексом ' + ИндексЛифта + ' категории "Грузовой лифт"'
  FROM DELETED
GO
ALTER TABLE [dbo].[ГрузовойЛифт] ENABLE TRIGGER [FreightElevatorDelete]
GO
/****** Object:  Trigger [dbo].[FreightElevatorInsert]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[FreightElevatorInsert]
  ON [dbo].[ГрузовойЛифт]
  AFTER INSERT
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT freightElevatorID ,'Добавлен лифт с индексом ' + ИндексЛифта + ' категории "Грузовой лифт"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[ГрузовойЛифт] ENABLE TRIGGER [FreightElevatorInsert]
GO
/****** Object:  Trigger [dbo].[FreightElevatorUpdate]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[FreightElevatorUpdate]
  ON [dbo].[ГрузовойЛифт]
  AFTER UPDATE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT freightElevatorID ,'Обновлен лифт с индексом ' + ИндексЛифта + ' категории "Грузовой лифт"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[ГрузовойЛифт] ENABLE TRIGGER [FreightElevatorUpdate]
GO
/****** Object:  Trigger [dbo].[changed_SmallElevator]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[changed_SmallElevator]
ON [dbo].[МалыйГрузовойЛифт]
AFTER UPDATE
AS
BEGIN
DECLARE @elevator_id_old INT
DECLARE @elevator_id_new INT
DECLARE @ИндексЛифта_old nvarchar(50)
DECLARE @ИндексЛифта_new nvarchar(50)
DECLARE @Грузоподъемность_old INT
DECLARE @Грузоподъемность_new INT
DECLARE @Скорость_old float
DECLARE @Скорость_new float
DECLARE @ШиринаКабины_old float
DECLARE @ШиринаКабины_new float
DECLARE @ГлубинаКабины_old float
DECLARE @ГлубинаКабины_new float
DECLARE @ВысотаКабины_old float
DECLARE @ВысотаКабины_new float
DECLARE @ШиринаШахты_old float
DECLARE @ШиринаШахты_new float
DECLARE @ГлубинаШахты_old float
DECLARE @ГлубинаШахты_new float
DECLARE @Противовес_old nvarchar(50)
DECLARE @Противовес_new nvarchar(50)
DECLARE @ШиринаПроемаДверей_old nvarchar(50)
DECLARE @ШиринаПроемаДверей_new nvarchar(50)
DECLARE @МаксВысотаПодъема_old float
DECLARE @МаксВысотаПодъема_new float
DECLARE @ОстановокКабины_old INT
DECLARE @ОстановокКабины_new INT

SELECT @elevator_id_old = (SELECT elevator_id FROM DELETED)
SELECT @elevator_id_new = (SELECT elevator_id FROM INSERTED)
SELECT @ИндексЛифта_old = (SELECT ИндексЛифта FROM DELETED)       
SELECT @ИндексЛифта_new = (SELECT ИндексЛифта FROM INSERTED)
SELECT @Грузоподъемность_old = (SELECT Грузоподъемность FROM DELETED)
SELECT @Грузоподъемность_new = (SELECT Грузоподъемность FROM INSERTED)
SELECT @Скорость_old = (SELECT Скорость FROM DELETED)
SELECT @Скорость_new = (SELECT Скорость FROM INSERTED)
SELECT @ШиринаКабины_old = (SELECT ШиринаКабины FROM DELETED)
SELECT @ШиринаКабины_new = (SELECT ШиринаКабины FROM INSERTED)
SELECT @ГлубинаКабины_old = (SELECT ГлубинаКабины FROM DELETED)
SELECT @ГлубинаКабины_new = (SELECT ГлубинаКабины FROM INSERTED)
SELECT @ВысотаКабины_old = (SELECT ВысотаКабины FROM DELETED)       
SELECT @ВысотаКабины_new = (SELECT ВысотаКабины FROM INSERTED)
SELECT @ШиринаШахты_old = (SELECT ШиринаШахты FROM DELETED)
SELECT @ШиринаШахты_new = (SELECT ШиринаШахты FROM INSERTED)
SELECT @ГлубинаШахты_old = (SELECT ГлубинаШахты FROM DELETED)
SELECT @ГлубинаШахты_new = (SELECT ГлубинаШахты FROM INSERTED)
SELECT @Противовес_old = (SELECT Противовес FROM DELETED)
SELECT @Противовес_new = (SELECT Противовес FROM INSERTED)

SELECT @ШиринаПроемаДверей_old = (SELECT ШиринаПроемаДверей FROM DELETED)
SELECT @ШиринаПроемаДверей_new = (SELECT ШиринаПроемаДверей FROM INSERTED)
SELECT @МаксВысотаПодъема_old = (SELECT МаксВысотаПодъема FROM DELETED)
SELECT @МаксВысотаПодъема_new = (SELECT МаксВысотаПодъема FROM INSERTED)
SELECT @ОстановокКабины_old = (SELECT ОстановокКабины FROM DELETED)
SELECT @ОстановокКабины_new = (SELECT ОстановокКабины FROM INSERTED)

INSERT INTO SmallElevChanged VALUES (@elevator_id_old, @elevator_id_new, @ИндексЛифта_old,@ИндексЛифта_new,
@Грузоподъемность_old,@Грузоподъемность_new, @Скорость_old, @Скорость_new,@ШиринаКабины_old,@ШиринаКабины_new,@ГлубинаКабины_old,@ГлубинаКабины_new,
@ВысотаКабины_old,@ВысотаКабины_new,@ШиринаШахты_old,@ШиринаШахты_new,@ГлубинаШахты_old, @ГлубинаШахты_new,@Противовес_old, @Противовес_new,
@ШиринаПроемаДверей_old,@ШиринаПроемаДверей_new,@МаксВысотаПодъема_old,@МаксВысотаПодъема_new,@ОстановокКабины_old,@ОстановокКабины_new,GETDATE())
END
GO
ALTER TABLE [dbo].[МалыйГрузовойЛифт] ENABLE TRIGGER [changed_SmallElevator]
GO
/****** Object:  Trigger [dbo].[SmallFreightElevatorDelete]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[SmallFreightElevatorDelete]
  ON [dbo].[МалыйГрузовойЛифт]
  AFTER DELETE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT elevator_id ,'Удален лифт с индексом ' + ИндексЛифта + '  категории " Малый Грузовой лифт"'
  FROM DELETED
GO
ALTER TABLE [dbo].[МалыйГрузовойЛифт] ENABLE TRIGGER [SmallFreightElevatorDelete]
GO
/****** Object:  Trigger [dbo].[SmallFreightElevatorINSERT]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[SmallFreightElevatorINSERT]
  ON [dbo].[МалыйГрузовойЛифт]
  AFTER INSERT
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT elevator_id ,'Добавлен лифт с индексом ' + ИндексЛифта + '  категории " Малый Грузовой лифт"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[МалыйГрузовойЛифт] ENABLE TRIGGER [SmallFreightElevatorINSERT]
GO
/****** Object:  Trigger [dbo].[SmallFreightElevatorUpdate]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[SmallFreightElevatorUpdate]
  ON [dbo].[МалыйГрузовойЛифт]
  AFTER UPDATE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT elevator_id ,'Обновлен лифт с индексом ' + ИндексЛифта + '  категории " Малый Грузовой лифт"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[МалыйГрузовойЛифт] ENABLE TRIGGER [SmallFreightElevatorUpdate]
GO
/****** Object:  Trigger [dbo].[changed_PegasElevator]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[changed_PegasElevator]
ON [dbo].[МодельныйРядПегас]
AFTER UPDATE
AS
BEGIN
DECLARE @Pegas_id_old INT
DECLARE @Pegas_id_new INT
DECLARE @ИндексЛифта_old nvarchar(50)
DECLARE @ИндексЛифта_new nvarchar(50)
DECLARE @Грузоподъемность_old INT
DECLARE @Грузоподъемность_new INT
DECLARE @Скорость_old nvarchar(50)
DECLARE @Скорость_new nvarchar(50)
DECLARE @ШиринаКабины_old float
DECLARE @ШиринаКабины_new float
DECLARE @ГлубинаКабины_old float
DECLARE @ГлубинаКабины_new float
DECLARE @ВысотаКабины_old float
DECLARE @ВысотаКабины_new float
DECLARE @ШтихмасКабины_old float
DECLARE @ШтихмасКабины_new float
DECLARE @ШиринаШахты_old float
DECLARE @ШиринаШахты_new float
DECLARE @ГлубинаШахты_old float
DECLARE @ГлубинаШахты_new float
DECLARE @Противовес_old nvarchar(50)
DECLARE @Противовес_new nvarchar(50)
DECLARE @ШиринаПроемаДверей_old float
DECLARE @ШиринаПроемаДверей_new float

SELECT @Pegas_id_old = (SELECT Pegas_id FROM DELETED)
SELECT @Pegas_id_new = (SELECT Pegas_id FROM INSERTED)
SELECT @ИндексЛифта_old = (SELECT ИндексЛифта FROM DELETED)       
SELECT @ИндексЛифта_new = (SELECT ИндексЛифта FROM INSERTED)
SELECT @Грузоподъемность_old = (SELECT Грузоподъемность FROM DELETED)
SELECT @Грузоподъемность_new = (SELECT Грузоподъемность FROM INSERTED)
SELECT @Скорость_old = (SELECT Скорость FROM DELETED)
SELECT @Скорость_new = (SELECT Скорость FROM INSERTED)
SELECT @ШиринаКабины_old = (SELECT ШиринаКабины FROM DELETED)
SELECT @ШиринаКабины_new = (SELECT ШиринаКабины FROM INSERTED)
SELECT @ГлубинаКабины_old = (SELECT ГлубинаКабины FROM DELETED)
SELECT @ГлубинаКабины_new = (SELECT ГлубинаКабины FROM INSERTED)
SELECT @ВысотаКабины_old = (SELECT ВысотаКабины FROM DELETED)       
SELECT @ВысотаКабины_new = (SELECT ВысотаКабины FROM INSERTED)
SELECT @ШтихмасКабины_old = (SELECT ШтихмасКабины FROM DELETED)
SELECT @ШтихмасКабины_new = (SELECT ШтихмасКабины FROM INSERTED)
SELECT @ШиринаШахты_old = (SELECT ШиринаШахты FROM DELETED)
SELECT @ШиринаШахты_new = (SELECT ШиринаШахты FROM INSERTED)
SELECT @ГлубинаШахты_old = (SELECT ГлубинаШахты FROM DELETED)
SELECT @ГлубинаШахты_new = (SELECT ГлубинаШахты FROM INSERTED)
SELECT @Противовес_old = (SELECT Противовес FROM DELETED)
SELECT @Противовес_new = (SELECT Противовес FROM INSERTED)
SELECT @ШиринаПроемаДверей_old = (SELECT ШиринаПроемаДверей FROM DELETED)
SELECT @ШиринаПроемаДверей_new = (SELECT ШиринаПроемаДверей FROM INSERTED)


INSERT INTO PegasChanged VALUES (@Pegas_id_old, @Pegas_id_new, @ИндексЛифта_old,@ИндексЛифта_new,
@Грузоподъемность_old,@Грузоподъемность_new, @Скорость_old, @Скорость_new,@ШиринаКабины_old,@ШиринаКабины_new,@ГлубинаКабины_old,@ГлубинаКабины_new,
@ВысотаКабины_old,@ВысотаКабины_new,@ШтихмасКабины_old,@ШтихмасКабины_new, @ШиринаШахты_old,@ШиринаШахты_new,@ГлубинаШахты_old, @ГлубинаШахты_new,@Противовес_old, @Противовес_new,
@ШиринаПроемаДверей_old,@ШиринаПроемаДверей_new,GETDATE())
END
GO
ALTER TABLE [dbo].[МодельныйРядПегас] ENABLE TRIGGER [changed_PegasElevator]
GO
/****** Object:  Trigger [dbo].[PegasDelete]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[PegasDelete]
  ON [dbo].[МодельныйРядПегас]
  AFTER DELETE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT Pegas_id ,'Удален лифт с индексом ' + ИндексЛифта + '  категории " Модельный Ряд Пегас"'
  FROM DELETED
GO
ALTER TABLE [dbo].[МодельныйРядПегас] ENABLE TRIGGER [PegasDelete]
GO
/****** Object:  Trigger [dbo].[PegasInsert]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[PegasInsert]
  ON [dbo].[МодельныйРядПегас]
  AFTER INSERT
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT Pegas_id ,'Добавлен лифт с индексом ' + ИндексЛифта + '  категории " Модельный Ряд Пегас"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[МодельныйРядПегас] ENABLE TRIGGER [PegasInsert]
GO
/****** Object:  Trigger [dbo].[PegasUpdate]    Script Date: 06.04.2021 18:20:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE TRIGGER [dbo].[PegasUpdate]
  ON [dbo].[МодельныйРядПегас]
  AFTER UPDATE
  AS
  INSERT INTO ГрузовойЛифтИстория(ElevatorIndex,Operation)
  SELECT Pegas_id ,'Обновлен лифт с индексом ' + ИндексЛифта + '  категории " Модельный Ряд Пегас"'
  FROM INSERTED
GO
ALTER TABLE [dbo].[МодельныйРядПегас] ENABLE TRIGGER [PegasUpdate]
GO
