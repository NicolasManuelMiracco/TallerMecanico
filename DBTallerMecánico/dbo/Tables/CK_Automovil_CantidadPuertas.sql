ALTER TABLE [dbo].[Automovil]  WITH CHECK ADD  CONSTRAINT [CK_Automovil_CantidadPuertas] CHECK  (([CantidadPuertas]>=(1) AND [CantidadPuertas]<=(10)))
GO

ALTER TABLE [dbo].[Automovil] CHECK CONSTRAINT [CK_Automovil_CantidadPuertas]
GO


GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'La Cantidad de Puertas para el Automóvil debe estar entre 1 y 10' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Automovil', @level2type=N'CONSTRAINT',@level2name=N'CK_Automovil_CantidadPuertas'