using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace CapaModelo
{
    public class ModeloDesperfecto
    {
        public int Id { get; set; }
        public decimal CostoRepuestosDesperfecto { get; set; }
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal ManoDeObra { get; set; }
        public int Tiempo { get; set; }       
        public bool Cerrado { get; set; }
        public List<ModeloRepuesto> Repuestos;
        public int CantidadRepuestos { get; set; }
        public int CantidadRepuestosExistentes { get; set; }
        public int CantidadRepuestosFaltantes { get; set; }

        private void init(String descripcion, decimal manoDeObra, int tiempo)
        {
            IdPresupuesto = -1; //Flag: sin persistencia
            CostoRepuestosDesperfecto = 0;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
            // Indica que el desperfecto está siendo tratado
            Cerrado = false;            
            Repuestos = new List<ModeloRepuesto>();
            CantidadRepuestos = 0;
            CantidadRepuestosExistentes = 0;
            CantidadRepuestosFaltantes = 0;
        }

        public void calcularCostoRepuestosDesperfecto()
        {
            Decimal costoParcial = 0;
            foreach (ModeloRepuesto repuesto in Repuestos)
            {
                costoParcial += repuesto.Precio;
            }
            CostoRepuestosDesperfecto = costoParcial;
        }

        public List<ModeloRepuesto> getRepuestos() { return Repuestos; }

        /// <summary>
        /// El idDepserfecto se agrega después de su persistencia en BD, a partir del autonumérico
        /// </summary>               
        public ModeloDesperfecto(int idPresupuesto, String descripcion, decimal manoDeObra, int tiempo)
        {
            init(descripcion, manoDeObra, tiempo);
            IdPresupuesto = idPresupuesto;            
        }

        public bool contains(ModeloRepuesto modeloRepuesto)
        {
            foreach (ModeloRepuesto repuesto in Repuestos)
            {
                if (repuesto.Id == modeloRepuesto.Id) return true;
            }
            return false;
        }
        public void agregarRepuesto(ModeloRepuesto nuevoRepuesto)
        {
            Repuestos.Add(nuevoRepuesto);
            CantidadRepuestos++;
            CostoRepuestosDesperfecto = CostoRepuestosDesperfecto + nuevoRepuesto.Precio;            
        }

        /// <summary>
        /// Se cierra el desperfecto, es decir se le asignaron los repuestos.
        /// </summary>
        public void cerrarDesperfecto() {   Cerrado = true; }

        public DataTable CreateDataTable<ModeloRepuesto>(IEnumerable<ModeloRepuesto> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(ModeloRepuesto));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (ModeloRepuesto item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        /// <summary>
        /// Retorna un DataTable con el listado de repuestos asignados al desperfecto en curso para el Presupuesto que se construye dinámicamente
        /// </summary> 
        public DataTable ListarRepuestos()
        {
            return CreateDataTable(this.getRepuestos());            
        }

        /// <summary>
        /// Se eliminan los repuestos que no fueron seleccionados al momento de cerrar el desperfecto.
        /// </summary>
        public void filtrarRepuestos(List<int> repuestosExistentes, List<int> repuestosEnEspera)
        {
            foreach (ModeloRepuesto repuesto in Repuestos)
            {
                if (!repuestosExistentes.Contains(repuesto.Id) && !repuestosEnEspera.Contains(repuesto.Id))
                {
                    System.Diagnostics.Debug.WriteLine("Se elimina repuesto: " + repuesto.Id);
                    Repuestos.Remove(repuesto);
                    CantidadRepuestos--;
                }
            }            
        }
    }
}
 