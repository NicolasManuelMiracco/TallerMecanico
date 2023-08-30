/*
EXEC dbo.cargaMotos 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaMotos                                                             */
/*+ Objetivo: Carga Masiva de Motos, llamando a dbo.cargaMotos                           */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaMotos]
AS
BEGIN
	Exec dbo.insertarMoto @Cilindrada = '1100', @Marca = 'Ducati', @Modelo = 'Gold', @Patente = 'HNG234';
	Exec dbo.insertarMoto @Cilindrada = '50', @Marca = 'Zanella', @Modelo = 'Fire', @Patente = 'JIK452';
	Exec dbo.insertarMoto @Cilindrada = '50', @Marca = 'Juki', @Modelo = 'Ninja', @Patente = 'KOP367';
	Exec dbo.insertarMoto @Cilindrada = '250', @Marca = 'Honda', @Modelo = 'Tornado', @Patente = 'HGQ234';
	Exec dbo.insertarMoto @Cilindrada = '300', @Marca = 'Yamaha', @Modelo = 'KMG', @Patente = 'KLP556';
	Exec dbo.insertarMoto @Cilindrada = '1250', @Marca = 'Ducati', @Modelo = 'Platinum', @Patente = 'FCB721';
	Exec dbo.insertarMoto @Cilindrada = '60', @Marca = 'Zanella', @Modelo = 'Luxe', @Patente = 'KLP987';
	Exec dbo.insertarMoto @Cilindrada = '55', @Marca = 'Juki', @Modelo = 'Fall', @Patente = 'FVQ237';
	Exec dbo.insertarMoto @Cilindrada = '110', @Marca = 'Honda', @Modelo = 'Twister', @Patente = 'HNM835';
	Exec dbo.insertarMoto @Cilindrada = '125', @Marca = 'Yamaha', @Modelo = 'Thunder', @Patente = 'KSI825';	
END