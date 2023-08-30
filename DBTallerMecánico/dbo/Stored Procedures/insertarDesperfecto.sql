/*
EXEC dbo.insertarDesperfecto 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarDesperfecto                                                    */
/*+ Objetivo: Inserción en Desperfecto                                                   */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarDesperfecto]
@IdPresupuesto int, 
@Descripcion varchar(255), 
@ManoDeObra decimal, 
@Tiempo int, 
@lastDesperfecto int OUT
AS
BEGIN
	insert into Desperfecto values (@IdPresupuesto, @Descripcion, @ManoDeObra, @Tiempo);
	SELECT @lastDesperfecto = SCOPE_IDENTITY();
END