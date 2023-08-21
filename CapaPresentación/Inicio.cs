using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaLogica;
using CapaModelo;

/// <summary>
/// Desarrollo Taller Mecánico 
/// Entrega Preliminar
/// Author: Nicolás Manuel Miracco
/// Challenge .NET 
/// </summary>

// Form según aspect ratio 16:9, de 1361 x 765 pixels, sin maximización ni resize.

namespace CapaPresentación
{
    public partial class Inicio : Form
    {

        /// <summary>
        /// Referencia dinámica al presupuesto que se construye desde UI. Al cerrar la transacción se persiste.
        /// </summary>
        ModeloPresupuesto presupuesto;
        public Inicio()
        {
            InitializeComponent();
        }        

        private void listar()
        {
            try
            {
                dgvDatos.DataSource = LogicaVehiculo.Listar();
                //dgvDatos = parseGridTipoVehiculo(dgvDatos);
                this.formato();
                labelTotal.Text = Convert.ToString(dgvDatos.Rows.Count);
                this.limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void formato()
        {
            dgvDatos.Columns[0].Visible = false;
            dgvDatos.Columns[0].Width = 30;
            dgvDatos.Columns[1].Width = 75;
            dgvDatos.Columns[2].Width = 75;
            dgvDatos.Columns[3].Width = 75;
            dgvDatos.Columns[4].Width = 45;
            dgvDatos.Columns[5].Width = 75;
            dgvDatos.Columns[6].Width = 45;
            dgvDatos.Columns[7].Width = 45;
            dgvDatos.Columns[8].Width = 75;
            dgvDatos.Columns[9].Width = 75;
        }

        private void buscar()
        {
            try
            {
                dgvDatos.DataSource = LogicaVehiculo.Buscar(txtBuscar.Text);
                //dgvDatos = parseGridTipoVehiculo(dgvDatos);
                this.formato();
                labelTotal.Text = Convert.ToString(dgvDatos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void limpiar()
        {
            txtBuscar.Clear();
            textBxIdVehículo.Clear();
            textBxIdMoto.Clear();
            textBxIdAutomóvil.Clear();
            textBxMarca.Clear();
            textBxModelo.Clear();
            textBxPatente.Clear();
            textBxCilindrada.Clear();
            textPuertas.Clear();
            btInsertarVehículo.Visible = true;
            btnActualizarVehículo.Visible = true;
            error.Clear();
            dgvDatos.Columns[0].Visible = false;
            Diagnose.Visible = false;
            btnPresupuestar.Visible = false;
            btEliminar.Visible = false;
            chkSelect.Checked = false;
        }

        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Control de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOk(string Message)
        {
            MessageBox.Show(Message, "Control de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string tratamientoDatosVehiculo()
        {
            if (textBxIdVehículo.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxIdVehículo, "Ingrese el Id del Vehiculo");
                return "FAIL";
            }
            if (textBxMarca.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxMarca, "Ingrese Marca del Vehiculo");
                return "FAIL";
            }
            if (textBxModelo.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxModelo, "Ingrese Modelo del Vehiculo");
                return "FAIL";
            }
            if (textBxPatente.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxPatente, "Ingrese Patente del Vehiculo");
                return "FAIL";
            }
            return "OK";
        }

        private string insertarAutomovil()
        {
            string respuesta = "";
            respuesta = LogicaAutomovil.Insertar(Convert.ToInt32(textBxIdAutomóvil.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text,
                ElComboTipoAutomovil.Text, Convert.ToInt32(textPuertas.Text), Convert.ToInt32(textBxIdVehículo.Text));
            return respuesta;
        }

        private string insertarMoto()
        {
            string respuesta = "";
            respuesta = LogicaMoto.Insertar(Convert.ToInt32(textBxIdMoto.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text,
                Convert.ToInt32(textBxIdVehículo.Text), textBxCilindrada.Text);
            return respuesta;
        }

        private string tratamientoDatosAutomovil()
        {
            //System.Diagnostics.Debug.WriteLine("Salida: " + "Automóvil selected");

            if (textBxIdAutomóvil.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxIdAutomóvil, "Ingrese el Id del Automóvil");
                return "FAIL";
            }
            if (textPuertas.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textPuertas, "Ingrese el número de puertas del Automóvil");
                return "FAIL";
            }
            if (ElComboTipoAutomovil.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(ElComboTipoAutomovil, "Ingrese el tipo de Vehículo");
                return "FAIL";
            }
            return "OK";
        }

        private string tratamientoDatosMoto()
        {
            if (textBxIdMoto.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxIdMoto, "Ingrese el Id de la Moto");
                return "FAIL";
            }
            if (textBxCilindrada.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del registro");
                error.SetError(textBxCilindrada, "Ingrese la cilindrada de la Moto");
                return "FAIL";
            }
            return "OK";
        }

        private void btInsertarVehículo_Click_1(object sender, EventArgs e)
        {
            string respuesta = "";
            if (selectorTipoVehículo.SelectedTab == tabAutomóvil)
            {
                if (tratamientoDatosVehiculo() == "OK" && tratamientoDatosAutomovil() == "OK")
                {
                    try
                    {
                        respuesta = insertarAutomovil();
                        if (respuesta == "OK")
                        {
                            this.MessageOk("Se insertó correctamente el Automóvil");
                            this.limpiar();
                            this.listar();
                        }
                        else { this.MessageError("No se pudo insertar el Automóvil"); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                    finally { }
                }
                else { this.MessageError("Existen errores en los datos del automóvil"); }
            }
            else
            {
                if (tratamientoDatosVehiculo() == "OK" && tratamientoDatosMoto() == "OK")
                {
                    try
                    {
                        respuesta = insertarMoto();
                        if (respuesta == "OK")
                        {
                            this.MessageOk("Se insertó correctamente la moto");
                            this.limpiar();
                            this.listar();
                        }
                        else { this.MessageError("No se pudo insertar la Moto"); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                    finally { }
                }
                else { this.MessageError("Existen errores en los datos de la moto"); }
            }
        }

        private void activarTabTipoVehiculo(string tipoAutomovil)
        {
            if (tipoAutomovil == string.Empty)
            {
                selectorTipoVehículo.SelectedIndex = 1; // Hace mantenimiento
            }
            else
            {
                selectorTipoVehículo.SelectedIndex = 0; // Hace mantenimiento
            }
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limpiar();
                btnActualizarVehículo.Visible = true;
                btInsertarVehículo.Visible = false;
                activarTabTipoVehiculo(Convert.ToString(dgvDatos.CurrentRow.Cells["IdAuto"].Value));

                textBxIdMoto.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["IdMoto"].Value);
                textBxIdAutomóvil.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["IdAuto"].Value);
                textBxMarca.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Marca"].Value);
                textBxModelo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Modelo"].Value);
                textBxPatente.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Patente"].Value);
                selectorTipoVehículo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Tipo"].Value);
                textPuertas.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Puertas"].Value);
                textBxCilindrada.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Cilindrada"].Value);
                tabControlPrincipal.SelectedIndex = 1; // Hace mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar desde la celda Id");
            }

        }

        /// <summary>
        /// Acceso para la eliminación de Vehiculos. Tener en cuenta que para el listado se realiza una Union entre la tabla Automóvil y Moto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigoMoto = 0, codigoAutomovil = 0, vehiculosSeleccionados = 0, vehiculosEliminados = 0, vehiculosAbortados = 0;                
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        vehiculosSeleccionados++; // Se registra la cantidad de seleccionados para UI usuario cuando es 0
                        // Aquí siempre tenemos un valor en columna 4 (Moto) OR exclusivo en columna 6 (Automovil)
                        if (!String.IsNullOrEmpty(row.Cells[4].Value.ToString())) // Es una Moto
                        {
                            codigoMoto = Int32.Parse(row.Cells[4].Value.ToString());
                            Opcion = MessageBox.Show("¿Eliminar la moto: " + codigoMoto + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                               
                        }
                        else // Es un Automóvil
                        {
                            codigoAutomovil = Int32.Parse(row.Cells[6].Value.ToString());
                            Opcion = MessageBox.Show("¿Eliminar el automóvil: " + codigoAutomovil + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);                            
                        }

                        respuesta = Opcion == DialogResult.OK ? LogicaVehiculo.Eliminar(codigoMoto, codigoAutomovil) : "ABORTED";
                        if (respuesta.Equals("OK"))
                        {
                            vehiculosEliminados++;
                        }
                        else if (respuesta.Equals("ABORTED"))
                        {
                            vehiculosAbortados++;
                        } 
                        else
                        {
                            this.MessageError("Error BD: " + respuesta);
                        }
                    }
                }
                if (vehiculosSeleccionados == 0) this.MessageError("Ingresar al menos un Vehículo");
                else this.MessageError("Vehículos eliminados: " + vehiculosEliminados + " y abortados: " + vehiculosAbortados);
                this.listar();                
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message + ex.StackTrace);  }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }        

        private void dgvDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Salida: " + dgvDatos.Rows.GetRowCount(DataGridViewElementStates.Selected));
            if (e.ColumnIndex == dgvDatos.Columns["Select"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Select"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                //System.Diagnostics.Debug.WriteLine("Salida: " + e.RowIndex);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }        

        private void btnCancelarInserción_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 0;
            this.listar();
        }

        /// <summary>
        /// Actualización del Vehículo al efectuar doble click sobre un registro del listado de Vehículos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnActualizarVehículo_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (textBxIdVehículo.Text == string.Empty)
                {
                    this.MessageError("Falta ingresar datos del registro");
                    error.SetError(textBxIdVehículo, "Ingrese el Id del Vehiculo");
                    return;
                }
                if (textBxMarca.Text == string.Empty)
                {
                    this.MessageError("Falta ingresar datos del registro");
                    error.SetError(txtMarca, "Ingrese Marca del Vehiculo");
                    return;
                }
                if (textBxModelo.Text == string.Empty)
                {
                    this.MessageError("Falta ingresar datos del registro");
                    error.SetError(TxtModelo, "Ingrese Modelo del Vehiculo");
                    return;
                }
                if (textBxPatente.Text == string.Empty)
                {
                    this.MessageError("Falta ingresar datos del registro");
                    error.SetError(txtPatente, "Ingrese Patente del Vehiculo");
                    return;
                }

                respuesta = LogicaVehiculo.Actualizar(Convert.ToInt32(textBxIdVehículo.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text);
                if (respuesta.Equals("OK"))
                {
                    this.MessageOk("Se actualizó correctamente el Vehiculo");
                    this.limpiar();
                    this.listar();
                }
                else
                {
                    this.MessageError(respuesta);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {

            }
        }
        
        private void Activate_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadVehiculos = 0, lastSelected = 0;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        lastSelected = Int32.Parse(row.Cells[9].Value.ToString());
                        cantidadVehiculos++;
                    }
                }
                DialogResult Opcion;
                if (cantidadVehiculos == 1)
                {
                    Opcion = MessageBox.Show("¿Presupuestar el Id vehículo: " + lastSelected + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel);
                    if (Opcion == DialogResult.OK)
                    {
                        //Se inicia el presupuesto y se incorpora el vehículo a presupuestar.
                        iniciarPresupuesto(lastSelected);
                        //Pasamos a la pestaña de selección de desperfectos. 
                        this.tabControlPrincipal.SelectedIndex = 4;
                        this.labelDesperfectosAsignados.Text = this.labelDesperfectosAsignados.Text + " Id Vehículo: " + this.presupuesto.IdVehiculo;
                    }
                    else
                    {
                        this.listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccionar 1 (un) vehículo.", "Control de Vehiculos", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dgvDatos.Columns[0].Visible = true;
                Diagnose.Visible = true;
                btnPresupuestar.Visible = true;
                btEliminar.Visible = true;
            }
            else
            {
                dgvDatos.Columns[0].Visible = false;
                Diagnose.Visible = false;
                btnPresupuestar.Visible = false;
                btEliminar.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Generación de instancia PRESUPUESTO
        /// </summary>

        private void iniciarPresupuesto(int automovilSeleccionado)
        {
            this.presupuesto = new ModeloPresupuesto(automovilSeleccionado);
            string respuesta = LogicaPresupuesto.IniciarPresupuesto(this.presupuesto);
            if (!respuesta.Equals("OK"))
            {
                this.MessageError(respuesta);
            }           
        }

        private List<int> rowsSelected(DataGridView dgv)
        {
            List<int> indicesSeleccionados = new List<int>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Selected) { indicesSeleccionados.Add(i); }   
            }
            System.Diagnostics.Debug.WriteLine("Salida: " + indicesSeleccionados.Count);
            return indicesSeleccionados;
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        /// <param name="indicesSeleccionados"></param>
        
        private int getFirstSelectedRow(List<int> indicesSeleccionados)
        {
            int encontro = 0;
            for (int i = 0; encontro == 0 && i < indicesSeleccionados.Count; i++)
            {
                if (dgvDatos.Rows[i].Cells[0].Selected) { encontro = i; }
            }
            return encontro;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 0;
            this.listar();
        }

        /// <summary>
        /// A partir de los desperfectos seleccionados en la grilla, se construye el presupuesto. 
        /// </summary>
        /// <returns></returns>
        
        
        
        /// <summary>
        /// Se cargan los Text Box con valores por default del presupuesto
        /// </summary>
        private void seteosDefaultPresupuesto()
        {

        }

        private void actualizarCamposCalculadosPresupuesto()
        {

        }

        private string tratamientoDatosPresupuesto()
        {
            if (txBoxEmail.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxEmail, "Ingrese el Email");
                return "FAIL";
            }   else presupuesto.Email = txBoxEmail.Text; 
            
            if (txBoxApellido.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxApellido, "Ingrese el Apellido");
                return "FAIL";
            }   else presupuesto.Apellido = txBoxApellido.Text;
            
            if (txBoxNombre.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxNombre, "Ingrese el Nombre");
                return "FAIL";
            }   else presupuesto.Nombre = txBoxNombre.Text;

            if (txBoxDescuento.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Presupuesto");
                error.SetError(txBoxDescuento, "Ingrese un Descuento");
                return "FAIL";
            }
            if (txBoxRecargo.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Presupuesto");
                error.SetError(txBoxRecargo, "Ingrese un Recargo");
                return "FAIL";
            }
            if (txBoxEstacionamiento.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Presupuesto");
                error.SetError(txBoxEstacionamiento, "Ingrese un Estacionamiento");
                return "FAIL";
            }
            if (txBoxRecargo.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxRecargo, "Ingrese un recargo para el Presupuesto");
                return "FAIL";
            }
            return "OK";
        }

        /// <summary>
        /// Se cierra la transacción presupuesto, esa es la lógica que se desarrolló para un concepto que se construye durante el ciclo de corrida de la aplicación.
        /// </summary>
        /// <returns></returns>
        private string finalizarPresupuesto()
        {
            string respuesta = "";
            /// Se persiste el presupuesto
            //respuesta = LogicaPresupuesto.Insertar(presupuesto);
            actualizarCamposCalculadosPresupuesto();
            return respuesta;
        }

        private string cargaDelCliente()
        {
            seteosDefaultPresupuesto();
            string respuesta = tratamientoDatosPresupuesto();
            if (respuesta == "OK")
            {
                try
                {
                    respuesta = finalizarPresupuesto();
                    if (respuesta == "OK")
                    {
                        this.MessageOk("Se insertó correctamente el presupuesto");
                        this.limpiar();
                        this.listar();
                    }
                    else { this.MessageError(respuesta); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                finally { }
            }
            else { this.MessageError("Verificar los datos del cliente, recargos y descuentos"); }
            return respuesta;
        }

        /// <summary>
        /// Se cargan los datos precalculados o por default. El usuario podrá modificarlos de manera parcial.
        /// Aquí se podría definir perfilería para la administración de permisos de edición (ejemplo incrementar estacionamiento o mano de obra).
        /// </summary>
        private void preSeteoParametriaPresupuesto()
        {
            txBoxEmail.Text = this.presupuesto.Email.ToString();
            txBoxDescuento.Text = this.presupuesto.Descuento.ToString(); ;
            txBoxRecargo.Text = this.presupuesto.Recargo.ToString(); ;
            //txBoxEstacionamiento.Text = this.presupuesto.Estacionamiento.ToString(); 
            txBoxRecargo.Text = this.presupuesto.Recargo.ToString(); 
        }
        
        /// <summary>
        /// // Momento en que se seleccionaron los desperfectos para el vehículo, y se presiona sobre el botón Presupuestar en la pestaña 3 de la aplicación
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string descripcion, manoDeObra, tiempo;
                int idDesperfecto = 0;
                ModeloDesperfecto modeloDesperfecto;
                Opcion = MessageBox.Show("¿Continúa con el presupuesto? => Cargue sus datos", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvDesperfectos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            idDesperfecto = Int32.Parse(row.Cells[1].Value.ToString());
                            descripcion = row.Cells[2].Value.ToString();
                            manoDeObra = row.Cells[3].Value.ToString();
                            tiempo = row.Cells[4].Value.ToString();
                            // Se incorporan los precios de los repuestos segun requerimientos funcionales
                            //procesarRepuestos(idDesperfecto);
                            //modeloDesperfecto = new ModeloDesperfecto(idDesperfecto, descripcion, manoDeObra, tiempo);
                            //modeloDesperfecto.adicionarCostoRepuesto(LogicaDesperfecto.obtenerSubtotalRepuestos(idDesperfecto));                                         
                            //presupuesto.addDesperfecto(modeloDesperfecto);
                         }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        /// <summary>
        /// Se confirma el procesamiento del presupuesto => último paso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            cargaDelCliente();            
        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 0;
            this.listar();
        }
        
        private void dgvDesperfectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Salida: " + dgvDesperfectos.Rows.GetRowCount(DataGridViewElementStates.Selected));
            if (e.ColumnIndex == dgvDesperfectos.Columns["SelectDesperfecto"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkDesperfecto = (DataGridViewCheckBoxCell)dgvDesperfectos.Rows[e.RowIndex].Cells["SelectDesperfecto"];
                chkDesperfecto.Value = !Convert.ToBoolean(chkDesperfecto.Value);                
            }
        }        
        
        /// <summary>
        /// Selección del contenido para el Datagrid de Vehículos
        /// </summary>
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Salida: " + dgvDesperfectos.Rows.GetRowCount(DataGridViewElementStates.Selected));
            if (e.ColumnIndex == dgvDatos.Columns["Select"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkVehiculo = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Select"];
                chkVehiculo.Value = !Convert.ToBoolean(chkVehiculo.Value);
            }
        }

        ///// <summary>
        ///// Inicio de la construcción del presupuesto
        ///// </summary>

        private void btnPresupuestar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadVehiculos = 0, lastSelected = 0;
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        lastSelected = Int32.Parse(row.Cells[9].Value.ToString());
                        cantidadVehiculos++;
                    }
                }
                DialogResult Opcion;               
                if (cantidadVehiculos == 1) 
                {
                    Opcion = MessageBox.Show("¿Presupuestar el Id vehículo: " + lastSelected + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel);
                    if (Opcion == DialogResult.OK)
                    {
                        //Se inicia el presupuesto y se incorpora el vehículo a presupuestar.
                        iniciarPresupuesto(lastSelected);
                        //Pasamos a la pestaña de selección de desperfectos. 
                        this.tabControlPrincipal.SelectedIndex = 2;                        
                    }
                    else
                    {
                        this.listar();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccionar 1 (un) vehículo.", "Control de Vehiculos", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private string tratamientoDatosDesperfecto()
        {
            if (textBoxDesperfectoDescripcion.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Desperfecto");
                error.SetError(textBoxDesperfectoDescripcion, "Ingrese la descripción del desperfecto");
                return "FAIL";
            }
            if (textBoxDesperfectoManoDeObra.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Desperfecto");
                error.SetError(textBoxDesperfectoManoDeObra, "Ingrese el costo de mano de obra del desperfecto");
                return "FAIL";
            }
            if (textBoxDesperfectoTiempo.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Desperfecto");
                error.SetError(textBoxDesperfectoTiempo, "Ingrese el tiempo en días para el desperfecto");
                return "FAIL";
            }
            return "OK";
        }

        private string insertarDesperfecto()
        {
            string respuesta = "";
            respuesta = LogicaDesperfecto.Insertar(presupuesto.Id, textBoxDesperfectoDescripcion.Text, Convert.ToDouble(textBoxDesperfectoManoDeObra.Text), Convert.ToInt32(textBoxDesperfectoTiempo.Text));
            return respuesta;
        }

        /// <summary>
        /// Se le da formato al listado de Desperfectos, que componen el diagnóstico del Presupuesto
        /// </summary>

        private void formatoDesperfectos()
        {
            dataGridViewDesperfectos.Columns[0].Visible = true;
            dataGridViewDesperfectos.Columns[0].Width = 30;
            dataGridViewDesperfectos.Columns[1].Width = 30;
            dataGridViewDesperfectos.Columns[2].Width = 185;
            dataGridViewDesperfectos.Columns[3].Width = 75;
            dataGridViewDesperfectos.Columns[4].Width = 50;            
        }

        /// <summary>
        /// Se actualiza la lista de desperfectos que se agregan al presupuesto
        /// </summary>

        private void listarDesperfectos()
        {
            try
            {
                dataGridViewDesperfectos.DataSource = LogicaDesperfecto.Listar(presupuesto.Id);
                this.formatoDesperfectos();
                labelTotal.Text = Convert.ToString(dataGridViewDesperfectos.Rows.Count);
                //this.limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Se limpia información del último desperfecto cargado
        /// </summary>
        private void limpiarDesperfecto()
        {
            textBoxDesperfectoDescripcion.Clear();
            textBoxDesperfectoManoDeObra.Clear();
            textBoxDesperfectoTiempo.Clear();
            //btInsertarVehículo.Visible = true;
            //btnActualizarVehículo.Visible = true;
            //error.Clear();
            //Diagnose.Visible = false;
            //btnPresupuestar.Visible = false;
            //btEliminar.Visible = false;
            //chkSelect.Checked = false;
        }

        private void buttonAgregarDesperfecto_Click(object sender, EventArgs e)
        {
            if (tratamientoDatosDesperfecto() == "OK")
            {
                try
                {
                    if (insertarDesperfecto() == "OK")
                    {
                        //this.MessageOk("Se insertó correctamente el Desperfecto");
                        this.listarDesperfectos();
                        this.limpiarDesperfecto();
                    }
                    else { this.MessageError("No se pudo insertar el Desperfecto"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                finally { }
            }
            else { this.MessageError("Existen errores en los datos del Desperfecto"); }
        }

        /// <summary>
        /// Cambio del estado de selección para las casillas de cada desperfecto
        /// </summary>
        
        private void dataGridViewDesperfectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDesperfectos.Columns["SeleccionarDesperfecto"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkDesperfecto = (DataGridViewCheckBoxCell)dataGridViewDesperfectos.Rows[e.RowIndex].Cells["SeleccionarDesperfecto"];
                chkDesperfecto.Value = !Convert.ToBoolean(chkDesperfecto.Value);
            }
        }

        /// Todos los id de las tablas deben ser autonumber
        /// Armar SP de cargaMasiva para toda la tabla
        /// Gestionar restricciones de integridad al insertar (IdVehiculo autonumber), o actualizar (no se modifica IdVehiculo oculto)
        /// El Id del vehiculo para la nueva moto o automovil no puede existir. Tiene que ser nuevo.

    }
}


