using System;

namespace CapaModelo
{
    public class ModeloRepuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public Boolean EnEspera { get; set; }

        /// <summary>
        /// El constructor de repuestos, permite parametrizar si el mismo está a la espera de confirmación. 
        /// Es usado cuando el presupuesto o el desperfecto que lo contiene se cancela, y por lo tanto debe quitarse de la BD.
        /// El valor por default es false.
        /// </summary>        
        
        public ModeloRepuesto(int IdRepuesto, String nombre, Decimal precio, Boolean enEspera = false)
        {
            Id = IdRepuesto;
            Nombre = nombre;
            Precio = precio;
            EnEspera = enEspera;
        }

        public Boolean Equals(ModeloRepuesto otroModeloRepuesto)
        {
            return Id == otroModeloRepuesto.Id;
        }
    }
}