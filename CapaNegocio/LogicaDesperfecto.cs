using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
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
            // Se persiste el desperfecto en BD
            return datos.Insertar(modeloDesperfecto);
        }

        /// <summary>
        /// Se gestiona la incorporación de repuestos al desperfecto en construcción, por medio de la tabla DesperfectoRepuesto.
        /// En LogicaRepuesto se agregan los repuestos para el desperfecto activo.
        /// Cualquier error en la inserción, desencadena un error general.
        /// </summary>
        
        public static string agregarRepuestos(ModeloPresupuesto modeloPresupuesto, List<int> repuestosExistentes, List<int> repuestosEnEspera)
        {
            string respuesta = "OK";
            PersistenciaDesperfectoRepuesto datos = new PersistenciaDesperfectoRepuesto();            
                        
            int idDesperfectoActivo = ((ModeloDesperfecto) modeloPresupuesto.getCurrentDesperfecto()).Id;
            foreach (int repuestoExistente in repuestosExistentes)
            {
                respuesta = datos.Insertar(repuestoExistente, idDesperfectoActivo);
                if (respuesta != "OK") return respuesta;
            }
            foreach (int repuestoEnEspera in repuestosEnEspera)
            {
                datos.Insertar(repuestoEnEspera, idDesperfectoActivo);
                if (respuesta != "OK") return respuesta;
            }
            return respuesta;
        }
    }
}
