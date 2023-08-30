/*
EXEC dbo.cargaAll
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaAll                                                               */
/*+ Objetivo: Carga ordenada total llamando a cada stored procedure                      */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaAll]
AS
BEGIN
	DELETE FROM Automovil
	DBCC CHECKIDENT ('Automovil', RESEED, 0);

	DELETE FROM Moto
	DBCC CHECKIDENT ('Moto', RESEED, 0);

	DELETE FROM DesperfectoRepuesto;
	
	DELETE FROM Repuesto;
	DBCC CHECKIDENT ('Repuesto', RESEED, 0);
	
	DELETE FROM Desperfecto;
	DBCC CHECKIDENT ('Desperfecto', RESEED, 0);	

	DELETE FROM Presupuesto;
	DBCC CHECKIDENT ('Presupuesto', RESEED, 0);	

	DELETE FROM Vehiculo
	DBCC CHECKIDENT ('Vehiculo', RESEED, 0);

	EXEC dbo.cargaAutomoviles;	/* Carga implícita de Vehículos */
	EXEC dbo.cargaMotos; /* Carga implícita de Vehículos */
	EXEC dbo.cargaPresupuestos;
	EXEC dbo.MassiveCharge; /* Carga de impuestos */
	EXEC dbo.cargaDesperfectos;
	EXEC dbo.cargaDesperfectosRepuestos;	
END