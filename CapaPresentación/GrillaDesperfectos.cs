using CapaLogica;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
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

        void IObserver.update(object obj)
        {
            System.Diagnostics.Debug.WriteLine("ENTRAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");

            //tabla.Load(resultado);
            //dataGridViewDesperfectos.DataSource = logicaDesperfecto.Listar(presupuesto.Id);
            //this.DataSource = (ModeloDesperfecto)o;
            ModeloDesperfecto modeloDesperfecto = (CapaModelo.ModeloDesperfecto)(obj);
            //this.DataSource = new DataTable().Load(modeloDesperfecto.Repuestos);
            //this.DataSource = modeloDesperfecto.Repuestos;
            this.Rows[0].Cells[2].Value = 'Z';

        }
    }
}
