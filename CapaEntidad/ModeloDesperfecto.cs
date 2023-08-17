using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloDesperfecto
    {
        //private List<ModeloRepuesto> repuestos;
        public int Id { get; set; }
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public Double ManoDeObra { get; set; }
        public int Tiempo { get; set; }

        
        public ModeloDesperfecto(String idDesperfecto, String descripcion, String manoDeObra, String tiempo)
        {
            Id = Int32.Parse(idDesperfecto);
            Descripcion = descripcion;
            ManoDeObra = Double.Parse(manoDeObra);
            Tiempo = Int32.Parse(tiempo);
        }


    }
}
