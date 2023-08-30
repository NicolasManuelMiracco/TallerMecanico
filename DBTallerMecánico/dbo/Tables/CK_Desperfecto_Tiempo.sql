ALTER TABLE [dbo].[Desperfecto]  WITH CHECK ADD  CONSTRAINT [CK_Desperfecto_Tiempo] CHECK  (([Tiempo]>=(0)))
GO

ALTER TABLE [dbo].[Desperfecto] CHECK CONSTRAINT [CK_Desperfecto_Tiempo]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'El campo Tiempo para el Desperfecto no puede ser negativo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Desperfecto', @level2type=N'CONSTRAINT',@level2name=N'CK_Desperfecto_Tiempo'