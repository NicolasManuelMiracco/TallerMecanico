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
        public List<ModeloDesperfecto> desperfectos { get; set; }
        public int TiempoTotal { get; set; }
        public double costoTotal { get; set; }

        public ModeloPresupuesto(int idVehiculo, int ultimoPresupuesto)
        {
            this.Completa = false;
            this.Id = ultimoPresupuesto;
            this.IdVehiculo = idVehiculo;
            this.CostoEstacionamiento = 130;
            this.Descuento = 0;
            this.Recargo = 0;
            this.ManoDeObra = 0;
            this.TiempoTotal = 0;
            this.costoTotal = 0;
            this.desperfectos = new List<ModeloDesperfecto>();
        }

        public void addDesperfecto(ModeloDesperfecto modeloDesperfecto)
        {
            this.desperfectos.Add(modeloDesperfecto);
            // Se incorpora al presupuesto el costo total de los repuestos
            costoTotal += modeloDesperfecto.costoRepuestosDesperfecto;
            // Se acumula el tiempo total para cada desperfecto tratado
            TiempoTotal += modeloDesperfecto.Tiempo;
            // Se acumula el costo total de mano de obra para cada desperfecto tratado
            ManoDeObra += modeloDesperfecto.ManoDeObra;
        }

          
    }
}
