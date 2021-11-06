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
    public partial class Nuevo_Artículo : Form
    {
        OracleDataAdapter Da;
        DataSet MyDataSet = new DataSet();
        public DataTable dt = new DataTable();
        int i;
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Nuevo_Artículo(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
            this.textBox6.ReadOnly = true;
            this.textBox7.ReadOnly = true;
            this.textBox8.ReadOnly = true;
            this.textBox9.ReadOnly = true;
            this.textBox10.ReadOnly = true;
            this.textBox11.ReadOnly = true;
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void Nuevo_Artículo_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand miComando = new OracleCommand("SP_MOSTRAR_ARTICULOS", miConexion);
                miComando.CommandType = System.Data.CommandType.StoredProcedure;
                OracleParameter pCursor = new OracleParameter("p_ResultSet", OracleDbType.RefCursor, ParameterDirection.Output);
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
                this.dataGridView2.DataSource = this.bindingSource1;
                miConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox4.Text != "" && this.textBox5.Text != "")
            {
                try
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_REGISTRO_ARTICULOS", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2).Value = textBox1.Text.Trim();
                    miComando.Parameters.Add("P_PRECIO_UNITARIO_DE_VENTA", OracleDbType.Varchar2).Value = textBox2.Text.Trim();
                    miComando.Parameters.Add("P_DIAS_DE_VIDA_UTIL", OracleDbType.Varchar2).Value = textBox3.Text.Trim();
                    miComando.Parameters.Add("P_CODIGO_MARCA", OracleDbType.Varchar2).Value = textBox4.Text.Trim();
                    miComando.Parameters.Add("P_CODIGO_PROVEEDOR", OracleDbType.Varchar2).Value = textBox5.Text.Trim();
                    miConexion.Open();
                    miComando.ExecuteNonQuery();

                    MessageBox.Show("Dato Agregado Exitosamente");
                    this.dataGridView1.Columns.Clear();

                    miComando = new OracleCommand("SP_MOSTRAR_ARTICULOS", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter pCursor = new OracleParameter("p_ResultSet", OracleDbType.RefCursor, ParameterDirection.Output);
                    miComando.Parameters.Add(pCursor);
                    OracleDataReader reader = miComando.ExecuteReader();
                    Da = new OracleDataAdapter(miComando);
                    Da.Fill(MyDataSet);
                    OracleCommandBuilder builder = new OracleCommandBuilder(Da);
                    MyDataSet = new DataSet();
                    Da.Fill(MyDataSet, "TBL_ARTICULOS");
                    dataGridView1.DataSource = MyDataSet.Tables["TBL_ARTICULOS"].DefaultView;
                    //dataGridView2.DataSource = MyDataSet.Tables["TBL_ARTICULOS"].DefaultView;
                    miConexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;
            textBox11.ReadOnly = false;

            try
            {
                i = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[i];
                textBox6.Text = row.Cells[0].Value.ToString();
                textBox7.Text = row.Cells[1].Value.ToString();
                textBox8.Text = row.Cells[2].Value.ToString();
                textBox9.Text = row.Cells[3].Value.ToString();
                textBox10.Text = row.Cells[4].Value.ToString();
                textBox11.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox7.Text != "" && this.textBox8.Text != "" && this.textBox10.Text != "" && this.textBox11.Text != "")
            {
                try
                {
                    OracleConnection miConexion = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_MODIFICAR_ARTICULO", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_CODIGO_ARTICULO", OracleDbType.Varchar2).Value = textBox6.Text.Trim();
                    miComando.Parameters.Add("P_DESCRIPCION", OracleDbType.Varchar2).Value = textBox7.Text.Trim();
                    miComando.Parameters.Add("P_PRECIO_UNITARIO_DE_VENTA", OracleDbType.Varchar2).Value = textBox8.Text.Trim();
                    miComando.Parameters.Add("P_DIAS_DE_VIDA_UTIL", OracleDbType.Varchar2).Value = textBox9.Text.Trim();
                    miComando.Parameters.Add("P_CODIGO_MARCA", OracleDbType.Varchar2).Value = textBox10.Text.Trim();
                    miComando.Parameters.Add("P_CODIGO_PROVEEDOR", OracleDbType.Varchar2).Value = textBox11.Text.Trim();
                    miConexion.Open();
                    miComando.ExecuteNonQuery();

                    MessageBox.Show("Artículo modificado exitosamente.");
                    this.dataGridView2.Columns.Clear();
                    miComando = new OracleCommand("SP_MOSTRAR_ARTICULOS", miConexion);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    OracleParameter pCursor = new OracleParameter("p_ResultSet", OracleDbType.RefCursor, ParameterDirection.Output);
                    miComando.Parameters.Add(pCursor);
                    OracleDataReader reader = miComando.ExecuteReader();
                    Da = new OracleDataAdapter(miComando);
                    Da.Fill(MyDataSet);
                    OracleCommandBuilder builder = new OracleCommandBuilder(Da);
                    MyDataSet = new DataSet();
                    Da.Fill(MyDataSet, "TBL_ARTICULOS");
                    dataGridView2.DataSource = MyDataSet.Tables["TBL_ARTICULOS"].DefaultView;
                    miConexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !char.IsPunctuation(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}