using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace CapaModelo
{
    public class ModeloDesperfecto
    {
        public double costoRepuestosDesperfecto { get; set; }
        public int Id { get; set; }
        public int IdPresupuesto { get; set; }
        public string Descripcion { get; set; }
        public Double ManoDeObra { get; set; }
        public int Tiempo { get; set; }       
        public Boolean Cerrado { get; set; }
        public List<ModeloRepuesto> Repuestos { get; set; }

        /// <summary>
        /// RESTA AGREGAR Id
        /// </summary>
               
        public ModeloDesperfecto(int idPresupuesto, String descripcion, Double manoDeObra, int tiempo)
        {
            IdPresupuesto = idPresupuesto;
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
            // Indica que el desperfecto está siendo tratado
            Cerrado = false;
            costoRepuestosDesperfecto = 0;
            Repuestos = new List<ModeloRepuesto>();
        }

        /// <summary>
        /// Constructor sin idDesperfecto ni idPresupuesto, dado que aún no se confirmó persistencia
        /// </summary>

        public ModeloDesperfecto(String descripcion, Double manoDeObra, int tiempo)
        {
            Descripcion = descripcion;
            ManoDeObra = manoDeObra;
            Tiempo = tiempo;
            // Indica que el desperfecto está siendo tratado
            Cerrado = false;
            costoRepuestosDesperfecto = 0;
            Repuestos = new List<ModeloRepuesto>();
        }

        public void agregarRepuesto(ModeloRepuesto nuevoRepuesto)
        {
            Repuestos.Add(nuevoRepuesto);
        }

        /// <summary>
        /// Se cierra el desperfecto, es decir se le asignaron los repuestos.
        /// </summary>

        public void cerrarDesperfecto()
        {
            Cerrado = true;
        }

        /// <summary>
        /// Usando Reflection: creación del DataTable para repuestos a partir de la lista de repuestos existentes en el modelo Desperfecto
        /// </summary>        

        private DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            dataTable.TableName = typeof(T).FullName;
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        /// <summary>
        /// Retorna un DataTable con el listado de repuestos asignados al desperfecto en curso para el Presupuesto que se construye dinámicamente
        /// </summary>              

        public DataTable ListarRepuestos()
        {            
            return CreateDataTable(Repuestos);            
        }

    }
}
