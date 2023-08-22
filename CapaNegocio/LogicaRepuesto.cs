using CapaModelo;
using CapaPersistencia;
using System;

namespace CapaLogica
{
    public class LogicaRepuesto
    {
        
        
        
        public static ModeloRepuesto agregarRepuestoExistenteAlDesperfectoActual(ModeloPresupuesto presupuesto, int idRepuestoExistente)
        {
            ModeloRepuesto modeloRepuesto = null;
            PersistenciaRepuesto datos = new PersistenciaRepuesto();
                       
            // Se obtiene el desperfecto que se esta configurando del presupuesto en curso
            ModeloDesperfecto desperfectoEnConstruccion = presupuesto.CurrentDesperfecto;

            // Se obtiene una instancia del Modelo Repuesto existente en BD desde el Id de repuesto
            modeloRepuesto = (ModeloRepuesto) datos.buscarRepuesto(idRepuestoExistente);

            if (!desperfectoEnConstruccion.contains(modeloRepuesto))
            {
                // Se agrega el Modelo Repuesto al Modelo Desperfecto
                desperfectoEnConstruccion.agregarRepuesto(modeloRepuesto);
                return modeloRepuesto;
            }
            else
            {
                return null;
            }

        }

        public static ModeloRepuesto agregarRepuestoNuevoAlDesperfectoActual(ModeloPresupuesto presupuesto, String nombre, Decimal precio)
        {
            ModeloRepuesto modeloRepuesto = null;
            PersistenciaRepuesto datos = new PersistenciaRepuesto();

            // Se obtiene el desperfecto que se esta configurando del presupuesto en curso
            ModeloDesperfecto desperfectoEnConstruccion = presupuesto.CurrentDesperfecto;

            int ultimoIdRepuesto = (int) datos.Insertar(nombre, precio);            
            
            // Se crea una instancia del nuevo Modelo Repuesto. El true indica que aún está a la espera de confirmación, dado que el presupuesto está en curso.
            modeloRepuesto = new ModeloRepuesto(ultimoIdRepuesto, nombre, precio, true);

            if (!desperfectoEnConstruccion.contains(modeloRepuesto))
            {
                // Se agrega el Modelo Repuesto al Modelo Desperfecto
                desperfectoEnConstruccion.agregarRepuesto(modeloRepuesto);
                return modeloRepuesto;
            }
            else
            {
                return null;
            }
        }
    }
}
