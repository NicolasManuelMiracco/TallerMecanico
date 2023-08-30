/*
EXEC dbo.actualizarVehiculo 
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.actualizarVehiculo                                                     */
/*+ Objetivo: Actualizar registro en Vehiculo.                                           */
/*+                                                                                      */
/*****************************************************************************************/
CREATE   proc [dbo].[actualizarVehiculo]
@Id int, 
@Marca varchar(50), 
@Modelo varchar(50), 
@Patente varchar(10)
AS
BEGIN
	update Vehiculo set Marca = @Marca, Modelo = @Modelo, Patente = @Patente where Id = @Id;
END