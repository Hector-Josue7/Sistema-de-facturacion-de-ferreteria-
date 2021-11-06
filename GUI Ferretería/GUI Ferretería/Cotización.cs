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
    public partial class Cotizacion : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Cotizacion(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
     
            cargarDatos2();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;
        DataTable dt = new DataTable();
        public int poc;
     
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarDatos2()
        {
            try
            {
                OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand miComando = new OracleCommand("SP_DETALLE_PRODUCTO", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;

                miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                miConexión.Open();

                OracleDataReader resultado = miComando.ExecuteReader();

                DataTable miDataTable = new DataTable();
                miDataTable.Load(resultado);

                this.DGVBusqueda.DataSource = miDataTable;
                dt = miDataTable;
                miConexión.Close();
                this.DGVBusqueda.Columns["Vida útil"].Visible = false;
                this.DGVBusqueda.Columns["Proveedor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void limpiar()
        {
            TXTCANTIDAD.Clear();
            TXTCODIGO.Clear();
            TXTDESCRIPCION.Clear();
            TXTMARCA.Clear();
            TXTPRECIO.Clear();
            TXTPROVEEDOR.Clear();
            TXTVIDAUTIL.Clear();

        }

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void TXTCODIGO_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void TXTDESCRIPCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);

        }

        private void TXTBUSCAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnbuscar_Click_1(sender, e);

            }
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvDatos.CurrentRow.Index;



        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {

                total += Convert.ToDouble(row.Cells["SUBTOTAL"].Value);


            }

            lblTotal.Text = total.ToString();
        }

        private void dgvDatos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {

                total += Convert.ToDouble(row.Cells["PRECIO_UNITARIO"].Value);


            }

            lblTotal.Text = total.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVBusqueda.CurrentRow;

            TXTBUSCAR.Text = row.Cells[1].Value.ToString();
            TXTCODIGO.Text = row.Cells[0].Value.ToString();
            TXTDESCRIPCION.Text = row.Cells[1].Value.ToString();
            TXTPRECIO.Text = row.Cells[2].Value.ToString();
            TXTVIDAUTIL.Text = row.Cells[3].Value.ToString();
            TXTMARCA.Text = row.Cells[4].Value.ToString();
            TXTPROVEEDOR.Text = row.Cells[5].Value.ToString();
            TXTCANTIDAD.Focus();

        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(usuarioActivo.cadenaConexión);
            OracleCommand cmd = new OracleCommand("select * from VDETALLE_PRODUCTO  WHERE DESCRIPCION like'%" + TXTBUSCAR.Text + "%'", conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);
            DGVBusqueda.DataSource = ds.Tables[0];
            TXTBUSCAR.Clear();
            TXTBUSCAR.Focus();
            if (btnbuscar.Text == "nueva")

                btnbuscar.Text = "Buscar";
            else

                btnbuscar.Text = "nueva";
            ;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TXTCANTIDAD.Text == "" || TXTCODIGO.Text == "")
            {
                MessageBox.Show("Tiene que seleccionar un producto y asignar una cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCANTIDAD.Focus();
            }

            else
            {
                int c, p, t;

                c = Convert.ToInt32(TXTCANTIDAD.Text);
                p = Convert.ToInt32(TXTPRECIO.Text);
                t = c * p;

                dgvDatos.Rows.Add(TXTCODIGO.Text, TXTDESCRIPCION.Text, TXTMARCA.Text, TXTPRECIO.Text, TXTCANTIDAD.Text, t);

                limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos qué eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                dgvDatos.Rows.RemoveAt(poc);
            }
            limpiar();
        }
    }
}