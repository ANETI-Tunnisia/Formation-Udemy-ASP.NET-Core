USE [JeuDontOnEstLeHeros.database.dev]
GO
/****** Object:  Table [dbo].[Paragraphe]    Script Date: 12/03/2024 9:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paragraphe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Titre] [varchar](250) NOT NULL,
	[Numero] [int] NOT NULL,
	[Description] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Paragraphe] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Paragraphe] ON 

INSERT [dbo].[Paragraphe] ([id], [Titre], [Numero], [Description]) VALUES (1, N'ali', 6, N'hbiuo')
INSERT [dbo].[Paragraphe] ([id], [Titre], [Numero], [Description]) VALUES (2, N'tutyu', 4, N'dfgerge')
INSERT [dbo].[Paragraphe] ([id], [Titre], [Numero], [Description]) VALUES (3, N'tutyu', 4, N'dfgerge')
INSERT [dbo].[Paragraphe] ([id], [Titre], [Numero], [Description]) VALUES (4, N'dgret', 5, N'ertret')
SET IDENTITY_INSERT [dbo].[Paragraphe] OFF
