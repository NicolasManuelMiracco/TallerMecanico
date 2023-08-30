ALTER TABLE [dbo].[Automovil]  WITH NOCHECK ADD  CONSTRAINT [CK_Automovil_Tipo] CHECK  (([Tipo]='lujo' OR [Tipo]='utilitario' OR [Tipo]='monovolumen' OR [Tipo]='sedan' OR [Tipo]='compacto'))
GO

ALTER TABLE [dbo].[Automovil] CHECK CONSTRAINT [CK_Automovil_Tipo]
GO


GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'El tipo de Automóvil debe ser: compacto, sedan, monovolumen, utilitario o lujo.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Automovil', @level2type=N'CONSTRAINT',@level2name=N'CK_Automovil_Tipo'