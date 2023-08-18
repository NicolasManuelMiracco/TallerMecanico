using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
