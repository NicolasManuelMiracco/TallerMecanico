/*
EXEC dbo.insertarAutomovil 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarAutomovil                                                      */
/*+ Objetivo: Inserción en Automovil                                                     */
/*+ Descripción: se verifica la NO existencia previa                                     */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarAutomovil]
@Tipo varchar(11), 
@CantidadPuertas tinyint, 
@Marca varchar(50), 
@Modelo varchar(50), 
@Patente varchar(10)
AS
BEGIN	
	DECLARE @IdVehiculo int;
	EXEC @IdVehiculo = dbo.insertarVehiculo @Marca, @Modelo, @Patente;
	INSERT INTO Automovil values (@Tipo, @CantidadPuertas, @IdVehiculo);
END