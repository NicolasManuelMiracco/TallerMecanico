/*
EXEC dbo.cargaDesperfectos 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaDesperfectos                                                      */
/*+ Objetivo: Carga Masiva de Desperfectos                                               */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaDesperfectos]
AS
BEGIN
	
	Exec dbo.insertarDesperfecto @IdPresupuesto = 1, @Descripcion = 'Rotura Tapa de Cilindros', @ManoDeObra = 1200000, @Tiempo = 15;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 1, @Descripcion = 'Rotura correa de distribución', @ManoDeObra = 1500000, @Tiempo = 18;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 1, @Descripcion = 'Obstrucción Bomba de Agua', @ManoDeObra = 180000, @Tiempo = 2;

	Exec dbo.insertarDesperfecto @IdPresupuesto = 2, @Descripcion = 'Batería agotada', @ManoDeObra = 50000, @Tiempo = 1;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 2, @Descripcion = 'Obstrucción Bomba de Agua', @ManoDeObra = 22000, @Tiempo = 2;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 2, @Descripcion = 'Termostato averiado', @ManoDeObra = 98000, @Tiempo = 2;

	Exec dbo.insertarDesperfecto @IdPresupuesto = 3, @Descripcion = 'Llanta fisurada', @ManoDeObra = 45000, @Tiempo = 1;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 3, @Descripcion = 'Rotura Tapa de Cilindros', @ManoDeObra = 1350000, @Tiempo = 17;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 3, @Descripcion = 'Bujías y cables deteriorados', @ManoDeObra = 35000, @Tiempo = 1;

	Exec dbo.insertarDesperfecto @IdPresupuesto = 4, @Descripcion = 'Problema encendido a distancia', @ManoDeObra = 125000, @Tiempo = 3;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 4, @Descripcion = 'Rotura correa de distribución', @ManoDeObra = 2200000, @Tiempo = 20;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 4, @Descripcion = 'Desprendimiento de Biela', @ManoDeObra = 1350000, @Tiempo = 15;

	Exec dbo.insertarDesperfecto @IdPresupuesto = 5, @Descripcion = 'Sin compresión en aros', @ManoDeObra = 450000, @Tiempo = 9;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 5, @Descripcion = 'Rotura Tapa de Cilindros', @ManoDeObra = 3000000, @Tiempo = 25;
	Exec dbo.insertarDesperfecto @IdPresupuesto = 5, @Descripcion = 'Rotura correa de distribución', @ManoDeObra = 1250000, @Tiempo = 17;
		
END