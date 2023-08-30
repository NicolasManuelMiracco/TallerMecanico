ALTER TABLE [dbo].[Desperfecto]  WITH CHECK ADD  CONSTRAINT [CK_Desperfecto_ManoDeObra] CHECK  (([ManoDeObra]>=(0)))
GO

ALTER TABLE [dbo].[Desperfecto] CHECK CONSTRAINT [CK_Desperfecto_ManoDeObra]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'El valor de Mano de obra para el Desperfecto, deber ser positivo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Desperfecto', @level2type=N'CONSTRAINT',@level2name=N'CK_Desperfecto_ManoDeObra'