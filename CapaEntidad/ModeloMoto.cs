using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloMoto : ModeloVehiculo
    {
        public int IdMoto { get; set; }
        public int IdVehiculo { get; set; }
        public string Cilindrada { get; set; }

        public ModeloMoto(int id, string marca, string modelo, string patente, int idVehiculo, string cilindrada)
            : base(idVehiculo, marca, modelo, patente)
        {
            this.IdVehiculo = idVehiculo;
            this.Cilindrada = cilindrada;
            this.IdMoto = id;
        }
        

    }
}
