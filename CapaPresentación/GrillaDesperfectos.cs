using CapaLogica;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class GrillaDesperfectos : DataGridView, CapaLogica.IObserver
    {

        // Subject al que se encuentra suscrito el observer
        private ISubject subject;

        // El constructor suscribira el observer al subject
        public GrillaDesperfectos(ISubject subject)
        {
            this.subject = subject;
            subject.RegistrarObserver(this);
        }

        public GrillaDesperfectos()
        {
            
        }

        public void setSubjec(ISubject obj)
        {
            this.subject = obj;
            subject.RegistrarObserver(this);
        }

        public void deleteSubject(ISubject obj)
        {
            this.subject = null;
            subject.EliminarObserver(this);

        }

        private int obtenerFilaGrillaDesperfectos(int desperfectoNuevo)
        {
            int indice = -1;
            try
            {
                Boolean encontre = false;
                foreach (DataGridViewRow row in this.Rows) if (!encontre)
                {
                    if (Convert.ToInt32(row.Cells[3].Value) == desperfectoNuevo)
                    {
                        encontre = true;
                        indice = row.Index;
                    }
                }                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
            return indice;
        }

        void IObserver.update(object obj)
        {                   
            if (obj != null)
            {
                ModeloDesperfecto modeloDesperfecto = (CapaModelo.ModeloDesperfecto)(obj);
                
                int filaGrillaDesperfectos = obtenerFilaGrillaDesperfectos(modeloDesperfecto.Id);
                if (filaGrillaDesperfectos != -1) // La grilla se actualizó con el nuevo desperfecto
                {                   
                    this.Rows[filaGrillaDesperfectos].Cells[1].ReadOnly = false;
                    this.Rows[filaGrillaDesperfectos].Cells[1].Value = modeloDesperfecto.CantidadRepuestosExistentes;
                    this.Rows[filaGrillaDesperfectos].Cells[2].ReadOnly = false;
                    this.Rows[filaGrillaDesperfectos].Cells[2].Value = modeloDesperfecto.CantidadRepuestosFaltantes;
                    /// Se definen Colores por defecto Verde y Rojo para repuestos en Stock y Faltantes respectivamente
                    this.Rows[filaGrillaDesperfectos].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }           
        }
    }
}
