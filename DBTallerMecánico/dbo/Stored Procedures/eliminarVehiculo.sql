/*
EXEC dbo.eliminarVehiculo 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.eliminarVehiculo                                                       */
/*+ Objetivo: Eliminación de un registro en Vehiculo a partir de @IdMoto OR @IdAutomovil */
/*+ Descripción: uno de los parámetros será nulo, dado que se elimina Automovil o Moto   */
/*****************************************************************************************/
CREATE   proc [dbo].[eliminarVehiculo]
@IdMoto int,
@IdAutomovil int
AS
BEGIN
	DECLARE @IdVehiculo int

	IF EXISTS (SELECT * FROM Moto M WHERE M.Id = @IdMoto)
		BEGIN
			select @idVehiculo = IdVehiculo from Moto where Id = @idMoto;
			delete from Moto where Id = @IdMoto;		
		END
	IF EXISTS (SELECT * FROM Automovil A WHERE A.Id = @IdAutomovil)
		BEGIN
			select @idVehiculo = IdVehiculo from Automovil where Id = @IdAutomovil;
			delete from Automovil where Id = @IdAutomovil;		
		END
	delete from Vehiculo where Id = @IdVehiculo;
END