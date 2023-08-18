namespace CapaModelo
{

    /// <summary>
    /// Tipo enumerado público segun requerimiento
    /// </summary>
    public enum TipoAutomovil 
    {
        compacto,
        sedan,
        monovolumen,
        utilitario,
        lujo
    }

    public class ModeloAutomovil : ModeloVehiculo
    {
        public int IdAutomovil { get; set; }
        public string Tipo { get; set; }
        public int CantidadPuertas { get; set; }
        public int IdVehiculo { get; set; }

        public ModeloAutomovil(int id, string marca, string modelo, string patente, string tipo, int cantidadPuertas, int idVehiculo) : base (idVehiculo, marca, modelo, patente)
        {
            this.Tipo = tipo;
            this.CantidadPuertas = cantidadPuertas;
            this.IdVehiculo = idVehiculo;
            this.IdAutomovil = id;
        }        
    }
}
