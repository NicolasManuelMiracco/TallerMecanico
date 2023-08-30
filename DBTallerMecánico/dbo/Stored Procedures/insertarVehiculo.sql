/*
EXEC dbo.insertarVehiculo 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarVehiculo                                                       */
/*+ Objetivo: Inserción en Vehiculo                                                      */
/*+ Descripción:                                                                         */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarVehiculo]
@Marca varchar(50), 
@Modelo varchar(50), 
@Patente varchar(10)
AS
BEGIN
	/* Retorna el autonumérico generado después de la inserción para mantener coherencia con el Automóvil o Moto que lo invoque al insertar */
	INSERT INTO Vehiculo values (@Marca, @Modelo, @Patente);		
	RETURN SCOPE_IDENTITY();
END