using System;
using System.Windows.Forms;
using CapaModelo;

namespace CapaLogica
{
    public class LogicaTallerMecanico
    {
        public static StrategyTurno getEstrategiaTurno(ComboBox comboBoxEstrategiaTurno)
        {
            if (comboBoxEstrategiaTurno.Text.Equals("Aleatoria con Rango"))
            {
                return new RandomTurno(6);
            }
            else
            {
                return new PrimerDisponibleTurno();
            }
        }

        public static void agregarPresupuesto(DateTime turno, ModeloTallerMecanico taller, String id, String nombre, String apellido, String email, String total, String idVehiculo)
        {
            
            taller.agregarPresupuesto(turno, new ModeloPresupuesto(Convert.ToInt32(id), nombre, apellido, email, Convert.ToDecimal(total), Convert.ToInt32(idVehiculo)));
        }
    }
}
