/*
EXEC dbo.listarPresupuestos 
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.listarPresupuestos                                                                          */
/*+ Objetivo: Listado de registros para la tabla Presupuesto                                                  */
/**************************************************************************************************************/
CREATE   proc [dbo].[listarPresupuestos]
AS
BEGIN
	SELECT * FROM Presupuesto;
END