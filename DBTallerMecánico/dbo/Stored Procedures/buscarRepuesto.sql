/*
DECLARE @Nombre varchar(100), @Precio decimal;
EXEC dbo.buscarRepuesto 1, @Nombre OUT, @Precio OUT;
SELECT @Nombre, @Precio;

*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.buscarRepuesto                                                         */
/*+ Objetivo: Búsqueda de los datos del repuesto existente a partir de su Id             */
/*****************************************************************************************/
CREATE   proc [dbo].[buscarRepuesto]
@Id int, 
@Nombre varchar(100) OUT, 
@Precio decimal OUT
AS
BEGIN
	SELECT @Nombre = Nombre, @Precio = Precio FROM Repuesto WHERE Id = @Id;
	SELECT @Precio = Precio FROM Repuesto WHERE Id = @Id;	
END