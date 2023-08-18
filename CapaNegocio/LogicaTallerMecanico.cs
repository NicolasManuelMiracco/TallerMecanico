using System.Collections.Generic;
using CapaModelo;
using CapaPersistencia;

namespace CapaLogica
{
    public class LogicaTallerMecanico
    {
        private List<ModeloVehiculo> vehiculos;
        private List<ModeloDesperfecto> desperfectos;

        public LogicaTallerMecanico()
        {
            vehiculos = new List<ModeloVehiculo>();
            desperfectos = new List<ModeloDesperfecto>();

        }

        public void ingresarAutomovil(ModeloAutomovil nuevoAutomovil)
        {
            vehiculos.Add(nuevoAutomovil);
            new PersistenciaAutomovil().Insertar(nuevoAutomovil);            
        }

        public void ingresarMoto(ModeloMoto nuevaMoto)
        {
            vehiculos.Add(nuevaMoto);
            new PersistenciaMoto().Insertar(nuevaMoto);            
        }


        /// <summary>
        /// Lógica principal para la generación del presupuesto
        /// </summary>
        
        public void emitirPresupuesto(ModeloVehiculo nuevoVehiculo, List<ModeloDesperfecto> desperfectos)
        {
            vehiculos.Add(nuevoVehiculo);
            this.desperfectos = desperfectos;

        }



    }
}
