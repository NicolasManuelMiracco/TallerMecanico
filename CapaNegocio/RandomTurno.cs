using System;

namespace CapaLogica
{
    /// <summary>
    /// Implementación patrón Strategy para la definición dinámica de la forma en que se asigna un turno
    /// </summary>
    public class RandomTurno : IStrategyTurno
    { 
        DateTime turno; 
        Random gen; 
        int range = 5; 
        public RandomTurno(int demora) {
            range = demora;
            turno = DateTime.Today; 
            gen = new Random();
            
        }        
        public DateTime Next() { 
            return turno.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60)); 
        }
    }    
}
