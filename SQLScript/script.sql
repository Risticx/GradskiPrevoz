USE [Projekat]
GO
SET IDENTITY_INSERT [dbo].[Radnici] ON 

INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (1, N'Vozac', 15, N'Stefan', N'Ristic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (2, N'Kondukter', 16, N'Mirko', N'Mirkovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (3, N'Kondukter', 17, N'Rade', N'Markovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (4, N'Kondukter', 18, N'Martin', N'Cvetkovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (5, N'Kondukter', 19, N'Aca', N'Ackovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (6, N'Kondukter', 20, N'Sara', N'Saric')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (7, N'Kondukter', 21, N'Teodora', N'Stojkovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (8, N'Kondukter', 22, N'Marko', N'Markovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (9, N'Kondukter', 23, N'Filip', N'Filipovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (10, N'Kondukter', 24, N'Petar', N'Petrovic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (11, N'Kondukter', 25, N'Milos', N'Milosevic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (12, N'Kondukter', 26, N'Zoran', N'Zoric')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (13, N'Kondukter', 27, N'Mitar', N'Miric')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (14, N'Kondukter', 28, N'Predrag', N'Pekic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (15, N'Kondukter', 29, N'Nikola', N'Nikolic')
INSERT [dbo].[Radnici] ([ID], [RadnoMesto], [MatBr], [Ime], [Prezime]) VALUES (16, N'Kondukter', 30, N'Lazar', N'Lazarevic')
SET IDENTITY_INSERT [dbo].[Radnici] OFF
GO
SET IDENTITY_INSERT [dbo].[Autobusi] ON 

INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (2, N'NI-123-AA', 10, 2)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (3, N'NI-123-BB', 5000, 3)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (4, N'NI-123-CC', 14141, 4)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (5, N'NI-123-DD', 5465, 5)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (6, N'NI-123-EE', 656546, 6)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (7, N'NI-123-FF', 65156, 7)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (8, N'NI-123-GG', 94561, 8)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (9, N'NI-123-HH', 651551, 9)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (10, N'NI-123-II', 9484855, 10)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (11, N'NI-123-JJ', 5654, 11)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (12, N'NI-123-KK', 5465545, 12)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (13, N'NI-123-LL', 556565, 13)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (14, N'NI-123-MM', 9656564, 14)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (15, N'NI-123-NN', 4448944, 15)
INSERT [dbo].[Autobusi] ([ID], [RegistarskaOznaka], [Kilometraza], [RadnikId]) VALUES (16, N'NI-123-OO', 554844132, 16)
SET IDENTITY_INSERT [dbo].[Autobusi] OFF
GO
SET IDENTITY_INSERT [dbo].[Karte] ON 

INSERT [dbo].[Karte] ([ID], [BrojKarte], [VremeIzdavanja], [CenaKarte], [RadnikID]) VALUES (44, 15, CAST(N'2022-03-10T02:34:13.1864514' AS DateTime2), 60, 2)
INSERT [dbo].[Karte] ([ID], [BrojKarte], [VremeIzdavanja], [CenaKarte], [RadnikID]) VALUES (45, 69, CAST(N'2022-03-10T02:36:12.2290160' AS DateTime2), 61, 3)
SET IDENTITY_INSERT [dbo].[Karte] OFF
GO
SET IDENTITY_INSERT [dbo].[Zona] ON 

INSERT [dbo].[Zona] ([ID], [BrojZone], [NazivZone], [CenaKarte]) VALUES (1, 1, N'Prva', 60)
INSERT [dbo].[Zona] ([ID], [BrojZone], [NazivZone], [CenaKarte]) VALUES (2, 2, N'Druga', 80)
INSERT [dbo].[Zona] ([ID], [BrojZone], [NazivZone], [CenaKarte]) VALUES (3, 3, N'Treca', 120)
SET IDENTITY_INSERT [dbo].[Zona] OFF
GO
SET IDENTITY_INSERT [dbo].[Linjia] ON 

INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (1, 1, N'Minovo Naselje - Niska Banja', 10, 50, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (2, 2, N'Bubanj - Donja Vrezina', 11, 54, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (3, 3, N'Brzi Brod - Naselje Ratko Jovic', 10, 48, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (4, 4, N'Calije - Bubanj', 9, 50, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (5, 5, N'Zeleznicka Stanica - Somborska', 7, 40, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (6, 6, N'Zeleznicka Stanica - Duvaniste', 7, 40, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (7, 7, N'Sarajevska - Kalac Brdo', 16, 70, 2)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (8, 8, N'Novo Groblje - Gabrovacka Reka', 17, 50, 2)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (9, 9, N'Mokranjceva - Brankov Bjegovic', 16, 60, 2)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (10, 10, N'Naselje 9. Maj -  Cele Kula', 16, 55, 2)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (11, 11, N'Medosevac - Duvaniste', 20, 78, 3)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (12, 12, N'Donji Komren - Njegoseva', 21, 80, 3)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (13, 13, N'Trg Kralja Aleksandra - Cele Kula', 15, 50, 1)
INSERT [dbo].[Linjia] ([ID], [BrojLinije], [NazivLinije], [DuzinaLinije], [VremeObilaska], [ZonaID]) VALUES (14, 34, N'Kruzni', 20, 60, 1)
SET IDENTITY_INSERT [dbo].[Linjia] OFF
GO
SET IDENTITY_INSERT [dbo].[AutobusiLinija] ON 

INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (1, CAST(N'2022-07-01' AS Date), 2, 1)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (2, CAST(N'2022-07-01' AS Date), 3, 2)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (3, CAST(N'2022-07-01' AS Date), 4, 3)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (4, CAST(N'2022-07-01' AS Date), 5, 4)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (5, CAST(N'2022-07-01' AS Date), 6, 5)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (6, CAST(N'2022-07-01' AS Date), 7, 6)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (7, CAST(N'2022-07-01' AS Date), 8, 7)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (8, CAST(N'2022-07-01' AS Date), 9, 8)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (9, CAST(N'2022-07-01' AS Date), 10, 9)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (10, CAST(N'2022-07-01' AS Date), 11, 10)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (11, CAST(N'2022-07-01' AS Date), 12, 11)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (12, CAST(N'2022-07-01' AS Date), 13, 12)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (13, CAST(N'2022-07-01' AS Date), 14, 13)
INSERT [dbo].[AutobusiLinija] ([ID], [DanVoznje], [AutobusID], [LinijaID]) VALUES (14, CAST(N'2022-07-01' AS Date), 15, 14)
SET IDENTITY_INSERT [dbo].[AutobusiLinija] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220107181336_V1', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220107182402_V2', N'5.0.0')
GO
