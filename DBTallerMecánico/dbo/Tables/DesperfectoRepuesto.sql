CREATE TABLE [dbo].[DesperfectoRepuesto](
	[IdDesperfecto] [bigint] NOT NULL,
	[IdRepuesto] [bigint] NOT NULL,
 CONSTRAINT [PK_DesperfectoRepuesto] PRIMARY KEY CLUSTERED 
(
	[IdDesperfecto] ASC,
	[IdRepuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]