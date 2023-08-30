/*
EXEC dbo.eliminarPresupuestosIncompletos 
*/

/************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                               */
/*+ Nombre  : dbo.eliminarPresupuestosIncompletos                                               */
/*+ Objetivo: Eliminar los registros incompletos                                                */
/*+ Descripción: Se buscan los parámetros por default, propios de un presupuesto sin completar. */
/*+              Se produce una eliminación en cascada hacia Desperfecto y DesperfectoRepuesto. */
/*+              Al momento de definir las relaciones se indicó eliminación en cascada          */
/************************************************************************************************/

CREATE   proc [dbo].[eliminarPresupuestosIncompletos]
AS
BEGIN
	delete from Presupuesto where Nombre = '' and Apellido = '' and Email = '@gmail.com' and Total = 0;
END