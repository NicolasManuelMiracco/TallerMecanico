/*
EXEC dbo.actualizarPresupuesto 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.actualizarPresupuesto                                                  */
/*+ Objetivo: Update en Presupuesto                                                      */
/*****************************************************************************************/
CREATE   proc [dbo].[actualizarPresupuesto]
@Id int, 
@Nombre varchar(100), 
@Apellido varchar(100), 
@Email varchar(100), 
@Total decimal
AS
BEGIN
	UPDATE Presupuesto 
	SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Total = @Total
	WHERE Id = @Id;	
END