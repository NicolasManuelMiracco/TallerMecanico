ALTER TABLE [dbo].[DesperfectoRepuesto]  WITH CHECK ADD  CONSTRAINT [FK_DesperfectoRepuesto_Repuesto] FOREIGN KEY([IdRepuesto])
REFERENCES [dbo].[Repuesto] ([Id])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[DesperfectoRepuesto] CHECK CONSTRAINT [FK_DesperfectoRepuesto_Repuesto]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'La FK IdRepuesto (DesperfectoRepuesto) debe coincidir con la PK Id (Repuesto).' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DesperfectoRepuesto', @level2type=N'CONSTRAINT',@level2name=N'FK_DesperfectoRepuesto_Repuesto'