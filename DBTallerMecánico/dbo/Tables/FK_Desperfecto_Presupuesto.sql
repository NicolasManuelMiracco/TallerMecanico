ALTER TABLE [dbo].[Desperfecto]  WITH CHECK ADD  CONSTRAINT [FK_Desperfecto_Presupuesto] FOREIGN KEY([IdPresupuesto])
REFERENCES [dbo].[Presupuesto] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Desperfecto] CHECK CONSTRAINT [FK_Desperfecto_Presupuesto]
GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'La FK IdPresupuesto (Desperfecto) debe coincidir con la PK Id (Presupuesto).' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Desperfecto', @level2type=N'CONSTRAINT',@level2name=N'FK_Desperfecto_Presupuesto'