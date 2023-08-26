using System;

namespace CapaLogica
{
    /// <summary>
    /// Interface padre que define el comportamiento base para definir turnos
    /// </summary>
    public abstract class StrategyTurno
    {
        protected DateTime turno;

        ///// <summary>
        ///// Constructor por defecto para tomar el día actual como fecha de referencia
        ///// </summary>
        //public StrategyTurno()
        //{
        //    turno = DateTime.Today;
        //}

        ///// <summary>
        ///// Constructor parametrizado para tomar como referencia una fecha
        ///// </summary>
        ///// <param name="turnoAnterior"></param>
        //public StrategyTurno(DateTime turnoAnterior)
        //{
        //    turno = turnoAnterior;
        //}
        
        /// <summary>
        /// Método abstracto a implementar por las clases hijas, quienes defienen la estrategia de asignación de turno.
        /// </summary>
        /// <returns></returns>
        public abstract DateTime Next(DateTime actual);         
    }
}
