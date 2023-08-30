/*
EXEC dbo.insertarDesperfectoRepuesto 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarDesperfectoRepuesto                                            */
/*+ Objetivo: Inserción en DesperfectoRepuesto                                           */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarDesperfectoRepuesto]
@IdDesperfecto int, 
@IdRepuesto int 
AS
BEGIN
	insert into DesperfectoRepuesto values (@IdDesperfecto, @IdRepuesto);
END