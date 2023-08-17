using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaModelo;
using CapaNegocio;

// Form según aspect ratio 16:9, de 1361 x 765 pixels, sin maximización ni resize.

namespace CapaPresentación
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////
        /// Parsing al Enumerator para el tipo de vehículo ///
        /// /////////////////////////////////////////////////
        /// 
        
        private DataGridView parseGridTipoVehiculo(DataGridView dgvToParse)
        {
            for (int i = 0; i < dgvToParse.Rows.Count - 1; i++)
            {
                String tipoAutomovil = dgvToParse.Rows[i].Cells[8].Value.ToString();
                if (!String.IsNullOrEmpty(tipoAutomovil))
                {
                    Array values = (TipoAutomovil[])Enum.GetValues(typeof(TipoAutomovil));
                    dgvToParse.Rows[i].Cells[8].Value = (TipoAutomovil)Enum.Parse(typeof(TipoAutomovil), tipoAutomovil);                    
                }      
            }
            return dgvToParse;
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
            dgvDatos.Columns[0].Width = 35;            
            dgvDatos.Columns[1].Width = 75;
            dgvDatos.Columns[2].Width = 75;
            dgvDatos.Columns[3].Width = 75;
            dgvDatos.Columns[4].Width = 45;
            dgvDatos.Columns[5].Width = 75;
            dgvDatos.Columns[6].Width = 45;
            dgvDatos.Columns[7].Width = 45;
            dgvDatos.Columns[8].Width = 90;            
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        

        private void textListarVehiculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            this.limpiar();
            tabControlPrincipal.SelectedIndex = 0;
        }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            //System.Diagnostics.Debug.WriteLine("Salida: " + selectorTipoVehículo.SelectedTab);

            string respuesta = "";
            if (selectorTipoVehículo.SelectedTab == tabAutomóvil)
            {
                if (tratamientoDatosVehiculo() == "OK" && tratamientoDatosAutomovil() == "OK")
                {
                    try
                    {
                        if (insertarAutomovil() == "OK")
                        {
                            this.MessageOk("Se insertó correctamente el Automóvil");
                            this.limpiar();
                            this.listar();
                        }
                        else { this.MessageError(respuesta); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                    finally { }
                }
                else { this.MessageError(respuesta); }
            }
            else
            {
                if (tratamientoDatosVehiculo() == "OK" && tratamientoDatosMoto() == "OK")
                {
                    try
                    {
                        if (insertarMoto() == "OK")
                        {
                            this.MessageOk("Se insertó correctamente la moto");
                            this.limpiar();
                            this.listar();
                        }
                        else { this.MessageError(respuesta); }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message + ex.StackTrace); }
                    finally { }
                }
                else { this.MessageError(respuesta); }
            }
        }

        private void Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_Click(object sender, EventArgs e)
        {

        }
        // HASTA ACÁ REFACTORING coherencia de nombres de referencia
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Select"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
                //System.Diagnostics.Debug.WriteLine("Salida: " + dgvDatos.Rows[e.RowIndex].Cells["Select"] + " Value: " + chkEliminar.Value);
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
                tabControl1.SelectedIndex = 1; // Hace mantenimiento
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar desde la celda Id");
            }
              
        }

        private void btnActualizarVehiculo_Click(object sender, EventArgs e)
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
                    error.SetError(txtModelo, "Ingrese Modelo del Vehiculo");
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


        private void chkSeleccionarVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionarVehiculo.Checked)
            {
                dgvDatos.Columns[0].Visible = true;
                btnEliminar.Visible = true;
            }
            else
            {
                dgvDatos.Columns[0].Visible = false;                
                btnEliminar.Visible = false;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {            
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("¿Eliminar el registro?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean res; 
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        res = Convert.ToBoolean(dgvDatos.Rows[row.Index].Cells["Select"].Value);
                        //System.Diagnostics.Debug.WriteLine("Salida: " + res.Equals(true));

                        if (res.Equals(true))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //System.Diagnostics.Debug.WriteLine("Salida: " + codigo);
                            respuesta = LogicaVehiculo.Eliminar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MessageOk("Se eliminó el registro correctamente: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MessageError(respuesta);
                            }
                        }
                         
                    }
                    this.listar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void tabPage1_Click_2(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvDatos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvDatos.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Select"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btInsertarVehículo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelarInserción_Click(object sender, EventArgs e)
        {
            this.listar();
            this.tabControlPrincipal.SelectedIndex = 0;
        }

        private void btnActualizarVehículo_Click(object sender, EventArgs e)
        {

        }

        private void Activate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("¿Diagnosticar el Vehículo?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean res;
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        res = Convert.ToBoolean(dgvDatos.Rows[row.Index].Cells["Select"].Value);
                        //System.Diagnostics.Debug.WriteLine("Salida: " + res.Equals(true));

                        if (res.Equals(true))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //System.Diagnostics.Debug.WriteLine("Salida: " + codigo);
                            //respuesta = LogicaVehiculo.Diagnosticar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MessageOk("Se incorporó un diagnóstico para el vehículo: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MessageError(respuesta);
                            }
                        }

                    }
                    this.listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("¿Eliminar el registro?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean res;
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        res = Convert.ToBoolean(dgvDatos.Rows[row.Index].Cells["Select"].Value);
                        //System.Diagnostics.Debug.WriteLine("Salida: " + res.Equals(true));

                        if (res.Equals(true))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //System.Diagnostics.Debug.WriteLine("Salida: " + codigo);
                            respuesta = LogicaVehiculo.Eliminar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                this.MessageOk("Se eliminó el registro correctamente: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MessageError(respuesta);
                            }
                        }

                    }
                    this.listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                string respuesta = "";
                int codigo;
                Opcion = MessageBox.Show("¿Presupuestar el Vehículo?", "Control de Vehiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    Boolean res;
                    foreach (DataGridViewRow row in dgvDatos.Rows)
                    {
                        res = Convert.ToBoolean(dgvDatos.Rows[row.Index].Cells["Select"].Value);
                        //System.Diagnostics.Debug.WriteLine("Salida: " + res.Equals(true));

                        System.Diagnostics.Debug.WriteLine("Turno: " + new RandomTurno(5) + " Vehículo: " + Convert.ToString(row.Cells[1].Value));
                        if (res.Equals(true))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            //System.Diagnostics.Debug.WriteLine("Salida: " + codigo);
                            //respuesta = LogicaVehiculo.Presupuestar(codigo);
                            if (respuesta.Equals("OK"))
                            {
                                System.Diagnostics.Debug.WriteLine("Turno: " + new RandomTurno(5).Next().ToString() + " Vehículo: " + Convert.ToString(row.Cells[1].Value));
                                //MessageBox messageBox = new MessageBox("Turno: " + new RandomTurno(5) + " Vehículo: " + Convert.ToString(row.Cells[1].Value));
                                
                            }
                            else
                            {
                                this.MessageError(respuesta);
                            }
                        }

                    }
                    this.listar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void actualizarIdVehículoFromAutomovil(object sender, EventArgs e)
        {
            textBxIdVehículo.Text = textBxIdAutomóvil.Text;
        }

        private void actualizarIdVehículoFromMoto(object sender, EventArgs e)
        {
            textBxIdVehículo.Text = textBxIdMoto.Text;
        }
    }
}
