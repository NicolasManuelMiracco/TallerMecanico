namespace CapaModelo
{
    public class ModeloVehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public ModeloVehiculo(int id, string marca, string modelo, string patente)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Patente = patente;
        }
          
        
    }
}
