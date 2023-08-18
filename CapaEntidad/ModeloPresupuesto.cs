using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public double Estacionamiento { get; set; }

        public ModeloPresupuesto(int idVehiculo, int ultimoPresupuesto)
        {
            init(idVehiculo, ultimoPresupuesto);
        }

        private void init(int idVehiculo, int ultimoPresupuesto)
        {
            Email = "@gmail.com";
            Completa = false;
            Id = ultimoPresupuesto;
            IdVehiculo = idVehiculo;
            CostoEstacionamiento = 130;
            Descuento = 0;
            Recargo = 0.10;
            DiasReparacion = 0;
            ManoDeObra = 0;
            TiempoTotal = 0;
            CostoTotal = 0;
            Desperfectos = new List<ModeloDesperfecto>();
        }

        public void addDesperfecto(ModeloDesperfecto modeloDesperfecto)
        {
            this.Desperfectos.Add(modeloDesperfecto);
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
