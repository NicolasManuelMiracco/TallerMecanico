using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaModelo;



namespace CapaPresentación
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        //[STAThread]
        static public void Main(String[] args)
        {
            Inicio formulario = new Inicio();
            formulario.ShowDialog();

            
            
            //Console.WriteLine("Standard Numeric Format Specifiers");
            //LogicaTallerMecanico taller = new LogicaTallerMecanico();
            //ModeloMoto nuevaMoto = new ModeloMoto(32, "Yamaha", "Enduro", "GFD321", 21, "150");
            //taller.ingresarMoto(nuevaMoto);

            //ModeloAutomovil nuevoAutomovil = new ModeloAutomovil(34, "GMT", "Camaro", "GFD321", TipoAutomovil.sedan, 4, 14);
            //System.Diagnostics.Debug.WriteLine("Salida: " + nuevoAutomovil.Patente);
            //taller.ingresarAutomovil(nuevoAutomovil);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
        
    }
}

