using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public partial class Ingreso_de_Artículos : Form
    {
        OracleDataAdapter Da;
        DataSet MyDataSet = new DataSet();
        public DataTable dt = new DataTable();
        int codigoArticuloSeleccionado;
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Ingreso_de_Artículos(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void Ingreso_de_Artículos_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand comando1 = new OracleCommand("SP_MOSTRAR_DES_ARTICULO", conexion);
                comando1.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter pCursor1 = new OracleParameter("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                comando1.Parameters.Add(pCursor1);

                conexion.Open();
                OracleDataReader lector1 = comando1.ExecuteReader();
                while (lector1.Read())
                {
                    comboBox1.Refresh();
                    comboBox1.Items.Add(lector1.GetValue(0).ToString());
                }         

                lector1.Close();
                conexion.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Seleccione elementos válidos.", "Error");
            }
            else
            {
                // PARA OBTENER EL CÓDIGO DEL ARTÍCULO SELECCIONADO EN EL COMBOBOX
                try
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SELECT \"CODIGO ARTICULO\" FROM TBL_ARTICULOS WHERE DESCRIPCION = '" + this.comboBox1.SelectedItem.ToString().Trim() + "'", miConexion);
                    miConexion.Open();
                    OracleDataReader lector1 = miComando.ExecuteReader();
                    while (lector1.Read())
                    {
                        this.codigoArticuloSeleccionado = lector1.GetInt32(0);
                    }

                    lector1.Close();
                    miConexion.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }

                // INTENTA INSERTAR COMO NUEVO ARTÍCULO, SI OCURRE UNA EXCEPCIÓN, ENTONCES LO ACTUALIZA PORQUE YA EXISTE.

                try
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_ING_ART_BODEGA", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_CODIGO_SUCURSAL", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;
                    miComando.Parameters.Add("P_CODIGO_ARTICULO", OracleDbType.Int32).Value = codigoArticuloSeleccionado;
                    miComando.Parameters.Add("P_CANTIDAD_QUE_INGRESA", OracleDbType.Int32).Value = numericUpDown1.Value;
                    miConexion.Open();
                    miComando.ExecuteNonQuery();
                    MessageBox.Show("Dato agregado exitosamente");
                    miConexion.Close();
                }
                catch (Exception ex)
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_ACT_ART_BODEGA", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_CODIGO_SUCURSAL", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;
                    miComando.Parameters.Add("P_CODIGO_ARTICULO", OracleDbType.Int32).Value = codigoArticuloSeleccionado;
                    miComando.Parameters.Add("P_CANTIDAD_QUE_INGRESA", OracleDbType.Int32).Value = numericUpDown1.Value;
                    miConexion.Open();
                    miComando.ExecuteNonQuery();
                    MessageBox.Show("Dato agregado exitosamente");
                    miConexion.Close();
                }
            }
        }
    }
}