/*
EXEC dbo.cargaAutomoviles 
*/

/*****************************************************************************************/
/*+ Autor: Nicolás Manuel Miracco                                                        */
/*+ Nombre  : dbo.cargaAutomoviles                                                      */
/*+ Objetivo: Carga Masiva de Automóviles, llamando a dbo.insertarAutomovil              */
/*****************************************************************************************/
CREATE   proc [dbo].[cargaAutomoviles]
AS
BEGIN
	Exec dbo.insertarAutomovil @Tipo = 'sedan', @CantidadPuertas = 4, @Marca = 'Ford', @Modelo = 'Falcon', @Patente = 'BYB152'; 
	Exec dbo.insertarAutomovil @Tipo = 'sedan', @CantidadPuertas = 4, @Marca = 'Chevrolet', @Modelo = 'Aveo', @Patente = 'NXN176'; 
	Exec dbo.insertarAutomovil @Tipo = 'compacto', @CantidadPuertas = 5, @Marca = 'Fiat', @Modelo = 'Falcon', @Patente = 'ALK765'; 
	Exec dbo.insertarAutomovil @Tipo = 'compacto', @CantidadPuertas = 5, @Marca = 'VW', @Modelo = 'Falcon', @Patente = 'KJS876'; 
	Exec dbo.insertarAutomovil @Tipo = 'monovolumen', @CantidadPuertas = 6, @Marca = 'BMW', @Modelo = 'Falcon', @Patente = 'KJw321'; 
	Exec dbo.insertarAutomovil @Tipo = 'monovolumen', @CantidadPuertas = 6, @Marca = 'Audi', @Modelo = 'Falcon', @Patente = 'FXV432'; 
	Exec dbo.insertarAutomovil @Tipo = 'utilitario', @CantidadPuertas = 2, @Marca = 'Renault', @Modelo = 'Falcon', @Patente = 'KIS321'; 
	Exec dbo.insertarAutomovil @Tipo = 'utilitario', @CantidadPuertas = 4, @Marca = 'Peugeot', @Modelo = 'Falcon', @Patente = 'LKA322'; 
	Exec dbo.insertarAutomovil @Tipo = 'lujo', @CantidadPuertas = 4, @Marca = 'BMW', @Modelo = '331', @Patente = 'LKQ098'; 
	Exec dbo.insertarAutomovil @Tipo = 'lujo', @CantidadPuertas = 5, @Marca = 'Mercedes Benz', @Modelo = 'Luxei', @Patente = 'SOP433'; 
END