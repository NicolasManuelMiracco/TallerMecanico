using CapaModelo;
using CapaPersistencia;
using System;
using System.Data;

namespace CapaLogica
{
    public class LogicaDesperfecto
    {
        public static DataTable Listar(int idPresupuesto)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            return datos.Listar(idPresupuesto);
        }

        /// <summary>
        /// Definición lógica para recuperar el costo de repuestos por desperfecto
        /// </summary>
        
        public static Double obtenerSubtotalRepuestos(int idDesperfecto)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            System.Diagnostics.Debug.WriteLine("Salida: " + datos.subTotalRepuestos(idDesperfecto));
            return datos.subTotalRepuestos(idDesperfecto);
        }

        /// <summary>
        /// Tratamiento lógico para la inserción de desperfectos, a partir de un modelo de presupuesto que se construye durante el flujo de ejecución
        /// </summary>
        
        public static string Insertar(ModeloPresupuesto presupuesto, string descripcion, double manoDeObra, int tiempo)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            ModeloDesperfecto modeloDesperfecto = new ModeloDesperfecto(presupuesto.Id, descripcion, manoDeObra, tiempo);
            // Se incorpora el nuevo desperfecto al modelo presupuesto, para continuar componiendo la instancia presupuesto
            presupuesto.addDesperfecto(modeloDesperfecto);
            return datos.Insertar(modeloDesperfecto);
        }
    }
}
