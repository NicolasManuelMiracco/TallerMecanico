using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica 
{
    public class LogicaDesperfecto : ISubject
    {
        // Listado de observers
        IList suscriptores;
        ModeloDesperfecto modeloDesperfecto;

        public LogicaDesperfecto()
        {
            this.suscriptores = new ArrayList();
            this.modeloDesperfecto = null;
        }
        
        public DataTable Listar(int idPresupuesto)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            return datos.Listar(idPresupuesto);
        }

        /// <summary>
        /// Definición lógica para recuperar el costo de repuestos por desperfecto
        /// </summary>        
        public Double obtenerSubtotalRepuestos(int idDesperfecto)
        {
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();            
            return datos.subTotalRepuestos(idDesperfecto);
        }

        /// <summary>
        /// Tratamiento lógico para la inserción de desperfectos, a partir de un modelo de presupuesto que se construye durante el flujo de ejecución
        /// </summary>        
        public string Insertar(ModeloPresupuesto presupuesto, string descripcion, double manoDeObra, int tiempo)
        {
            string respuesta;
            PersistenciaDesperfecto datos = new PersistenciaDesperfecto();
            modeloDesperfecto = new ModeloDesperfecto(presupuesto.Id, descripcion, manoDeObra, tiempo);  
            // Se incorpora el nuevo desperfecto al modelo presupuesto, para continuar componiendo la instancia presupuesto
            presupuesto.addDesperfecto(modeloDesperfecto);
            // Se persiste el desperfecto en BD
            respuesta = datos.Insertar(modeloDesperfecto);
            this.NotificarObservers();
            return respuesta;       
        }        

        /// <summary>
        /// Se gestiona la incorporación de repuestos al desperfecto en construcción, por medio de la tabla DesperfectoRepuesto.
        /// En LogicaRepuesto se agregan los repuestos para el desperfecto activo.
        /// Cualquier error en la inserción, desencadena un error general.
        /// </summary>
        public string agregarRepuestos(ModeloPresupuesto modeloPresupuesto, List<int> repuestosExistentes, List<int> repuestosEnEspera)
        {
            string respuesta = "OK";
            PersistenciaDesperfectoRepuesto datos = new PersistenciaDesperfectoRepuesto();            
                        
            int idDesperfectoActivo = ((ModeloDesperfecto) modeloPresupuesto.CurrentDesperfecto).Id;
            foreach (int repuestoExistente in repuestosExistentes)
            {
                respuesta = datos.Insertar(repuestoExistente, idDesperfectoActivo);
                if (respuesta != "OK") return respuesta;
            }
            foreach (int repuestoEnEspera in repuestosEnEspera)
            {
                respuesta = datos.Insertar(repuestoEnEspera, idDesperfectoActivo);
                if (respuesta != "OK") return respuesta;
            }
            /// Update de repuestos para ser mostrado como faltante / existente
            modeloDesperfecto.CantidadRepuestosExistentes = repuestosExistentes.Count;
            modeloDesperfecto.CantidadRepuestosFaltantes = repuestosEnEspera.Count;

            this.NotificarObservers();
            return respuesta;
        }

        public void RegistrarObserver(IObserver o)
        {
            if (!suscriptores.Contains(o))
                suscriptores.Add(o);
        }

        public void EliminarObserver(IObserver o)
        {
            if (suscriptores.Contains(o))
                suscriptores.Remove(o);
        }

        public void NotificarObservers()
        {
            // Recorremos todos los objetos suscritos (observers)
            IObserver observer;
            foreach (Object o in suscriptores)
            {
                // Se invoca al update de cada Observer, pasándo el estado que interesa observar                
                observer = (IObserver)o;
                observer.update(modeloDesperfecto); // Aquí se pasa el estado modificado
            }
        }
    }
}
