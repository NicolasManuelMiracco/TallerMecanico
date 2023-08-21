using System;

namespace CapaModelo
{
    public class ModeloRepuesto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }

        public ModeloRepuesto(int IdRepuesto, String nombre, Decimal precio)
        {
            Id = IdRepuesto;
            Nombre = nombre;
            Precio = precio;
        }
    }
}