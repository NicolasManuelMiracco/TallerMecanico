ALTER TABLE [dbo].[Repuesto]  WITH CHECK ADD  CONSTRAINT [CK_Repuesto_Precio] CHECK  (([Precio]>=(0)))
GO

ALTER TABLE [dbo].[Repuesto] CHECK CONSTRAINT [CK_Repuesto_Precio]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'El Precio del Repuesto no puede ser negativo.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Repuesto', @level2type=N'CONSTRAINT',@level2name=N'CK_Repuesto_Precio'