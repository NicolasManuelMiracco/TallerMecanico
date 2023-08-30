/*
EXEC dbo.cargaDesperfectosRepuestos
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaDesperfectosRepuestos                                             */
/*+ Objetivo: Carga Masiva de cargaDesperfectosRepuestos                                 */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaDesperfectosRepuestos]
AS
BEGIN
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 1, @IdRepuesto = 1;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 1, @IdRepuesto = 9;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 1, @IdRepuesto = 4;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 2, @IdRepuesto = 10;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 2, @IdRepuesto = 3;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 2, @IdRepuesto = 21;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 3, @IdRepuesto = 4;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 3, @IdRepuesto = 9;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 3, @IdRepuesto = 22;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 4, @IdRepuesto = 6;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 4, @IdRepuesto = 1;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 4, @IdRepuesto = 8;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 5, @IdRepuesto = 21;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 5, @IdRepuesto = 12;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 5, @IdRepuesto = 11;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 6, @IdRepuesto = 11;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 6, @IdRepuesto = 1;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 6, @IdRepuesto = 3;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 7, @IdRepuesto = 1;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 7, @IdRepuesto = 2;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 7, @IdRepuesto = 3;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 8, @IdRepuesto = 11;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 8, @IdRepuesto = 12;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 8, @IdRepuesto = 13;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 9, @IdRepuesto = 7;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 9, @IdRepuesto = 9;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 9, @IdRepuesto = 20;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 10, @IdRepuesto = 22;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 10, @IdRepuesto = 18;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 10, @IdRepuesto = 19;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 11, @IdRepuesto = 17;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 11, @IdRepuesto = 16;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 11, @IdRepuesto = 15;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 12, @IdRepuesto = 14;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 12, @IdRepuesto = 13;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 12, @IdRepuesto = 12;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 13, @IdRepuesto = 11;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 13, @IdRepuesto = 10;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 13, @IdRepuesto = 9;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 14, @IdRepuesto = 8;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 14, @IdRepuesto = 7;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 14, @IdRepuesto = 6;

	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 15, @IdRepuesto = 5;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 15, @IdRepuesto = 4;
	Exec dbo.insertarDesperfectoRepuesto @IdDesperfecto = 15, @IdRepuesto = 3;
END