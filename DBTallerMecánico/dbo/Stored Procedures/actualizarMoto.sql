/*
EXEC dbo.actualizarMoto
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.actualizarMoto                                                         */
/*+ Objetivo: Actualizar registro en Moto.                                               */
/*+                                                                                      */
/*****************************************************************************************/
CREATE   proc [dbo].[actualizarMoto]
@Id int, 
@Cilindrada varchar(50)
AS
BEGIN
	update Moto set Cilindrada = @Cilindrada where Id = @Id;
END