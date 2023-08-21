using System;
using System.Collections.Generic;

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
        public Boolean Cerrado { get; set; }
        public List<ModeloRepuesto> Repuestos { get; set; }

        
        public ModeloDesperfecto(int idPresupuesto, String descripcion, Double manoDeObra, int tiempo)
        {
            IdPresupuesto = idPresupuesto;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
            // Indica que el desperfecto está siendo tratado
            Cerrado = false;
            costoRepuestosDesperfecto = 0;
            Repuestos = new List<ModeloRepuesto>();
        }

        public void agregarRepuesto(ModeloRepuesto nuevoRepuesto)
        {
            Repuestos.Add(nuevoRepuesto);
        }

        /// <summary>
        /// Se cierra el desperfecto, es decir se le asignaron los repuestos.
        /// </summary>

        public void cerrarDesperfecto()
        {
            Cerrado = true;
        }

    }
}
