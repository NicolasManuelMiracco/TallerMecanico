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
            ModeloDesperfecto desperfectoEnConstruccion = presupuesto.getDesperfectoActual();
            // OK System.Diagnostics.Debug.WriteLine("Se recupera DESPERFECTO: " + desperfectoEnConstruccion.Id);

            // Se obtiene una instancia del Modelo Repuesto existente en BD desde el Id de repuesto
            modeloRepuesto = (ModeloRepuesto) datos.buscarRepuesto(idRepuestoExistente);
            //OK - System.Diagnostics.Debug.WriteLine("Se recupera el repuesto: " + modeloRepuesto.Id);

            if (!desperfectoEnConstruccion.contains(modeloRepuesto))
            {
                // Se agrega el Modelo Repuesto al Modelo Desperfecto
                desperfectoEnConstruccion.agregarRepuesto(modeloRepuesto);
                // OKSystem.Diagnostics.Debug.WriteLine("DESPERFECTO EN CONSTRUCCION: " + desperfectoEnConstruccion.CostoRepuestosDesperfecto);
                presupuesto.actualizarDesperfectoActual(desperfectoEnConstruccion);
                return modeloRepuesto;
            }
            else
            {
                // OK System.Diagnostics.Debug.WriteLine("EXISTE REPUESTO");
                return null;
            }

        }

        public static ModeloRepuesto agregarRepuestoNuevoAlDesperfectoActual(ModeloPresupuesto presupuesto, String nombre, Decimal precio)
        {
            ModeloRepuesto modeloRepuesto = null;
            PersistenciaRepuesto datos = new PersistenciaRepuesto();

            // Se obtiene el desperfecto que se esta configurando del presupuesto en curso
            ModeloDesperfecto desperfectoEnConstruccion = presupuesto.getDesperfectoActual();
            //OK. System.Diagnostics.Debug.WriteLine("Se recupera DESPERFECTO: " + desperfectoEnConstruccion.Id);


            int ultimoIdRepuesto = (int) datos.Insertar(nombre, precio);            
            
            // Se crea una instancia del nuevo Modelo Repuesto. El true indica que aún está a la espera de confirmación, dado que el presupuesto está en curso.
            modeloRepuesto = new ModeloRepuesto(ultimoIdRepuesto, nombre, precio, true);

            if (!desperfectoEnConstruccion.contains(modeloRepuesto))
            {
                // Se agrega el Modelo Repuesto al Modelo Desperfecto
                desperfectoEnConstruccion.agregarRepuesto(modeloRepuesto);
                // OKSystem.Diagnostics.Debug.WriteLine("DESPERFECTO EN CONSTRUCCION: " + desperfectoEnConstruccion.CostoRepuestosDesperfecto);
                presupuesto.actualizarDesperfectoActual(desperfectoEnConstruccion);
                System.Diagnostics.Debug.WriteLine("------>>>>> DESPERFECTO ACTUALIZADO: " + presupuesto.getDesperfectoActual().CostoRepuestosDesperfecto);
                return modeloRepuesto;
            }
            else
            {
                // OK System.Diagnostics.Debug.WriteLine("EXISTE REPUESTO");
                return null;
            }
        }
    }
}
