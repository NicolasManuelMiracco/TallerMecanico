using System;

namespace CapaLogica
{
    /// <summary>
    /// Interface padre que define el comportamiento base para definir turnos
    /// </summary>
    public abstract class StrategyTurno
    {
        protected DateTime turno;

        /// <summary>
        /// Método abstracto a implementar por las clases hijas, quienes defienen la estrategia de asignación de turno.
        /// </summary>
        /// <returns></returns>
        public abstract DateTime Next(DateTime actual);         
    }
}
