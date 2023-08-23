using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaModelo
{
    public class ModeloPresupuesto
    {
        public string Email { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Id { get; set; }
        public decimal Descuento { get; set; }
        public int IdVehiculo { get; set; }
        public decimal Recargo { get; set; }
        public decimal ManoDeObra { get; set; }
        public decimal Total { get; set; }
        public Boolean Completa { get; set; }
        public decimal CostoEstacionamiento { get; set; }
        public List<ModeloDesperfecto> Desperfectos { get; set; }
        public int TiempoTotal { get; set; }
        public decimal CostoTotal { get; set; }        
        public int IdCurrentDesperfecto { get; set; }        
        public List<int> DesperfectosAPresupuestar { get; set; }
        public decimal gananciaTaller { get; set; }
        public decimal TotalConRecargosDescuentos { get; set; }
        public decimal TotalConGanancia { get; set; }

        public ModeloPresupuesto(int idVehiculo)
        {
            init(idVehiculo);
        }

        /// <summary>
        /// Se genera el modelo sin el Id, que será ingresado después de la persistencia del nuevo Presupuesto, dado que se genera de forma autonumérica
        /// </summary> 
        private void init(int idVehiculo)
        {
            Email = "@gmail.com";
            Apellido = "";
            Nombre = "";
            Completa = false;
            Id = -1; // Este flag indica que el presupuesto aún no esta en BD, es coherente con Completa en false
            IdVehiculo = idVehiculo;
            CostoEstacionamiento = 130;
            Descuento = 0;
            gananciaTaller = (decimal)0.10;
            Recargo = 0;
            ManoDeObra = 0;
            TiempoTotal = 0;
            CostoTotal = 0;
            Total = 0;
            Desperfectos = new List<ModeloDesperfecto>();            
        }

        public ModeloDesperfecto getDesperfectoActual()
        {
            ModeloDesperfecto desperfectoActual = null;
            foreach (ModeloDesperfecto desperfecto in Desperfectos)
            {
                if (desperfecto.Id == IdCurrentDesperfecto)
                    desperfectoActual = desperfecto;                
            }
            return desperfectoActual;
        }

        public void setIdCurrentDesperfecto(int idDesperfecto)
        {
            IdCurrentDesperfecto = idDesperfecto; // Se completa el seteo para el desperfecto en construcción
        }

        /// <summary>
        /// Incorporación de desperfectos al presupuesto y actualización
        /// </summary>
        public void addDesperfecto(ModeloDesperfecto modeloDesperfecto)
        {
            this.Desperfectos.Add(modeloDesperfecto);
            //CurrentDesperfecto = modeloDesperfecto;
            // Se incorpora al presupuesto el costo total de los repuestos
            CostoTotal += modeloDesperfecto.CostoRepuestosDesperfecto;
            // Se acumula el tiempo total para cada desperfecto tratado
            TiempoTotal += modeloDesperfecto.Tiempo;
            // Se acumula el costo total de mano de obra para cada desperfecto tratado
            ManoDeObra += modeloDesperfecto.ManoDeObra;
        }
        public void cerrarPresupuesto() { 
            Completa = true;
            CostoEstacionamiento = TiempoTotal * CostoEstacionamiento; /// Calculo el precio de estacionamiento según la cantidad de días
            Total = CostoTotal + ManoDeObra + CostoEstacionamiento;
            TotalConRecargosDescuentos = Total + Total * Recargo - Total * Descuento;
            TotalConGanancia = TotalConRecargosDescuentos + TotalConRecargosDescuentos * gananciaTaller;

        }     
    }
}
