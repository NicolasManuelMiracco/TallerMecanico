/*
EXEC dbo.sumatoriaMontoTotal @TipoVehiculo = 'Moto'
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.sumatoriaMontoTotal                                                                         */
/*+ Objetivo: Sumatoria del Monto Total de Presupuestos para Autos y para Motos                               */
/**************************************************************************************************************/

CREATE   proc [dbo].[sumatoriaMontoTotal]
@TipoVehiculo varchar(50)
AS
BEGIN
	DECLARE @Suma varchar(17)
	DECLARE @Error int
	SELECT @Error = 0

	IF @TipoVehiculo = 'Automovil'
		BEGIN
			SELECT @Suma = (
				SELECT SUM(PR.Total) 
				FROM Vehiculo AS V, Presupuesto AS PR, Automovil AS A
				WHERE A.IdVehiculo = V.Id and V.Id = PR.IdVehiculo 
			);
		END
	ELSE IF @TipoVehiculo = 'Moto'
		BEGIN
			SELECT @Suma = (
				SELECT SUM(PR.Total) 
				FROM Vehiculo AS V, Presupuesto AS PR, Moto as M
				WHERE M.IdVehiculo = V.Id and V.Id = PR.IdVehiculo 
			);
		END
	ELSE 
		BEGIN
			SELECT @Error = 1
		END

	IF @Error = 0
		BEGIN
			SELECT	'Return Value' = @Suma;
		END
	ELSE
		BEGIN
			SELECT	'Error tipo Vehículo'
		END
END