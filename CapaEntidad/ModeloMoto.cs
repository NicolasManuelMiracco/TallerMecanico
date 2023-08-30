namespace CapaModelo
{
    public class ModeloMoto : ModeloVehiculo
    {
        public int IdMoto { get; set; }
        public int IdVehiculo { get; set; }
        public string Cilindrada { get; set; }

        /// <summary>
        /// Constructor parametrizado, quien llama al padre manteniendo coherencia en su instanciación
        /// </summary>        
        public ModeloMoto(int id, string marca, string modelo, string patente, int idVehiculo, string cilindrada) : base(idVehiculo, marca, modelo, patente)
        {
            this.IdVehiculo = idVehiculo;
            this.Cilindrada = cilindrada;
            this.IdMoto = id;
        }

        public ModeloMoto(string marca, string modelo, string patente, string cilindrada) : base(marca, modelo, patente)
        {
            this.Cilindrada = cilindrada;            
        }
    }
}
