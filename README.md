# Taller Mecánico
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
  - Esto es así porque se considera al desperfecto específico para un presupuesto, quien a la vez se relaciona con un vehículo.

- Se definen restricciones de integridad para:
  - El Tipo de Automóvil: congruencia con el tipo enumerado solicitado (compacto, sedan, monovolumen, utilitario y lujo).
  - Valores monetarios, temporales o que representan cantidades: deben ser >= 0.

Base de datos: Stored procedures (SP)

- Inserción: se crea un SP por cada tabla.
- Carga: se crean un SP que llama a su correspondiente SP de inserción, para efectuar carga masiva.
- Carga Masiva: dbo.cargaAll que elimina las tablas en orden, setea los autonuméricos y llama a los SP de carga.
- Se generan los stored procedures para cumplir con los servicios:
    -  Repuesto más utilizado por Marca/Modelo en las reparaciones realizadas: se implementa por medio de tablas auxiliares y un cursor (ver comentarios en implementación).
    -  Promedio del Monto Total de Presupuestos por Marca/Modelo: se efectua un ensamble y un agrupamiento, como en el caso anterior, pero sin la necesidad de aplicar cursor.
    -  Sumatoria del Monto Total de Presupuestos para Autos y para Motos.

- Se introducen también stored procedures como servicios a consumirse desde la capa Persistencia para insertar, eliminar, actualizar, buscar y listar; en cada tabla o entidad de la base de datos.

Diseño e implementación: 

- BD: se incorpora proyecto DBTallerMecánico con tablas, stored procedures, etc.

- Patrones de diseño:  
    - Patrón Strategy:
      Utilizado para la asignación dinámica de turnos. Se incorpora al desarrollo la posibilidad de listar los presupuestos generados hasta el momento, para luego   asignar automáticamente turnos.
      La asignación de la estrategia puede cambiar en ejecución, y a nivel desarrollo se puede extender, heredando de la clase abstracta StrategyTurno.
      Para la implementación actual se heredan dos estrategias:
        -  RandomTurno: a partir del último turno otorgado por el Taller mecánico, y de una semilla que define el rango aleatorio o amplitud, se designa un turno.
        -  PrimerDisponibleTurno: asigna el primer día disponible, a partir del último turno otorgado por el taller.
  
    -  Patrón observer:
       Se utiliza para la actualización automática de UI cuando se actualiza el modelo, específicamente al momento de cargar repuestos para un desperfecto, en la construcción de un presupuesto.
       De esta forma un DataGridView que almacena los desperfectos con sus repuestos, para un determinado presupuesto; es incorporado como Observador de los Desperfectos (e implementa el método Update).
       Este binding entre estado y vista, se realiza en la clase Lógica Desperfecto. El Desperfecto será un elemento Observable, y deberá registrar y notificar a sus oyentes u observadores.
       Adicionalmente, al momento de agregar repuestos a un desperfecto, que será incorporado al presupuesto; se actualizan automáticamente los textBox indicando la cantidad de repuestos existentes, y la cantidad de repuestos faltantes.
       Visualmente también se modifica el color, para la fila correspondiente al desperfecto que actualizó sus repuestos.
       
    -  Patrón MVC:
       Se aplica modelo de arquitectura en 4 capas (Presentación, Lógica, Persistencia y Modelo) que incorpora las características del patrón: Model View Controller.       
-  Funcionalidad adicional:
    -  Asignación de turnos.
    -  Selección de repuestos existentes:
         Se consideran en stock los cargados masivamente por el stored procedure massiveCharge.
         Los repuestos que se agregan, son incluidos como faltantes.
    - ABM: actualización, eliminación, inserción de vehículos.
    - Edición de repuestos para un desperfecto:
      -  1°: se cargan todos los desperfectos.
      -  2°: al comenzar con la carga de repuestos (doble clic en el desperfecto) se deshabilita la generación de desperfectos, para comenzar a cargar repuestos.

- Organización en namespaces y regiones (para la capa de presentación).
- Organización de código para la capa de Presentación en las regiones:
  -  Init:
  -  Gestión de errores.
  -  Tratamiento de los TextBoxes: para validar su contenido.
  -  Gestión de botones.
  -  Conexión Capa Lógica: aquí se accede a la capa lógica, quién luego accede a la capa de Persistencia.
  -  Tratamiento sobre DataGridViews: formato de grillas, carga, verificaciones, etc.
  -  Gestión dobre Tabs: se controla el flujo de navegación.
  -  Etiquetas, Panel, Combobox.

- Diseño en 4 capas interoperativas:
  -  Capa Modelo
  -  Capa Persistencia: acceso a la capa Modelo.
  -  Capa Lógica: acceso a capa Modelo y Persistencia.
  -  Capa Presentación: interacción y visualización, accede al modelo como a la capa lógica.  

- Manejo de excepciones
 
- Comentarios en código.

-  Enlace a documentación que se mantendrá en actualización hasta la entrega final:
  -  https://drive.google.com/drive/folders/1DyXBphfs0FpLa678VIKQWvpebyLFZ_LB?usp=sharing
      La documentación en drive incluye:

      -  BD: Store procedures utilizados en los servicios, en las cargas y como apoyo auxiliar.
      -  BD: Backup de toda la BD, listo para un local restore.
      -  BD: Script total de toda la BD.
      -  General: capturas.
      -  Arquitectura 4 capas: se incorpora diagrama con la representación del flujo principal entre capas.
      -  Instalador: setup.exe
