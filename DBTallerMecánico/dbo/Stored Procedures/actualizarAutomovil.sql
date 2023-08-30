/*
EXEC dbo.actualizarAutomovil 
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.actualizarAutomovil                                                    */
/*+ Objetivo: Actualizar registro en Automovil.                                          */
/*+                                                                                      */
/*****************************************************************************************/
CREATE   proc [dbo].[actualizarAutomovil]
@Id int, 
@Tipo varchar(11), 
@CantidadPuertas int
AS
BEGIN
	update Automovil set Tipo = @Tipo, CantidadPuertas = @CantidadPuertas where Id = @Id;
END