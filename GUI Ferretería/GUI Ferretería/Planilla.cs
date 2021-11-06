using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public partial class Planilla : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Planilla(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
            cargarDatos();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;
        
        private int codigoPlanilla;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarDatos()
        {
            this.textBoxSucursal.Text = usuarioActivo.nombreSucursal;
            this.textBoxUsuario.Text = usuarioActivo.nombreEmpleado;
            this.dateTimePicker1.Value = DateTime.Now;

            try
            {
                OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand miComando = new OracleCommand("SP_GENERAR_PLANILLA", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.Add("P_COD_SUCURSAL", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;
                miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                miConexión.Open();

                OracleDataReader resultado = miComando.ExecuteReader();

                DataTable miDataTable = new DataTable();
                miDataTable.Load(resultado);
                this.dataGridView1.DataSource = miDataTable;
                this.dataGridView1.Columns["Código cargo"].Visible = false;
                this.dataGridView1.Columns["Código sucursal"].Visible = false;
                this.dataGridView1.Columns["Código empleado"].ReadOnly = true;
                this.dataGridView1.Columns["Nombre"].ReadOnly = true;

                miConexión.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void buttonGuardarPlanilla_Click(object sender, EventArgs e)
        {
            OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);

            try
            {       
                OracleCommand miComando = new OracleCommand("SP_REGISTRAR_PLANILLA", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.Add("P_COD_EMPLEADO_USUARIO", OracleDbType.Int32).Value = usuarioActivo.codigoEmpleado;
                miComando.Parameters.Add("P_COD_CARGO_USUARIO", OracleDbType.Int32).Value = usuarioActivo.codigoCargo;
                miComando.Parameters.Add("P_COD_SUCURSAL_USUARIO", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;

                miConexión.Open();
                miComando.ExecuteNonQuery();

                OracleCommand miComando2 = new OracleCommand("SELECT SQ_CODIGO_PLANILLA.CURRVAL FROM DUAL", miConexión);
                OracleDataReader resultado = miComando2.ExecuteReader();
                resultado.Read();
                this.codigoPlanilla = resultado.GetInt32(0);

                OracleCommand miComando3 = new OracleCommand("SP_GUARDAR_DETALLE_PLANILLA", miConexión);
                miComando3.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow fila in this.dataGridView1.Rows)
                {
                    miComando3.Parameters.Clear();
                    miComando3.Parameters.Add("P_COD_PLANILLA", OracleDbType.Int32).Value = this.codigoPlanilla;
                    miComando3.Parameters.Add("P_COD_EMPLEADO", OracleDbType.Int32).Value = Convert.ToInt32(fila.Cells["Código empleado"].Value.ToString().Trim());
                    miComando3.Parameters.Add("P_IHSS", OracleDbType.Varchar2).Value = fila.Cells["IHSS"].Value.ToString().Trim();
                    miComando3.Parameters.Add("P_RAP", OracleDbType.Varchar2).Value = fila.Cells["RAP/FOSOVI"].Value.ToString().Trim();
                    miComando3.Parameters.Add("P_INFOP", OracleDbType.Varchar2).Value = fila.Cells["INFOP"].Value.ToString().Trim();
                    miComando3.Parameters.Add("P_BONIFICACION", OracleDbType.Varchar2).Value = fila.Cells["Bonificación"].Value.ToString().Trim(); ;
                    miComando3.Parameters.Add("P_SUELDO_NETO", OracleDbType.Varchar2).Value = (Convert.ToDouble(fila.Cells["Sueldo base"].Value) + Convert.ToDouble(fila.Cells["Bonificación"].Value) - Convert.ToDouble(fila.Cells["IHSS"].Value) - Convert.ToDouble(fila.Cells["RAP/FOSOVI"].Value) - -Convert.ToDouble(fila.Cells["INFOP"].Value)).ToString().Trim();
                    miComando3.Parameters.Add("P_COD_CARGO", OracleDbType.Int32).Value = Convert.ToInt32(fila.Cells["Código cargo"].Value.ToString().Trim());
                    miComando3.Parameters.Add("P_COD_SUCURSAL", OracleDbType.Int32).Value = Convert.ToInt32(fila.Cells["Código sucursal"].Value.ToString().Trim());

                    miComando3.ExecuteNonQuery();
                }

                MessageBox.Show("Los datos han sido almacenados\ncon el número de planilla: " + this.codigoPlanilla.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miConexión.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}