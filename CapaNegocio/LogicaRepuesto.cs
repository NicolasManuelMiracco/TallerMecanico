using CapaModelo;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class LogicaRepuesto
    {
        
        
        
        public static ModeloRepuesto agregarRepuestoExistenteAlDesperfectoActual(ModeloPresupuesto presupuesto, int idRepuestoExistente)
        {
            //System.Diagnostics.Debug.WriteLine("El repuesto es: " + idRepuestoExistente);
            ModeloRepuesto modeloRepuesto = null;

            PersistenciaRepuesto datos = new PersistenciaRepuesto();
                       
            // Se obtiene el desperfecto que se esta configurando del presupuesto en curso
            ModeloDesperfecto desperfectoEnConstruccion = presupuesto.getCurrentDesperfecto();



            //System.Diagnostics.Debug.WriteLine("El desperfecto actual es: " + (int) desperfectoEnConstruccion.IdPresupuesto);

            // Se obtiene una instancia del Modelo Repuesto existente en BD desde el Id de repuesto
            modeloRepuesto = (ModeloRepuesto) datos.buscarRepuesto(idRepuestoExistente);

            // Se agrega el Modelo Repuesto al Modelo Desperfecto
            desperfectoEnConstruccion.agregarRepuesto(modeloRepuesto);

            return modeloRepuesto;
        }
    }
}
