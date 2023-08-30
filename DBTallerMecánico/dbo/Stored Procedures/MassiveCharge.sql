﻿/*
EXEC dbo.MassiveCharge 
*/

/*****************************************************************************************/
/*+                                                                                      */
/*+ Nombre  : dbo.MassiveCharge                                                          */
/*+ Objetivo: Insertar en la BD una serie de Respuestos con sus Precios                  */
/*+                                                                                      */
/*****************************************************************************************/

CREATE   PROC [dbo].[MassiveCharge] AS
BEGIN

/*+ Creación de la tabla Temporal que contendrá los Repuestos con sus precios*/

    CREATE TABLE #TMP_REPUESTO (Nombre VARCHAR(100), Precio DECIMAL(18,6))

/*+ Creación de la tabla Temporal que contendrá los Repuestos que no se inserten/actualicen*/

    CREATE TABLE #TMP_NOT_CHARGED (Nombre VARCHAR(100), Precio DECIMAL(18,6))

/*+ Se generan los registros en la tabla temporal que posteriormente se evaluarán para ver si procede su carga en la tabla definitiva de Repuestos*/

    BEGIN /*+ BEGIN INSERT EN LA TEMPORAL DE RESPUESTOS*/
        INSERT INTO #TMP_REPUESTO VALUES ('B356963821', 17.61)
        INSERT INTO #TMP_REPUESTO VALUES ('B881468337', 40.88)
        INSERT INTO #TMP_REPUESTO VALUES ('B867719836', 87.76)
        INSERT INTO #TMP_REPUESTO VALUES ('B397571688', 13.97)
        INSERT INTO #TMP_REPUESTO VALUES ('B852883143', 47.97)
        INSERT INTO #TMP_REPUESTO VALUES ('B461882670', 22.68)
        INSERT INTO #TMP_REPUESTO VALUES ('B333520964', 82.28)
        INSERT INTO #TMP_REPUESTO VALUES ('B388445039', 50.71)
        INSERT INTO #TMP_REPUESTO VALUES ('B648201513', 21.83)
        INSERT INTO #TMP_REPUESTO VALUES ('B436759416', 35.39)
        INSERT INTO #TMP_REPUESTO VALUES ('B317533243', 22.84)
        INSERT INTO #TMP_REPUESTO VALUES ('B666592414', 58.67)
        INSERT INTO #TMP_REPUESTO VALUES ('B443568817', 53.83)
        INSERT INTO #TMP_REPUESTO VALUES ('B316416378', 17.74)
        INSERT INTO #TMP_REPUESTO VALUES ('B252543362', 16.98)
        INSERT INTO #TMP_REPUESTO VALUES ('B453148609', 14.23)
        INSERT INTO #TMP_REPUESTO VALUES ('B254958806', 41.19)
        INSERT INTO #TMP_REPUESTO VALUES ('B356963821', 62.58)
        INSERT INTO #TMP_REPUESTO VALUES ('B846487171', 92.91)
        INSERT INTO #TMP_REPUESTO VALUES ('B397571688', 1.04)
        INSERT INTO #TMP_REPUESTO VALUES ('B535169105', 90.14)
        INSERT INTO #TMP_REPUESTO VALUES ('B628263302', 78.64)
        INSERT INTO #TMP_REPUESTO VALUES ('B608816685', 93.73)
        INSERT INTO #TMP_REPUESTO VALUES ('B660755442', 43.62)
        INSERT INTO #TMP_REPUESTO VALUES ('B659053715', 90.59)
        INSERT INTO #TMP_REPUESTO VALUES ('B556344166', 71.62)
        INSERT INTO #TMP_REPUESTO VALUES ('B216140665', 93.15)
        INSERT INTO #TMP_REPUESTO VALUES ('B843858581', 66.52)
        INSERT INTO #TMP_REPUESTO VALUES ('B790077756', 8.91)
        INSERT INTO #TMP_REPUESTO VALUES ('B916071768', 85.46)
        INSERT INTO #TMP_REPUESTO VALUES ('B317533243', 7.97)
        INSERT INTO #TMP_REPUESTO VALUES ('B343454513', 22.91)
        INSERT INTO #TMP_REPUESTO VALUES ('B986574036', 65.10)
        INSERT INTO #TMP_REPUESTO VALUES ('B662139869', 3.50)
        INSERT INTO #TMP_REPUESTO VALUES ('B618792223', 6.87)
        INSERT INTO #TMP_REPUESTO VALUES ('B578485476', 49.70)
        INSERT INTO #TMP_REPUESTO VALUES ('B132813434', 32.58)
        INSERT INTO #TMP_REPUESTO VALUES ('B776163235', 73.64)
        INSERT INTO #TMP_REPUESTO VALUES ('B215908676', 92.83)
        INSERT INTO #TMP_REPUESTO VALUES ('B871139440', 31.83)
        INSERT INTO #TMP_REPUESTO VALUES ('B564893705', 18.91)
        INSERT INTO #TMP_REPUESTO VALUES ('B634131771', 70.35)
        INSERT INTO #TMP_REPUESTO VALUES ('B321187273', 91.96)
        INSERT INTO #TMP_REPUESTO VALUES ('B444737823', 78.73)
        INSERT INTO #TMP_REPUESTO VALUES ('B413525993', 9.93)
        INSERT INTO #TMP_REPUESTO VALUES ('B229547877', 97.08)
        INSERT INTO #TMP_REPUESTO VALUES ('B545788950', 11.84)
        INSERT INTO #TMP_REPUESTO VALUES ('B658514562', 8.84)
        INSERT INTO #TMP_REPUESTO VALUES ('B736313138', 78.47)
        INSERT INTO #TMP_REPUESTO VALUES ('B840888802', 93.85)
        INSERT INTO #TMP_REPUESTO VALUES ('B883572821', 21.57)
        INSERT INTO #TMP_REPUESTO VALUES ('B493478663', 76.98)
        INSERT INTO #TMP_REPUESTO VALUES ('B718838840', 7.41)
        INSERT INTO #TMP_REPUESTO VALUES ('B183671709', 45.53)
        INSERT INTO #TMP_REPUESTO VALUES ('B908384721', 14.73)
        INSERT INTO #TMP_REPUESTO VALUES ('B566417680', 44.04)
        INSERT INTO #TMP_REPUESTO VALUES ('B633833113', 33.28)
        INSERT INTO #TMP_REPUESTO VALUES ('B829258206', 41.74)
        INSERT INTO #TMP_REPUESTO VALUES ('B350041352', 85.13)
        INSERT INTO #TMP_REPUESTO VALUES ('B548168477', 7.44)
        INSERT INTO #TMP_REPUESTO VALUES ('B765657146', 89.79)
        INSERT INTO #TMP_REPUESTO VALUES ('B830231322', 81.42)
        INSERT INTO #TMP_REPUESTO VALUES ('B816385774', 9.30)
        INSERT INTO #TMP_REPUESTO VALUES ('B857448796', 77.36)
        INSERT INTO #TMP_REPUESTO VALUES ('B302875266', 54.89)
        INSERT INTO #TMP_REPUESTO VALUES ('B790507487', 50.41)
        INSERT INTO #TMP_REPUESTO VALUES ('B723629401', 65.36)
        INSERT INTO #TMP_REPUESTO VALUES ('B595728629', 19.94)
        INSERT INTO #TMP_REPUESTO VALUES ('B472436824', 65.69)
        INSERT INTO #TMP_REPUESTO VALUES ('B235859870', 66.44)
        INSERT INTO #TMP_REPUESTO VALUES ('B874178252', 42.38)
        INSERT INTO #TMP_REPUESTO VALUES ('B777713850', 40.26)
        INSERT INTO #TMP_REPUESTO VALUES ('B550221285', 8.72)
        INSERT INTO #TMP_REPUESTO VALUES ('B816043247', 73.97)
        INSERT INTO #TMP_REPUESTO VALUES ('B607313788', 15.95)
        INSERT INTO #TMP_REPUESTO VALUES ('B396482694', 45.17)
        INSERT INTO #TMP_REPUESTO VALUES ('B504021331', 24.52)
        INSERT INTO #TMP_REPUESTO VALUES ('B651475349', 86.77)
        INSERT INTO #TMP_REPUESTO VALUES ('B470409863', 11.81)
        INSERT INTO #TMP_REPUESTO VALUES ('B264135435', 62.58)
        INSERT INTO #TMP_REPUESTO VALUES ('B755636151', 33.88)
        INSERT INTO #TMP_REPUESTO VALUES ('B382183955', 0.92)
        INSERT INTO #TMP_REPUESTO VALUES ('B667316286', 0.29)
        INSERT INTO #TMP_REPUESTO VALUES ('B783117048', 41.57)
        INSERT INTO #TMP_REPUESTO VALUES ('B812952354', 86.25)
        INSERT INTO #TMP_REPUESTO VALUES ('B621838237', 80.54)
        INSERT INTO #TMP_REPUESTO VALUES ('B665465223', 53.69)
        INSERT INTO #TMP_REPUESTO VALUES ('B881682635', 64.78)
        INSERT INTO #TMP_REPUESTO VALUES ('B646289861', 72.01)
        INSERT INTO #TMP_REPUESTO VALUES ('B852115667', 48.73)
        INSERT INTO #TMP_REPUESTO VALUES ('B144635415', 34.23)
        INSERT INTO #TMP_REPUESTO VALUES ('B874863828', 24.70)
        INSERT INTO #TMP_REPUESTO VALUES ('B333841476', 41.57)
        INSERT INTO #TMP_REPUESTO VALUES ('B587386017', 45.27)
        INSERT INTO #TMP_REPUESTO VALUES ('B874270576', 42.38)
        INSERT INTO #TMP_REPUESTO VALUES ('B300733136', 25.55)
        INSERT INTO #TMP_REPUESTO VALUES ('B611446656', 60.12)
        INSERT INTO #TMP_REPUESTO VALUES ('B801300387', 61.04)
        INSERT INTO #TMP_REPUESTO VALUES ('B845153562', 60.09)
        INSERT INTO #TMP_REPUESTO VALUES ('B943846621', 37.05)
    END /*+ END INSERT EN LA TEMPORAL DE RESPUESTOS*/

/*+ Cursor para evaluación de tabla temporal para determinar: 
	 - Si el valor < 20 => Insertar
		- Si ya existe acumular su precio para el mismo Id.
	 - Si el valor >= 20 => Incorporar al listado de salida.
*/

	DECLARE @Nombre VARCHAR(100)
	DECLARE @Precio DECIMAL(18,6)

	DECLARE CursorRepuestos CURSOR SCROLL
	FOR SELECT * FROM #TMP_REPUESTO
	OPEN CursorRepuestos
	FETCH FIRST FROM CursorRepuestos INTO @Nombre, @Precio
	
	while (@@FETCH_STATUS = 0)
		BEGIN			
			IF ( @Precio < 20 ) 				
				BEGIN
					IF EXISTS (SELECT * FROM Repuesto WHERE Nombre = @Nombre)
						BEGIN
							UPDATE Repuesto  SET Precio = Precio + @Precio WHERE Nombre = @Nombre;  							
						END
					ELSE
						BEGIN
							INSERT INTO Repuesto (Nombre, Precio) VALUES (@Nombre, @Precio);
						END
				END			
			ELSE
				/* Inserción en tabla temporal para los repuestos que no se insertan / actualizan */
				BEGIN
					INSERT INTO #TMP_NOT_CHARGED (Nombre, Precio) VALUES (@Nombre, @Precio);				
					/*PRINT 'Repuesto descartado: ' + @Nombre + ' Valor: ' + CAST(@Precio AS VARCHAR);*/
				END
				
			FETCH NEXT FROM CursorRepuestos INTO @Nombre, @Precio					
		END
	CLOSE CursorRepuestos
	DEALLOCATE CursorRepuestos
	/* Query de salida con repuestos que no se insertan / actualizan */
	SELECT * FROM #TMP_NOT_CHARGED;
END