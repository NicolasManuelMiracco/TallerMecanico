/*
EXEC dbo.subtotalDesperfecto
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.subtotalDesperfecto                                                                             */
/*+ Objetivo: Listado de registros para la tabla Moto y Automóvil                                             */
/*+ Descripción: Se listan los registos de las tablas hijas de Vehiculo (Moto y Automovil)                    */
/*+ Se realiza una union entre dos Select (Automovil y Moto), completando los campos que no aplican en NULL   */
/**************************************************************************************************************/

CREATE   proc [dbo].[subtotalDesperfecto]
@IdDesperfecto int
AS
BEGIN
	select SUM(R.Precio)
	from Repuesto R, DesperfectoRepuesto DR
	where DR.IdRepuesto = R.Id and DR.IdDesperfecto = @IdDesperfecto;
END