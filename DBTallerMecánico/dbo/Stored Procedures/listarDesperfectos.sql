/*
EXEC dbo.listarDesperfectos 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.listarDesperfectos                                                     */
/*+ Objetivo: Listado de registros para la tabla Desperfecto                             */
/*+ Descripción:                                                                         */
/*****************************************************************************************/
CREATE   proc [dbo].[listarDesperfectos]
@IdPresupuesto int
AS
BEGIN
	SELECT Id, Descripcion, ManoDeObra, Tiempo
	FROM Desperfecto
	WHERE Desperfecto.IdPresupuesto = @IdPresupuesto;
END