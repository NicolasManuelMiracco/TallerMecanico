/*
EXEC dbo.insertarMoto 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarMoto                                                           */
/*+ Objetivo: Inserción en Moto                                                          */
/*+ Descripción: se verifica la NO existencia previa                                     */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarMoto]
@Cilindrada varchar(50), 
@Marca varchar(50), 
@Modelo varchar(50), 
@Patente varchar(10)
AS
BEGIN
	DECLARE @IdVehiculo int;
	EXEC @IdVehiculo = dbo.insertarVehiculo @Marca, @Modelo, @Patente;
	INSERT INTO Moto values (@IdVehiculo, @Cilindrada);
END