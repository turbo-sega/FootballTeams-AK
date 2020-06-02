
/****** Object:  Table [dbo].[Championships]    Script Date: 6/1/2020 17:48:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Championships](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Country] [nvarchar](100) NULL,
	[IsNational] [bit] NOT NULL,
 CONSTRAINT [PK_Championships] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Players]    Script Date: 6/1/2020 17:48:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
	[Position] [nvarchar](100) NULL,
 CONSTRAINT [PK_Players] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 6/1/2020 17:48:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Country] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[Coaches] [nvarchar](500) NOT NULL,
	[History] [nvarchar](2000) NULL,
	[GameScheme] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamStatistics]    Script Date: 6/1/2020 17:48:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamStatistics](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[ChampionshipId] [int] NOT NULL,
	[Years] [nvarchar](20) NOT NULL,
	[IsChampion] [bit] NOT NULL,
 CONSTRAINT [PK_TeamStatistics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Teams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Teams_TeamId]
GO
ALTER TABLE [dbo].[TeamStatistics]  WITH CHECK ADD  CONSTRAINT [FK_TeamStatistics_Championships_ChampionshipId] FOREIGN KEY([ChampionshipId])
REFERENCES [dbo].[Championships] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeamStatistics] CHECK CONSTRAINT [FK_TeamStatistics_Championships_ChampionshipId]
GO
ALTER TABLE [dbo].[TeamStatistics]  WITH CHECK ADD  CONSTRAINT [FK_TeamStatistics_Teams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TeamStatistics] CHECK CONSTRAINT [FK_TeamStatistics_Teams_TeamId]
GO
