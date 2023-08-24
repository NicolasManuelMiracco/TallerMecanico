# TallerMecanico
Challenge .NET 
Autor: Nicolás Manuel Miracco

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
- Se generan los stored procedures para cumplir con los servicios:
    -  Repuesto más utilizado por Marca/Modelo en las reparaciones realizadas: se implementa por medio de tablas auxiliares y un cursor (ver comentarios en implementación).
    -  Promedio del Monto Total de Presupuestos por Marca/Modelo: se efectua un ensamble y un agrupamiento, como en el caso anterior, pero sin la necesidad de aplicar cursor.
    -  Sumatoria del Monto Total de Presupuestos para Autos y para Motos.

Diseño e implementación (a extender): 
- Aplicación patrón strategy para la asignación dinámica de turnos.
- Aplicación del patrón observer para la actualización automática de UI cuando se actualiza el modelo.
  -  Al momento de agregar repuestos a un desperfecto, que será incorporado al presupuesto; se actualizan automáticamente los textBox indicando la cantidad de repuestos existentes, y la cantidad de repuestos faltantes.
  -  Visualmente también se modifica el color. 
- Organización en namespaces.
- Diseño en 4 capas interoperativas.
- Manejo de excepciones
- Comentarios en código.
- Tratamiento de UI y control de errores.

Enlace a documentación que se mantendrá en actualización hasta la entrega final: 
- https://drive.google.com/drive/folders/1DyXBphfs0FpLa678VIKQWvpebyLFZ_LB?usp=sharing

La documentación en drive incluye: 
- BD: Store procedures utilizados en los servicios, en las cargas y como apoyo auxiliar.
- BD: backup de toda la BD, listo para un local restore.

Aclaración: el desarrollo es robusto, cumple con todos los requerimientos funcionales, orientado a objetos y aplica patrones básicos. 
Se hace hincapié en una arquitectura multicapa. 
Por cuestiones de tiempo, requiere mas testing unitario/integral. 
  

