using CapaModelo;
using System;

namespace CapaLogica
{
    /// <summary>
    /// Implementación para asignar el primer turno disponible en el taller mecánico
    /// </summary>
    public class PrimerDisponibleTurno : StrategyTurno
    {
        public override DateTime Next(DateTime actual)
        {
            return actual.AddDays(1);
        }

        //public PrimerDisponibleTurno(DateTime lastTurno) : base(lastTurno)
        //{
            
        //}
    }
}