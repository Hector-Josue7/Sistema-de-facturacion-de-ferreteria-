using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public class Usuario
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        protected internal int codigoEmpleado;
        protected internal int codigoCargo;
        protected internal int codigoSucursal;
        protected internal string permisoInventario;
        protected internal string permisoFacturacion;
        protected internal string permisoReportes;
        protected internal string permisoPlanilla;
        protected internal string nombreEmpleado;
        protected internal string nombreSucursal;
        protected internal string usuario;
        protected internal string contraseña;
        protected internal string cadenaConexión = "DATA SOURCE=LOCALHOST:1521/XE;PASSWORD=oracle;PERSIST SECURITY INFO=True;USER ID=FERRETERIA";

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public void registrarBitácora(string formulario)
        {
            try
            {
                OracleConnection miConexión = new OracleConnection(cadenaConexión);               
                OracleCommand miComando = new OracleCommand("SP_REGISTRAR_BITACORA", miConexión);
                miComando.CommandType = System.Data.CommandType.StoredProcedure;
                miComando.Parameters.Add("P_FORM", OracleDbType.Varchar2).Value = formulario;
                miComando.Parameters.Add("P_COD_EMPLEADO", OracleDbType.Int32).Value = codigoEmpleado;
                miComando.Parameters.Add("P_COD_CARGO", OracleDbType.Int32).Value = codigoCargo;
                miComando.Parameters.Add("P_COD_SUCURSAL", OracleDbType.Int32).Value = codigoSucursal;
                miConexión.Open();
                miComando.ExecuteNonQuery();
                miConexión.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}