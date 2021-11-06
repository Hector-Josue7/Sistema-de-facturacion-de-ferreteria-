using System;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public partial class Clientes : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Clientes(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
            cargarTipoDeClientes();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;
        private int tipoCliente;
        private int tipoCliente2;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarTipoDeClientes()
        {
            OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
            OracleCommand miComando = new OracleCommand("SELECT \"CODIGO TIPO DE CLIENTE\", INITCAP(DESCRIPCION) FROM TBL_TIPO_CLIENTE", miConexión);

            miConexión.Open();

            OracleDataReader resultado = miComando.ExecuteReader();

            while(resultado.Read())
            {
                this.comboBoxTipoCliente.Items.Add(resultado.GetString(1));
                this.comboBoxTipoCliente2.Items.Add(resultado.GetString(1));
            }
                     
            miConexión.Close();
        }

        private void limpiarControles()
        {
            this.textBoxNombre.Text = "";
            this.textBoxID.Text = "";
            this.textBoxTeléfono.Text = "";
            this.textBoxDirección.Text = "";
            this.textBoxRTN.Text = "";
            this.textBoxCorreo.Text = "";
        }

        private void limpiarControles2()
        {
            this.textBoxNombre2.Text = "";
            this.textBoxID2.Text = "";
            this.textBoxTeléfono2.Text = "";
            this.textBoxDirección2.Text = "";
            this.textBoxRTN2.Text = "";
            this.textBoxCorreo2.Text = "";
        }

        public static void soloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                if (char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }                     
        }

        public static void soloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                if (Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    if (Char.IsSeparator(pE.KeyChar))
                    {
                        pE.Handled = false;
                    }
                    else
                    {
                        pE.Handled = true;
                    }                      
                }
            }          
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if(this.textBoxNombre.Text != "" && this.textBoxID.Text != "" && this.textBoxRTN.Text != "" && this.comboBoxTipoCliente.SelectedIndex != -1)
            {
                try
                {
                    OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_REGISTRAR_CLIENTE", miConexión);
                    miComando.CommandType = CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_IDENTIDAD", OracleDbType.Varchar2).Value = this.textBoxID.Text.Trim();
                    miComando.Parameters.Add("P_NOMBRE", OracleDbType.Varchar2).Value = this.textBoxNombre.Text.Trim();

                    if (this.textBoxTeléfono.Text == "")
                        miComando.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = null;
                    else
                        miComando.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = Convert.ToInt32(this.textBoxTeléfono.Text.Trim());

                    miComando.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = this.textBoxDirección.Text.Trim();
                    miComando.Parameters.Add("P_RTN", OracleDbType.Varchar2).Value = this.textBoxRTN.Text.Trim();

                    if (this.textBoxCorreo.Text == "")
                        miComando.Parameters.Add("P_CORREO", OracleDbType.Varchar2).Value = null;
                    else
                    {
                        if (Regex.IsMatch(this.textBoxCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                            miComando.Parameters.Add("P_CORREO", OracleDbType.Varchar2).Value = this.textBoxCorreo.Text.Trim();
                        else
                            MessageBox.Show("El formato del correo es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    miComando.Parameters.Add("P_COD_TIPO_CLIENTE", OracleDbType.Int32).Value = this.tipoCliente;
                    miConexión.Open();
                    miComando.ExecuteNonQuery();
                    miConexión.Close();

                    MessageBox.Show("Datos registrados exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
            OracleCommand miComando = new OracleCommand("SELECT \"CODIGO TIPO DE CLIENTE\", INITCAP(DESCRIPCION) FROM TBL_TIPO_CLIENTE", miConexión);

            miConexión.Open();

            OracleDataReader resultado = miComando.ExecuteReader();

            while (resultado.Read())
            {
                if (this.comboBoxTipoCliente.SelectedItem.ToString() == resultado.GetString(1))
                {
                    this.tipoCliente = resultado.GetInt32(0);
                    break; // Una vez que encuentra una coincidencia, rompe el ciclo while.
                }
            }
            //this.label15.Text = this.tipoCliente.ToString(); // CÓDIGO DE TESTEO
            miConexión.Close();
        }

        private void comboBoxTipoCliente2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
            OracleCommand miComando = new OracleCommand("SELECT \"CODIGO TIPO DE CLIENTE\", INITCAP(DESCRIPCION) FROM TBL_TIPO_CLIENTE", miConexión);

            miConexión.Open();

            OracleDataReader resultado = miComando.ExecuteReader();

            while (resultado.Read())
            {
                if (this.comboBoxTipoCliente2.SelectedItem.ToString() == resultado.GetString(1))
                {
                    this.tipoCliente2 = resultado.GetInt32(0);
                    break; // Una vez que encuentra una coincidencia, rompe el ciclo while.
                }
            }

            miConexión.Close();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            this.textBoxRTN.Text = this.textBoxID.Text;
        }

        private void textBoxConsulta_TextChanged(object sender, EventArgs e)
        {
            limpiarControles2();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (this.textBoxConsulta.Text != "")
            {
                limpiarControles2();

                try
                {
                    OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_BUSCAR_CLIENTE", miConexión);
                    miComando.CommandType = CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_IDENTIDAD", OracleDbType.Varchar2).Value = this.textBoxConsulta.Text;
                    miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                    miConexión.Open();

                    OracleDataReader resultado = miComando.ExecuteReader();
                    resultado.Read();

                    this.textBoxNombre2.Text = resultado.GetString(0);
                    this.textBoxID2.Text = resultado.GetString(1);
                    this.textBoxRTN2.Text = resultado.GetString(2);
                    if(resultado.GetInt32(3).ToString() != "0")
                        this.textBoxTeléfono2.Text = resultado.GetInt32(3).ToString();
                    if(resultado.GetString(4) != "0")
                        this.textBoxCorreo2.Text = resultado.GetString(4);                                          
                    this.tipoCliente2 = resultado.GetInt32(5);
                    if(resultado.GetString(6) != "0")
                        this.textBoxDirección2.Text = resultado.GetString(6);
                    this.comboBoxTipoCliente2.Text = resultado.GetString(7);
                                     
                    miConexión.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se encontraron datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de identidad como consulta.", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (this.textBoxID2.Text != "")
            {
                try
                {
                    OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                    OracleCommand miComando = new OracleCommand("SP_MODIFICAR_CLIENTE", miConexión);
                    miComando.CommandType = System.Data.CommandType.StoredProcedure;
                    miComando.Parameters.Add("P_IDENTIDAD", OracleDbType.Varchar2).Value = this.textBoxID2.Text;

                    if (this.textBoxTeléfono2.Text != "")
                        miComando.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = this.textBoxTeléfono2.Text;
                    else
                        miComando.Parameters.Add("P_TELEFONO", OracleDbType.Int32).Value = null;

                    if (this.textBoxCorreo2.Text == "")
                        miComando.Parameters.Add("P_CORREO", OracleDbType.Varchar2).Value = null;
                    else
                    {
                        if (Regex.IsMatch(this.textBoxCorreo2.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
                            miComando.Parameters.Add("P_CORREO", OracleDbType.Varchar2).Value = this.textBoxCorreo2.Text.Trim();
                        else
                            MessageBox.Show("El formato del correo es inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (this.textBoxDirección2.Text != "")
                        miComando.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = this.textBoxDirección2.Text;
                    else
                        miComando.Parameters.Add("P_DIRECCION", OracleDbType.Varchar2).Value = null;

                    miComando.Parameters.Add("P_COD_TIPO_CLIENTE", OracleDbType.Int32).Value = this.tipoCliente2;
                    miConexión.Open();
                    miComando.ExecuteNonQuery();
                    miConexión.Close();

                    MessageBox.Show("Datos actualizados exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarControles2();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("No se modificó nada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                          
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textBoxRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textBoxTeléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textBoxConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void textBoxTeléfono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}