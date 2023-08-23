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
            this.repuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new CapaPresentación.masterDataSet();
            this.repuestoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.repuestoTableAdapter = new CapaPresentación.masterDataSetTableAdapters.RepuestoTableAdapter();
            this.tabPageRepuestos = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.labelAgregarNuevoRepuesto = new System.Windows.Forms.Label();
            this.labelNombreRepuesto = new System.Windows.Forms.Label();
            this.labelPrecioRepuesto = new System.Windows.Forms.Label();
            this.textBoxNombreNuevoRepuesto = new System.Windows.Forms.TextBox();
            this.textBoxPrecioNuevoRepuesto = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.labelRapuestosAsignados = new System.Windows.Forms.Label();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel11 = new System.Windows.Forms.Panel();
            this.labelSeleccionarRepuestoExistente = new System.Windows.Forms.Label();
            this.labelNombreRepuestoExistente = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBoxRepuestosExistentes = new System.Windows.Forms.ComboBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.buttonAgregarRepuestosDesperfecto = new System.Windows.Forms.Button();
            this.buttonRegresarMenuDesperfectos = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageDesperfectos = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelNuevoDesperfecto = new System.Windows.Forms.Label();
            this.labelDescripcionDesperfecto = new System.Windows.Forms.Label();
            this.labelDesperfectoManoDeObra = new System.Windows.Forms.Label();
            this.labelDesperfectoTiempo = new System.Windows.Forms.Label();
            this.textBoxDesperfectoDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxDesperfectoManoDeObra = new System.Windows.Forms.TextBox();
            this.textBoxDesperfectoTiempo = new System.Windows.Forms.TextBox();
            this.buttonAgregarDesperfecto = new System.Windows.Forms.Button();
            this.buttonCancelarDesperfecto = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelDesperfectosAsignados = new System.Windows.Forms.Label();
            this.dataGridViewDesperfectos = new CapaPresentación.GrillaDesperfectos();
            this.RF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarDesperfecto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel13 = new System.Windows.Forms.Panel();
            this.labelSeleccionDesperfectos = new System.Windows.Forms.Label();
            this.labelInfoContexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonPresupuestar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txBoxNombre = new System.Windows.Forms.TextBox();
            this.txBoxApellido = new System.Windows.Forms.TextBox();
            this.txBoxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txBoxRecargo = new System.Windows.Forms.TextBox();
            this.txBoxDescuento = new System.Windows.Forms.TextBox();
            this.txManoDeObra = new System.Windows.Forms.TextBox();
            this.txBoxEstacionamiento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txRepuestosTotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalPresupuesto = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.etiquetaIdVehiculo = new System.Windows.Forms.Label();
            this.etiquetaMarca = new System.Windows.Forms.Label();
            this.etiquetaModelo = new System.Windows.Forms.Label();
            this.etiquetaPatente = new System.Windows.Forms.Label();
            this.selectorTipoVehículo = new System.Windows.Forms.TabControl();
            this.tabMoto = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.etiquetaIdMoto = new System.Windows.Forms.Label();
            this.etiquetaCilindrada = new System.Windows.Forms.Label();
            this.textBxIdMoto = new System.Windows.Forms.TextBox();
            this.textBxCilindrada = new System.Windows.Forms.TextBox();
            this.tabAutomóvil = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.etiquetaIdAutomóvil = new System.Windows.Forms.Label();
            this.etiquetaPuertasAutomóvil = new System.Windows.Forms.Label();
            this.etiquetaTipo = new System.Windows.Forms.Label();
            this.textBxIdAutomóvil = new System.Windows.Forms.TextBox();
            this.textPuertas = new System.Windows.Forms.TextBox();
            this.ElComboTipoAutomovil = new System.Windows.Forms.ComboBox();
            this.textBxIdVehículo = new System.Windows.Forms.TextBox();
            this.textBxMarca = new System.Windows.Forms.TextBox();
            this.textBxModelo = new System.Windows.Forms.TextBox();
            this.textBxPatente = new System.Windows.Forms.TextBox();
            this.btInsertarVehículo = new System.Windows.Forms.Button();
            this.btnActualizarVehículo = new System.Windows.Forms.Button();
            this.btnCancelarInserción = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btEliminar = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.Diagnose = new System.Windows.Forms.Button();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.tabPageRepuestos.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tabPageDesperfectos.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesperfectos)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.selectorTipoVehículo.SuspendLayout();
            this.tabMoto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabAutomóvil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControlPrincipal.SuspendLayout();
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
            this.tabPageRepuestos.Location = new System.Drawing.Point(4, 29);
            this.tabPageRepuestos.Name = "tabPageRepuestos";
            this.tabPageRepuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRepuestos.Size = new System.Drawing.Size(846, 514);
            this.tabPageRepuestos.TabIndex = 5;
            this.tabPageRepuestos.Text = "Repuestos";
            this.tabPageRepuestos.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button5);
            this.panel9.Controls.Add(this.textBoxPrecioNuevoRepuesto);
            this.panel9.Controls.Add(this.textBoxNombreNuevoRepuesto);
            this.panel9.Controls.Add(this.labelPrecioRepuesto);
            this.panel9.Controls.Add(this.labelNombreRepuesto);
            this.panel9.Controls.Add(this.labelAgregarNuevoRepuesto);
            this.panel9.Location = new System.Drawing.Point(7, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(206, 196);
            this.panel9.TabIndex = 1;
            // 
            // labelAgregarNuevoRepuesto
            // 
            this.labelAgregarNuevoRepuesto.AutoSize = true;
            this.labelAgregarNuevoRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarNuevoRepuesto.Location = new System.Drawing.Point(20, 10);
            this.labelAgregarNuevoRepuesto.Name = "labelAgregarNuevoRepuesto";
            this.labelAgregarNuevoRepuesto.Size = new System.Drawing.Size(168, 25);
            this.labelAgregarNuevoRepuesto.TabIndex = 0;
            this.labelAgregarNuevoRepuesto.Text = "Repuesto nuevo";
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
            // textBoxNombreNuevoRepuesto
            // 
            this.textBoxNombreNuevoRepuesto.Location = new System.Drawing.Point(80, 51);
            this.textBoxNombreNuevoRepuesto.Name = "textBoxNombreNuevoRepuesto";
            this.textBoxNombreNuevoRepuesto.Size = new System.Drawing.Size(108, 26);
            this.textBoxNombreNuevoRepuesto.TabIndex = 5;
            // 
            // textBoxPrecioNuevoRepuesto
            // 
            this.textBoxPrecioNuevoRepuesto.Location = new System.Drawing.Point(66, 100);
            this.textBoxPrecioNuevoRepuesto.Name = "textBoxPrecioNuevoRepuesto";
            this.textBoxPrecioNuevoRepuesto.Size = new System.Drawing.Size(122, 26);
            this.textBoxPrecioNuevoRepuesto.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 149);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 44);
            this.button5.TabIndex = 7;
            this.button5.Text = "Agregar nuevo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvRepuestos);
            this.panel10.Controls.Add(this.labelRapuestosAsignados);
            this.panel10.Location = new System.Drawing.Point(219, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(621, 440);
            this.panel10.TabIndex = 2;
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
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            this.dgvRepuestos.Location = new System.Drawing.Point(0, 51);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.ReadOnly = true;
            this.dgvRepuestos.RowHeadersWidth = 62;
            this.dgvRepuestos.RowTemplate.Height = 28;
            this.dgvRepuestos.Size = new System.Drawing.Size(607, 386);
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
            // panel11
            // 
            this.panel11.Controls.Add(this.comboBoxRepuestosExistentes);
            this.panel11.Controls.Add(this.button6);
            this.panel11.Controls.Add(this.labelNombreRepuestoExistente);
            this.panel11.Controls.Add(this.labelSeleccionarRepuestoExistente);
            this.panel11.Location = new System.Drawing.Point(7, 208);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(206, 152);
            this.panel11.TabIndex = 8;
            // 
            // labelSeleccionarRepuestoExistente
            // 
            this.labelSeleccionarRepuestoExistente.AutoSize = true;
            this.labelSeleccionarRepuestoExistente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionarRepuestoExistente.Location = new System.Drawing.Point(3, 9);
            this.labelSeleccionarRepuestoExistente.Name = "labelSeleccionarRepuestoExistente";
            this.labelSeleccionarRepuestoExistente.Size = new System.Drawing.Size(196, 25);
            this.labelSeleccionarRepuestoExistente.TabIndex = 0;
            this.labelSeleccionarRepuestoExistente.Text = "Repuesto existente";
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
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(25, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(157, 45);
            this.button6.TabIndex = 7;
            this.button6.Text = "Agregar existente";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBoxRepuestosExistentes
            // 
            this.comboBoxRepuestosExistentes.DataSource = this.repuestoBindingSource;
            this.comboBoxRepuestosExistentes.DisplayMember = "Nombre";
            this.comboBoxRepuestosExistentes.FormattingEnabled = true;
            this.comboBoxRepuestosExistentes.Location = new System.Drawing.Point(43, 50);
            this.comboBoxRepuestosExistentes.Name = "comboBoxRepuestosExistentes";
            this.comboBoxRepuestosExistentes.Size = new System.Drawing.Size(145, 28);
            this.comboBoxRepuestosExistentes.TabIndex = 8;
            this.comboBoxRepuestosExistentes.ValueMember = "Id";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.buttonRegresarMenuDesperfectos);
            this.panel12.Controls.Add(this.buttonAgregarRepuestosDesperfecto);
            this.panel12.Location = new System.Drawing.Point(7, 366);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(206, 139);
            this.panel12.TabIndex = 9;
            // 
            // buttonAgregarRepuestosDesperfecto
            // 
            this.buttonAgregarRepuestosDesperfecto.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAgregarRepuestosDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarRepuestosDesperfecto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAgregarRepuestosDesperfecto.Location = new System.Drawing.Point(25, 13);
            this.buttonAgregarRepuestosDesperfecto.Name = "buttonAgregarRepuestosDesperfecto";
            this.buttonAgregarRepuestosDesperfecto.Size = new System.Drawing.Size(157, 50);
            this.buttonAgregarRepuestosDesperfecto.TabIndex = 9;
            this.buttonAgregarRepuestosDesperfecto.Text = "Agregar repuestos al desperfecto";
            this.buttonAgregarRepuestosDesperfecto.UseVisualStyleBackColor = false;
            this.buttonAgregarRepuestosDesperfecto.Click += new System.EventHandler(this.buttonAgregarRepuestosDesperfecto_Click_1);
            // 
            // buttonRegresarMenuDesperfectos
            // 
            this.buttonRegresarMenuDesperfectos.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonRegresarMenuDesperfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegresarMenuDesperfectos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegresarMenuDesperfectos.Location = new System.Drawing.Point(25, 86);
            this.buttonRegresarMenuDesperfectos.Name = "buttonRegresarMenuDesperfectos";
            this.buttonRegresarMenuDesperfectos.Size = new System.Drawing.Size(157, 50);
            this.buttonRegresarMenuDesperfectos.TabIndex = 10;
            this.buttonRegresarMenuDesperfectos.Text = "Regresar Menú Desperfectos";
            this.buttonRegresarMenuDesperfectos.UseVisualStyleBackColor = false;
            this.buttonRegresarMenuDesperfectos.Click += new System.EventHandler(this.buttonRegresarMenuDesperfectos_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox1);
            this.panel15.Location = new System.Drawing.Point(219, 452);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(631, 62);
            this.panel15.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 53);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Es posible seleccionar repuestos existentes (desde el desplegable) o solicitar nu" +
    "evos repuestos (proveedor). Después de cargar los repuestos es necesario selecci" +
    "onarlos.";
            // 
            // tabPageDesperfectos
            // 
            this.tabPageDesperfectos.Controls.Add(this.panel14);
            this.tabPageDesperfectos.Controls.Add(this.panel13);
            this.tabPageDesperfectos.Controls.Add(this.panel8);
            this.tabPageDesperfectos.Controls.Add(this.panel7);
            this.tabPageDesperfectos.Location = new System.Drawing.Point(4, 29);
            this.tabPageDesperfectos.Name = "tabPageDesperfectos";
            this.tabPageDesperfectos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDesperfectos.Size = new System.Drawing.Size(846, 514);
            this.tabPageDesperfectos.TabIndex = 4;
            this.tabPageDesperfectos.Text = "Desperfectos";
            this.tabPageDesperfectos.UseVisualStyleBackColor = true;
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
            this.panel7.Location = new System.Drawing.Point(7, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(247, 349);
            this.panel7.TabIndex = 0;
            // 
            // labelNuevoDesperfecto
            // 
            this.labelNuevoDesperfecto.AutoSize = true;
            this.labelNuevoDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoDesperfecto.Location = new System.Drawing.Point(25, 11);
            this.labelNuevoDesperfecto.Name = "labelNuevoDesperfecto";
            this.labelNuevoDesperfecto.Size = new System.Drawing.Size(193, 25);
            this.labelNuevoDesperfecto.TabIndex = 0;
            this.labelNuevoDesperfecto.Text = "Nuevo desperfecto";
            // 
            // labelDescripcionDesperfecto
            // 
            this.labelDescripcionDesperfecto.AutoSize = true;
            this.labelDescripcionDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionDesperfecto.Location = new System.Drawing.Point(3, 75);
            this.labelDescripcionDesperfecto.Name = "labelDescripcionDesperfecto";
            this.labelDescripcionDesperfecto.Size = new System.Drawing.Size(115, 22);
            this.labelDescripcionDesperfecto.TabIndex = 1;
            this.labelDescripcionDesperfecto.Text = "Descripción";
            // 
            // labelDesperfectoManoDeObra
            // 
            this.labelDesperfectoManoDeObra.AutoSize = true;
            this.labelDesperfectoManoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectoManoDeObra.Location = new System.Drawing.Point(3, 220);
            this.labelDesperfectoManoDeObra.Name = "labelDesperfectoManoDeObra";
            this.labelDesperfectoManoDeObra.Size = new System.Drawing.Size(132, 22);
            this.labelDesperfectoManoDeObra.TabIndex = 2;
            this.labelDesperfectoManoDeObra.Text = "Mano de obra";
            // 
            // labelDesperfectoTiempo
            // 
            this.labelDesperfectoTiempo.AutoSize = true;
            this.labelDesperfectoTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectoTiempo.Location = new System.Drawing.Point(3, 264);
            this.labelDesperfectoTiempo.Name = "labelDesperfectoTiempo";
            this.labelDesperfectoTiempo.Size = new System.Drawing.Size(76, 22);
            this.labelDesperfectoTiempo.TabIndex = 3;
            this.labelDesperfectoTiempo.Text = "Tiempo";
            // 
            // textBoxDesperfectoDescripcion
            // 
            this.textBoxDesperfectoDescripcion.Location = new System.Drawing.Point(7, 109);
            this.textBoxDesperfectoDescripcion.Multiline = true;
            this.textBoxDesperfectoDescripcion.Name = "textBoxDesperfectoDescripcion";
            this.textBoxDesperfectoDescripcion.Size = new System.Drawing.Size(236, 95);
            this.textBoxDesperfectoDescripcion.TabIndex = 4;
            // 
            // textBoxDesperfectoManoDeObra
            // 
            this.textBoxDesperfectoManoDeObra.Location = new System.Drawing.Point(144, 216);
            this.textBoxDesperfectoManoDeObra.Name = "textBoxDesperfectoManoDeObra";
            this.textBoxDesperfectoManoDeObra.Size = new System.Drawing.Size(99, 26);
            this.textBoxDesperfectoManoDeObra.TabIndex = 5;
            // 
            // textBoxDesperfectoTiempo
            // 
            this.textBoxDesperfectoTiempo.Location = new System.Drawing.Point(144, 260);
            this.textBoxDesperfectoTiempo.Name = "textBoxDesperfectoTiempo";
            this.textBoxDesperfectoTiempo.Size = new System.Drawing.Size(99, 26);
            this.textBoxDesperfectoTiempo.TabIndex = 6;
            // 
            // buttonAgregarDesperfecto
            // 
            this.buttonAgregarDesperfecto.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAgregarDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarDesperfecto.Location = new System.Drawing.Point(141, 309);
            this.buttonAgregarDesperfecto.Name = "buttonAgregarDesperfecto";
            this.buttonAgregarDesperfecto.Size = new System.Drawing.Size(102, 40);
            this.buttonAgregarDesperfecto.TabIndex = 7;
            this.buttonAgregarDesperfecto.Text = "Agregar";
            this.buttonAgregarDesperfecto.UseVisualStyleBackColor = false;
            this.buttonAgregarDesperfecto.Click += new System.EventHandler(this.buttonAgregarDesperfecto_Click);
            // 
            // buttonCancelarDesperfecto
            // 
            this.buttonCancelarDesperfecto.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonCancelarDesperfecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarDesperfecto.Location = new System.Drawing.Point(7, 309);
            this.buttonCancelarDesperfecto.Name = "buttonCancelarDesperfecto";
            this.buttonCancelarDesperfecto.Size = new System.Drawing.Size(128, 40);
            this.buttonCancelarDesperfecto.TabIndex = 8;
            this.buttonCancelarDesperfecto.Text = "Regresar Vehículos";
            this.buttonCancelarDesperfecto.UseVisualStyleBackColor = false;
            this.buttonCancelarDesperfecto.Click += new System.EventHandler(this.buttonCancelarDesperfecto_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridViewDesperfectos);
            this.panel8.Controls.Add(this.labelDesperfectosAsignados);
            this.panel8.Location = new System.Drawing.Point(260, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(580, 436);
            this.panel8.TabIndex = 1;
            // 
            // labelDesperfectosAsignados
            // 
            this.labelDesperfectosAsignados.AutoSize = true;
            this.labelDesperfectosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesperfectosAsignados.Location = new System.Drawing.Point(3, 0);
            this.labelDesperfectosAsignados.Name = "labelDesperfectosAsignados";
            this.labelDesperfectosAsignados.Size = new System.Drawing.Size(244, 25);
            this.labelDesperfectosAsignados.TabIndex = 1;
            this.labelDesperfectosAsignados.Text = "Desperfectos asignados";
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
            this.dataGridViewDesperfectos.Location = new System.Drawing.Point(8, 51);
            this.dataGridViewDesperfectos.Name = "dataGridViewDesperfectos";
            this.dataGridViewDesperfectos.RowHeadersWidth = 62;
            this.dataGridViewDesperfectos.RowTemplate.Height = 28;
            this.dataGridViewDesperfectos.Size = new System.Drawing.Size(569, 382);
            this.dataGridViewDesperfectos.TabIndex = 2;
            this.dataGridViewDesperfectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDesperfectos_CellContentClick);
            this.dataGridViewDesperfectos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDesperfectos_CellDoubleClick);
            // 
            // RF
            // 
            this.RF.HeaderText = "RF (i)";
            this.RF.MinimumWidth = 8;
            this.RF.Name = "RF";
            this.RF.ToolTipText = "Repuestos en espera de proveedor";
            this.RF.Width = 150;
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
            // SeleccionarDesperfecto
            // 
            this.SeleccionarDesperfecto.HeaderText = "Sel";
            this.SeleccionarDesperfecto.MinimumWidth = 8;
            this.SeleccionarDesperfecto.Name = "SeleccionarDesperfecto";
            this.SeleccionarDesperfecto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarDesperfecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeleccionarDesperfecto.Width = 150;
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
            // labelSeleccionDesperfectos
            // 
            this.labelSeleccionDesperfectos.AutoSize = true;
            this.labelSeleccionDesperfectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeleccionDesperfectos.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelSeleccionDesperfectos.Location = new System.Drawing.Point(0, 0);
            this.labelSeleccionDesperfectos.Name = "labelSeleccionDesperfectos";
            this.labelSeleccionDesperfectos.Size = new System.Drawing.Size(240, 22);
            this.labelSeleccionDesperfectos.TabIndex = 3;
            this.labelSeleccionDesperfectos.Text = "1°: agregar los desperfectos.";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(249, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "2°: doble clic en cada desperfecto para seleccionar repuestos.";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonPresupuestar);
            this.panel14.Location = new System.Drawing.Point(3, 361);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(253, 81);
            this.panel14.TabIndex = 3;
            // 
            // buttonPresupuestar
            // 
            this.buttonPresupuestar.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPresupuestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresupuestar.Location = new System.Drawing.Point(34, 3);
            this.buttonPresupuestar.Name = "buttonPresupuestar";
            this.buttonPresupuestar.Size = new System.Drawing.Size(188, 72);
            this.buttonPresupuestar.TabIndex = 9;
            this.buttonPresupuestar.Text = "Confirma Presupuesto";
            this.buttonPresupuestar.UseVisualStyleBackColor = false;
            this.buttonPresupuestar.Click += new System.EventHandler(this.buttonPresupuestar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(846, 514);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Presupuestación";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TotalPresupuesto);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.txRepuestosTotal);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.button4);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.txBoxEstacionamiento);
            this.panel6.Controls.Add(this.txManoDeObra);
            this.panel6.Controls.Add(this.txBoxDescuento);
            this.panel6.Controls.Add(this.txBoxRecargo);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txBoxEmail);
            this.panel6.Controls.Add(this.txBoxApellido);
            this.panel6.Controls.Add(this.txBoxNombre);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(7, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(833, 451);
            this.panel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // txBoxNombre
            // 
            this.txBoxNombre.Location = new System.Drawing.Point(143, 23);
            this.txBoxNombre.Name = "txBoxNombre";
            this.txBoxNombre.Size = new System.Drawing.Size(262, 26);
            this.txBoxNombre.TabIndex = 11;
            // 
            // txBoxApellido
            // 
            this.txBoxApellido.Location = new System.Drawing.Point(143, 88);
            this.txBoxApellido.Name = "txBoxApellido";
            this.txBoxApellido.Size = new System.Drawing.Size(262, 26);
            this.txBoxApellido.TabIndex = 12;
            // 
            // txBoxEmail
            // 
            this.txBoxEmail.Location = new System.Drawing.Point(143, 151);
            this.txBoxEmail.Name = "txBoxEmail";
            this.txBoxEmail.Size = new System.Drawing.Size(262, 26);
            this.txBoxEmail.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(444, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "% recargo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(444, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "% descuento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(444, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "$ mano de obra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(444, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(246, 29);
            this.label15.TabIndex = 17;
            this.label15.Text = "$ parking ($130/día)";
            // 
            // txBoxRecargo
            // 
            this.txBoxRecargo.Location = new System.Drawing.Point(647, 26);
            this.txBoxRecargo.Name = "txBoxRecargo";
            this.txBoxRecargo.Size = new System.Drawing.Size(170, 26);
            this.txBoxRecargo.TabIndex = 18;
            // 
            // txBoxDescuento
            // 
            this.txBoxDescuento.Location = new System.Drawing.Point(647, 84);
            this.txBoxDescuento.Name = "txBoxDescuento";
            this.txBoxDescuento.Size = new System.Drawing.Size(170, 26);
            this.txBoxDescuento.TabIndex = 19;
            // 
            // txManoDeObra
            // 
            this.txManoDeObra.Location = new System.Drawing.Point(647, 155);
            this.txManoDeObra.Name = "txManoDeObra";
            this.txManoDeObra.Size = new System.Drawing.Size(168, 26);
            this.txManoDeObra.TabIndex = 20;
            // 
            // txBoxEstacionamiento
            // 
            this.txBoxEstacionamiento.Location = new System.Drawing.Point(647, 219);
            this.txBoxEstacionamiento.Name = "txBoxEstacionamiento";
            this.txBoxEstacionamiento.Size = new System.Drawing.Size(168, 26);
            this.txBoxEstacionamiento.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DeepPink;
            this.button3.Location = new System.Drawing.Point(657, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 57);
            this.button3.TabIndex = 19;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Lime;
            this.button4.Location = new System.Drawing.Point(0, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Confirma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(444, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 29);
            this.label16.TabIndex = 23;
            this.label16.Text = "$ repuestos";
            // 
            // txRepuestosTotal
            // 
            this.txRepuestosTotal.Location = new System.Drawing.Point(647, 280);
            this.txRepuestosTotal.Name = "txRepuestosTotal";
            this.txRepuestosTotal.Size = new System.Drawing.Size(168, 26);
            this.txRepuestosTotal.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(444, 343);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 29);
            this.label17.TabIndex = 25;
            this.label17.Text = "Total";
            // 
            // TotalPresupuesto
            // 
            this.TotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPresupuesto.Location = new System.Drawing.Point(647, 346);
            this.TotalPresupuesto.Name = "TotalPresupuesto";
            this.TotalPresupuesto.Size = new System.Drawing.Size(168, 26);
            this.TotalPresupuesto.TabIndex = 26;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 514);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Mantenimiento";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(833, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel3.Controls.Add(this.textBxCilindrada);
            this.panel3.Controls.Add(this.textBxIdMoto);
            this.panel3.Controls.Add(this.etiquetaCilindrada);
            this.panel3.Controls.Add(this.etiquetaIdMoto);
            this.panel3.Location = new System.Drawing.Point(3, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 293);
            this.panel3.TabIndex = 0;
            // 
            // etiquetaIdMoto
            // 
            this.etiquetaIdMoto.AutoSize = true;
            this.etiquetaIdMoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIdMoto.Location = new System.Drawing.Point(14, 17);
            this.etiquetaIdMoto.Name = "etiquetaIdMoto";
            this.etiquetaIdMoto.Size = new System.Drawing.Size(100, 29);
            this.etiquetaIdMoto.TabIndex = 6;
            this.etiquetaIdMoto.Text = "Id Moto";
            // 
            // etiquetaCilindrada
            // 
            this.etiquetaCilindrada.AutoSize = true;
            this.etiquetaCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaCilindrada.Location = new System.Drawing.Point(14, 89);
            this.etiquetaCilindrada.Name = "etiquetaCilindrada";
            this.etiquetaCilindrada.Size = new System.Drawing.Size(133, 29);
            this.etiquetaCilindrada.TabIndex = 7;
            this.etiquetaCilindrada.Text = "Cilindrada";
            // 
            // textBxIdMoto
            // 
            this.textBxIdMoto.Location = new System.Drawing.Point(244, 17);
            this.textBxIdMoto.Name = "textBxIdMoto";
            this.textBxIdMoto.Size = new System.Drawing.Size(168, 28);
            this.textBxIdMoto.TabIndex = 8;
            // 
            // textBxCilindrada
            // 
            this.textBxCilindrada.Location = new System.Drawing.Point(244, 93);
            this.textBxCilindrada.Name = "textBxCilindrada";
            this.textBxCilindrada.Size = new System.Drawing.Size(168, 28);
            this.textBxCilindrada.TabIndex = 9;
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
            // etiquetaIdAutomóvil
            // 
            this.etiquetaIdAutomóvil.AutoSize = true;
            this.etiquetaIdAutomóvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaIdAutomóvil.Location = new System.Drawing.Point(3, 17);
            this.etiquetaIdAutomóvil.Name = "etiquetaIdAutomóvil";
            this.etiquetaIdAutomóvil.Size = new System.Drawing.Size(156, 29);
            this.etiquetaIdAutomóvil.TabIndex = 5;
            this.etiquetaIdAutomóvil.Text = "Id Automóvil";
            // 
            // etiquetaPuertasAutomóvil
            // 
            this.etiquetaPuertasAutomóvil.AutoSize = true;
            this.etiquetaPuertasAutomóvil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPuertasAutomóvil.Location = new System.Drawing.Point(3, 76);
            this.etiquetaPuertasAutomóvil.Name = "etiquetaPuertasAutomóvil";
            this.etiquetaPuertasAutomóvil.Size = new System.Drawing.Size(102, 29);
            this.etiquetaPuertasAutomóvil.TabIndex = 6;
            this.etiquetaPuertasAutomóvil.Text = "Puertas";
            // 
            // etiquetaTipo
            // 
            this.etiquetaTipo.AutoSize = true;
            this.etiquetaTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTipo.Location = new System.Drawing.Point(3, 165);
            this.etiquetaTipo.Name = "etiquetaTipo";
            this.etiquetaTipo.Size = new System.Drawing.Size(67, 29);
            this.etiquetaTipo.TabIndex = 8;
            this.etiquetaTipo.Text = "Tipo";
            // 
            // textBxIdAutomóvil
            // 
            this.textBxIdAutomóvil.Location = new System.Drawing.Point(233, 21);
            this.textBxIdAutomóvil.Name = "textBxIdAutomóvil";
            this.textBxIdAutomóvil.Size = new System.Drawing.Size(168, 28);
            this.textBxIdAutomóvil.TabIndex = 14;
            // 
            // textPuertas
            // 
            this.textPuertas.Location = new System.Drawing.Point(233, 80);
            this.textPuertas.Name = "textPuertas";
            this.textPuertas.Size = new System.Drawing.Size(168, 28);
            this.textPuertas.TabIndex = 15;
            // 
            // ElComboTipoAutomovil
            // 
            this.ElComboTipoAutomovil.FormattingEnabled = true;
            this.ElComboTipoAutomovil.Items.AddRange(new object[] {
            "compacto",
            "sedan",
            "monovolumen",
            "utilitario",
            "lujo"});
            this.ElComboTipoAutomovil.Location = new System.Drawing.Point(233, 169);
            this.ElComboTipoAutomovil.Name = "ElComboTipoAutomovil";
            this.ElComboTipoAutomovil.Size = new System.Drawing.Size(159, 30);
            this.ElComboTipoAutomovil.TabIndex = 16;
            this.ElComboTipoAutomovil.Text = "compacto";
            this.ElComboTipoAutomovil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBxIdVehículo
            // 
            this.textBxIdVehículo.Location = new System.Drawing.Point(199, 59);
            this.textBxIdVehículo.Name = "textBxIdVehículo";
            this.textBxIdVehículo.Size = new System.Drawing.Size(168, 28);
            this.textBxIdVehículo.TabIndex = 10;
            // 
            // textBxMarca
            // 
            this.textBxMarca.Location = new System.Drawing.Point(199, 127);
            this.textBxMarca.Name = "textBxMarca";
            this.textBxMarca.Size = new System.Drawing.Size(168, 28);
            this.textBxMarca.TabIndex = 11;
            // 
            // textBxModelo
            // 
            this.textBxModelo.Location = new System.Drawing.Point(199, 203);
            this.textBxModelo.Name = "textBxModelo";
            this.textBxModelo.Size = new System.Drawing.Size(168, 28);
            this.textBxModelo.TabIndex = 12;
            // 
            // textBxPatente
            // 
            this.textBxPatente.Location = new System.Drawing.Point(199, 282);
            this.textBxPatente.Name = "textBxPatente";
            this.textBxPatente.Size = new System.Drawing.Size(168, 28);
            this.textBxPatente.TabIndex = 13;
            // 
            // btInsertarVehículo
            // 
            this.btInsertarVehículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertarVehículo.ForeColor = System.Drawing.Color.Lime;
            this.btInsertarVehículo.Location = new System.Drawing.Point(33, 388);
            this.btInsertarVehículo.Name = "btInsertarVehículo";
            this.btInsertarVehículo.Size = new System.Drawing.Size(146, 57);
            this.btInsertarVehículo.TabIndex = 14;
            this.btInsertarVehículo.Text = "Ingresar";
            this.btInsertarVehículo.UseVisualStyleBackColor = true;
            this.btInsertarVehículo.Click += new System.EventHandler(this.btInsertarVehículo_Click_1);
            // 
            // btnActualizarVehículo
            // 
            this.btnActualizarVehículo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarVehículo.ForeColor = System.Drawing.Color.Lime;
            this.btnActualizarVehículo.Location = new System.Drawing.Point(199, 388);
            this.btnActualizarVehículo.Name = "btnActualizarVehículo";
            this.btnActualizarVehículo.Size = new System.Drawing.Size(176, 57);
            this.btnActualizarVehículo.TabIndex = 15;
            this.btnActualizarVehículo.Text = "Actualizar";
            this.btnActualizarVehículo.UseVisualStyleBackColor = true;
            this.btnActualizarVehículo.Click += new System.EventHandler(this.btnActualizarVehículo_Click);
            // 
            // btnCancelarInserción
            // 
            this.btnCancelarInserción.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarInserción.ForeColor = System.Drawing.Color.DeepPink;
            this.btnCancelarInserción.Location = new System.Drawing.Point(631, 388);
            this.btnCancelarInserción.Name = "btnCancelarInserción";
            this.btnCancelarInserción.Size = new System.Drawing.Size(176, 57);
            this.btnCancelarInserción.TabIndex = 16;
            this.btnCancelarInserción.Text = "Cancelar";
            this.btnCancelarInserción.UseVisualStyleBackColor = true;
            this.btnCancelarInserción.Click += new System.EventHandler(this.btnCancelarInserción_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.btnBuscador);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.dgvDatos);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_2);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDatos.ColumnHeadersHeight = 34;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvDatos.Location = new System.Drawing.Point(3, 89);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 30;
            this.dgvDatos.RowTemplate.Height = 23;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(712, 418);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // Select
            // 
            this.Select.FalseValue = "";
            this.Select.HeaderText = "Select";
            this.Select.IndeterminateValue = "";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.TrueValue = "";
            this.Select.Width = 150;
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(42, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(290, 28);
            this.txtBuscar.TabIndex = 2;
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(637, 23);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(170, 39);
            this.btnBuscador.TabIndex = 3;
            this.btnBuscador.Text = "Buscar";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.Diagnose);
            this.panel4.Controls.Add(this.chkSelect);
            this.panel4.Controls.Add(this.btEliminar);
            this.panel4.Location = new System.Drawing.Point(721, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 418);
            this.panel4.TabIndex = 4;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(5, 117);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(118, 36);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelect.Location = new System.Drawing.Point(5, 13);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(118, 24);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Seleccionar";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // Diagnose
            // 
            this.Diagnose.Location = new System.Drawing.Point(5, 63);
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Size = new System.Drawing.Size(118, 35);
            this.Diagnose.TabIndex = 5;
            this.Diagnose.Text = "Dignosticar";
            this.Diagnose.UseVisualStyleBackColor = true;
            this.Diagnose.Click += new System.EventHandler(this.Activate_Click);
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage3);
            this.tabControlPrincipal.Controls.Add(this.tabPageDesperfectos);
            this.tabControlPrincipal.Controls.Add(this.tabPageRepuestos);
            this.tabControlPrincipal.Controls.Add(this.tabPage5);
            this.tabControlPrincipal.Location = new System.Drawing.Point(1, 12);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(854, 547);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.tabControlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Taller Mecánico";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repuestoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.tabPageRepuestos.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tabPageDesperfectos.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesperfectos)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectorTipoVehículo.ResumeLayout(false);
            this.tabMoto.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabAutomóvil.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControlPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtMarca;

        public Inicio(Label txtMarca, Label txtModelo, Label txtPatente)
        {
            this.txtMarca = txtMarca;
            this.txtModelo = txtModelo;
            this.txtPatente = txtPatente;
            this.Select = new DataGridViewCheckBoxColumn();
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
        private TabPage tabPage1;
        private Panel panel4;
        private Button Diagnose;
        private CheckBox chkSelect;
        private Button btEliminar;
        private Button btnBuscador;
        private TextBox txtBuscar;
        private Label labelTotal;
        private DataGridView dgvDatos;
        private new DataGridViewCheckBoxColumn Select;
        private TabPage tabPage3;
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
        private TabPage tabPage5;
        private Panel panel6;
        private TextBox TotalPresupuesto;
        private Label label17;
        private TextBox txRepuestosTotal;
        private Label label16;
        private Button button4;
        private Button button3;
        private TextBox txBoxEstacionamiento;
        private TextBox txManoDeObra;
        private TextBox txBoxDescuento;
        private TextBox txBoxRecargo;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox txBoxEmail;
        private TextBox txBoxApellido;
        private TextBox txBoxNombre;
        private Label label11;
        private Label label8;
        private Label label7;

        public Label TxtModelo { get => txtModelo; set => txtModelo = value; }
    }
}