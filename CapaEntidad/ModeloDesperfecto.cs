using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloDesperfecto
    {
        public double costoRepuestosDesperfecto { get; set; }
        public int Id { get; set; }
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public Double ManoDeObra { get; set; }
        public int Tiempo { get; set; }       

        
        public ModeloDesperfecto(int idDesperfecto, String descripcion, String manoDeObra, String tiempo)
        {
            Id = idDesperfecto;
            Descripcion = descripcion;
            ManoDeObra = Double.Parse(manoDeObra);
            Tiempo = Int32.Parse(tiempo);
            costoRepuestosDesperfecto = 0;
        }

        public void adicionarCostoRepuesto(double nuevoRepuesto)
        {
            costoRepuestosDesperfecto += nuevoRepuesto;
        }

    }
}
