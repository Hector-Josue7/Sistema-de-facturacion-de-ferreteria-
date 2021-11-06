using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public partial class Login : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Login()
        {
            InitializeComponent();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        string cadenaConexión = "DATA SOURCE=LOCALHOST:1521/XE;PASSWORD=oracle;PERSIST SECURITY INFO=True;USER ID=FERRETERIA";
        Usuario usuarioActivo = new Usuario();

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void agitarVentana()
        {
            this.Location = new Point(this.Location.X - 3, this.Location.Y - 3);
            Thread.Sleep(20);
            this.Location = new Point(this.Location.X + 6, this.Location.Y + 6);
            Thread.Sleep(20);
            this.Location = new Point(this.Location.X + 6, this.Location.Y - 6);
            Thread.Sleep(20);
            this.Location = new Point(this.Location.X - 9, this.Location.Y + 3);
            Thread.Sleep(20);
        }

        private void datosUsuario(int codigoCargo, int codigoEmpleado, int codigoSucursal, string permisoInventario, string permisoFacturacion, string permisoReportes, string permisoPlanilla, string nombreEmpleado, string nombreSucursal, string usuario, string contraseña)
        {
            usuarioActivo.codigoCargo = codigoCargo;
            usuarioActivo.codigoEmpleado = codigoEmpleado;
            usuarioActivo.codigoSucursal = codigoSucursal;
            usuarioActivo.permisoInventario = permisoInventario;
            usuarioActivo.permisoFacturacion = permisoFacturacion;
            usuarioActivo.permisoReportes = permisoReportes;
            usuarioActivo.permisoPlanilla = permisoPlanilla;
            usuarioActivo.nombreEmpleado = nombreEmpleado;
            usuarioActivo.nombreSucursal = nombreSucursal;
            usuarioActivo.usuario = usuario;
            usuarioActivo.contraseña = contraseña;
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection miConexión = new OracleConnection(cadenaConexión);           
                OracleCommand miComando = new OracleCommand("SP_DATOS_USUARIO", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.Add("P_USUARIO", OracleDbType.Varchar2).Value = this.textBoxUsuario.Text;
                miComando.Parameters.Add("P_CONTRASENIA", OracleDbType.Varchar2).Value = this.textBoxPassword.Text;
                miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);
                miConexión.Open();

                OracleDataReader resultado = miComando.ExecuteReader();

                if (resultado.Read() != false)
                {
                    datosUsuario(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetInt32(2), resultado.GetString(3), resultado.GetString(4), resultado.GetString(5), resultado.GetString(6), resultado.GetString(7), resultado.GetString(8), resultado.GetString(9), resultado.GetString(10));
                    miConexión.Close();

                    try
                    {
                        SoundPlayer miSonido = new SoundPlayer(@"c:\Windows\Media\notify.wav");
                        miSonido.Play();
                    }
                    catch (Exception ex) { /*No se encontró el audio.*/ }

                    agitarVentana(); agitarVentana(); agitarVentana();
                    Principal miForm = new Principal(usuarioActivo);
                    this.Hide();
                    miForm.ShowDialog();
                    Application.Exit();
                    //MessageBox.Show("Código cargo: " + usuarioActivo.codigoCargo + "\nCódigo empleado: " + usuarioActivo.codigoEmpleado + "\nCódigo sucursal: " + usuarioActivo.codigoSucursal + "\nPermiso inventario: " + usuarioActivo.permisoInventario + "\nPermiso facturación: " + usuarioActivo.permisoFacturacion + "\nPermiso reportes: " + usuarioActivo.permisoReportes + "\nPermiso planilla: " + usuarioActivo.permisoPlanilla + "\nNombre emplead@: " + usuarioActivo.nombreEmpleado + "\nNombre sucursal: " + usuarioActivo.nombreSucursal + "\nUsuario: " +usuarioActivo.usuario + "\nContraseña: " + usuarioActivo.contraseña, "sasa"); // PARA PROBAR
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}