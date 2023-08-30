CREATE TABLE [dbo].[Desperfecto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdPresupuesto] [bigint] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
	[ManoDeObra] [decimal](10, 2) NOT NULL,
	[Tiempo] [int] NOT NULL,
 CONSTRAINT [PK_Desperfecto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]