using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentación
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.repuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new CapaPresentación.masterDataSet();
            this.repuestoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.repuestoTableAdapter = new CapaPresentación.masterDataSetTableAdapters.RepuestoTableAdapter();
            this.tabPageRepuestos = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.labelDesperfecto = new System.Windows.Forms.Label();
            this.buttonRegresarMenuDesperfectos = new System.Windows.Forms.Button();
            this.buttonAgregarRepuestosDesperfecto = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.comboBoxRepuestosExistentes = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.labelNombreRepuestoExistente = new System.Windows.Forms.Label();
            this.labelSeleccionarRepuestoExistente = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelRapuestosAsignados = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxPrecioNuevoRepuesto = new System.Windows.Forms.TextBox();
            this.textBoxNombreNuevoRepuesto = new System.Windows.Forms.TextBox();
            this.labelPrecioRepuesto = new System.Windows.Forms.Label();
            this.labelNombreRepuesto = new System.Windows.Forms.Label();
            this.labelAgregarNuevoRepuesto = new System.Windows.Forms.Label();
            this.tabPageDesperfectos = new System.Windows.Forms.TabPage();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonPresupuestar = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfoContexto = new System.Windows.Forms.Label();
            this.labelSeleccionDesperfectos = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewDesperfectos = new CapaPresentación.GrillaDesperfectos();
            this.SeleccionarDesperfecto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDesperfectosAsignados = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonCancelarDesperfecto = new System.Windows.Forms.Button();
            this.buttonAgregarDesperfecto = new System.Windows.Forms.Button();
            this.textBoxDesperfectoTiempo = new System.Windows.Forms.TextBox();
            this.textBoxDesperfectoManoDeObra = new System.Windows.Forms.TextBox();
            this.textBoxDesperfectoDescripcion = new System.Windows.Forms.TextBox();
            this.labelDesperfectoTiempo = new System.Windows.Forms.Label();
            this.labelDesperfectoManoDeObra = new System.Windows.Forms.Label();
            this.labelDescripcionDesperfecto = new System.Windows.Forms.Label();
            this.labelNuevoDesperfecto = new System.Windows.Forms.Label();
            this.tabPresupuestacion = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txBoxNombre = new System.Windows.Forms.TextBox();
            this.txBoxApellido = new System.Windows.Forms.TextBox();
            this.txBoxEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTotalConsumidor = new System.Windows.Forms.Label();
            this.TotalPresupuestoConsumidor = new System.Windows.Forms.TextBox();
            this.textBoxTiempoTotal = new System.Windows.Forms.TextBox();
            this.labelTiempoTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.txRepuestosTotal = new System.Windows.Forms.TextBox();
            this.labelCostoRepuestos = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txBoxEstacionamiento = new System.Windows.Forms.TextBox();
            this.txManoDeObra = new System.Windows.Forms.TextBox();
            this.txBoxDescuento = new System.Windows.Forms.TextBox();
            this.txBoxRecargo = new System.Windows.Forms.TextBox();
            this.labelCostoEstacionamiento = new System.Windows.Forms.Label();
            this.labelManoDeObra = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabABM = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarInserción = new System.Windows.Forms.Button();
            this.btnActualizarVehículo = new System.Windows.Forms.Button();
            this.btInsertarVehículo = new System.Windows.Forms.Button();
            this.textBxPatente = new System.Windows.Forms.TextBox();
            this.textBxModelo = new System.Windows.Forms.TextBox();
            this.textBxMarca = new System.Windows.Forms.TextBox();
            this.textBxIdVehículo = new System.Windows.Forms.TextBox();
            this.selectorTipoVehículo = new System.Windows.Forms.TabControl();
            this.tabAutomóvil = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ElComboTipoAutomovil = new System.Windows.Forms.ComboBox();
            this.textPuertas = new System.Windows.Forms.TextBox();
            this.textBxIdAutomóvil = new System.Windows.Forms.TextBox();
            this.etiquetaTipo = new System.Windows.Forms.Label();
            this.etiquetaPuertasAutomóvil = new System.Windows.Forms.Label();
            this.etiquetaIdAutomóvil = new System.Windows.Forms.Label();
            this.tabMoto = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBxCilindrada = new System.Windows.Forms.TextBox();
            this.textBxIdMoto = new System.Windows.Forms.TextBox();
            this.etiquetaCilindrada = new System.Windows.Forms.Label();
            this.etiquetaIdMoto = new System.Windows.Forms.Label();
            this.etiquetaPatente = new System.Windows.Forms.Label();
            this.etiquetaModelo = new System.Windows.Forms.Label();
            this.etiquetaMarca = new System.Windows.Forms.Label();
            this.etiquetaIdVehiculo = new System.Windows.Forms.Label();
            this.tabVehiculos = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.Diagnose = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPresupuestos = new System.Windows.Forms.TabPage();
            this.panel17 = new System.Windows.Forms.Panel();
            this.Reloj = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonABM = new System.Windows.Forms.Button();
            this.buttonListarPresupuestos = new System.Windows.Forms.Button();
            this.dataGridViewPresupuestos = new System.Windows.Forms.DataGridView();
            this.tabServicios = new System.Windows.Forms.TabPage();
            this.panel19 = new System.Windows.Forms.Panel();
            this.comboBoxServicioTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServiciosMasivos = new System.Windows.Forms.TextBox();
            this.textBoxServiciosBasicos = new System.Windows.Forms.TextBox();
            this.labelServicioModelo = new System.Windows.Forms.Label();
            this.textBoxServicioMarcaModelo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSumatoriaTotalPresupuestos = new System.Windows.Forms.Button();
            this.buttonPromedioTotalPresupuestos = new System.Windows.Forms.Button();
            this.buttonRepuestoMasUsado = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.labelOutputServicios = new System.Windows.Forms.Label();
            this.dgvOutputServicios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.tabPageRepuestos.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.panel9.SuspendLayout();
            this.tabPageDesperfectos.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesperfectos)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabPresupuestacion.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabABM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.selectorTipoVehículo.SuspendLayout();
            this.tabAutomóvil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMoto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabVehiculos.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPresupuestos.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestos)).BeginInit();
            this.tabServicios.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // repuestoBindingSource
            // 
            this.repuestoBindingSource.DataMember = "Repuesto";
            this.repuestoBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repuestoBindingSource1
            // 
            this.repuestoBindingSource1.DataMember = "Repuesto";
            this.repuestoBindingSource1.DataSource = this.masterDataSet;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // repuestoTableAdapter
            // 
            this.repuestoTableAdapter.ClearBeforeFill = true;
            // 
            // tabPageRepuestos
            // 
            this.tabPageRepuestos.Controls.Add(this.panel15);
            this.tabPageRepuestos.Controls.Add(this.panel12);
            this.tabPageRepuestos.Controls.Add(this.panel11);
            this.tabPageRepuestos.Controls.Add(this.panel10);
            this.tabPageRepuestos.Controls.Add(this.panel9);
            this.tabPageRepuestos.Location = new System.Drawing.Point(4, 34);
            this.tabPageRepuestos.Name = "tabPageRepuestos";
            this.tabPageRepuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepuestos.Size = new System.Drawing.Size(850, 517);
            this.tabPageRepuestos.TabIndex = 5;
            this.tabPageRepuestos.Text = "Repuestos";
            this.tabPageRepuestos.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox1);
            this.panel15.Location = new System.Drawing.Point(238, 452);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(612, 62);
            this.panel15.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Es posible seleccionar repuestos existentes (desde el desplegable) o solicitar nu" +
    "evos repuestos (proveedor). Después de cargar los repuestos es necesario selecci" +
    "onarlos.";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Lavender;
            this.panel12.Controls.Add(this.labelDesperfecto);
            this.panel12.Controls.Add(this.buttonRegresarMenuDesperfectos);
            this.panel12.Controls.Add(this.buttonAgregarRepuestosDesperfecto);
            this.panel12.Location = new System.Drawing.Point(7, 366);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(225, 139);
            this.panel12.TabIndex = 9;
            // 
            // labelDesperfecto
            // 
            this.labelDesperfecto.AutoSize = true;
            this.labelDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfecto.Location = new System.Drawing.Point(3, 9);
            this.labelDesperfecto.Name = "labelDesperfecto";
            this.labelDesperfecto.Size = new System.Drawing.Size(199, 37);
            this.labelDesperfecto.TabIndex = 9;
            this.labelDesperfecto.Text = "Desperfecto";
            // 
            // buttonRegresarMenuDesperfectos
            // 
            this.buttonRegresarMenuDesperfectos.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRegresarMenuDesperfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenuDesperfectos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegresarMenuDesperfectos.Location = new System.Drawing.Point(32, 99);
            this.buttonRegresarMenuDesperfectos.Name = "buttonRegresarMenuDesperfectos";
            this.buttonRegresarMenuDesperfectos.Size = new System.Drawing.Size(157, 37);
            this.buttonRegresarMenuDesperfectos.TabIndex = 10;
            this.buttonRegresarMenuDesperfectos.Text = "Regresar Menú Desperfectos";
            this.buttonRegresarMenuDesperfectos.UseVisualStyleBackColor = false;
            this.buttonRegresarMenuDesperfectos.Click += new System.EventHandler(this.buttonRegresarMenuDesperfectos_Click);
            // 
            // buttonAgregarRepuestosDesperfecto
            // 
            this.buttonAgregarRepuestosDesperfecto.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAgregarRepuestosDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarRepuestosDesperfecto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarRepuestosDesperfecto.Location = new System.Drawing.Point(32, 58);
            this.buttonAgregarRepuestosDesperfecto.Name = "buttonAgregarRepuestosDesperfecto";
            this.buttonAgregarRepuestosDesperfecto.Size = new System.Drawing.Size(157, 35);
            this.buttonAgregarRepuestosDesperfecto.TabIndex = 9;
            this.buttonAgregarRepuestosDesperfecto.Text = "Agregar repuestos al desperfecto";
            this.buttonAgregarRepuestosDesperfecto.UseVisualStyleBackColor = false;
            this.buttonAgregarRepuestosDesperfecto.Click += new System.EventHandler(this.buttonAgregarRepuestosDesperfecto_Click_1);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel11.Controls.Add(this.comboBoxRepuestosExistentes);
            this.panel11.Controls.Add(this.button6);
            this.panel11.Controls.Add(this.labelNombreRepuestoExistente);
            this.panel11.Controls.Add(this.labelSeleccionarRepuestoExistente);
            this.panel11.Location = new System.Drawing.Point(7, 208);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 152);
            this.panel11.TabIndex = 8;
            // 
            // comboBoxRepuestosExistentes
            // 
            this.comboBoxRepuestosExistentes.DataSource = this.repuestoBindingSource;
            this.comboBoxRepuestosExistentes.DisplayMember = "Nombre";
            this.comboBoxRepuestosExistentes.FormattingEnabled = true;
            this.comboBoxRepuestosExistentes.Location = new System.Drawing.Point(43, 50);
            this.comboBoxRepuestosExistentes.Name = "comboBoxRepuestosExistentes";
            this.comboBoxRepuestosExistentes.Size = new System.Drawing.Size(145, 30);
            this.comboBoxRepuestosExistentes.TabIndex = 8;
            this.comboBoxRepuestosExistentes.ValueMember = "Id";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(32, 107);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Agregar existente";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelNombreRepuestoExistente
            // 
            this.labelNombreRepuestoExistente.AutoSize = true;
            this.labelNombreRepuestoExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRepuestoExistente.Location = new System.Drawing.Point(3, 51);
            this.labelNombreRepuestoExistente.Name = "labelNombreRepuestoExistente";
            this.labelNombreRepuestoExistente.Size = new System.Drawing.Size(45, 22);
            this.labelNombreRepuestoExistente.TabIndex = 2;
            this.labelNombreRepuestoExistente.Text = "Sel:";
            // 
            // labelSeleccionarRepuestoExistente
            // 
            this.labelSeleccionarRepuestoExistente.AutoSize = true;
            this.labelSeleccionarRepuestoExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionarRepuestoExistente.Location = new System.Drawing.Point(2, 9);
            this.labelSeleccionarRepuestoExistente.Name = "labelSeleccionarRepuestoExistente";
            this.labelSeleccionarRepuestoExistente.Size = new System.Drawing.Size(216, 26);
            this.labelSeleccionarRepuestoExistente.TabIndex = 0;
            this.labelSeleccionarRepuestoExistente.Text = "Repuesto existente";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvRepuestos);
            this.panel10.Controls.Add(this.labelRapuestosAsignados);
            this.panel10.Location = new System.Drawing.Point(238, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(602, 440);
            this.panel10.TabIndex = 2;
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            this.dgvRepuestos.Location = new System.Drawing.Point(3, 51);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersWidth = 62;
            this.dgvRepuestos.RowTemplate.Height = 28;
            this.dgvRepuestos.Size = new System.Drawing.Size(604, 386);
            this.dgvRepuestos.TabIndex = 2;
            this.dgvRepuestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepuestos_CellContentClick);
            // 
            // Sel
            // 
            this.Sel.HeaderText = "Sel";
            this.Sel.MinimumWidth = 8;
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sel.Width = 150;
            // 
            // labelRapuestosAsignados
            // 
            this.labelRapuestosAsignados.AutoSize = true;
            this.labelRapuestosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRapuestosAsignados.Location = new System.Drawing.Point(93, 10);
            this.labelRapuestosAsignados.Name = "labelRapuestosAsignados";
            this.labelRapuestosAsignados.Size = new System.Drawing.Size(219, 25);
            this.labelRapuestosAsignados.TabIndex = 1;
            this.labelRapuestosAsignados.Text = "Repuestos asignados";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PeachPuff;
            this.panel9.Controls.Add(this.button5);
            this.panel9.Controls.Add(this.textBoxPrecioNuevoRepuesto);
            this.panel9.Controls.Add(this.textBoxNombreNuevoRepuesto);
            this.panel9.Controls.Add(this.labelPrecioRepuesto);
            this.panel9.Controls.Add(this.labelNombreRepuesto);
            this.panel9.Controls.Add(this.labelAgregarNuevoRepuesto);
            this.panel9.Location = new System.Drawing.Point(7, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(225, 196);
            this.panel9.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(31, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 31);
            this.button5.TabIndex = 7;
            this.button5.Text = "Agregar nuevo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxPrecioNuevoRepuesto
            // 
            this.textBoxPrecioNuevoRepuesto.Location = new System.Drawing.Point(66, 100);
            this.textBoxPrecioNuevoRepuesto.Name = "textBoxPrecioNuevoRepuesto";
            this.textBoxPrecioNuevoRepuesto.Size = new System.Drawing.Size(122, 29);
            this.textBoxPrecioNuevoRepuesto.TabIndex = 6;
            // 
            // textBoxNombreNuevoRepuesto
            // 
            this.textBoxNombreNuevoRepuesto.Location = new System.Drawing.Point(80, 51);
            this.textBoxNombreNuevoRepuesto.Name = "textBoxNombreNuevoRepuesto";
            this.textBoxNombreNuevoRepuesto.Size = new System.Drawing.Size(108, 29);
            this.textBoxNombreNuevoRepuesto.TabIndex = 5;
            // 
            // labelPrecioRepuesto
            // 
            this.labelPrecioRepuesto.AutoSize = true;
            this.labelPrecioRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioRepuesto.Location = new System.Drawing.Point(3, 101);
            this.labelPrecioRepuesto.Name = "labelPrecioRepuesto";
            this.labelPrecioRepuesto.Size = new System.Drawing.Size(67, 22);
            this.labelPrecioRepuesto.TabIndex = 3;
            this.labelPrecioRepuesto.Text = "Precio";
            // 
            // labelNombreRepuesto
            // 
            this.labelNombreRepuesto.AutoSize = true;
            this.labelNombreRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRepuesto.Location = new System.Drawing.Point(3, 51);
            this.labelNombreRepuesto.Name = "labelNombreRepuesto";
            this.labelNombreRepuesto.Size = new System.Drawing.Size(79, 22);
            this.labelNombreRepuesto.TabIndex = 2;
            this.labelNombreRepuesto.Text = "Nombre";
            // 
            // labelAgregarNuevoRepuesto
            // 
            this.labelAgregarNuevoRepuesto.AutoSize = true;
            this.labelAgregarNuevoRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarNuevoRepuesto.Location = new System.Drawing.Point(2, 10);
            this.labelAgregarNuevoRepuesto.Name = "labelAgregarNuevoRepuesto";
            this.labelAgregarNuevoRepuesto.Size = new System.Drawing.Size(184, 26);
            this.labelAgregarNuevoRepuesto.TabIndex = 0;
            this.labelAgregarNuevoRepuesto.Text = "Repuesto nuevo";
            // 
            // tabPageDesperfectos
            // 
            this.tabPageDesperfectos.Controls.Add(this.panel14);
            this.tabPageDesperfectos.Controls.Add(this.panel13);
            this.tabPageDesperfectos.Controls.Add(this.panel8);
            this.tabPageDesperfectos.Controls.Add(this.panel7);
            this.tabPageDesperfectos.Location = new System.Drawing.Point(4, 34);
            this.tabPageDesperfectos.Name = "tabPageDesperfectos";
            this.tabPageDesperfectos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesperfectos.Size = new System.Drawing.Size(850, 517);
            this.tabPageDesperfectos.TabIndex = 4;
            this.tabPageDesperfectos.Text = "Desperfectos";
            this.tabPageDesperfectos.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonPresupuestar);
            this.panel14.Location = new System.Drawing.Point(3, 361);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(231, 81);
            this.panel14.TabIndex = 3;
            // 
            // buttonPresupuestar
            // 
            this.buttonPresupuestar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonPresupuestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresupuestar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPresupuestar.Location = new System.Drawing.Point(16, 3);
            this.buttonPresupuestar.Name = "buttonPresupuestar";
            this.buttonPresupuestar.Size = new System.Drawing.Size(193, 72);
            this.buttonPresupuestar.TabIndex = 9;
            this.buttonPresupuestar.Text = "Confirma Presupuesto";
            this.buttonPresupuestar.UseVisualStyleBackColor = false;
            this.buttonPresupuestar.Click += new System.EventHandler(this.buttonPresupuestar_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label1);
            this.panel13.Controls.Add(this.labelInfoContexto);
            this.panel13.Controls.Add(this.labelSeleccionDesperfectos);
            this.panel13.Location = new System.Drawing.Point(7, 448);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(833, 70);
            this.panel13.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(249, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "2°: doble clic en cada desperfecto para seleccionar repuestos.";
            // 
            // labelInfoContexto
            // 
            this.labelInfoContexto.AutoSize = true;
            this.labelInfoContexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoContexto.Location = new System.Drawing.Point(-4, 36);
            this.labelInfoContexto.Name = "labelInfoContexto";
            this.labelInfoContexto.Size = new System.Drawing.Size(399, 22);
            this.labelInfoContexto.TabIndex = 4;
            this.labelInfoContexto.Text = "(i) Indica componente con información contextual";
            // 
            // labelSeleccionDesperfectos
            // 
            this.labelSeleccionDesperfectos.AutoSize = true;
            this.labelSeleccionDesperfectos.BackColor = System.Drawing.Color.Transparent;
            this.labelSeleccionDesperfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionDesperfectos.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelSeleccionDesperfectos.Location = new System.Drawing.Point(0, 0);
            this.labelSeleccionDesperfectos.Name = "labelSeleccionDesperfectos";
            this.labelSeleccionDesperfectos.Size = new System.Drawing.Size(290, 25);
            this.labelSeleccionDesperfectos.TabIndex = 3;
            this.labelSeleccionDesperfectos.Text = "1°: agregar los desperfectos.";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridViewDesperfectos);
            this.panel8.Controls.Add(this.labelDesperfectosAsignados);
            this.panel8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(240, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(600, 436);
            this.panel8.TabIndex = 1;
            // 
            // dataGridViewDesperfectos
            // 
            this.dataGridViewDesperfectos.AllowUserToAddRows = false;
            this.dataGridViewDesperfectos.AllowUserToDeleteRows = false;
            this.dataGridViewDesperfectos.AllowUserToOrderColumns = true;
            this.dataGridViewDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesperfectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeleccionarDesperfecto,
            this.RE,
            this.RF});
            this.dataGridViewDesperfectos.Location = new System.Drawing.Point(3, 51);
            this.dataGridViewDesperfectos.Name = "dataGridViewDesperfectos";
            this.dataGridViewDesperfectos.RowHeadersWidth = 62;
            this.dataGridViewDesperfectos.RowTemplate.Height = 28;
            this.dataGridViewDesperfectos.Size = new System.Drawing.Size(594, 382);
            this.dataGridViewDesperfectos.TabIndex = 2;
            this.dataGridViewDesperfectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDesperfectos_CellContentClick);
            this.dataGridViewDesperfectos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDesperfectos_CellDoubleClick);
            // 
            // SeleccionarDesperfecto
            // 
            this.SeleccionarDesperfecto.HeaderText = "Sel";
            this.SeleccionarDesperfecto.MinimumWidth = 8;
            this.SeleccionarDesperfecto.Name = "SeleccionarDesperfecto";
            this.SeleccionarDesperfecto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarDesperfecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeleccionarDesperfecto.Width = 150;
            // 
            // RE
            // 
            this.RE.HeaderText = "RE (i)";
            this.RE.MinimumWidth = 8;
            this.RE.Name = "RE";
            this.RE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RE.ToolTipText = "Repuestos en Stock";
            this.RE.Width = 150;
            // 
            // RF
            // 
            this.RF.HeaderText = "RF (i)";
            this.RF.MinimumWidth = 8;
            this.RF.Name = "RF";
            this.RF.ToolTipText = "Repuestos en espera de proveedor";
            this.RF.Width = 150;
            // 
            // labelDesperfectosAsignados
            // 
            this.labelDesperfectosAsignados.AutoSize = true;
            this.labelDesperfectosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectosAsignados.Location = new System.Drawing.Point(7, 9);
            this.labelDesperfectosAsignados.Name = "labelDesperfectosAsignados";
            this.labelDesperfectosAsignados.Size = new System.Drawing.Size(295, 26);
            this.labelDesperfectosAsignados.TabIndex = 1;
            this.labelDesperfectosAsignados.Text = "2) Desperfectos asignados";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.buttonCancelarDesperfecto);
            this.panel7.Controls.Add(this.buttonAgregarDesperfecto);
            this.panel7.Controls.Add(this.textBoxDesperfectoTiempo);
            this.panel7.Controls.Add(this.textBoxDesperfectoManoDeObra);
            this.panel7.Controls.Add(this.textBoxDesperfectoDescripcion);
            this.panel7.Controls.Add(this.labelDesperfectoTiempo);
            this.panel7.Controls.Add(this.labelDesperfectoManoDeObra);
            this.panel7.Controls.Add(this.labelDescripcionDesperfecto);
            this.panel7.Controls.Add(this.labelNuevoDesperfecto);
            this.panel7.Location = new System.Drawing.Point(0, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 349);
            this.panel7.TabIndex = 0;
            // 
            // buttonCancelarDesperfecto
            // 
            this.buttonCancelarDesperfecto.BackColor = System.Drawing.Color.LightPink;
            this.buttonCancelarDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarDesperfecto.Location = new System.Drawing.Point(0, 309);
            this.buttonCancelarDesperfecto.Name = "buttonCancelarDesperfecto";
            this.buttonCancelarDesperfecto.Size = new System.Drawing.Size(128, 40);
            this.buttonCancelarDesperfecto.TabIndex = 8;
            this.buttonCancelarDesperfecto.Text = "Regresar Vehículos";
            this.buttonCancelarDesperfecto.UseVisualStyleBackColor = false;
            this.buttonCancelarDesperfecto.Click += new System.EventHandler(this.buttonCancelarDesperfecto_Click);
            // 
            // buttonAgregarDesperfecto
            // 
            this.buttonAgregarDesperfecto.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAgregarDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarDesperfecto.Location = new System.Drawing.Point(128, 309);
            this.buttonAgregarDesperfecto.Name = "buttonAgregarDesperfecto";
            this.buttonAgregarDesperfecto.Size = new System.Drawing.Size(102, 40);
            this.buttonAgregarDesperfecto.TabIndex = 7;
            this.buttonAgregarDesperfecto.Text = "Agregar";
            this.buttonAgregarDesperfecto.UseVisualStyleBackColor = false;
            this.buttonAgregarDesperfecto.Click += new System.EventHandler(this.buttonAgregarDesperfecto_Click);
            // 
            // textBoxDesperfectoTiempo
            // 
            this.textBoxDesperfectoTiempo.Location = new System.Drawing.Point(128, 261);
            this.textBoxDesperfectoTiempo.Name = "textBoxDesperfectoTiempo";
            this.textBoxDesperfectoTiempo.Size = new System.Drawing.Size(99, 29);
            this.textBoxDesperfectoTiempo.TabIndex = 6;
            // 
            // textBoxDesperfectoManoDeObra
            // 
            this.textBoxDesperfectoManoDeObra.Location = new System.Drawing.Point(128, 217);
            this.textBoxDesperfectoManoDeObra.Name = "textBoxDesperfectoManoDeObra";
            this.textBoxDesperfectoManoDeObra.Size = new System.Drawing.Size(99, 29);
            this.textBoxDesperfectoManoDeObra.TabIndex = 5;
            // 
            // textBoxDesperfectoDescripcion
            // 
            this.textBoxDesperfectoDescripcion.Location = new System.Drawing.Point(7, 109);
            this.textBoxDesperfectoDescripcion.Multiline = true;
            this.textBoxDesperfectoDescripcion.Name = "textBoxDesperfectoDescripcion";
            this.textBoxDesperfectoDescripcion.Size = new System.Drawing.Size(220, 95);
            this.textBoxDesperfectoDescripcion.TabIndex = 4;
            // 
            // labelDesperfectoTiempo
            // 
            this.labelDesperfectoTiempo.AutoSize = true;
            this.labelDesperfectoTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectoTiempo.Location = new System.Drawing.Point(3, 264);
            this.labelDesperfectoTiempo.Name = "labelDesperfectoTiempo";
            this.labelDesperfectoTiempo.Size = new System.Drawing.Size(126, 38);
            this.labelDesperfectoTiempo.TabIndex = 3;
            this.labelDesperfectoTiempo.Text = "Tiempo";
            // 
            // labelDesperfectoManoDeObra
            // 
            this.labelDesperfectoManoDeObra.AutoSize = true;
            this.labelDesperfectoManoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectoManoDeObra.Location = new System.Drawing.Point(6, 220);
            this.labelDesperfectoManoDeObra.Name = "labelDesperfectoManoDeObra";
            this.labelDesperfectoManoDeObra.Size = new System.Drawing.Size(145, 25);
            this.labelDesperfectoManoDeObra.TabIndex = 2;
            this.labelDesperfectoManoDeObra.Text = "Mano de obra";
            // 
            // labelDescripcionDesperfecto
            // 
            this.labelDescripcionDesperfecto.AutoSize = true;
            this.labelDescripcionDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionDesperfecto.Location = new System.Drawing.Point(7, 81);
            this.labelDescripcionDesperfecto.Name = "labelDescripcionDesperfecto";
            this.labelDescripcionDesperfecto.Size = new System.Drawing.Size(125, 25);
            this.labelDescripcionDesperfecto.TabIndex = 1;
            this.labelDescripcionDesperfecto.Text = "Descripción";
            // 
            // labelNuevoDesperfecto
            // 
            this.labelNuevoDesperfecto.AutoSize = true;
            this.labelNuevoDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoDesperfecto.Location = new System.Drawing.Point(2, 9);
            this.labelNuevoDesperfecto.Name = "labelNuevoDesperfecto";
            this.labelNuevoDesperfecto.Size = new System.Drawing.Size(239, 26);
            this.labelNuevoDesperfecto.TabIndex = 0;
            this.labelNuevoDesperfecto.Text = "1) Nuevo desperfecto";
            // 
            // tabPresupuestacion
            // 
            this.tabPresupuestacion.Controls.Add(this.panel6);
            this.tabPresupuestacion.Location = new System.Drawing.Point(4, 34);
            this.tabPresupuestacion.Name = "tabPresupuestacion";
            this.tabPresupuestacion.Size = new System.Drawing.Size(850, 517);
            this.tabPresupuestacion.TabIndex = 3;
            this.tabPresupuestacion.Text = "Presupuestación";
            this.tabPresupuestacion.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel16);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.textBoxTiempoTotal);
            this.panel6.Controls.Add(this.labelTiempoTotal);
            this.panel6.Controls.Add(this.textBoxSubTotal);
            this.panel6.Controls.Add(this.labelSubTotal);
            this.panel6.Controls.Add(this.txRepuestosTotal);
            this.panel6.Controls.Add(this.labelCostoRepuestos);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.txBoxEstacionamiento);
            this.panel6.Controls.Add(this.txManoDeObra);
            this.panel6.Controls.Add(this.txBoxDescuento);
            this.panel6.Controls.Add(this.txBoxRecargo);
            this.panel6.Controls.Add(this.labelCostoEstacionamiento);
            this.panel6.Controls.Add(this.labelManoDeObra);
            this.panel6.Controls.Add(this.labelDescuento);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(3, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(844, 490);
            this.panel6.TabIndex = 0;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.Info;
            this.panel16.Controls.Add(this.label8);
            this.panel16.Controls.Add(this.label7);
            this.panel16.Controls.Add(this.label11);
            this.panel16.Controls.Add(this.txBoxNombre);
            this.panel16.Controls.Add(this.txBoxApellido);
            this.panel16.Controls.Add(this.txBoxEmail);
            this.panel16.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.panel16.Location = new System.Drawing.Point(4, 9);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(409, 262);
            this.panel16.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // txBoxNombre
            // 
            this.txBoxNombre.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxNombre.Location = new System.Drawing.Point(147, 29);
            this.txBoxNombre.Name = "txBoxNombre";
            this.txBoxNombre.Size = new System.Drawing.Size(254, 32);
            this.txBoxNombre.TabIndex = 11;
            // 
            // txBoxApellido
            // 
            this.txBoxApellido.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxApellido.Location = new System.Drawing.Point(147, 110);
            this.txBoxApellido.Name = "txBoxApellido";
            this.txBoxApellido.Size = new System.Drawing.Size(254, 32);
            this.txBoxApellido.TabIndex = 12;
            // 
            // txBoxEmail
            // 
            this.txBoxEmail.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxEmail.Location = new System.Drawing.Point(147, 202);
            this.txBoxEmail.Name = "txBoxEmail";
            this.txBoxEmail.Size = new System.Drawing.Size(254, 32);
            this.txBoxEmail.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.labelTotalConsumidor);
            this.panel5.Controls.Add(this.TotalPresupuestoConsumidor);
            this.panel5.Location = new System.Drawing.Point(3, 277);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 147);
            this.panel5.TabIndex = 31;
            // 
            // labelTotalConsumidor
            // 
            this.labelTotalConsumidor.AutoSize = true;
            this.labelTotalConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalConsumidor.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTotalConsumidor.Location = new System.Drawing.Point(74, 19);
            this.labelTotalConsumidor.Name = "labelTotalConsumidor";
            this.labelTotalConsumidor.Size = new System.Drawing.Size(249, 32);
            this.labelTotalConsumidor.TabIndex = 25;
            this.labelTotalConsumidor.Text = "Total consumidor";
            // 
            // TotalPresupuestoConsumidor
            // 
            this.TotalPresupuestoConsumidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPresupuestoConsumidor.ForeColor = System.Drawing.Color.ForestGreen;
            this.TotalPresupuestoConsumidor.Location = new System.Drawing.Point(58, 82);
            this.TotalPresupuestoConsumidor.Name = "TotalPresupuestoConsumidor";
            this.TotalPresupuestoConsumidor.Size = new System.Drawing.Size(284, 44);
            this.TotalPresupuestoConsumidor.TabIndex = 26;
            // 
            // textBoxTiempoTotal
            // 
            this.textBoxTiempoTotal.Location = new System.Drawing.Point(657, 11);
            this.textBoxTiempoTotal.Name = "textBoxTiempoTotal";
            this.textBoxTiempoTotal.Size = new System.Drawing.Size(168, 29);
            this.textBoxTiempoTotal.TabIndex = 30;
            // 
            // labelTiempoTotal
            // 
            this.labelTiempoTotal.AutoSize = true;
            this.labelTiempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTiempoTotal.Location = new System.Drawing.Point(426, 9);
            this.labelTiempoTotal.Name = "labelTiempoTotal";
            this.labelTiempoTotal.Size = new System.Drawing.Size(177, 29);
            this.labelTiempoTotal.TabIndex = 29;
            this.labelTiempoTotal.Text = "Tiempo (días)";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(657, 445);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(168, 29);
            this.textBoxSubTotal.TabIndex = 28;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(429, 443);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(119, 29);
            this.labelSubTotal.TabIndex = 27;
            this.labelSubTotal.Text = "SubTotal";
            // 
            // txRepuestosTotal
            // 
            this.txRepuestosTotal.Location = new System.Drawing.Point(657, 369);
            this.txRepuestosTotal.Name = "txRepuestosTotal";
            this.txRepuestosTotal.Size = new System.Drawing.Size(168, 29);
            this.txRepuestosTotal.TabIndex = 24;
            // 
            // labelCostoRepuestos
            // 
            this.labelCostoRepuestos.AutoSize = true;
            this.labelCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoRepuestos.Location = new System.Drawing.Point(429, 367);
            this.labelCostoRepuestos.Name = "labelCostoRepuestos";
            this.labelCostoRepuestos.Size = new System.Drawing.Size(213, 29);
            this.labelCostoRepuestos.TabIndex = 23;
            this.labelCostoRepuestos.Text = "Costo Repuestos";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(3, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Emitir";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Location = new System.Drawing.Point(221, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 57);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txBoxEstacionamiento
            // 
            this.txBoxEstacionamiento.Location = new System.Drawing.Point(657, 296);
            this.txBoxEstacionamiento.Name = "txBoxEstacionamiento";
            this.txBoxEstacionamiento.Size = new System.Drawing.Size(168, 29);
            this.txBoxEstacionamiento.TabIndex = 21;
            // 
            // txManoDeObra
            // 
            this.txManoDeObra.Location = new System.Drawing.Point(657, 219);
            this.txManoDeObra.Name = "txManoDeObra";
            this.txManoDeObra.Size = new System.Drawing.Size(168, 29);
            this.txManoDeObra.TabIndex = 20;
            // 
            // txBoxDescuento
            // 
            this.txBoxDescuento.Location = new System.Drawing.Point(657, 84);
            this.txBoxDescuento.Name = "txBoxDescuento";
            this.txBoxDescuento.Size = new System.Drawing.Size(168, 29);
            this.txBoxDescuento.TabIndex = 19;
            // 
            // txBoxRecargo
            // 
            this.txBoxRecargo.Location = new System.Drawing.Point(657, 151);
            this.txBoxRecargo.Name = "txBoxRecargo";
            this.txBoxRecargo.Size = new System.Drawing.Size(168, 29);
            this.txBoxRecargo.TabIndex = 18;
            // 
            // labelCostoEstacionamiento
            // 
            this.labelCostoEstacionamiento.AutoSize = true;
            this.labelCostoEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostoEstacionamiento.Location = new System.Drawing.Point(426, 294);
            this.labelCostoEstacionamiento.Name = "labelCostoEstacionamiento";
            this.labelCostoEstacionamiento.Size = new System.Drawing.Size(245, 29);
            this.labelCostoEstacionamiento.TabIndex = 17;
            this.labelCostoEstacionamiento.Text = "Estacionamiento ($)";
            // 
            // labelManoDeObra
            // 
            this.labelManoDeObra.AutoSize = true;
            this.labelManoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManoDeObra.Location = new System.Drawing.Point(429, 217);
            this.labelManoDeObra.Name = "labelManoDeObra";
            this.labelManoDeObra.Size = new System.Drawing.Size(174, 29);
            this.labelManoDeObra.TabIndex = 16;
            this.labelManoDeObra.Text = "Mano de obra";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(426, 82);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(185, 29);
            this.labelDescuento.TabIndex = 15;
            this.labelDescuento.Text = "Descuento (%)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(426, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Recargo (%)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tabABM
            // 
            this.tabABM.Controls.Add(this.panel1);
            this.tabABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabABM.Location = new System.Drawing.Point(4, 34);
            this.tabABM.Name = "tabABM";
            this.tabABM.Padding = new System.Windows.Forms.Padding(3);
            this.tabABM.Size = new System.Drawing.Size(850, 517);
            this.tabABM.TabIndex = 1;
            this.tabABM.Text = "ABM";
            this.tabABM.UseVisualStyleBackColor = true;
            this.tabABM.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCancelarInserción);
            this.panel1.Controls.Add(this.btnActualizarVehículo);
            this.panel1.Controls.Add(this.btInsertarVehículo);
            this.panel1.Controls.Add(this.textBxPatente);
            this.panel1.Controls.Add(this.textBxModelo);
            this.panel1.Controls.Add(this.textBxMarca);
            this.panel1.Controls.Add(this.textBxIdVehículo);
            this.panel1.Controls.Add(this.selectorTipoVehículo);
            this.panel1.Controls.Add(this.etiquetaPatente);
            this.panel1.Controls.Add(this.etiquetaModelo);
            this.panel1.Controls.Add(this.etiquetaMarca);
            this.panel1.Controls.Add(this.etiquetaIdVehiculo);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 494);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancelarInserción
            // 
            this.btnCancelarInserción.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelarInserción.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarInserción.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancelarInserción.Location = new System.Drawing.Point(578, 409);
            this.btnCancelarInserción.Name = "btnCancelarInserción";
            this.btnCancelarInserción.Size = new System.Drawing.Size(176, 57);
            this.btnCancelarInserción.TabIndex = 16;
            this.btnCancelarInserción.Text = "Cancelar";
            this.btnCancelarInserción.UseVisualStyleBackColor = false;
            this.btnCancelarInserción.Click += new System.EventHandler(this.btnCancelarInserción_Click);
            // 
            // btnActualizarVehículo
            // 
            this.btnActualizarVehículo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizarVehículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVehículo.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizarVehículo.Location = new System.Drawing.Point(317, 409);
            this.btnActualizarVehículo.Name = "btnActualizarVehículo";
            this.btnActualizarVehículo.Size = new System.Drawing.Size(176, 57);
            this.btnActualizarVehículo.TabIndex = 15;
            this.btnActualizarVehículo.Text = "Actualizar";
            this.btnActualizarVehículo.UseVisualStyleBackColor = false;
            this.btnActualizarVehículo.Click += new System.EventHandler(this.btnActualizarVehículo_Click);
            // 
            // btInsertarVehículo
            // 
            this.btInsertarVehículo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btInsertarVehículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertarVehículo.ForeColor = System.Drawing.Color.Lime;
            this.btInsertarVehículo.Location = new System.Drawing.Point(80, 409);
            this.btInsertarVehículo.Name = "btInsertarVehículo";
            this.btInsertarVehículo.Size = new System.Drawing.Size(146, 57);
            this.btInsertarVehículo.TabIndex = 14;
            this.btInsertarVehículo.Text = "Ingresar";
            this.btInsertarVehículo.UseVisualStyleBackColor = false;
            this.btInsertarVehículo.Click += new System.EventHandler(this.btInsertarVehículo_Click_1);
            // 
            // textBxPatente
            // 
            this.textBxPatente.Location = new System.Drawing.Point(199, 282);
            this.textBxPatente.Name = "textBxPatente";
            this.textBxPatente.Size = new System.Drawing.Size(168, 28);
            this.textBxPatente.TabIndex = 13;
            // 
            // textBxModelo
            // 
            this.textBxModelo.Location = new System.Drawing.Point(199, 203);
            this.textBxModelo.Name = "textBxModelo";
            this.textBxModelo.Size = new System.Drawing.Size(168, 28);
            this.textBxModelo.TabIndex = 12;
            // 
            // textBxMarca
            // 
            this.textBxMarca.Location = new System.Drawing.Point(199, 127);
            this.textBxMarca.Name = "textBxMarca";
            this.textBxMarca.Size = new System.Drawing.Size(168, 28);
            this.textBxMarca.TabIndex = 11;
            // 
            // textBxIdVehículo
            // 
            this.textBxIdVehículo.Location = new System.Drawing.Point(199, 59);
            this.textBxIdVehículo.Name = "textBxIdVehículo";
            this.textBxIdVehículo.Size = new System.Drawing.Size(168, 28);
            this.textBxIdVehículo.TabIndex = 10;
            // 
            // selectorTipoVehículo
            // 
            this.selectorTipoVehículo.Controls.Add(this.tabAutomóvil);
            this.selectorTipoVehículo.Controls.Add(this.tabMoto);
            this.selectorTipoVehículo.Location = new System.Drawing.Point(388, 3);
            this.selectorTipoVehículo.Name = "selectorTipoVehículo";
            this.selectorTipoVehículo.SelectedIndex = 0;
            this.selectorTipoVehículo.Size = new System.Drawing.Size(442, 338);
            this.selectorTipoVehículo.TabIndex = 4;
            // 
            // tabAutomóvil
            // 
            this.tabAutomóvil.Controls.Add(this.panel2);
            this.tabAutomóvil.Location = new System.Drawing.Point(4, 31);
            this.tabAutomóvil.Name = "tabAutomóvil";
            this.tabAutomóvil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomóvil.Size = new System.Drawing.Size(434, 303);
            this.tabAutomóvil.TabIndex = 0;
            this.tabAutomóvil.Text = "Automóvil";
            this.tabAutomóvil.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.ElComboTipoAutomovil);
            this.panel2.Controls.Add(this.textPuertas);
            this.panel2.Controls.Add(this.textBxIdAutomóvil);
            this.panel2.Controls.Add(this.etiquetaTipo);
            this.panel2.Controls.Add(this.etiquetaPuertasAutomóvil);
            this.panel2.Controls.Add(this.etiquetaIdAutomóvil);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 293);
            this.panel2.TabIndex = 0;
            // 
            // ElComboTipoAutomovil
            // 
            this.ElComboTipoAutomovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElComboTipoAutomovil.FormattingEnabled = true;
            this.ElComboTipoAutomovil.Items.AddRange(new object[] {
            "compacto",
            "sedan",
            "monovolumen",
            "utilitario",
            "lujo"});
            this.ElComboTipoAutomovil.Location = new System.Drawing.Point(250, 220);
            this.ElComboTipoAutomovil.Name = "ElComboTipoAutomovil";
            this.ElComboTipoAutomovil.Size = new System.Drawing.Size(159, 37);
            this.ElComboTipoAutomovil.TabIndex = 16;
            this.ElComboTipoAutomovil.Text = "compacto";
            this.ElComboTipoAutomovil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textPuertas
            // 
            this.textPuertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPuertas.ForeColor = System.Drawing.Color.YellowGreen;
            this.textPuertas.Location = new System.Drawing.Point(210, 121);
            this.textPuertas.Name = "textPuertas";
            this.textPuertas.Size = new System.Drawing.Size(199, 35);
            this.textPuertas.TabIndex = 15;
            // 
            // textBxIdAutomóvil
            // 
            this.textBxIdAutomóvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxIdAutomóvil.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBxIdAutomóvil.Location = new System.Drawing.Point(233, 30);
            this.textBxIdAutomóvil.Name = "textBxIdAutomóvil";
            this.textBxIdAutomóvil.Size = new System.Drawing.Size(176, 35);
            this.textBxIdAutomóvil.TabIndex = 14;
            // 
            // etiquetaTipo
            // 
            this.etiquetaTipo.AutoSize = true;
            this.etiquetaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTipo.Location = new System.Drawing.Point(3, 219);
            this.etiquetaTipo.Name = "etiquetaTipo";
            this.etiquetaTipo.Size = new System.Drawing.Size(75, 32);
            this.etiquetaTipo.TabIndex = 8;
            this.etiquetaTipo.Text = "Tipo";
            // 
            // etiquetaPuertasAutomóvil
            // 
            this.etiquetaPuertasAutomóvil.AutoSize = true;
            this.etiquetaPuertasAutomóvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPuertasAutomóvil.Location = new System.Drawing.Point(3, 121);
            this.etiquetaPuertasAutomóvil.Name = "etiquetaPuertasAutomóvil";
            this.etiquetaPuertasAutomóvil.Size = new System.Drawing.Size(120, 32);
            this.etiquetaPuertasAutomóvil.TabIndex = 6;
            this.etiquetaPuertasAutomóvil.Text = "Puertas";
            // 
            // etiquetaIdAutomóvil
            // 
            this.etiquetaIdAutomóvil.AutoSize = true;
            this.etiquetaIdAutomóvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIdAutomóvil.Location = new System.Drawing.Point(3, 30);
            this.etiquetaIdAutomóvil.Name = "etiquetaIdAutomóvil";
            this.etiquetaIdAutomóvil.Size = new System.Drawing.Size(183, 32);
            this.etiquetaIdAutomóvil.TabIndex = 5;
            this.etiquetaIdAutomóvil.Text = "Id Automóvil";
            // 
            // tabMoto
            // 
            this.tabMoto.Controls.Add(this.panel3);
            this.tabMoto.Location = new System.Drawing.Point(4, 31);
            this.tabMoto.Name = "tabMoto";
            this.tabMoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoto.Size = new System.Drawing.Size(434, 303);
            this.tabMoto.TabIndex = 1;
            this.tabMoto.Text = "Moto";
            this.tabMoto.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.textBxCilindrada);
            this.panel3.Controls.Add(this.textBxIdMoto);
            this.panel3.Controls.Add(this.etiquetaCilindrada);
            this.panel3.Controls.Add(this.etiquetaIdMoto);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 293);
            this.panel3.TabIndex = 0;
            // 
            // textBxCilindrada
            // 
            this.textBxCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxCilindrada.Location = new System.Drawing.Point(198, 105);
            this.textBxCilindrada.Name = "textBxCilindrada";
            this.textBxCilindrada.Size = new System.Drawing.Size(214, 35);
            this.textBxCilindrada.TabIndex = 9;
            // 
            // textBxIdMoto
            // 
            this.textBxIdMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxIdMoto.Location = new System.Drawing.Point(198, 14);
            this.textBxIdMoto.Name = "textBxIdMoto";
            this.textBxIdMoto.Size = new System.Drawing.Size(214, 35);
            this.textBxIdMoto.TabIndex = 8;
            // 
            // etiquetaCilindrada
            // 
            this.etiquetaCilindrada.AutoSize = true;
            this.etiquetaCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCilindrada.Location = new System.Drawing.Point(14, 105);
            this.etiquetaCilindrada.Name = "etiquetaCilindrada";
            this.etiquetaCilindrada.Size = new System.Drawing.Size(155, 32);
            this.etiquetaCilindrada.TabIndex = 7;
            this.etiquetaCilindrada.Text = "Cilindrada";
            // 
            // etiquetaIdMoto
            // 
            this.etiquetaIdMoto.AutoSize = true;
            this.etiquetaIdMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIdMoto.Location = new System.Drawing.Point(14, 19);
            this.etiquetaIdMoto.Name = "etiquetaIdMoto";
            this.etiquetaIdMoto.Size = new System.Drawing.Size(115, 32);
            this.etiquetaIdMoto.TabIndex = 6;
            this.etiquetaIdMoto.Text = "Id Moto";
            // 
            // etiquetaPatente
            // 
            this.etiquetaPatente.AutoSize = true;
            this.etiquetaPatente.BackColor = System.Drawing.Color.Gainsboro;
            this.etiquetaPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPatente.Location = new System.Drawing.Point(28, 278);
            this.etiquetaPatente.Name = "etiquetaPatente";
            this.etiquetaPatente.Size = new System.Drawing.Size(102, 29);
            this.etiquetaPatente.TabIndex = 3;
            this.etiquetaPatente.Text = "Patente";
            // 
            // etiquetaModelo
            // 
            this.etiquetaModelo.AutoSize = true;
            this.etiquetaModelo.BackColor = System.Drawing.Color.Gainsboro;
            this.etiquetaModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaModelo.Location = new System.Drawing.Point(28, 203);
            this.etiquetaModelo.Name = "etiquetaModelo";
            this.etiquetaModelo.Size = new System.Drawing.Size(101, 29);
            this.etiquetaModelo.TabIndex = 2;
            this.etiquetaModelo.Text = "Modelo";
            // 
            // etiquetaMarca
            // 
            this.etiquetaMarca.AutoSize = true;
            this.etiquetaMarca.BackColor = System.Drawing.Color.Gainsboro;
            this.etiquetaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaMarca.Location = new System.Drawing.Point(28, 127);
            this.etiquetaMarca.Name = "etiquetaMarca";
            this.etiquetaMarca.Size = new System.Drawing.Size(84, 29);
            this.etiquetaMarca.TabIndex = 1;
            this.etiquetaMarca.Text = "Marca";
            // 
            // etiquetaIdVehiculo
            // 
            this.etiquetaIdVehiculo.AutoSize = true;
            this.etiquetaIdVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIdVehiculo.Location = new System.Drawing.Point(28, 55);
            this.etiquetaIdVehiculo.Name = "etiquetaIdVehiculo";
            this.etiquetaIdVehiculo.Size = new System.Drawing.Size(143, 29);
            this.etiquetaIdVehiculo.TabIndex = 0;
            this.etiquetaIdVehiculo.Text = "Id Vehiculo";
            // 
            // tabVehiculos
            // 
            this.tabVehiculos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabVehiculos.BackgroundImage")));
            this.tabVehiculos.Controls.Add(this.panel4);
            this.tabVehiculos.Controls.Add(this.panel20);
            this.tabVehiculos.Controls.Add(this.labelTotal);
            this.tabVehiculos.Controls.Add(this.dgvDatos);
            this.tabVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVehiculos.Location = new System.Drawing.Point(4, 34);
            this.tabVehiculos.Name = "tabVehiculos";
            this.tabVehiculos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehiculos.Size = new System.Drawing.Size(850, 517);
            this.tabVehiculos.TabIndex = 0;
            this.tabVehiculos.Text = "Vehículos";
            this.tabVehiculos.UseVisualStyleBackColor = true;
            this.tabVehiculos.Click += new System.EventHandler(this.tabPage1_Click_2);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 462);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 55);
            this.panel4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(0, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(850, 56);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Operar: permite eliminar o diagnosticar Vehículos. \r\n- Al diagnosticar, se inicia" +
    " un nuevo Presupuesto con Desperfectos y Repuestos.\r\nDoble clic sobre fila para " +
    "actualizar vehículo.\r\n";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.btEliminar);
            this.panel20.Controls.Add(this.Diagnose);
            this.panel20.Controls.Add(this.txtBuscar);
            this.panel20.Controls.Add(this.chkSelect);
            this.panel20.Controls.Add(this.btnBuscador);
            this.panel20.Location = new System.Drawing.Point(3, 6);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(844, 37);
            this.panel20.TabIndex = 5;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(724, 3);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(117, 31);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Diagnose
            // 
            this.Diagnose.BackColor = System.Drawing.Color.PaleGreen;
            this.Diagnose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnose.Location = new System.Drawing.Point(617, 3);
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Size = new System.Drawing.Size(101, 31);
            this.Diagnose.TabIndex = 5;
            this.Diagnose.Text = "Dignosticar";
            this.Diagnose.UseVisualStyleBackColor = false;
            this.Diagnose.Click += new System.EventHandler(this.Activate_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(3, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(299, 32);
            this.txtBuscar.TabIndex = 2;
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.BackColor = System.Drawing.Color.Yellow;
            this.chkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelect.Location = new System.Drawing.Point(422, 5);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(129, 36);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Operar";
            this.chkSelect.UseVisualStyleBackColor = false;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // btnBuscador
            // 
            this.btnBuscador.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscador.Location = new System.Drawing.Point(308, 1);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(108, 33);
            this.btnBuscador.TabIndex = 3;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = false;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1602, 938);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(51, 22);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeight = 35;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHK});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.Location = new System.Drawing.Point(53, 49);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 30;
            this.dgvDatos.RowTemplate.Height = 23;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(743, 407);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // CHK
            // 
            this.CHK.FalseValue = "";
            this.CHK.HeaderText = "CHK";
            this.CHK.IndeterminateValue = "";
            this.CHK.MinimumWidth = 10;
            this.CHK.Name = "CHK";
            this.CHK.ReadOnly = true;
            this.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHK.TrueValue = "";
            this.CHK.Width = 150;
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.tabControlPrincipal.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlPrincipal.Controls.Add(this.tabVehiculos);
            this.tabControlPrincipal.Controls.Add(this.tabABM);
            this.tabControlPrincipal.Controls.Add(this.tabPageDesperfectos);
            this.tabControlPrincipal.Controls.Add(this.tabPageRepuestos);
            this.tabControlPrincipal.Controls.Add(this.tabPresupuestacion);
            this.tabControlPrincipal.Controls.Add(this.tabPresupuestos);
            this.tabControlPrincipal.Controls.Add(this.tabServicios);
            this.tabControlPrincipal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrincipal.Location = new System.Drawing.Point(1, 2);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(858, 555);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabPresupuestos
            // 
            this.tabPresupuestos.Controls.Add(this.panel17);
            this.tabPresupuestos.Location = new System.Drawing.Point(4, 34);
            this.tabPresupuestos.Name = "tabPresupuestos";
            this.tabPresupuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPresupuestos.Size = new System.Drawing.Size(850, 517);
            this.tabPresupuestos.TabIndex = 6;
            this.tabPresupuestos.Text = "Presupuestos";
            this.tabPresupuestos.UseVisualStyleBackColor = true;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.Reloj);
            this.panel17.Controls.Add(this.textBox2);
            this.panel17.Controls.Add(this.buttonABM);
            this.panel17.Controls.Add(this.buttonListarPresupuestos);
            this.panel17.Controls.Add(this.dataGridViewPresupuestos);
            this.panel17.Location = new System.Drawing.Point(3, 6);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(844, 498);
            this.panel17.TabIndex = 0;
            // 
            // Reloj
            // 
            this.Reloj.Location = new System.Drawing.Point(474, 451);
            this.Reloj.Name = "Reloj";
            this.Reloj.Size = new System.Drawing.Size(186, 29);
            this.Reloj.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(666, 433);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 62);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "(i) Doble clic en el presupuesto para turnos";
            // 
            // buttonABM
            // 
            this.buttonABM.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonABM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonABM.ForeColor = System.Drawing.Color.Green;
            this.buttonABM.Location = new System.Drawing.Point(268, 438);
            this.buttonABM.Name = "buttonABM";
            this.buttonABM.Size = new System.Drawing.Size(200, 55);
            this.buttonABM.TabIndex = 24;
            this.buttonABM.Text = "ABM Vehículos";
            this.buttonABM.UseVisualStyleBackColor = false;
            this.buttonABM.Click += new System.EventHandler(this.buttonABM_Click);
            // 
            // buttonListarPresupuestos
            // 
            this.buttonListarPresupuestos.BackColor = System.Drawing.Color.Linen;
            this.buttonListarPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarPresupuestos.ForeColor = System.Drawing.Color.Green;
            this.buttonListarPresupuestos.Location = new System.Drawing.Point(4, 438);
            this.buttonListarPresupuestos.Name = "buttonListarPresupuestos";
            this.buttonListarPresupuestos.Size = new System.Drawing.Size(258, 55);
            this.buttonListarPresupuestos.TabIndex = 23;
            this.buttonListarPresupuestos.Text = "Listar Presupuestos";
            this.buttonListarPresupuestos.UseVisualStyleBackColor = false;
            this.buttonListarPresupuestos.Click += new System.EventHandler(this.buttonListarPresupuestos_Click);
            // 
            // dataGridViewPresupuestos
            // 
            this.dataGridViewPresupuestos.AllowUserToAddRows = false;
            this.dataGridViewPresupuestos.AllowUserToDeleteRows = false;
            this.dataGridViewPresupuestos.AllowUserToOrderColumns = true;
            this.dataGridViewPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPresupuestos.Location = new System.Drawing.Point(4, 3);
            this.dataGridViewPresupuestos.Name = "dataGridViewPresupuestos";
            this.dataGridViewPresupuestos.ReadOnly = true;
            this.dataGridViewPresupuestos.RowHeadersWidth = 62;
            this.dataGridViewPresupuestos.RowTemplate.Height = 28;
            this.dataGridViewPresupuestos.Size = new System.Drawing.Size(834, 427);
            this.dataGridViewPresupuestos.TabIndex = 0;
            this.dataGridViewPresupuestos.DoubleClick += new System.EventHandler(this.dataGridViewPresupuestos_DoubleClick);
            // 
            // tabServicios
            // 
            this.tabServicios.Controls.Add(this.panel19);
            this.tabServicios.Controls.Add(this.panel18);
            this.tabServicios.Location = new System.Drawing.Point(4, 34);
            this.tabServicios.Name = "tabServicios";
            this.tabServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tabServicios.Size = new System.Drawing.Size(850, 517);
            this.tabServicios.TabIndex = 7;
            this.tabServicios.Text = "Servicios";
            this.tabServicios.UseVisualStyleBackColor = true;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel19.Controls.Add(this.comboBoxServicioTipo);
            this.panel19.Controls.Add(this.label2);
            this.panel19.Controls.Add(this.textBoxServiciosMasivos);
            this.panel19.Controls.Add(this.textBoxServiciosBasicos);
            this.panel19.Controls.Add(this.labelServicioModelo);
            this.panel19.Controls.Add(this.textBoxServicioMarcaModelo);
            this.panel19.Controls.Add(this.button1);
            this.panel19.Controls.Add(this.buttonSumatoriaTotalPresupuestos);
            this.panel19.Controls.Add(this.buttonPromedioTotalPresupuestos);
            this.panel19.Controls.Add(this.buttonRepuestoMasUsado);
            this.panel19.Location = new System.Drawing.Point(7, 6);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(522, 500);
            this.panel19.TabIndex = 1;
            // 
            // comboBoxServicioTipo
            // 
            this.comboBoxServicioTipo.FormattingEnabled = true;
            this.comboBoxServicioTipo.Items.AddRange(new object[] {
            "Automovil",
            "Moto"});
            this.comboBoxServicioTipo.Location = new System.Drawing.Point(393, 122);
            this.comboBoxServicioTipo.Name = "comboBoxServicioTipo";
            this.comboBoxServicioTipo.Size = new System.Drawing.Size(121, 30);
            this.comboBoxServicioTipo.TabIndex = 12;
            this.comboBoxServicioTipo.Text = "Moto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // textBoxServiciosMasivos
            // 
            this.textBoxServiciosMasivos.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServiciosMasivos.Location = new System.Drawing.Point(3, 396);
            this.textBoxServiciosMasivos.Multiline = true;
            this.textBoxServiciosMasivos.Name = "textBoxServiciosMasivos";
            this.textBoxServiciosMasivos.Size = new System.Drawing.Size(513, 101);
            this.textBoxServiciosMasivos.TabIndex = 10;
            this.textBoxServiciosMasivos.Text = "ATENCIÓN: \r\nLa carga masiva altera el contenido de la tabla Repuesto. ";
            // 
            // textBoxServiciosBasicos
            // 
            this.textBoxServiciosBasicos.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServiciosBasicos.Location = new System.Drawing.Point(3, 163);
            this.textBoxServiciosBasicos.Multiline = true;
            this.textBoxServiciosBasicos.Name = "textBoxServiciosBasicos";
            this.textBoxServiciosBasicos.Size = new System.Drawing.Size(513, 179);
            this.textBoxServiciosBasicos.TabIndex = 9;
            this.textBoxServiciosBasicos.Text = resources.GetString("textBoxServiciosBasicos.Text");
            // 
            // labelServicioModelo
            // 
            this.labelServicioModelo.AutoSize = true;
            this.labelServicioModelo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServicioModelo.Location = new System.Drawing.Point(328, 9);
            this.labelServicioModelo.Name = "labelServicioModelo";
            this.labelServicioModelo.Size = new System.Drawing.Size(177, 26);
            this.labelServicioModelo.TabIndex = 8;
            this.labelServicioModelo.Text = "Marca/Modelo?";
            // 
            // textBoxServicioMarcaModelo
            // 
            this.textBoxServicioMarcaModelo.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServicioMarcaModelo.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxServicioMarcaModelo.Location = new System.Drawing.Point(319, 51);
            this.textBoxServicioMarcaModelo.Name = "textBoxServicioMarcaModelo";
            this.textBoxServicioMarcaModelo.Size = new System.Drawing.Size(186, 32);
            this.textBoxServicioMarcaModelo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.ForeColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(3, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Carga Masiva Repuestos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSumatoriaTotalPresupuestos
            // 
            this.buttonSumatoriaTotalPresupuestos.BackColor = System.Drawing.Color.Snow;
            this.buttonSumatoriaTotalPresupuestos.Location = new System.Drawing.Point(3, 115);
            this.buttonSumatoriaTotalPresupuestos.Name = "buttonSumatoriaTotalPresupuestos";
            this.buttonSumatoriaTotalPresupuestos.Size = new System.Drawing.Size(287, 42);
            this.buttonSumatoriaTotalPresupuestos.TabIndex = 2;
            this.buttonSumatoriaTotalPresupuestos.Text = "Sumatoria total presupuestos";
            this.buttonSumatoriaTotalPresupuestos.UseVisualStyleBackColor = false;
            this.buttonSumatoriaTotalPresupuestos.Click += new System.EventHandler(this.buttonSumatoriaTotalPresupuestos_Click);
            // 
            // buttonPromedioTotalPresupuestos
            // 
            this.buttonPromedioTotalPresupuestos.BackColor = System.Drawing.Color.Snow;
            this.buttonPromedioTotalPresupuestos.Location = new System.Drawing.Point(3, 58);
            this.buttonPromedioTotalPresupuestos.Name = "buttonPromedioTotalPresupuestos";
            this.buttonPromedioTotalPresupuestos.Size = new System.Drawing.Size(279, 42);
            this.buttonPromedioTotalPresupuestos.TabIndex = 1;
            this.buttonPromedioTotalPresupuestos.Text = "Promedio total presupuestos";
            this.buttonPromedioTotalPresupuestos.UseVisualStyleBackColor = false;
            this.buttonPromedioTotalPresupuestos.Click += new System.EventHandler(this.buttonPromedioTotalPresupuestos_Click);
            // 
            // buttonRepuestoMasUsado
            // 
            this.buttonRepuestoMasUsado.BackColor = System.Drawing.Color.Snow;
            this.buttonRepuestoMasUsado.Location = new System.Drawing.Point(3, 3);
            this.buttonRepuestoMasUsado.Name = "buttonRepuestoMasUsado";
            this.buttonRepuestoMasUsado.Size = new System.Drawing.Size(208, 42);
            this.buttonRepuestoMasUsado.TabIndex = 0;
            this.buttonRepuestoMasUsado.Text = "Repuesto mas usado";
            this.buttonRepuestoMasUsado.UseVisualStyleBackColor = false;
            this.buttonRepuestoMasUsado.Click += new System.EventHandler(this.buttonRepuestoMasUsado_Click);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.labelOutputServicios);
            this.panel18.Controls.Add(this.dgvOutputServicios);
            this.panel18.Location = new System.Drawing.Point(535, 6);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(314, 503);
            this.panel18.TabIndex = 0;
            // 
            // labelOutputServicios
            // 
            this.labelOutputServicios.AutoSize = true;
            this.labelOutputServicios.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutputServicios.Location = new System.Drawing.Point(111, 13);
            this.labelOutputServicios.Name = "labelOutputServicios";
            this.labelOutputServicios.Size = new System.Drawing.Size(98, 26);
            this.labelOutputServicios.TabIndex = 9;
            this.labelOutputServicios.Text = "Output";
            // 
            // dgvOutputServicios
            // 
            this.dgvOutputServicios.AllowUserToAddRows = false;
            this.dgvOutputServicios.AllowUserToDeleteRows = false;
            this.dgvOutputServicios.AllowUserToOrderColumns = true;
            this.dgvOutputServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutputServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputServicios.Location = new System.Drawing.Point(3, 51);
            this.dgvOutputServicios.Name = "dgvOutputServicios";
            this.dgvOutputServicios.ReadOnly = true;
            this.dgvOutputServicios.RowHeadersWidth = 50;
            this.dgvOutputServicios.RowTemplate.Height = 28;
            this.dgvOutputServicios.Size = new System.Drawing.Size(309, 449);
            this.dgvOutputServicios.TabIndex = 0;
            this.dgvOutputServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutputServicios_CellContentClick);
            // 
            // Inicio
            // 
            this.AccessibleDescription = "Aplicación que modela un sistema de presupuestos para reparaciones de un taller m" +
    "ecánico.";
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(858, 557);
            this.Controls.Add(this.tabControlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Text = "Taller Mecánico";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.tabPageRepuestos.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPageDesperfectos.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesperfectos)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPresupuestacion.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabABM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectorTipoVehículo.ResumeLayout(false);
            this.tabAutomóvil.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMoto.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabVehiculos.ResumeLayout(false);
            this.tabVehiculos.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPresupuestos.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresupuestos)).EndInit();
            this.tabServicios.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtMarca;

        public Inicio(Label txtMarca, Label txtModelo, Label txtPatente)
        {
            this.txtMarca = txtMarca;
            this.txtModelo = txtModelo;
            this.txtPatente = txtPatente;
            this.CHK = new DataGridViewCheckBoxColumn();
        }

        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.Label txtPatente;
        private ErrorProvider error;
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private masterDataSet masterDataSet;
        private BindingSource repuestoBindingSource;
        private masterDataSetTableAdapters.RepuestoTableAdapter repuestoTableAdapter;
        private BindingSource repuestoBindingSource1;
        private TabControl tabControlPrincipal;
        private TabPage tabVehiculos;
        private Button Diagnose;
        private CheckBox chkSelect;
        private Button btEliminar;
        private Button btnBuscador;
        private TextBox txtBuscar;
        private Label labelTotal;
        private DataGridView dgvDatos;
        private TabPage tabABM;
        private Panel panel1;
        private Button btnCancelarInserción;
        private Button btnActualizarVehículo;
        private Button btInsertarVehículo;
        private TextBox textBxPatente;
        private TextBox textBxModelo;
        private TextBox textBxMarca;
        private TextBox textBxIdVehículo;
        private TabControl selectorTipoVehículo;
        private TabPage tabAutomóvil;
        private Panel panel2;
        private ComboBox ElComboTipoAutomovil;
        private TextBox textPuertas;
        private TextBox textBxIdAutomóvil;
        private Label etiquetaTipo;
        private Label etiquetaPuertasAutomóvil;
        private Label etiquetaIdAutomóvil;
        private TabPage tabMoto;
        private Panel panel3;
        private TextBox textBxCilindrada;
        private TextBox textBxIdMoto;
        private Label etiquetaCilindrada;
        private Label etiquetaIdMoto;
        private Label etiquetaPatente;
        private Label etiquetaModelo;
        private Label etiquetaMarca;
        private Label etiquetaIdVehiculo;
        private TabPage tabPageDesperfectos;
        private Panel panel14;
        private Button buttonPresupuestar;
        private Panel panel13;
        private Label label1;
        private Label labelInfoContexto;
        private Label labelSeleccionDesperfectos;
        private Panel panel8;
        private GrillaDesperfectos dataGridViewDesperfectos;
        private DataGridViewCheckBoxColumn SeleccionarDesperfecto;
        private DataGridViewTextBoxColumn RE;
        private DataGridViewTextBoxColumn RF;
        private Label labelDesperfectosAsignados;
        private Panel panel7;
        private Button buttonCancelarDesperfecto;
        private Button buttonAgregarDesperfecto;
        private TextBox textBoxDesperfectoTiempo;
        private TextBox textBoxDesperfectoManoDeObra;
        private TextBox textBoxDesperfectoDescripcion;
        private Label labelDesperfectoTiempo;
        private Label labelDesperfectoManoDeObra;
        private Label labelDescripcionDesperfecto;
        private Label labelNuevoDesperfecto;
        private TabPage tabPageRepuestos;
        private Panel panel15;
        private TextBox textBox1;
        private Panel panel12;
        private Button buttonRegresarMenuDesperfectos;
        private Button buttonAgregarRepuestosDesperfecto;
        private Panel panel11;
        private ComboBox comboBoxRepuestosExistentes;
        private Button button6;
        private Label labelNombreRepuestoExistente;
        private Label labelSeleccionarRepuestoExistente;
        private Panel panel10;
        private DataGridView dgvRepuestos;
        private DataGridViewCheckBoxColumn Sel;
        private Label labelRapuestosAsignados;
        private Panel panel9;
        private Button button5;
        private TextBox textBoxPrecioNuevoRepuesto;
        private TextBox textBoxNombreNuevoRepuesto;
        private Label labelPrecioRepuesto;
        private Label labelNombreRepuesto;
        private Label labelAgregarNuevoRepuesto;
        private TabPage tabPresupuestacion;
        private Panel panel6;
        private TextBox TotalPresupuestoConsumidor;
        private Label labelTotalConsumidor;
        private TextBox txRepuestosTotal;
        private Label labelCostoRepuestos;
        private Button button4;
        private Button button3;
        private TextBox txBoxEstacionamiento;
        private TextBox txManoDeObra;
        private TextBox txBoxDescuento;
        private TextBox txBoxRecargo;
        private Label labelCostoEstacionamiento;
        private Label labelManoDeObra;
        private Label labelDescuento;
        private Label label12;
        private TextBox txBoxEmail;
        private TextBox txBoxApellido;
        private TextBox txBoxNombre;
        private Label label11;
        private Label label8;
        private Label label7;
        private TextBox textBoxSubTotal;
        private Label labelSubTotal;
        private TextBox textBoxTiempoTotal;
        private Label labelTiempoTotal;
        private Panel panel5;
        private Panel panel16;
        private Label labelDesperfecto;
        private TabPage tabPresupuestos;
        private TabPage tabServicios;
        private Panel panel17;
        private DataGridView dataGridViewPresupuestos;
        private TextBox textBox2;
        private Button buttonABM;
        private Button buttonListarPresupuestos;
        private DateTimePicker Reloj;
        private Panel panel19;
        private Button button1;
        private Button buttonSumatoriaTotalPresupuestos;
        private Button buttonPromedioTotalPresupuestos;
        private Button buttonRepuestoMasUsado;
        private Panel panel18;
        private Label labelServicioModelo;
        private TextBox textBoxServicioMarcaModelo;
        private Label labelOutputServicios;
        private DataGridView dgvOutputServicios;
        private TextBox textBoxServiciosMasivos;
        private TextBox textBoxServiciosBasicos;
        private ComboBox comboBoxServicioTipo;
        private Label label2;
        private Panel panel20;
        private DataGridViewCheckBoxColumn CHK;
        private Panel panel4;
        private TextBox textBox3;

        public Label TxtModelo { get => txtModelo; set => txtModelo = value; }
    }
}