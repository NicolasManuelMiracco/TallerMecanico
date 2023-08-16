using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloDesperfecto
    {


        private List<ModeloRepuesto> repuestos;
        public int Id { get; set; }
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public Double ManoDeObra { get; set; }
        public int Tiempo { get; set; }
    }
}
