using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloPresupuesto
    {
        public int IdPresupuesto { get; set; }
        public Double Descuento { get; set; }
        public int IdVehiculo { get; set; }
        public Double Recargo { get; set; }
        public int DiasReparacion { get; set; }
        public Double ManoDeObra { get; set; }
        public Double Total { get; set; }
        public Boolean Completa { get; set; }
        public Double CostoEstacionamiento { get; set; }
        public List<ModeloDesperfecto> desperfectos { get; set; }

        public ModeloPresupuesto(int idVehiculo, int ultimoPresupuesto)
        {
            this.Completa = false;
            this.IdPresupuesto = ultimoPresupuesto;
            this.IdVehiculo = idVehiculo;
            this.CostoEstacionamiento = 130;
            this.Descuento = 0;
            this.Recargo = 0;
            this.desperfectos = new List<ModeloDesperfecto>();
        }

        public void addDesperfecto(ModeloDesperfecto modeloDesperfecto)
        {
            this.desperfectos.Add(modeloDesperfecto);
        }
    }
}
