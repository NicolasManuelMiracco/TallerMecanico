/*
EXEC dbo.cargaPresupuestos 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaPresupuestos                                                      */
/*+ Objetivo: Carga Masiva de Presupuestos, llamando a dbo.insertarPresupuesto           */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaPresupuestos]
AS
BEGIN
	Exec dbo.insertarPresupuesto @Nombre = 'Nicolas', @Apellido = 'Miracco', @Email = 'nmiracco@gmail.com', @Total = 450000, @IdVehiculo = 1; 
	Exec dbo.insertarPresupuesto @Nombre = 'Leopoldo', @Apellido = 'Miracco', @Email = 'lmiracco@gmail.com', @Total = 1125000, @IdVehiculo = 2; 
	Exec dbo.insertarPresupuesto @Nombre = 'Ulises', @Apellido = 'Miracco', @Email = 'umiracco@gmail.com', @Total = 225000, @IdVehiculo = 3; 
	Exec dbo.insertarPresupuesto @Nombre = 'Florencia', @Apellido = 'Miracco', @Email = 'fmiracco@gmail.com', @Total = 2500000, @IdVehiculo = 4; 
	Exec dbo.insertarPresupuesto @Nombre = 'Edgardo', @Apellido = 'Miracco', @Email = 'emiracco@gmail.com', @Total = 150000, @IdVehiculo = 5; 	
END