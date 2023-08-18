
using CapaModelo;
using System;
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Diagnose = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.btnPresupuestar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDesperfectos = new System.Windows.Forms.DataGridView();
            this.SelectDesperfecto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TotalPresupuesto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txRepuestosTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txBoxEstacionamiento = new System.Windows.Forms.TextBox();
            this.txManoDeObra = new System.Windows.Forms.TextBox();
            this.txBoxDescuento = new System.Windows.Forms.TextBox();
            this.txBoxRecargo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txBoxEmail = new System.Windows.Forms.TextBox();
            this.txBoxApellido = new System.Windows.Forms.TextBox();
            this.txBoxNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.selectorTipoVehículo.SuspendLayout();
            this.tabAutomóvil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMoto.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesperfectos)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage3);
            this.tabControlPrincipal.Controls.Add(this.tabPage4);
            this.tabControlPrincipal.Controls.Add(this.tabPage5);
            this.tabControlPrincipal.Location = new System.Drawing.Point(1, 12);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(854, 547);
            this.tabControlPrincipal.TabIndex = 0;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Diagnose);
            this.panel4.Controls.Add(this.chkSelect);
            this.panel4.Controls.Add(this.btnPresupuestar);
            this.panel4.Controls.Add(this.btEliminar);
            this.panel4.Location = new System.Drawing.Point(684, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 418);
            this.panel4.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "doble click to update";
            // 
            // Diagnose
            // 
            this.Diagnose.Location = new System.Drawing.Point(21, 130);
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Size = new System.Drawing.Size(135, 25);
            this.Diagnose.TabIndex = 5;
            this.Diagnose.Text = "Dignosticar";
            this.Diagnose.UseVisualStyleBackColor = true;
            this.Diagnose.Click += new System.EventHandler(this.Activate_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelect.Location = new System.Drawing.Point(24, 38);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(118, 24);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Seleccionar";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // btnPresupuestar
            // 
            this.btnPresupuestar.Location = new System.Drawing.Point(21, 99);
            this.btnPresupuestar.Name = "btnPresupuestar";
            this.btnPresupuestar.Size = new System.Drawing.Size(135, 25);
            this.btnPresupuestar.TabIndex = 6;
            this.btnPresupuestar.Text = "Presupuestar";
            this.btnPresupuestar.UseVisualStyleBackColor = true;
            this.btnPresupuestar.Click += new System.EventHandler(this.btnPresupuestar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(21, 68);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(135, 25);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(42, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(290, 28);
            this.txtBuscar.TabIndex = 2;
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
            this.dgvDatos.ColumnHeadersHeight = 34;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dgvDatos.Location = new System.Drawing.Point(3, 89);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 30;
            this.dgvDatos.RowTemplate.Height = 23;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(675, 418);
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
            // textPuertas
            // 
            this.textPuertas.Location = new System.Drawing.Point(233, 80);
            this.textPuertas.Name = "textPuertas";
            this.textPuertas.Size = new System.Drawing.Size(168, 28);
            this.textPuertas.TabIndex = 15;
            // 
            // textBxIdAutomóvil
            // 
            this.textBxIdAutomóvil.Location = new System.Drawing.Point(233, 21);
            this.textBxIdAutomóvil.Name = "textBxIdAutomóvil";
            this.textBxIdAutomóvil.Size = new System.Drawing.Size(168, 28);
            this.textBxIdAutomóvil.TabIndex = 14;
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
            // textBxCilindrada
            // 
            this.textBxCilindrada.Location = new System.Drawing.Point(244, 93);
            this.textBxCilindrada.Name = "textBxCilindrada";
            this.textBxCilindrada.Size = new System.Drawing.Size(168, 28);
            this.textBxCilindrada.TabIndex = 9;
            // 
            // textBxIdMoto
            // 
            this.textBxIdMoto.Location = new System.Drawing.Point(244, 17);
            this.textBxIdMoto.Name = "textBxIdMoto";
            this.textBxIdMoto.Size = new System.Drawing.Size(168, 28);
            this.textBxIdMoto.TabIndex = 8;
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
            // etiquetaPatente
            // 
            this.etiquetaPatente.AutoSize = true;
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
            this.etiquetaModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaModelo.Location = new System.Drawing.Point(28, 203);
            this.etiquetaModelo.Name = "etiquetaModelo";
            this.etiquetaModelo.Size = new System.Drawing.Size(101, 29);
            this.etiquetaModelo.TabIndex = 2;
            this.etiquetaModelo.Text = "Modelo";
            this.etiquetaModelo.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // etiquetaMarca
            // 
            this.etiquetaMarca.AutoSize = true;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(846, 514);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Desperfectos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.dgvDesperfectos);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(6, 49);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(837, 456);
            this.panel5.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(416, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 57);
            this.button2.TabIndex = 20;
            this.button2.Text = "Presupuestar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDesperfectos
            // 
            this.dgvDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesperfectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectDesperfecto});
            this.dgvDesperfectos.Location = new System.Drawing.Point(3, 3);
            this.dgvDesperfectos.Name = "dgvDesperfectos";
            this.dgvDesperfectos.RowHeadersWidth = 62;
            this.dgvDesperfectos.RowTemplate.Height = 28;
            this.dgvDesperfectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesperfectos.Size = new System.Drawing.Size(831, 359);
            this.dgvDesperfectos.TabIndex = 19;
            this.dgvDesperfectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesperfectos_CellContentClick);
            // 
            // SelectDesperfecto
            // 
            this.SelectDesperfecto.FalseValue = "";
            this.SelectDesperfecto.HeaderText = "Select";
            this.SelectDesperfecto.IndeterminateValue = "";
            this.SelectDesperfecto.MinimumWidth = 8;
            this.SelectDesperfecto.Name = "SelectDesperfecto";
            this.SelectDesperfecto.TrueValue = "";
            this.SelectDesperfecto.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepPink;
            this.button1.Location = new System.Drawing.Point(644, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 57);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // TotalPresupuesto
            // 
            this.TotalPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPresupuesto.Location = new System.Drawing.Point(647, 346);
            this.TotalPresupuesto.Name = "TotalPresupuesto";
            this.TotalPresupuesto.Size = new System.Drawing.Size(168, 26);
            this.TotalPresupuesto.TabIndex = 26;
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
            // txRepuestosTotal
            // 
            this.txRepuestosTotal.Location = new System.Drawing.Point(647, 280);
            this.txRepuestosTotal.Name = "txRepuestosTotal";
            this.txRepuestosTotal.Size = new System.Drawing.Size(168, 26);
            this.txRepuestosTotal.TabIndex = 24;
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
            // txBoxEstacionamiento
            // 
            this.txBoxEstacionamiento.Location = new System.Drawing.Point(647, 219);
            this.txBoxEstacionamiento.Name = "txBoxEstacionamiento";
            this.txBoxEstacionamiento.Size = new System.Drawing.Size(168, 26);
            this.txBoxEstacionamiento.TabIndex = 21;
            // 
            // txManoDeObra
            // 
            this.txManoDeObra.Location = new System.Drawing.Point(647, 155);
            this.txManoDeObra.Name = "txManoDeObra";
            this.txManoDeObra.Size = new System.Drawing.Size(168, 26);
            this.txManoDeObra.TabIndex = 20;
            // 
            // txBoxDescuento
            // 
            this.txBoxDescuento.Location = new System.Drawing.Point(647, 84);
            this.txBoxDescuento.Name = "txBoxDescuento";
            this.txBoxDescuento.Size = new System.Drawing.Size(170, 26);
            this.txBoxDescuento.TabIndex = 19;
            // 
            // txBoxRecargo
            // 
            this.txBoxRecargo.Location = new System.Drawing.Point(647, 26);
            this.txBoxRecargo.Name = "txBoxRecargo";
            this.txBoxRecargo.Size = new System.Drawing.Size(170, 26);
            this.txBoxRecargo.TabIndex = 18;
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
            this.label15.Click += new System.EventHandler(this.label15_Click);
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
            // txBoxEmail
            // 
            this.txBoxEmail.Location = new System.Drawing.Point(143, 151);
            this.txBoxEmail.Name = "txBoxEmail";
            this.txBoxEmail.Size = new System.Drawing.Size(262, 26);
            this.txBoxEmail.TabIndex = 13;
            // 
            // txBoxApellido
            // 
            this.txBoxApellido.Location = new System.Drawing.Point(143, 88);
            this.txBoxApellido.Name = "txBoxApellido";
            this.txBoxApellido.Size = new System.Drawing.Size(262, 26);
            this.txBoxApellido.TabIndex = 12;
            // 
            // txBoxNombre
            // 
            this.txBoxNombre.Location = new System.Drawing.Point(143, 23);
            this.txBoxNombre.Name = "txBoxNombre";
            this.txBoxNombre.Size = new System.Drawing.Size(262, 26);
            this.txBoxNombre.TabIndex = 11;
            this.txBoxNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellido";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.tabControlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Taller Mecánico";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectorTipoVehículo.ResumeLayout(false);
            this.tabAutomóvil.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabMoto.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesperfectos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabVehiculo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.TextBox textBxModelo;
        private System.Windows.Forms.TextBox textBxMarca;
        private System.Windows.Forms.TextBox textBxIdVehículo;
        private System.Windows.Forms.TextBox textBxPatente;
        private System.Windows.Forms.Label txtPatente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btInsertarVehículo;
        private System.Windows.Forms.Button btnActualizarVehículo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox chkSeleccionarVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl selectorTipoVehículo;
        private System.Windows.Forms.TabPage tabAutomóvil;
        private System.Windows.Forms.TextBox textBxIdAutomóvil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPuertas;
        private System.Windows.Forms.TabPage tabPageMoto;
        private System.Windows.Forms.TextBox textBxCilindrada;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBxIdMoto;
        private System.Windows.Forms.Label label10;        
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscador;
        private TabPage tabPage3;
        private Panel panel1;
        private Label etiquetaIdVehiculo;
        private Label etiquetaMarca;
        private Label etiquetaModelo;
        private Label etiquetaPatente;
        private TabPage tabMoto;
        private Panel panel2;
        private Label etiquetaIdAutomóvil;
        private Label etiquetaPuertasAutomóvil;
        private Label etiquetaTipo;
        private Panel panel3;
        private Label etiquetaIdMoto;
        private Label etiquetaCilindrada;
        
        //private Button btnActualizarVehículo;
        private Button btnCancelarInserción;
        private ErrorProvider error;
        private CheckBox chkSelect;
        private Button btEliminar;
        private Button btnPresupuestar;
        private Button Diagnose;
        private ComboBox ElComboTipoAutomovil;
        private Panel panel4;
        private Label label6;
        private TabPage tabPage4;
        private Panel panel5;
        private Button button1;
        private DataGridView dgvDesperfectos;
        private Button button2;
        private TabPage tabPage5;
        private Panel panel6;
        private Label label11;
        private Label label8;
        private Label label7;
        private TextBox txBoxEmail;
        private TextBox txBoxApellido;
        private TextBox txBoxNombre;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button4;
        private Button button3;
        private TextBox txBoxEstacionamiento;
        private TextBox txManoDeObra;
        private TextBox txBoxDescuento;
        private TextBox txBoxRecargo;
        private TextBox TotalPresupuesto;
        private Label label17;
        private TextBox txRepuestosTotal;
        private Label label16;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewCheckBoxColumn SelectDesperfecto;
    }
}

