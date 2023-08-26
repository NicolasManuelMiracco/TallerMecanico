using System;

namespace CapaLogica
{
    /// <summary>
    /// Implementación patrón Strategy para la definición dinámica de la forma en que se asigna un turno
    /// </summary>
    public class RandomTurno : StrategyTurno
    { 
        Random gen; 
        int range = 5; 
        public RandomTurno(int demora) {
            range = demora;
            gen = new Random();            
        }

        //public RandomTurno(int demora, DateTime lastTurno) : base(lastTurno)
        //{
        //    range = demora;
        //    gen = new Random();
        //}

        public override DateTime Next(DateTime actual) { 
            return actual.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60)); 
        }
    }    
}
