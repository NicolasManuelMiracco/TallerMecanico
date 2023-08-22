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
        public Double Descuento { get; set; }
        public int IdVehiculo { get; set; }
        public Double Recargo { get; set; }
        public int DiasReparacion { get; set; }
        public Double ManoDeObra { get; set; }
        public Double Total { get; set; }
        public Boolean Completa { get; set; }
        public Double CostoEstacionamiento { get; set; }
        public List<ModeloDesperfecto> Desperfectos { get; set; }
        public int TiempoTotal { get; set; }
        public double CostoTotal { get; set; }
        public ModeloDesperfecto CurrentDesperfecto { get; set; }
        

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
            Recargo = 0.10;
            DiasReparacion = 0;
            ManoDeObra = 0;
            TiempoTotal = 0;
            CostoTotal = 0;
            Total = 0;
            Desperfectos = new List<ModeloDesperfecto>();
            CurrentDesperfecto = null;
        }

        public void setIdCurrentDesperfecto(int idDesperfecto)
        {
            ((ModeloDesperfecto)CurrentDesperfecto).Id = idDesperfecto; // Se completa el seteo para el desperfecto en construcción
        }

        /// <summary>
        /// Incorporación de desperfectos al presupuesto y actualización
        /// </summary>
        public void addDesperfecto(ModeloDesperfecto modeloDesperfecto)
        {
            this.Desperfectos.Add(modeloDesperfecto);
            CurrentDesperfecto = modeloDesperfecto;
            // Se incorpora al presupuesto el costo total de los repuestos
            CostoTotal += modeloDesperfecto.costoRepuestosDesperfecto;
            // Se acumula el tiempo total para cada desperfecto tratado
            TiempoTotal += modeloDesperfecto.Tiempo;
            // Se acumula el costo total de mano de obra para cada desperfecto tratado
            ManoDeObra += modeloDesperfecto.ManoDeObra;
        }
        public void cerrarPresupuesto() { Completa = true;  }     
    }
}
