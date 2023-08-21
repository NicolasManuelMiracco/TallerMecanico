using System;

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

        
        public ModeloDesperfecto(int idPresupuesto, String descripcion, Double manoDeObra, int tiempo)
        {
            IdPresupuesto = idPresupuesto;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
            costoRepuestosDesperfecto = 0;
        }

        /// <summary>
        /// Incorporación del costo de repuesto al desperfecto
        /// </summary>
        /// <param name="nuevoRepuesto"></param>
        public void adicionarCostoRepuesto(double nuevoRepuesto)
        {
            costoRepuestosDesperfecto += nuevoRepuesto;
        }

    }
}
