﻿CREATE TABLE [dbo].[Moto](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdVehiculo] [bigint] NOT NULL,
	[Cilindrada] [varchar](50) NULL,
 CONSTRAINT [PK_Moto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]