SET IDENTITY_INSERT [dbo].[Championships] ON 
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (1, N'Серія А', N'Італія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (2, N'Кубок Італії', N'Італія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (3, N'Ла-Ліга', N'Іспанія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (4, N'Кубок Іспанії', N'Іспанія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (5, N'Прем''єр-ліга', N'Англія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (6, N'Кубок Англії', N'Англія', 1)
GO
INSERT [dbo].[Championships] ([Id], [Name], [Country], [IsNational]) VALUES (7, N'Ліга чемпіонів УЄФА', N'', 0)
GO
SET IDENTITY_INSERT [dbo].[Championships] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 
GO
INSERT [dbo].[Teams] ([Id], [Name], [Country], [City], [Coaches], [History], [GameScheme]) VALUES (1, N'Ювентус', N'Італія', N'Турин', N'Мауріціо Саррі', NULL, N'2-4-4')
GO
INSERT [dbo].[Teams] ([Id], [Name], [Country], [City], [Coaches], [History], [GameScheme]) VALUES (2, N'Барселона', N'Іспанія', N'Барселона', N'Ернесто Вальверде', NULL, N'2-4-4')
GO
INSERT [dbo].[Teams] ([Id], [Name], [Country], [City], [Coaches], [History], [GameScheme]) VALUES (3, N'Ліверпуль', N'Англія', N'Енфілд', N'Юрген Клопп', NULL, N'2-4-4')
GO
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[TeamStatistics] ON 
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (1, 1, 1, N'1983/84', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (2, 1, 1, N'1985/86', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (3, 1, 1, N'1994/95', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (4, 1, 1, N'1996/97', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (5, 1, 1, N'1997/98', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (6, 1, 1, N'2001/02', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (7, 1, 1, N'2002/03', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (8, 1, 1, N'2004/05', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (9, 1, 1, N'2005/06', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (10, 1, 1, N'2011/12', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (11, 1, 1, N'2012/13', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (12, 1, 1, N'2013/14', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (13, 1, 1, N'2014/15', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (14, 1, 1, N'2015/16', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (15, 1, 1, N'2016/17', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (16, 1, 1, N'2017/18', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (17, 1, 1, N'2018/19', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (18, 1, 2, N'1982/83', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (19, 1, 2, N'1989/90', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (20, 1, 2, N'1994/95', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (21, 1, 2, N'2014/15', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (22, 1, 2, N'2015/16', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (23, 1, 2, N'2017/18', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (24, 1, 7, N'1984/85', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (25, 1, 7, N'1995/96', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (26, 2, 3, N'1992/93', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (27, 2, 3, N'1994/95', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (28, 2, 3, N'1998/99', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (29, 2, 3, N'2004/05', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (30, 2, 3, N'2005/06', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (31, 2, 3, N'2008/09', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (32, 2, 3, N'2009/10', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (33, 2, 3, N'2010/11', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (34, 2, 3, N'2012/13', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (35, 2, 3, N'2014/15', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (36, 2, 3, N'2015/16', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (37, 2, 3, N'2017/18', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (38, 2, 4, N'1978', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (39, 2, 4, N'1981', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (40, 2, 4, N'1988', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (41, 2, 4, N'1990', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (42, 2, 4, N'1997', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (43, 2, 4, N'1998', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (44, 2, 4, N'2009', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (45, 2, 4, N'2012', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (46, 2, 4, N'2015', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (47, 2, 4, N'2016', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (48, 2, 4, N'2017', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (49, 2, 4, N'2018', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (50, 2, 7, N'1992', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (51, 2, 7, N'2006', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (52, 2, 7, N'2009', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (53, 2, 7, N'2011', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (54, 2, 7, N'2015', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (55, 3, 5, N'1979/80', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (56, 3, 5, N'1981/82', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (57, 3, 5, N'1985/86', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (58, 3, 5, N'1987/88', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (59, 3, 5, N'1989/90', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (60, 3, 6, N'1965', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (61, 3, 6, N'1974', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (62, 3, 6, N'1986', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (63, 3, 6, N'1989', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (64, 3, 6, N'1992', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (65, 3, 6, N'2001', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (66, 3, 6, N'2006', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (67, 3, 7, N'1977', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (68, 3, 7, N'1978', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (69, 3, 7, N'1981', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (70, 3, 7, N'1984', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (71, 3, 7, N'2005', 1)
GO
INSERT [dbo].[TeamStatistics] ([Id], [TeamId], [ChampionshipId], [Years], [IsChampion]) VALUES (72, 3, 7, N'2019', 1)
GO
SET IDENTITY_INSERT [dbo].[TeamStatistics] OFF
GO
SET IDENTITY_INSERT [dbo].[Players] ON 
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (1, 1, N'Войчех Шченсний', N'1', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (2, 1, N'Леонардо Бонуччі', N'19', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (3, 1, N'Матейс де Лігт', N'4', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (4, 1, N'Алекс Сандро', N'12', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (5, 1, N'Даніло', N'13', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (6, 1, N'Миралем Пяніч', N'5', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (7, 1, N'Блез Матюіді', N'14', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (8, 1, N'Айрон Ремзі', N'8', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (9, 1, N'Пауло Дібала', N'10', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (10, 1, N'Фредеріко Бернандескі', N'33', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (11, 1, N'Кріштіану Роналду', N'7', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (12, 2, N'Марк-Андре тер Штеген', N'22', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (13, 2, N'Нелсон Семеду', N'2', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (14, 2, N'Жерар Піке', N'3', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (15, 2, N'Жоржи Альба', N'18', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (16, 2, N'Самюель Умтіті', N'23', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (17, 2, N'Артуро Відаль', N'22', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (18, 2, N'Френкі де йонг', N'21', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (19, 2, N'Усман Дембеле', N'11', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (20, 2, N'Антуан Грізман', N'17', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (21, 2, N'Луіс Суарес', N'9', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (22, 2, N'Ліонель Мессі', N'10', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (23, 3, N'Алісон Беккер', N'13', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (24, 3, N'Трент Александр-Арнольд', N'66', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (25, 3, N'Вірджил ван Дейк', N'4', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (26, 3, N'Джо Гомес', N'12', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (27, 3, N'Ендрю Робертсон', N'26', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (28, 3, N'Садіо Мане', N'10', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (29, 3, N'Джордан Хендерсон', N'14', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (30, 3, N'Фабіньйо', N'3', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (31, 3, N'Мохамед салах', N'11', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (32, 3, N'Роберто Фірміно', N'9', NULL)
GO
INSERT [dbo].[Players] ([Id], [TeamId], [Name], [Number], [Position]) VALUES (33, 3, N'Дивок Орігі', N'27', NULL)
GO
SET IDENTITY_INSERT [dbo].[Players] OFF
GO
