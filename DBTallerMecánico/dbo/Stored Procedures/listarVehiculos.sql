/*
EXEC dbo.listarVehiculos 
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.listarVehiculos                                                                             */
/*+ Objetivo: Listado de registros para la tabla Moto y Automóvil                                             */
/*+ Descripción: Se listan los registos de las tablas hijas de Vehiculo (Moto y Automovil)                    */
/*+ Se realiza una union entre dos Select (Automovil y Moto), completando los campos que no aplican en NULL   */
/**************************************************************************************************************/
CREATE   proc [dbo].[listarVehiculos]
AS
BEGIN
	SELECT V.Marca, V.Modelo, V.Patente, M.Id as IdMoto, M.Cilindrada, IdAuto = NULL, Puertas = NULL, Tipo = NULL, M.IdVehiculo 
	FROM Vehiculo AS V, Moto as M
	WHERE V.Id = M.IdVehiculo
	UNION
	SELECT V.Marca, V.Modelo, V.Patente, IdMoto = NULL, Cilindrada = NULL, A.Id as IdAuto, A.CantidadPuertas as Puertas, A.Tipo, A.IdVehiculo 
	FROM Vehiculo AS V, Automovil as A
	WHERE V.Id = A.IdVehiculo;
END