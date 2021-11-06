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
    public partial class Inventario : Form
    {
        int contadorInventario;
        OracleDataAdapter Da;
        DataSet MyDataSet = new DataSet();
        public DataTable dt = new DataTable();
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Inventario(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);            
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;

        private void Inventario_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conexion = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand comando = new OracleCommand("SP_MOSTRAR_SUCURSALES", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter pCursor = new OracleParameter("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
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
            contadorInventario = comboBox1.SelectedIndex;
            if (contadorInventario + 1 == 1)
            {
                try
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_MOSTRAR_INVENTARIO", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter pCursor = new OracleParameter("P_RESULTADOS", OracleDbType.RefCursor, ParameterDirection.Output);
                    miComando.Parameters.Add(pCursor);
                    miConexion.Open();
                    OracleDataReader reader = miComando.ExecuteReader();
                    Da = new OracleDataAdapter(miComando);
                    Da.Fill(MyDataSet);
                    OracleCommandBuilder builder = new OracleCommandBuilder(Da);
                    MyDataSet = new DataSet();
                    Da.Fill(MyDataSet, "MyTable");
                    this.bindingSource1.DataSource = MyDataSet.Tables["MyTable"];
                    this.dataGridView1.DataSource = this.bindingSource1;
                    miConexion.Close();
                    this.dataGridView1.Columns["CODIGO SUCURSAL"].Visible = false;
                    this.dataGridView1.Columns["CODIGO ARTICULO"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (contadorInventario + 1 == 0)
                {
                    MessageBox.Show("No Ah Seleccionado Ningun Inventario");
                }
                else
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_MOSTRAR_INV_X_SUC", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter pCursor = new OracleParameter("P_RESULTADOS", OracleDbType.RefCursor, ParameterDirection.Output);
                    miComando.Parameters.Add(pCursor);
                    miComando.Parameters.Add("P_CODIGO_SUCURSAL", OracleDbType.Varchar2).Value = contadorInventario;
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






        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬







        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
    }
}