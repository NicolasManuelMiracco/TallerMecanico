using System;

namespace CapaLogica
{
    public interface IObserver
    {
        /// <summary>
        /// Metodo que sera invocado por el Subject
        /// El objeto "o" seran los valores que el Subject le pasara al Observer
        /// </summary>
        /// <param name="o"></param>
        void update(Object o);
    }
}
