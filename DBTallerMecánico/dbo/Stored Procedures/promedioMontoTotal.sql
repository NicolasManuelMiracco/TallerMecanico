/*
EXEC dbo.promedioMontoTotal @MarcaModelo = 'BMW'
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.promedioMontoTotal                                                                          */
/*+ Objetivo: Promedio del Monto Total de Presupuestos por Marca/Modelo                                       */
/*+ Aclaración: se asume marca/modelo, como un OR lógico. En caso de ser necesario buscar por Marca y Modelo  */
/*+             entonces es necesario pasar ambos parámetros y efectuar operar con el AND en el Where         */
/**************************************************************************************************************/

CREATE   proc [dbo].[promedioMontoTotal]
@MarcaModelo varchar(50)
AS
BEGIN
	DECLARE @Promedio varchar(17)

	SELECT @Promedio = (
		SELECT AVG(P.Total) 
		FROM Vehiculo AS V, Presupuesto AS P
		WHERE V.Id = P.IdVehiculo and (V.Marca = @MarcaModelo or V.Modelo = @MarcaModelo)
	);
	/*SELECT	'Return Value' = 'El promedio de presupuestos para la Marca: ' + @Marca + ', Modelo: ' + @Modelo + ' es: ' + @Promedio;*/
	SELECT 'Return Value' = @Promedio;
END