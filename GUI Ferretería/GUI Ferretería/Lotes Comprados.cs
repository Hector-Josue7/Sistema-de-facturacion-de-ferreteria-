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
    public partial class Lotes_Comprados : Form
    {

        int contadorLotes;
        OracleDataAdapter Da;
        DataSet MyDataSet = new DataSet();
        public DataTable dt = new DataTable();
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Lotes_Comprados(Usuario usuarioActivo)
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
        private void Lotes_Comprados_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand comando = new OracleCommand("SP_MOSTRAR_LOTES", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter pCursor = new OracleParameter("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                comando.Parameters.Add("P_CODIGO_SUCURSAL", OracleDbType.Int32).Value = this.usuarioActivo.codigoSucursal;
                comando.Parameters.Add(pCursor);

                conexion.Open();
                OracleDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    comboBox1.Refresh();
                    comboBox1.Items.Add(lector.GetValue(0).ToString());
                }
                lector.Close();
                conexion.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contadorLotes = comboBox1.SelectedIndex;
            if (contadorLotes + 1 == 0)
            {
                MessageBox.Show("No ha deleccionado ningún lote.");
            }
            else
            {
                OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand miComando = new OracleCommand("SP_MOSTRAR_LOTE_X_DET", miConexion);
                miComando.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter pCursor = new OracleParameter("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                miComando.Parameters.Add(pCursor);
                //miComando.Parameters.Add("P_CODIGO_LOTE", OracleDbType.Varchar2).Value = contadorLotes + 1; // MALO
                miComando.Parameters.Add("P_CODIGO_LOTE", OracleDbType.Varchar2).Value = this.comboBox1.SelectedItem.ToString();
                miConexion.Open();
                OracleDataReader reader = miComando.ExecuteReader();
                Da = new OracleDataAdapter(miComando);
                Da.Fill(MyDataSet);
                //OracleCommandBuilder builder = new OracleCommandBuilder(Da);
                MyDataSet = new DataSet();
                Da.Fill(MyDataSet, "MyTable");
                this.bindingSource1.DataSource = MyDataSet.Tables["MyTable"];
                this.dataGridView1.DataSource = this.bindingSource1;
                miConexion.Close();
            }

        }
    }
}