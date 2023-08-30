/*
EXEC dbo.insertarRepuesto
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.insertarRepuesto                                                       */
/*+ Objetivo: Inserción en Repuesto                                                      */
/*+ Descripción:                                                                         */
/*****************************************************************************************/
CREATE   proc [dbo].[insertarRepuesto]
@Nombre varchar(100), 
@Precio decimal, 
@IdRepuesto int OUT
AS
BEGIN
	/* Retorna el autonumérico generado después de la inserción*/
	INSERT INTO Repuesto values (@Nombre, @Precio);		
	SELECT @IdRepuesto = SCOPE_IDENTITY();
END