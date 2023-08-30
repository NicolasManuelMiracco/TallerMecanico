/*
EXEC dbo.insertarPresupuesto 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarPresupuesto                                                    */
/*+ Objetivo: Inserción en Presupuesto                                                   */
/*+ Descripción: la constraint FK verifica existencia de registro en Vehiculo            */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarPresupuesto]
@Nombre varchar(100), 
@Apellido varchar(100), 
@Email varchar(100), 
@Total decimal, 
@IdVehiculo int, 
@Identity int OUT
AS
BEGIN
	INSERT INTO Presupuesto (Nombre, Apellido, Email, Total, IdVehiculo) VALUES (@Nombre, @Apellido, @Email, @Total, @IdVehiculo);
	SET @Identity = SCOPE_IDENTITY();
END