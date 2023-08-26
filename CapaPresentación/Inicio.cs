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

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        #region Init

        /// <summary>
        /// Referencia dinámica al presupuesto que se construye desde UI. Al cerrar la transacción se persiste.
        /// </summary>
        ModeloPresupuesto presupuesto;
        ModeloTallerMecanico taller;
        LogicaDesperfecto logicaDesperfecto;
        LogicaTallerMecanico logicaTallerMecanico;

        /// <summary>
        /// // Form según aspect ratio 16:9, de 1361 x 765 pixels, sin maximización ni resize.
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            taller = new ModeloTallerMecanico();
            logicaTallerMecanico = new LogicaTallerMecanico();
            logicaDesperfecto = new LogicaDesperfecto();
            /// Se asocia el Observer DataGridView con la lógica del desperfecto
            this.dataGridViewDesperfectos.setSubjec(logicaDesperfecto);
            /// Se define estrategia de asignacion de turno con un margen aleatorio de 3. 
            /// Aplicación del patrón strategy que permite modificar la forma en que se asignan los turnos -> binding dinámico en ejecúción
            
        }

        #endregion

        #region Gestión de Errores

        private void MessageError(string Message)
        {
            MessageBox.Show(Message, "Control de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MessageOk(string Message)
        {
            MessageBox.Show(Message, "Control de Vehiculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Validación formularios de datos

        private string tratamientoRepuestoExistente()
        {
            if (comboBoxRepuestosExistentes.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Repuesto");
                error.SetError(comboBoxRepuestosExistentes, "Ingrese un repuesto existente válido");
                return "FAIL";
            }
            return "OK";
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

        private string tratamientoDatosAutomovil()
        {
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

        private string tratamientoRepuestoNuevo()
        {
            if (textBoxNombreNuevoRepuesto.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Repuesto");
                error.SetError(textBoxNombreNuevoRepuesto, "Ingrese un nombre de Repuesto");
                return "FAIL";
            }
            if (textBoxPrecioNuevoRepuesto.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del Repuesto");
                error.SetError(textBoxPrecioNuevoRepuesto, "Ingrese un precio para el Repuesto");
                return "FAIL";
            }
            return "OK";
        }

        private string tratamientoDatosPresupuesto()
        {
            if (txBoxEmail.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxEmail, "Ingrese el Email");
                return "FAIL";
            }
            else presupuesto.Email = txBoxEmail.Text;

            if (txBoxApellido.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxApellido, "Ingrese el Apellido");
                return "FAIL";
            }
            else presupuesto.Apellido = txBoxApellido.Text;

            if (txBoxNombre.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del cliente");
                error.SetError(txBoxNombre, "Ingrese el Nombre");
                return "FAIL";
            }
            else presupuesto.Nombre = txBoxNombre.Text;

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
            if (txRepuestosTotal.Text == string.Empty)
            {
                this.MessageError("Falta ingresar datos del presupuesto");
                error.SetError(txRepuestosTotal, "Ingrese el costo total de repuestos para el Presupuesto");
                return "FAIL";
            }
            if (txManoDeObra.Text == string.Empty)
            {
                this.MessageError("Falta completar el Presupuesto");
                error.SetError(txManoDeObra, "Ingrese mano de obra para el Presupuesto");
                return "FAIL";
            }
            if (textBoxSubTotal.Text == string.Empty)
            {
                this.MessageError("Falta completar el Presupuesto");
                error.SetError(textBoxSubTotal, "Ingrese subTotal para el Presupuesto");
                return "FAIL";
            }
            if (TotalPresupuestoConsumidor.Text == string.Empty)
            {
                this.MessageError("Falta completar el Presupuesto");
                error.SetError(TotalPresupuestoConsumidor, "Ingrese Total para el Presupuesto");
                return "FAIL";
            }
            if (textBoxTiempoTotal.Text == string.Empty)
            {
                this.MessageError("Falta completar el Presupuesto");
                error.SetError(textBoxTiempoTotal, "Ingrese el Tiempo para el Presupuesto");
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

        #endregion

        #region Tratamiento TextBoxes

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
            btEliminar.Visible = false;
            chkSelect.Checked = false;
        }

        /// <summary>
        /// Se limpia la entrada para el próximo repuesto
        /// </summary>   
        private void limpiarRepuestoNuevo()
        {
            textBoxNombreNuevoRepuesto.Clear();
            textBoxPrecioNuevoRepuesto.Clear();
        }

        /// <summary>
        /// Se limpia información del último desperfecto cargado
        /// </summary>
        private void limpiarDesperfecto()
        {
            textBoxDesperfectoDescripcion.Clear();
            textBoxDesperfectoManoDeObra.Clear();
            textBoxDesperfectoTiempo.Clear();
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
            txBoxEstacionamiento.Text = this.presupuesto.CostoEstacionamiento.ToString();
            txBoxDescuento.Text = this.presupuesto.Descuento.ToString();
        }

        private void actualizarTextBoxesPresupuesto()
        {
            txBoxRecargo.Text = presupuesto.Recargo.ToString();
            txBoxEstacionamiento.Text = presupuesto.CostoEstacionamiento.ToString();
            txRepuestosTotal.Text = presupuesto.getCostoTotalRepuestos().ToString();
            txManoDeObra.Text = presupuesto.ManoDeObra.ToString();
            textBoxSubTotal.Text = presupuesto.TotalConRecargosDescuentos.ToString();
            TotalPresupuestoConsumidor.Text = presupuesto.TotalAlConsumidor.ToString();
            textBoxTiempoTotal.Text = presupuesto.TiempoTotal.ToString();
        }

        #endregion

        #region Gestión de Botones

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
                        ///Se inicia el presupuesto y se incorpora el vehículo a presupuestar.
                        iniciarPresupuesto(lastSelected);
                        ///Pasamos a la pestaña de selección de desperfectos. 
                        this.tabControlPrincipal.SelectedIndex = 2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Opcion = MessageBox.Show("¿Proceder con Carga Masiva en Repuestos?", "Tratamiento Carga Masiva Repuestos", MessageBoxButtons.OKCancel);
            if (Opcion == DialogResult.OK)
            {
                dgvOutputServicios.DataSource = LogicaServicios.MassiveCharge();
            }
        }

        private void buttonPromedioTotalPresupuestos_Click(object sender, EventArgs e)
        {
            if (textBoxServicioMarcaModelo.Text == string.Empty)
            {
                this.MessageError("Falta completar formulario, campo Marca/Modelo");
                error.SetError(textBoxServicioMarcaModelo, "Ingrese Marca/Modelo para el servicio");
            }
            else
            {
                this.formatoServicios();
                dgvOutputServicios.DataSource = LogicaServicios.PromedioMontoTotal(textBoxServicioMarcaModelo.Text);
            }
        }

        private void buttonSumatoriaTotalPresupuestos_Click(object sender, EventArgs e)
        {
            if (comboBoxServicioTipo.Text == string.Empty)
            {
                this.MessageError("Faltan datos para llamar al Servicio");
                error.SetError(comboBoxServicioTipo, "Ingrese el tipo de Vehículo");
            }
            else
            {
                this.formatoServicios();
                dgvOutputServicios.DataSource = LogicaServicios.SumatoriaMontoTotal(comboBoxServicioTipo.Text);
            }
        }

        private void buttonRepuestoMasUsado_Click(object sender, EventArgs e)
        {
            if (textBoxServicioMarcaModelo.Text == string.Empty)
            {
                this.MessageError("Falta seleccionar Marca/Modelo");
                error.SetError(textBoxServicioMarcaModelo, "Ingrese Marca/Modelo");
            }
            else
            {
                this.formatoServicios();
                dgvOutputServicios.DataSource = LogicaServicios.RepuestoMasUtilizado(textBoxServicioMarcaModelo.Text);
            }
        }

        private void buttonListarPresupuestos_Click(object sender, EventArgs e)
        {
            listarPresupuestos();
        }

        private void buttonABM_Click(object sender, EventArgs e)
        {
            ///Redirección al ABM
            this.tabControlPrincipal.SelectedIndex = 1;
        }

        private void buttonPresupuestar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadDesperfectos = 0;
                List<int> idDesperfectosAPresupuestar = new List<int>();
                foreach (DataGridViewRow row in dataGridViewDesperfectos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        idDesperfectosAPresupuestar.Add(Int32.Parse(row.Cells[3].Value.ToString()));
                        cantidadDesperfectos++;
                    }
                }
                DialogResult Opcion;
                if (cantidadDesperfectos > 0)
                {
                    Opcion = MessageBox.Show("¿Confirma el presupuesto para: " + cantidadDesperfectos + " desperfectos ?", "Control de Vehiculos", MessageBoxButtons.OKCancel);
                    if (Opcion == DialogResult.OK)
                    {
                        /// Dirección a la pestaña de presupuestación
                        this.tabControlPrincipal.SelectedIndex = 4;
                        /// Seteo de parametría por default.
                        this.preSeteoParametriaPresupuesto();
                        /// Se setea el modelo con los desperfectos seleccionados.
                        this.presupuesto.DesperfectosAPresupuestar = idDesperfectosAPresupuestar;
                        /// Se calculan los totales del modelo Presupuesto
                        this.presupuesto.cerrarPresupuesto();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccionar al menos 1 (UN) desperfecto.", "Control de Vehiculos", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private void buttonCancelarDesperfecto_Click(object sender, EventArgs e)
        {
            DialogResult Opcion = MessageBox.Show("¿Abandonar la carga de Desperfectos?", "Tratamiento de Desperfectos", MessageBoxButtons.OKCancel);
            if (Opcion == DialogResult.OK)
            {
                ///Regreso a la pestaña de selección de Vehículos. 
                this.tabControlPrincipal.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Se confirma el procesamiento del presupuesto => último paso
        /// </summary>        
        private void button4_Click(object sender, EventArgs e)
        {
            actualizarTextBoxesPresupuesto();
            cargaDelCliente();
            /// Se muestra el listado de total de presupuestos
            this.tabControlPrincipal.SelectedIndex = 5;
            listarPresupuestos();
        }

        /// <summary>
        /// Se cancela modificación de repuestos para el desperfecto activo y se regresa a pestaña Desperfectos
        /// </summary>        
        private void buttonRegresarMenuDesperfectos_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 2;
            this.formatoDesperfectos();
        }

        /// <summary>
        /// Tratamiento de los repuestos para el desperfecto en curso: Se eliminan del modelo los NO seleccinados.
        /// Se retornan los seleccionados, se incorporan al desperfecto y se persisten los inexistentes (marca EnEspera).
        /// </summary>
        private void buttonAgregarRepuestosDesperfecto_Click_1(object sender, EventArgs e)
        {
            List<int> repuestosExistentes = new List<int>();
            List<int> repuestosEnEspera = new List<int>();
            try
            {
                foreach (DataGridViewRow row in dgvRepuestos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        if (Convert.ToBoolean(row.Cells[4].Value))
                        {
                            repuestosEnEspera.Add(Int32.Parse(row.Cells[1].Value.ToString())); // Se trata de un nuevo repuesto en espera del proveedor.                            
                        }
                        else
                        {
                            repuestosExistentes.Add(Int32.Parse(row.Cells[1].Value.ToString())); // Se trata de un nuevo repuesto en stock.
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
            if ((repuestosEnEspera.Count + repuestosExistentes.Count) == 0)
            {
                this.MessageError("Ingresar al menos un Repuesto");
            }
            else
            {
                this.MessageOk("Se incorporan al desperfecto, " + repuestosExistentes.Count + " rep. existentes y " + repuestosEnEspera.Count + " en espera de entrega.");
                /// Se incorporan los repuestos para el desperfecto en contrucción
                this.actualizarRepuestosEnDesperfecto(repuestosExistentes, repuestosEnEspera);
                /// Salgo del menú repuestos para regresar al menu de Diagnóstico para agregar desperfectos.
                this.tabControlPrincipal.SelectedIndex = 2;
                this.formatoDesperfectos();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tratamientoRepuestoNuevo() == "OK")
            {
                try
                {
                    if (insertarRepuestoNuevo() != null)
                    {
                        this.listarRepuestosDelDesperfecto();
                        this.limpiarRepuestoNuevo();
                    }
                    else { this.MessageError("El repuesto existe o es erróneo"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                finally { }
            }
            else { this.MessageError("Existen errores en los datos del Repuesto"); }
        }

        /// <summary>
        /// Selección de repuesto existente, para agregar al desperfecto activo
        /// </summary>
        private void button6_Click(object sender, EventArgs e)
        {
            if (tratamientoRepuestoExistente() == "OK")
            {
                try
                {
                    /// Se genera el nuevo repuesto de la lista de existentes
                    ModeloRepuesto nuevoRepuestoExistente = insertarRepuestoExistente();
                    if (nuevoRepuestoExistente != null) /// El respuesto ya fue incorporado al desperfecto
                    {
                        this.listarRepuestosDelDesperfecto();
                    }
                    else { this.MessageError("El repuesto existe o es erróneo"); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                finally { }
            }
            else { this.MessageError("Existen errores en los datos del Repuesto"); }
        }

        private void buttonAgregarDesperfecto_Click(object sender, EventArgs e)
        {
            if (tratamientoDatosDesperfecto() == "OK")
            {
                try
                {
                    ModeloDesperfecto nuevoModeloDesperfecto = this.insertarDesperfecto();
                    ///El modelo de arriba se persistió. Se continúa con la carga de repuestos.
                    if (nuevoModeloDesperfecto != null)
                    {
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 0;
            this.listar();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        /// <summary>
        /// Comienza la inserción de un nuevo Automóvil o Moto. Esto desencadena la inserción en cascada del Vehículo.
        /// </summary>        
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

        /// <summary>
        /// Acceso para la eliminación de Vehiculos. Tener en cuenta que para el listado se realiza una Union entre la tabla Automóvil y Moto
        /// </summary>
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
                        vehiculosSeleccionados++; /// Se registra la cantidad de seleccionados para UI usuario cuando es 0
                                                  /// Aquí siempre tenemos un valor en columna 4 (Moto) OR exclusivo en columna 6 (Automovil)
                        if (!String.IsNullOrEmpty(row.Cells[4].Value.ToString())) // Es una Moto
                        {
                            codigoMoto = Int32.Parse(row.Cells[4].Value.ToString());
                            Opcion = MessageBox.Show("¿Eliminar la moto: " + codigoMoto + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        }
                        else /// Es un Automóvil
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
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }

        private void btnCancelarInserción_Click(object sender, EventArgs e)
        {
            this.tabControlPrincipal.SelectedIndex = 0;
            this.listar();
        }

        /// <summary>
        /// Actualización del Vehículo al efectuar doble click sobre un registro del listado de Vehículos
        /// </summary>
        private void btnActualizarVehículo_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Diagnostics.Debug.WriteLine("SELECTED TAB Automovil??" + (selectorTipoVehículo.SelectedTab == tabAutomóvil));


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
                if (selectorTipoVehículo.SelectedTab == tabAutomóvil && (textBxIdAutomóvil.Text == string.Empty || textPuertas.Text == string.Empty || ElComboTipoAutomovil.Text == string.Empty))
                {
                    this.MessageError("Falta ingresar datos del Automóvil");
                    error.SetError(textPuertas, "Ingrese Cantidad Puertas/Tipo Automóvil");
                    return;
                }
                else
                {
                    if (selectorTipoVehículo.SelectedTab == tabMoto && (textBxIdMoto.Text == string.Empty || textBxCilindrada.Text == string.Empty))
                    {
                        this.MessageError("Falta ingresar datos de la moto");
                        error.SetError(textBxCilindrada, "Ingrese Cilindrada de la Moto");
                        return;
                    }
                }

                if (selectorTipoVehículo.SelectedTab == tabAutomóvil)
                {
                    respuesta = LogicaAutomovil.Actualizar(Convert.ToInt32(textBxIdAutomóvil.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text, ElComboTipoAutomovil.Text, Convert.ToInt32(textPuertas.Text), Convert.ToInt32(textBxIdVehículo.Text));
                }
                else
                {
                    respuesta = LogicaMoto.Actualizar(Convert.ToInt32(textBxIdMoto.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text, Convert.ToInt32(textBxIdVehículo.Text), textBxCilindrada.Text);
                }

                if (respuesta.Equals("OK"))
                {
                    respuesta = LogicaVehiculo.Actualizar(Convert.ToInt32(textBxIdVehículo.Text), textBxMarca.Text, textBxModelo.Text, textBxPatente.Text);
                }

                if (respuesta.Equals("OK"))
                {
                    if (selectorTipoVehículo.SelectedTab == tabAutomóvil)
                    {
                        this.MessageOk("Se actualizó correctamente el Automóvil");
                    }
                    else
                    {
                        this.MessageOk("Se actualizó correctamente la Moto");
                    }
                    //this.limpiar();
                    //this.listar();
                }
                else
                {
                    this.MessageError(respuesta);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
            finally { }
        }

        #endregion

        #region Conexión Capa Lógica

        private ModeloDesperfecto insertarDesperfecto()
        {
            /// Se agrega el desperfecto que está siendo configurado, al presupuesto que está siendo creado y se retorna para ser agregado como nuevo desperfecto del presupuesto
            return logicaDesperfecto.Insertar(presupuesto, textBoxDesperfectoDescripcion.Text, Convert.ToDecimal(textBoxDesperfectoManoDeObra.Text), Convert.ToInt32(textBoxDesperfectoTiempo.Text));
        }

        private ModeloRepuesto insertarRepuestoExistente()
        {
            /// Se obtiene el Id del repuesto existente seleccionado
            return (ModeloRepuesto)LogicaRepuesto.agregarRepuestoExistenteAlDesperfectoActual(presupuesto, Convert.ToInt32(comboBoxRepuestosExistentes.SelectedValue.ToString()));
        }

        private ModeloRepuesto insertarRepuestoNuevo()
        {
            /// Se obtiene el Id del repuesto existente seleccionado
            return (ModeloRepuesto)LogicaRepuesto.agregarRepuestoNuevoAlDesperfectoActual(presupuesto, Convert.ToString(textBoxNombreNuevoRepuesto.Text), Convert.ToDecimal(textBoxPrecioNuevoRepuesto.Text));
        }

        /// <summary>
        /// Se desencadena persistencia para tabla DesperfectoRepuesto
        /// </summary>        
        private void actualizarRepuestosEnDesperfecto(List<int> repuestosExistentes, List<int> repuestosEnEspera)
        {
            logicaDesperfecto.actualizarRepuestos(presupuesto, repuestosExistentes, repuestosEnEspera);
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

        /// <summary>
        /// Se cierra la transacción presupuesto, esa es la lógica que se desarrolló para un concepto que se construye durante el ciclo de corrida de la aplicación.
        /// </summary>        
        private string finalizarPresupuesto()
        {
            string respuesta = "";
            /// Se actualiza el último presupuesto con la información restante 
            respuesta = LogicaPresupuesto.actualizarPresupuesto(presupuesto);
            return respuesta;
        }

        private string cargaDelCliente()
        {
            string respuesta = tratamientoDatosPresupuesto();
            if (respuesta == "OK")
            {
                try
                {
                    respuesta = finalizarPresupuesto();
                    if (respuesta == "OK")
                    {
                        this.MessageOk("Se insertó correctamente el presupuesto");

                    }
                    else { this.MessageError(respuesta); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                finally { }
            }
            else { this.MessageError("Verificar los datos del cliente, y del presupuesto"); }
            return respuesta;
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

        #endregion

        #region Tratamiento sobre DataGridViews

        private void listar()
        {
            try
            {
                dgvDatos.DataSource = LogicaVehiculo.Listar();
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
            dgvDatos.Columns[0].Width = 40;
            dgvDatos.Columns[1].Width = 85;
            dgvDatos.Columns[2].Width = 80;
            dgvDatos.Columns[3].Width = 80;
            dgvDatos.Columns[4].Width = 55;
            dgvDatos.Columns[5].Width = 75;
            dgvDatos.Columns[6].Width = 55;
            dgvDatos.Columns[7].Width = 55;
            dgvDatos.Columns[8].Width = 90;
            dgvDatos.Columns[9].Width = 72;
        }

        private void buscar()
        {
            try
            {
                dgvDatos.DataSource = LogicaVehiculo.Buscar(txtBuscar.Text);
                this.formato();
                labelTotal.Text = Convert.ToString(dgvDatos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Se actualiza el DataGridView dgvRepuestos con el nuevo repuesto para el Desperfecto
        /// </summary>
        private void listarRepuestosDelDesperfecto()
        {
            try
            {
                dgvRepuestos.DataSource = ((ModeloDesperfecto)presupuesto.getDesperfectoActual()).ListarRepuestos();      // no son todos, solo los del desperfecto           
                this.formatoRepuestos();
                labelTotal.Text = Convert.ToString(dgvRepuestos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Se da formato al DataGridView dgvRepuestos
        /// </summary>
        private void formatoRepuestos()
        {
            dgvRepuestos.Columns[0].Visible = true;
            dgvRepuestos.Columns[0].Width = 60;
            dgvRepuestos.Columns[1].Width = 30;
            dgvRepuestos.Columns[2].Width = 80;
            dgvRepuestos.Columns[3].Width = 60;
            dgvRepuestos.Columns[4].Width = 60;
        }

        private void listarPresupuestos()
        {
            try
            {
                LogicaPresupuesto.eliminarPresupuestosIncompletos();
                dataGridViewPresupuestos.DataSource = LogicaPresupuesto.Listar();
                this.formatoPresupuestos();
                labelTotal.Text = Convert.ToString(dataGridViewPresupuestos.Rows.Count);
                //this.limpiarPresupuestos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Se limpia el listado de repuestos anterior, para cargar el siguiente Desperfecto
        /// </summary>
        private void limpiarRepuestos()
        {
            this.dgvRepuestos.DataSource = null;
            this.dgvRepuestos.Rows.Clear();
        }

        private void formatoPresupuestos()
        {
            dataGridViewPresupuestos.Columns[0].Visible = true;
            dataGridViewPresupuestos.Columns[0].Width = 125;
            dataGridViewPresupuestos.Columns[1].Width = 40;
            dataGridViewPresupuestos.Columns[2].Width = 110;
            dataGridViewPresupuestos.Columns[3].Width = 110;
            dataGridViewPresupuestos.Columns[4].Width = 200;
            dataGridViewPresupuestos.Columns[5].Width = 100;
            dataGridViewPresupuestos.Columns[6].Width = 85;
        }

        /// <summary>
        ///  Aplicación patron strategy, para la selección del turno
        /// </summary>       

        private void dataGridViewPresupuestos_DoubleClick(object sender, EventArgs e)
        {
            //StrategyTurno estrategiaTurno = LogicaTallerMecanico.getEstrategiaTurno(this.taller, this.comboBoxEstrategiaTurno);
            //DateTime fecha = estrategiaTurno.Next();
            //this.taller.setUltimoTurno(fecha);
            //this.Reloj.Value = fecha;
            //this.Reloj.Update();
        }

        private void formatoServicios()
        {
            //dgvOutputServicios.Columns[0].Visible = true;
            //dgvOutputServicios.Columns[0].Width = 45;

        }

        private void dgvOutputServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Incorporación de repuestos a un desperfecto por medio de Doble Clic
        /// También se deshabilita la carga de Desperfectos
        /// </summary>        
        private void dataGridViewDesperfectos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /// Verifico si aún no se deshabilitó la carga de Desperfectos
            if (buttonAgregarDesperfecto.Enabled)
            {
                DialogResult Opcion = MessageBox.Show("¿Finalizar carga de desperfectos, para comenzar con la carga de repuestos?", "Tratamiento Carga Repuestos", MessageBoxButtons.OKCancel);
                if (Opcion == DialogResult.OK)
                {
                    buttonAgregarDesperfecto.Enabled = false;
                    this.cargaRepuestosParaElDesperfecto();
                }
            }
            else
            {
                this.cargaRepuestosParaElDesperfecto();
            }
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

        /// <summary>
        /// Cambio del estado de selección para las casillas de cada repuesto
        /// </summary>
        private void dgvRepuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRepuestos.Columns["Sel"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkDesperfecto = (DataGridViewCheckBoxCell)dgvRepuestos.Rows[e.RowIndex].Cells["Sel"];
                chkDesperfecto.Value = !Convert.ToBoolean(chkDesperfecto.Value);
            }
        }

        /// <summary>
        /// Se actualiza la lista de desperfectos que se agregan al presupuesto
        /// </summary>
        private void listarDesperfectos()
        {
            try
            {
                dataGridViewDesperfectos.DataSource = logicaDesperfecto.Listar(presupuesto.Id);
                this.formatoDesperfectos();
                labelTotal.Text = Convert.ToString(dataGridViewDesperfectos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        /// <summary>
        /// Se le da formato al listado de Desperfectos, que componen el diagnóstico del Presupuesto
        /// </summary>
        private void formatoDesperfectos()
        {
            dataGridViewDesperfectos.Columns[0].Visible = true;
            dataGridViewDesperfectos.Columns[0].Width = 25;
            dataGridViewDesperfectos.Columns[1].Width = 40;
            dataGridViewDesperfectos.Columns[2].Width = 40;
            dataGridViewDesperfectos.Columns[3].Width = 30;
            dataGridViewDesperfectos.Columns[4].Width = 250;
            dataGridViewDesperfectos.Columns[5].Width = 75;
            dataGridViewDesperfectos.Columns[6].Width = 50;
        }

        private void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dgvDatos.Columns[0].Visible = true;
                Diagnose.Visible = true;
                btEliminar.Visible = true;
            }
            else
            {
                dgvDatos.Columns[0].Visible = false;
                Diagnose.Visible = false;
                btEliminar.Visible = false;
            }
        }

        /// <summary>
        /// Selección del contenido para el Datagrid de Vehículos
        /// </summary>
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["CHK"].Index) // Press on select
            {
                DataGridViewCheckBoxCell chkVehiculo = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["CHK"];
                chkVehiculo.Value = !Convert.ToBoolean(chkVehiculo.Value);
            }
        }

        /// <summary>
        /// Tratamiento Actualización de Vehículo con doble clic
        /// </summary>
        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.limpiar();
                btnActualizarVehículo.Visible = true;
                btInsertarVehículo.Visible = false;
                /// Activo según columna IdAuto del DataGridView
                activarTabTipoVehiculo(Convert.ToString(dgvDatos.CurrentRow.Cells["IdAuto"].Value));

                /// Se deshabilitan PK/FK que no pueden actualizarse
                textBxIdMoto.Enabled = false;
                textBxIdAutomóvil.Enabled = false;
                textBxIdVehículo.Enabled = false;

                /// Se lee información que será actualizada
                textBxIdVehículo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["IdVehiculo"].Value);
                textBxIdMoto.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["IdMoto"].Value);
                textBxIdAutomóvil.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["IdAuto"].Value);
                textBxMarca.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Marca"].Value);
                textBxModelo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Modelo"].Value);
                textBxPatente.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Patente"].Value);
                selectorTipoVehículo.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Tipo"].Value);
                textPuertas.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Puertas"].Value);
                textBxCilindrada.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Cilindrada"].Value);
                tabControlPrincipal.SelectedIndex = 1; // Redirección a pestaña ABM
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar desde la celda Id");
            }

        }

        #endregion

        #region Gestión sobre Tabs del Form: transiciones

        private void cargaRepuestosParaElDesperfecto()
        {
            this.limpiarRepuestos();
            /// Obtengo el Id del desperfecto destinatario de repuestos
            int desperfectoToAddRepuestos = Convert.ToInt32(dataGridViewDesperfectos.CurrentRow.Cells["Id"].Value);
            /// Se setea el idDesperfecto activo para agregarle repuestos
            presupuesto.setIdCurrentDesperfecto(desperfectoToAddRepuestos);

            this.tabControlPrincipal.SelectedIndex = 3;  //Pasamos a la pestaña de selección de repuestos
            this.labelRapuestosAsignados.Text = "Asignación de repuestos, Id desperfecto: " + desperfectoToAddRepuestos;
            this.listarRepuestosDelDesperfecto();
        }

        /// <summary>
        /// //Activo Tab selector tipo Vehículo
        /// </summary>
        private void activarTabTipoVehiculo(string tipoAutomovil)
        {
            if (tipoAutomovil == string.Empty)
            {
                selectorTipoVehículo.SelectedIndex = 1; /// Activo Tab Moto
            }
            else
            {
                selectorTipoVehículo.SelectedIndex = 0; /// Activo Tab Vehículo
            }
        }

        private void tabPage1_Click_2(object sender, EventArgs e) { }

        private void tabPage3_Click(object sender, EventArgs e) { }

        #endregion

        #region Etiquetas, Panel, Combobox

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.repuestoTableAdapter.Fill(this.masterDataSet.Repuesto);
            this.listar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void buttonAsignarTurnos_Click(object sender, EventArgs e)
        {
            try
            {
                //DialogResult Opcion;
                //string respuesta = "";
                //int codigoMoto = 0, codigoAutomovil = 0, vehiculosSeleccionados = 0, vehiculosEliminados = 0, vehiculosAbortados = 0;
                /// Obtengo la estrategia de asignación activa
                StrategyTurno estrategiaTurnoActiva = LogicaTallerMecanico.getEstrategiaTurno(this.comboBoxEstrategiaTurno);
                DateTime siguienteTurno = estrategiaTurnoActiva.Next(DateTime.Today);
                foreach (DataGridViewRow row in dataGridViewPresupuestos.Rows)
                {
                    LogicaTallerMecanico.agregarPresupuesto(siguienteTurno, this.taller, row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString());
                    siguienteTurno = estrategiaTurnoActiva.Next(siguienteTurno);
                    //LogicaTallerMecanico.getEstrategiaTurno(this.comboBoxEstrategiaTurno).Next();
                    //LogicaTallerMecanico.asignarTurno(row.Cells[0].Value, row.Cells[1].Value);
                    //row.Cells[0].Value = LogicaTallerMecanico.getEstrategiaTurno(this.comboBoxEstrategiaTurno).Next().ToString(); 
                    row.Cells[0].Value = siguienteTurno.ToString("dd-MM-yyyy");
                }
                //    if (Convert.ToBoolean(row.Cells[0].Value))
                //    {
                //        vehiculosSeleccionados++; /// Se registra la cantidad de seleccionados para UI usuario cuando es 0
                //                                  /// Aquí siempre tenemos un valor en columna 4 (Moto) OR exclusivo en columna 6 (Automovil)
                //        if (!String.IsNullOrEmpty(row.Cells[4].Value.ToString())) // Es una Moto
                //        {
                //            codigoMoto = Int32.Parse(row.Cells[4].Value.ToString());
                //            Opcion = MessageBox.Show("¿Eliminar la moto: " + codigoMoto + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                //        }
                //        else /// Es un Automóvil
                //        {
                //            codigoAutomovil = Int32.Parse(row.Cells[6].Value.ToString());
                //            Opcion = MessageBox.Show("¿Eliminar el automóvil: " + codigoAutomovil + "?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //        }

                //        respuesta = Opcion == DialogResult.OK ? LogicaVehiculo.Eliminar(codigoMoto, codigoAutomovil) : "ABORTED";
                //        if (respuesta.Equals("OK"))
                //        {
                //            vehiculosEliminados++;
                //        }
                //        else if (respuesta.Equals("ABORTED"))
                //        {
                //            vehiculosAbortados++;
                //        }
                //        else
                //        {
                //            this.MessageError("Error BD: " + respuesta);
                //        }
                //    }
                //}
                //if (vehiculosSeleccionados == 0) this.MessageError("Ingresar al menos un Vehículo");
                //else this.MessageError("Vehículos eliminados: " + vehiculosEliminados + " y abortados: " + vehiculosAbortados);
                //this.listar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
        }
    }
}