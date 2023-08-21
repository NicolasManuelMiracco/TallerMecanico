# TallerMecanico
Challenge .NET 
Autor: Nicolás Manuel Miracco

Aclaración: 
-Versión preliminar a un 80%, resta entrega final que será pusheada a la misma rama master.
-Me extendí en la entrega, pero dejar un producto en buen estado. 
-El tiempo extra que tuve para la construcción no fue lo que esperaba, dado que la jornada laboral quita tiempo, aún así se logró una entrega coherente.

El presente es un proyecto Challenge que responde a la creación de un modelo de Taller Mecánico.
Para el desarrollo se utilizó: 

- BD: SQL server V 19.1
- Microsoft Visual Studio Professional 2019 Versión 16.11.10 
- .NET 4.8 (framework) en C#

Base de datos: Estructura

- Se materializa el DER del challenge con mismos nombres de Tablas y Campos.
- Se cumple con FN3: cada tabla posee PK, las FK en tablas hijas refieren a PK de su tabla padre.
- Se incorpora Identity(1, 1) para la generación automática de las PK para cada tabla.
- Se define eliminación y actualización en cascada desde las tablas hijas hacia las padres.
  - Por ejemplo, al eliminar un Automóvil, se elimina en cascada: Automóvil -> Vehículo -> Presupuesto -> Desperfecto -> 
    DesperfectoRepuesto.
  - Esto es así porque se considera al desperfecto específico de un presupuesto, al presupuesto relacionado aa un vehículo.
- Se definen restricciones de integridad para:
  - El Tipo de Automóvil: congruencia con el tipo enumerado solicitado.
  - Valores monetarios, temporales o que representan cantidades: deben ser >= 0.

Base de datos: Stored procedures (SP)

- Inserción: se crea un SP por cada tabla.
- Carga: se crean un SP que llama a su correspondiente SP de inserción, para efectuar carga masiva.
- Carga Masiva: dbo.cargaAll que elimina las tablas en orden, setea los autonuméricos y llama a los SP de carga.
- Agregar restantes...

Diseño e implementación (a extender): 
- Aplicación patrón strategy para la asignación dinámica de turnos.
- Organización en namespaces.
- Diseño en 4 capas interoperativas.
- Manejo de excepciones (resta extender).
- Comentarios en código.
- Tratamiento de UI y control de errores (resta completar).
- 

Pendientes: 
- Prueba final generación de presupuesto: evidenciación y testing.
- Incorporación de store procedures a la app (está creado y testeado todo el modelo de datos).

Enlace a documentación que se mantendrá en actualización hasta la entrega final: 
- https://drive.google.com/drive/folders/1DyXBphfs0FpLa678VIKQWvpebyLFZ_LB?usp=sharing
  

