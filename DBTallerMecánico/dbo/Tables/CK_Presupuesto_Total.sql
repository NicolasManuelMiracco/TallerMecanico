ALTER TABLE [dbo].[Presupuesto]  WITH CHECK ADD  CONSTRAINT [CK_Presupuesto_Total] CHECK  (([Total]>=(0)))
GO

ALTER TABLE [dbo].[Presupuesto] CHECK CONSTRAINT [CK_Presupuesto_Total]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'El Total para el presupuesto no puede ser negativo.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Presupuesto', @level2type=N'CONSTRAINT',@level2name=N'CK_Presupuesto_Total'