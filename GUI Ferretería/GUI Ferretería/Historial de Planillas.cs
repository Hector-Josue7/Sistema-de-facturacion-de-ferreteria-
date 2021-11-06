using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI_Ferretería
{
    public partial class Historial_de_Planillas : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Historial_de_Planillas(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
            cargarCódigosPlanilla();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarCódigosPlanilla()
        {
            OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
            OracleCommand miComando = new OracleCommand("SELECT \"CODIGO PLANILLA\" FROM TBL_PLANILLAS WHERE \"CODIGO SUCURSAL\" = '" + this.usuarioActivo.codigoSucursal + "' ORDER BY \"CODIGO PLANILLA\" ASC", miConexión);

            miConexión.Open();

            OracleDataReader resultado = miComando.ExecuteReader();

            while (resultado.Read())
            {
                this.comboBox1.Items.Add(resultado.GetInt32(0));
            }

            miConexión.Close();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleConnection miConexión = new OracleConnection(usuarioActivo.cadenaConexión);
                OracleCommand miComando = new OracleCommand("SP_DATOS_PLANILLA", miConexión);
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.Clear();
                miComando.Parameters.Add("P_COD_PLANILLA", OracleDbType.Int32).Value = Convert.ToInt32(this.comboBox1.SelectedItem.ToString());
                miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);

                miConexión.Open();

                OracleDataReader resultado = miComando.ExecuteReader();
                resultado.Read();

                this.dateTimePicker1.Value = resultado.GetDateTime(0);
                this.textBoxElaboradaPor.Text = resultado.GetString(1);

                miComando.CommandText = "SP_DETALLE_PLANILLA";
                miComando.CommandType = CommandType.StoredProcedure;
                miComando.Parameters.Clear();
                miComando.Parameters.Add("P_COD_PLANILLA", OracleDbType.Int32).Value = Convert.ToInt32(this.comboBox1.SelectedItem.ToString());
                miComando.Parameters.Add("P_RESULTADO", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader resultado2 = miComando.ExecuteReader();
                DataTable miDataTable = new DataTable();
                miDataTable.Load(resultado2);
                this.dataGridView1.DataSource = miDataTable;
                miConexión.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void buttonExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    // Formato para la tabla de excel
                    hoja_trabajo.get_Range(cadena[0] + "1", cadena[this.dataGridView1.ColumnCount - 1] + "1").Font.Bold = true;
                    hoja_trabajo.get_Range(cadena[0] + "1", cadena[this.dataGridView1.ColumnCount - 1] + "1").Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                    hoja_trabajo.get_Range(cadena[0] + "1", cadena[this.dataGridView1.ColumnCount - 1] + "1").Interior.ColorIndex = 23;

                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).Borders.Weight = Excel.XlBorderWeight.xlThin;
                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).Font.Name = "Arial";
                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).Font.Size = 12;


                    // Nombres de columnas
                    for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                    {
                        hoja_trabajo.Cells[1, i + 1] = this.dataGridView1.Columns[i].Name;

                    }

                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < this.dataGridView1.Columns.Count; j++)
                        {
                            hoja_trabajo.Cells[i + 2, j + 1] = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    hoja_trabajo.get_Range("A1", cadena[this.dataGridView1.ColumnCount - 1] + (this.dataGridView1.RowCount + 1).ToString()).Columns.AutoFit();

                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar.", "Error");
            }            
        }
    }
}