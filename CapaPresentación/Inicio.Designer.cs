
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
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btnPresupuestar = new System.Windows.Forms.Button();
            this.Diagnose = new System.Windows.Forms.Button();
            this.chkSelect = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.selectorTipoVehículo.SuspendLayout();
            this.tabAutomóvil.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabMoto.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPage1);
            this.tabControlPrincipal.Controls.Add(this.tabPage3);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_2);
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
            this.txtBuscar.Size = new System.Drawing.Size(290, 26);
            this.txtBuscar.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(1602, 938);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(44, 20);
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
            this.dgvDatos.Size = new System.Drawing.Size(687, 418);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick_1);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 8;
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 532);
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
            this.btInsertarVehículo.Size = new System.Drawing.Size(132, 57);
            this.btInsertarVehículo.TabIndex = 14;
            this.btInsertarVehículo.Text = "Insertar";
            this.btInsertarVehículo.UseVisualStyleBackColor = true;
            this.btInsertarVehículo.Click += new System.EventHandler(this.btInsertarVehículo_Click_1);
            // 
            // textBxPatente
            // 
            this.textBxPatente.Location = new System.Drawing.Point(199, 282);
            this.textBxPatente.Name = "textBxPatente";
            this.textBxPatente.Size = new System.Drawing.Size(168, 26);
            this.textBxPatente.TabIndex = 13;
            // 
            // textBxModelo
            // 
            this.textBxModelo.Location = new System.Drawing.Point(199, 203);
            this.textBxModelo.Name = "textBxModelo";
            this.textBxModelo.Size = new System.Drawing.Size(168, 26);
            this.textBxModelo.TabIndex = 12;
            // 
            // textBxMarca
            // 
            this.textBxMarca.Location = new System.Drawing.Point(199, 127);
            this.textBxMarca.Name = "textBxMarca";
            this.textBxMarca.Size = new System.Drawing.Size(168, 26);
            this.textBxMarca.TabIndex = 11;
            // 
            // textBxIdVehículo
            // 
            this.textBxIdVehículo.Location = new System.Drawing.Point(199, 59);
            this.textBxIdVehículo.Name = "textBxIdVehículo";
            this.textBxIdVehículo.Size = new System.Drawing.Size(168, 26);
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
            this.tabAutomóvil.Location = new System.Drawing.Point(4, 29);
            this.tabAutomóvil.Name = "tabAutomóvil";
            this.tabAutomóvil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAutomóvil.Size = new System.Drawing.Size(434, 305);
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
            this.ElComboTipoAutomovil.Size = new System.Drawing.Size(159, 28);
            this.ElComboTipoAutomovil.TabIndex = 16;
            this.ElComboTipoAutomovil.Text = "compacto";
            this.ElComboTipoAutomovil.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textPuertas
            // 
            this.textPuertas.Location = new System.Drawing.Point(233, 80);
            this.textPuertas.Name = "textPuertas";
            this.textPuertas.Size = new System.Drawing.Size(168, 26);
            this.textPuertas.TabIndex = 15;
            // 
            // textBxIdAutomóvil
            // 
            this.textBxIdAutomóvil.Location = new System.Drawing.Point(233, 21);
            this.textBxIdAutomóvil.Name = "textBxIdAutomóvil";
            this.textBxIdAutomóvil.Size = new System.Drawing.Size(168, 26);
            this.textBxIdAutomóvil.TabIndex = 14;
            this.textBxIdAutomóvil.TextChanged += new System.EventHandler(this.actualizarIdVehículoFromAutomovil);
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
            this.tabMoto.Location = new System.Drawing.Point(4, 29);
            this.tabMoto.Name = "tabMoto";
            this.tabMoto.Padding = new System.Windows.Forms.Padding(3);
            this.tabMoto.Size = new System.Drawing.Size(434, 305);
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
            this.textBxCilindrada.Size = new System.Drawing.Size(168, 26);
            this.textBxCilindrada.TabIndex = 9;
            // 
            // textBxIdMoto
            // 
            this.textBxIdMoto.Location = new System.Drawing.Point(244, 17);
            this.textBxIdMoto.Name = "textBxIdMoto";
            this.textBxIdMoto.Size = new System.Drawing.Size(168, 26);
            this.textBxIdMoto.TabIndex = 8;
            this.textBxIdMoto.TextChanged += new System.EventHandler(this.actualizarIdVehículoFromMoto);
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
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(24, 107);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(111, 46);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btnPresupuestar
            // 
            this.btnPresupuestar.Location = new System.Drawing.Point(20, 175);
            this.btnPresupuestar.Name = "btnPresupuestar";
            this.btnPresupuestar.Size = new System.Drawing.Size(123, 46);
            this.btnPresupuestar.TabIndex = 6;
            this.btnPresupuestar.Text = "Presupuestar";
            this.btnPresupuestar.UseVisualStyleBackColor = true;
            this.btnPresupuestar.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // Diagnose
            // 
            this.Diagnose.Location = new System.Drawing.Point(24, 243);
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Size = new System.Drawing.Size(111, 46);
            this.Diagnose.TabIndex = 5;
            this.Diagnose.Text = "Dignosticar";
            this.Diagnose.UseVisualStyleBackColor = true;
            this.Diagnose.Click += new System.EventHandler(this.Activate_Click);
            // 
            // chkSelect
            // 
            this.chkSelect.AutoSize = true;
            this.chkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSelect.Location = new System.Drawing.Point(20, 18);
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.Size = new System.Drawing.Size(139, 24);
            this.chkSelect.TabIndex = 4;
            this.chkSelect.Text = "Sel. to operate";
            this.chkSelect.UseVisualStyleBackColor = true;
            this.chkSelect.CheckedChanged += new System.EventHandler(this.chkSelect_CheckedChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
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
            this.label6.Location = new System.Drawing.Point(21, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "doble click to update";
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(857, 558);
            this.Controls.Add(this.tabControlPrincipal);
            this.Name = "Inicio";
            this.Text = "Taller Mecánico";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private DataGridViewCheckBoxColumn Select;
        private CheckBox chkSelect;
        private Button btEliminar;
        private Button btnPresupuestar;
        private Button Diagnose;
        private ComboBox ElComboTipoAutomovil;
        private Panel panel4;
        private Label label6;
    }
}

