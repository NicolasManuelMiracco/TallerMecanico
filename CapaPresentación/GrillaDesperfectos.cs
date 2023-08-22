using CapaLogica;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class GrillaDesperfectos : DataGridView, CapaLogica.IObserver
    {
        void IObserver.update(object o)
        {
            this.DataSource = (ModeloDesperfecto)o;
        }
    }
}
