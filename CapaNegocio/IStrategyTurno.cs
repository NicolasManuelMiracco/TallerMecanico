using System;

namespace CapaNegocio
{
    /// <summary>
    /// Interface padre que define el comportamiento base para definir turnos
    /// </summary>

    public interface IStrategyTurno
    {
        DateTime Next(); 
        
    }
}
