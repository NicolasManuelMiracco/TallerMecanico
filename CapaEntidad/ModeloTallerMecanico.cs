﻿using System;
using System.Collections.Generic;

namespace CapaModelo
{
    public class ModeloTallerMecanico
    {
        List<ModeloPresupuesto> presupuestos { get; set; }

        public DateTime getLastTurno() 
        {
            return UltimoTurno;
        }

        DateTime UltimoTurno { get; set; }

        public void setUltimoTurno(DateTime ultimoTurno)
        {
            UltimoTurno = ultimoTurno;
        }

        public ModeloTallerMecanico()
        {
            presupuestos = new List<ModeloPresupuesto>();
            UltimoTurno = DateTime.Today;
        }

        public void agregarPresupuesto(DateTime turno, ModeloPresupuesto nuevoPresupuesto)
        {
            presupuestos.Add(nuevoPresupuesto);
            UltimoTurno = turno; 
        }
    }
}
