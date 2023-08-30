ALTER TABLE [dbo].[Automovil]  WITH CHECK ADD  CONSTRAINT [FK_Automovil_Vehiculo] FOREIGN KEY([IdVehiculo])
REFERENCES [dbo].[Vehiculo] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Automovil] CHECK CONSTRAINT [FK_Automovil_Vehiculo]
GO


GO


GO


GO


GO


GO


GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'La FK IdVehiculo (Automovil) debe coincidir con la PK Id (Vehiculo).' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Automovil', @level2type=N'CONSTRAINT',@level2name=N'FK_Automovil_Vehiculo'