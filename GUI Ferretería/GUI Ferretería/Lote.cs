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
    public partial class Lote : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Lote(Usuario usuarioActivo)
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
        public int poc = 0;

        double Stotal = 0, total = 0, isv = 0, desc = 0;
        private int codigolote = 0;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarDatos2()
        {
            try
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
            TXTVIDAUTIL.Clear();
            TXTBUSCAR.Clear();
            TXTBUSCAR.Focus();

        }




        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVBusqueda.CurrentRow;

            TXTBUSCAR.Text = row.Cells[1].Value.ToString();
            TXTCODIGO.Text = row.Cells[0].Value.ToString();
            TXTDESCRIPCION.Text = row.Cells[1].Value.ToString();
            TXTPRECIO.Text = row.Cells[2].Value.ToString();
            TXTVIDAUTIL.Text = row.Cells[3].Value.ToString();
            TXTMARCA.Text = row.Cells[4].Value.ToString();

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
                MessageBox.Show("Tiene que seleccionar un producto y asignar una cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCANTIDAD.Focus();
            }

            else
            {
                int c, p, St;

                c = Convert.ToInt32(TXTCANTIDAD.Text);
                p = Convert.ToInt32(TXTPRECIO.Text);
                St = c * p;


                dgvDatos.Rows.Add(TXTCODIGO.Text, TXTDESCRIPCION.Text, TXTMARCA.Text, TXTPRECIO.Text, TXTCANTIDAD.Text, St);
                limpiar();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos que Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                dgvDatos.Rows.RemoveAt(poc);
            }
            limpiar();

        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dgvDatos.CurrentRow.Index;
        }

        private void dgvDatos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Stotal = 0;


            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                Stotal += Convert.ToDouble(row.Cells["COSTO_ACUMULADO"].Value);
            }


            if (CHKBISV.Checked)
            {

                isv = Stotal * 0.15;
                total = (Stotal - desc) + isv;
                lblTotal.Text = total.ToString();
                lblisv.Text = isv.ToString();

            }
            else
            {

                isv = 0;
                total = (Stotal - desc) + isv;

                lblisv.Text = isv.ToString();
                lblTotal.Text = total.ToString();
            }



            string caseSwitch = CMBXDESCUENTO.Text;
            switch (caseSwitch)
            {

                case "10%":
                    desc = Stotal * 0.1;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "20%":
                    desc = Stotal * 0.2;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;

                case "30%":
                    desc = Stotal * 0.3;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "40%":
                    desc = Stotal * 0.4;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "50%":
                    desc = Stotal * 0.5;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                default:
                    desc = 0;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
            }


            lblSTotal.Text = Stotal.ToString();

        }

        private void dgvDatos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Stotal = 0;


            foreach (DataGridViewRow row in dgvDatos.Rows)
            {

                Stotal += Convert.ToDouble(row.Cells["COSTO_ACUMULADO"].Value);



            }

            if (Stotal != 0)
            {
                if (CHKBISV.Checked)
                {

                    isv = Stotal * 0.15;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    lblisv.Text = isv.ToString();

                }
                else
                {

                    isv = 0;
                    total = (Stotal - desc) + isv;

                    lblisv.Text = isv.ToString();
                    lblTotal.Text = total.ToString();
                }



                string caseSwitch = CMBXDESCUENTO.Text;
                switch (caseSwitch)
                {
                    case "10%":
                        desc = Stotal * 0.1;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;
                    case "20%":
                        desc = Stotal * 0.2;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;

                    case "30%":
                        desc = Stotal * 0.3;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;
                    case "40%":
                        desc = Stotal * 0.4;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;
                    case "50%":
                        desc = Stotal * 0.5;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;
                    default:
                        desc = 0;
                        total = (Stotal - desc) + isv;
                        lblTotal.Text = total.ToString();
                        break;


                }
                lblSTotal.Text = Stotal.ToString();
            }

            else
            {
                lblSTotal.Text = Stotal.ToString();
                isv = 0;
                total = 0;
                desc = 0;
                lblSTotal.Text = Stotal.ToString();
                lblTotal.Text = total.ToString();
                CHKBISV.CheckState = CheckState.Unchecked;
                CMBXDESCUENTO.Text = "";
            }


        }

        private void DGVBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void CHKBISV_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKBISV.Checked)
            {

                isv = Stotal * 0.15;
                total = (Stotal - desc) + isv;
                lblTotal.Text = total.ToString();
                lblisv.Text = isv.ToString();

            }
            else
            {

                isv = 0;
                total = (Stotal - desc) + isv;

                lblisv.Text = isv.ToString();
                lblTotal.Text = total.ToString();
            }
        }

        private void CMBXDESCUENTO_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caseSwitch = CMBXDESCUENTO.Text;
            switch (caseSwitch)
            {
                case "10%":
                    desc = Stotal * 0.1;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "20%":
                    desc = Stotal * 0.2;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;

                case "30%":
                    desc = Stotal * 0.3;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "40%":
                    desc = Stotal * 0.4;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                case "50%":
                    desc = Stotal * 0.5;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
                default:
                    desc = 0;
                    total = (Stotal - desc) + isv;
                    lblTotal.Text = total.ToString();
                    break;
            }

        }

        private void TXTCANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void TXTBUSCAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                btnbuscar_Click_1(sender, e);

            }
        }

        private void TXTDESCRIPCION_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {

                MessageBox.Show("No ha seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                miConexión.Open();


                OracleCommand miComando = new OracleCommand("SP_GUARDAR_LOTE", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;
                //miComando.CommandType = CommandType.StoredProcedure; // ???????????

                miComando.Parameters.Add("CODIGOSU", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;
                //miComando.Parameters.Add("FECHAINGRESO", OracleDbType.Date).Value = DateTime.Today;
                miComando.Parameters.Add("IMPUESTOSV", OracleDbType.Varchar2).Value = isv.ToString().Trim();
                miComando.Parameters.Add("TOTAL", OracleDbType.Varchar2).Value = total.ToString().Trim();

                miComando.ExecuteNonQuery();


                OracleCommand miComando2 = new OracleCommand("SELECT SQ_CODIGO_LOTE.CURRVAL FROM DUAL", miConexión);
                OracleDataReader resultado2 = miComando2.ExecuteReader();
                resultado2.Read();
                this.codigolote = resultado2.GetInt32(0);




                OracleCommand miComando3 = new OracleCommand("SP_GUARDAR_DETALLE_LOTE", miConexión);
                miComando3.CommandType = CommandType.StoredProcedure;

                foreach (DataGridViewRow fila in this.dgvDatos.Rows)
                {

                    miComando3.Parameters.Clear();

                    miComando3.Parameters.Add("CODIGOSU", OracleDbType.Int32).Value = usuarioActivo.codigoSucursal;
                    miComando3.Parameters.Add("CODIGOLO", OracleDbType.Int32).Value = this.codigolote;
                    miComando3.Parameters.Add("CODIGOART", OracleDbType.Int32).Value = Convert.ToUInt32(fila.Cells["CODIGO_ARTICULO"].Value.ToString().Trim());
                    miComando3.Parameters.Add("CANTIDAD", OracleDbType.Int32).Value = Convert.ToUInt32(fila.Cells["CANTIDAD"].Value.ToString().Trim());
                    miComando3.Parameters.Add("PRECIOU", OracleDbType.Int32).Value = Convert.ToUInt32(fila.Cells["PRECIO_UNITARIO"].Value.ToString().Trim());
                    miComando3.Parameters.Add("COSTOACUMULADO", OracleDbType.Int32).Value = Convert.ToUInt32(fila.Cells["COSTO_ACUMULADO"].Value.ToString().Trim());
                    miComando3.ExecuteNonQuery();
                }

                MessageBox.Show("Los datos han sido almacenados\ncon el número de lote: " + this.codigolote.ToString(), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                miConexión.Close();


                cargarDatos2();
                limpiar();
                poc = 0;

                Stotal = 0;
                total = 0;
                isv = 0;
                desc = 0;
                codigolote = 0;
                lblisv.Text = "";
                lblSTotal.Text = "";
                lblTotal.Text = "";
                CMBXDESCUENTO.Text = "";
                TXTBUSCAR.Text = "";
                dgvDatos.Rows.Clear();

            }

        }
    }
}
