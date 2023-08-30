/*
EXEC dbo.repuestoMasUtilizado @MarcaModelo = 'Falcon'
*/

/**************************************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                                             */
/*+ Nombre  : dbo.repuestoMasUtilizado                                                                        */
/*+ Objetivo: Repuesto más utilizado por Marca/Modelo en las reparaciones realizadas                          */
/*+ Descripción: Se utilizan tablas auxiliares y un ensamble multiple entre las tablas:                       */
/*+ Vehiculo, Presupuesto, Desperfecto, DesperfectoRepuesto y Repuesto.                                       */
/*+ Mediante el cursor, se visita cada fila de la tabla auxiliar, para extraer el máximo.                     */
/**************************************************************************************************************/
CREATE   proc [dbo].[repuestoMasUtilizado]
@MarcaModelo varchar(50)
AS
BEGIN
	/* Se crea tabla temporal #Ocurrencias, con la cantidad de ocurrencias y el nombre del repuesto, para la marca Y el modelo, pasados por parámetro */ 
	SELECT COUNT(*) as Ocurrencias, r.Nombre INTO #Ocurrencias
	FROM Vehiculo AS v, Presupuesto AS p, Desperfecto AS d, DesperfectoRepuesto AS dr, Repuesto AS r
	WHERE V.Id = P.IdVehiculo and P.Id = D.IdPresupuesto and D.Id = DR.IdDesperfecto and DR.IdRepuesto = R.Id and (V.Marca = @MarcaModelo or V.Modelo = @MarcaModelo)
	GROUP BY r.Nombre; 

	DECLARE @MAXNombreRepuesto varchar(50)
	DECLARE @MAXOcurrenciasRepuesto bigint
	/* Inicializo en -1 para que siempre encuentre un máximo */
	SELECT @MAXOcurrenciasRepuesto = -1
	DECLARE @NombreRepuesto varchar(50)
	DECLARE @OcurrenciasRepuesto bigint
	
	DECLARE CursorOcurrencias CURSOR SCROLL
	FOR SELECT * FROM #Ocurrencias
	OPEN CursorOcurrencias
	FETCH FIRST FROM CursorOcurrencias INTO @OcurrenciasRepuesto, @NombreRepuesto 

	WHILE (@@FETCH_STATUS = 0)
		BEGIN
			IF (@OcurrenciasRepuesto > @MAXOcurrenciasRepuesto)
				BEGIN
					SELECT @MAXOcurrenciasRepuesto = @OcurrenciasRepuesto; 
					SELECT @MAXNombreRepuesto = @NombreRepuesto;
				END
			FETCH NEXT FROM CursorOcurrencias INTO @OcurrenciasRepuesto, @NombreRepuesto 
		END
	CLOSE CursorOcurrencias
	DEALLOCATE CursorOcurrencias	
	SELECT	'Return Value' = 'Mas usado: ' + @MAXNombreRepuesto + ' #:' + CONVERT(varchar(10), @MAXOcurrenciasRepuesto)
END