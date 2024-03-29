USE [JeuDontOnEstLeHeros.database.dev]
GO
/****** Object:  Table [dbo].[Droide]    Script Date: 12/03/2024 9:30:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Droide](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricule] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Droide] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Droide] ON 

INSERT [dbo].[Droide] ([Id], [Matricule]) VALUES (1, N'1')
INSERT [dbo].[Droide] ([Id], [Matricule]) VALUES (2, N'4')
INSERT [dbo].[Droide] ([Id], [Matricule]) VALUES (3, N'10')
SET IDENTITY_INSERT [dbo].[Droide] OFF
