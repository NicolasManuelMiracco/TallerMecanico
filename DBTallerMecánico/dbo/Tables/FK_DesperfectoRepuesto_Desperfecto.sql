ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto] FOREIGN KEY([IdDesperfecto])
REFERENCES [dbo].[Desperfecto] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Desperfecto]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'La FK IdDesperfecto (DesperfectoRepuesto) debe coincidir con la PK Id (Desperfecto).' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DesperfectoRepuesto', @level2type=N'CONSTRAINT',@level2name=N'FK_DesperfectoRepuesto_Desperfecto'