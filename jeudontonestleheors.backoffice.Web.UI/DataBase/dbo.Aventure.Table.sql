USE [JeuDontOnEstLeHeros.database.dev]
GO
/****** Object:  Table [dbo].[Aventure]    Script Date: 12/03/2024 9:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aventure](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titre] [nvarchar](250) NOT NULL,
	[dateCreation] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Aventure] ON 

INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (1, N'Aventure1', CAST(0x0000B1250015C5D7 AS DateTime))
INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (2, N'Aventure2', CAST(0x0000B1250015C7AA AS DateTime))
INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (3, N'Aventure3', CAST(0x0000B1250015D261 AS DateTime))
INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (4, N'Aventure 10', CAST(0x0000B12500163A6E AS DateTime))
INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (5, N'Titre', CAST(0x0000B12E010F98B3 AS DateTime))
INSERT [dbo].[Aventure] ([Id], [Titre], [dateCreation]) VALUES (6, N'Titre', CAST(0x0000B12E0118396F AS DateTime))
SET IDENTITY_INSERT [dbo].[Aventure] OFF
ALTER TABLE [dbo].[Aventure] ADD  CONSTRAINT [DF_Aventure_dateCreation]  DEFAULT (getdate()) FOR [dateCreation]
GO
