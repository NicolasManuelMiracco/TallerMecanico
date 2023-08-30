/*
EXEC dbo.buscarVehiculos 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.buscarVehiculos                                                        */
/*+ Objetivo: Búsqueda de registros en Vehiculo segun parámetro @valor                   */
/*+                                                                                      */
/*****************************************************************************************/
CREATE   proc [dbo].[buscarVehiculos]
@valor varchar(50)
AS
BEGIN
	CREATE TABLE #ListadoAuxiliar
	(
		Marca VARCHAR(50),
		Modelo VARCHAR(50),
		Patente VARCHAR(50),
		IdMoto BIGINT,
		Cilindrada VARCHAR(50),
		IdAuto BIGINT,
		Puertas BIGINT,
		Tipo VARCHAR(11),
		IdVehiculo int
	)

	INSERT INTO #ListadoAuxiliar EXEC listarVehiculos

	SELECT *
	FROM #ListadoAuxiliar
	/* Se efectua una búsqueda de registros sobre los campos: Marca, Modelo y Patente */
	WHERE Marca like '%' + @valor + '%' or Modelo like '%' + @valor + '%' or Patente like '%' + @valor + '%';
END