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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.IO;
using System.Data.Common;


namespace GUI_Ferretería
{
    public partial class Reportes1 : Form
    {
        static string cadenaConexion = "DATA SOURCE=localhost:1521/XE;PASSWORD=oracle;USER ID=FERRETERIA";
        string cadenaConsulta;
        int opc = 0;

        public Reportes1()
        {
            InitializeComponent();


        }


        private void Reportes1_Load(object sender, EventArgs e)
        {

        }

        public void llenarGrid(int opcion, string encabezado)
        {
            if (opcion == 1)
            {
                opc = opcion;
                lblEncabezado.Text = this.Text + ": " + encabezado;
                cadenaConsulta = "SELECT \"CODIGO ARTICULO\",DESCRIPCION,\"CODIGO MARCA\", \"CODIGO PROVEEDOR\" FROM TBL_ARTICULOS";
                //cadenaConsulta = "SELECT A.\"CODIGO SUCURSAL\" AS Código_de_Sucursal,B.NOMBRE AS Nombre_de_Sucursal,COUNT(A.\"CODIGO SUCURSAL\") AS Numero_de_Ventas,SUM(A.TOTAL) AS Monto_Total_de_Ventas FROM TBL_SUCURSALES B INNER JOIN TBL_FACTURAS A ON (A.\"CODIGO SUCURSAL\"=B.\"CODIGO SUCURSAL\") GROUP BY A.\"CODIGO SUCURSAL\",B.NOMBRE ORDER BY COUNT(A.\"CODIGO SUCURSAL\") DESC ";
            }
            else if (opcion == 2)
            {
                opc = opcion;
                lblEncabezado.Text = this.Text + ": " + encabezado;
                cadenaConsulta = "SELECT A.\"CODIGO ARTICULO\",B.DESCRIPCION, SUM(A.\"CANTIDAD ARTICULOS COMPRADOS\") AS Total_Vendidos FROM TBL_DETALLE_FACTURA A LEFT JOIN TBL_ARTICULOS B ON(A.\"CODIGO ARTICULO\"=B.\"CODIGO ARTICULO\") INNER JOIN TBL_FACTURAS C ON (A.\"CODIGO FACTURA\"=C.\"CODIGO FACTURA\") GROUP BY A.\"CODIGO ARTICULO\",B.DESCRIPCION ORDER BY SUM(A.\"CANTIDAD ARTICULOS COMPRADOS\") DESC";
            }
            else if (opcion == 3)
            {
                opc = opcion;
                lblEncabezado.Text = this.Text + ": " + encabezado;
                cadenaConsulta = "SELECT  TO_CHAR(A.FECHA,'MONTH') AS Mes,COUNT(TO_CHAR(A.FECHA,'MONTH')) AS Numero_de_Ventas,SUM(A.TOTAL) AS Monto_Total_Ventas FROM TBL_FACTURAS A GROUP BY TO_CHAR(A.FECHA, 'MONTH') ORDER BY COUNT(TO_CHAR(A.\"CODIGO FACTURA\")) DESC";
            }
            else if (opcion == 4)
            {
                opc = opcion;
                lblEncabezado.Text = this.Text + ": " + encabezado;
                cadenaConsulta = "SELECT A.\"CODIGO EMPLEADO\" AS Codigo_de_Empleado,B.NOMBRE AS Nombre_del_Empleado , COUNT(A.\"CODIGO EMPLEADO\") AS Ventas_Realizadas,SUM(A.TOTAL) AS Monto_Total_Ventas FROM TBL_FACTURAS A INNER JOIN TBL_EMPLEADOS B ON(A.\"CODIGO EMPLEADO\"=B.\"CODIGO EMPLEADO\") GROUP BY A.\"CODIGO EMPLEADO\",B.NOMBRE ORDER BY SUM(A.TOTAL) DESC";
            }
            else if (opcion == 5)
            {
                opc = opcion;
                lblEncabezado.Text = this.Text + ": " + encabezado;
                cadenaConsulta = "SELECT  A.\"CODIGO CLIENTE\" AS Codigo_de_Cliente,B.NOMBRE AS Nombre_del_Cliente , COUNT(A.\"CODIGO CLIENTE\") AS Compras_Realizadas,SUM(A.TOTAL) AS Monto_Total_Compras FROM TBL_FACTURAS A INNER JOIN TBL_CLIENTES B ON(A.\"CODIGO CLIENTE\"=B.\"CODIGO CLIENTE\") GROUP BY A.\"CODIGO CLIENTE\",B.NOMBRE ORDER BY SUM(A.TOTAL) DESC";
            }



            try
            {
                OracleConnection miConexion = new OracleConnection(cadenaConexion);
                OracleCommand miComando = new OracleCommand(cadenaConsulta, miConexion);
                {
                    miConexion.Open();
                    OracleDataReader lector = miComando.ExecuteReader();
                    {
                        DataTable Tabla = new DataTable();
                        Tabla.Load(lector);
                        dataGridView1.DataSource = Tabla;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnCrystal_Click(object sender, EventArgs e)
        {
            int filas = dataGridView1.RowCount;

            
            if (opc == 1)
            {
                DSVentas_Sucursal DsVentas = new DSVentas_Sucursal();
                for (int i = 0; i <= filas - 2; i++)
                {
                    DsVentas.Tables[0].Rows.Add
                        (
                            (new object[]
                            {
                              dataGridView1[0, i].Value.ToString(),
                              dataGridView1[1, i].Value.ToString(),
                              dataGridView1[2, i].Value.ToString(),
                              dataGridView1[3, i].Value.ToString()
                            })
                        );
                }

                ReporteCrystal FrmReporte = new ReporteCrystal();
                FrmReporte.mostrarReporteSucursal(DsVentas, opc);
                FrmReporte.ShowDialog();

            }

            else if (opc == 2)
            {
                DsVentas_Articulo DsArticulo = new DsVentas_Articulo();
                for (int i = 0; i <= filas - 2; i++)
                {
                    DsArticulo.Tables[0].Rows.Add
                        (
                            (new object[]
                            {
                                    dataGridView1[0, i].Value.ToString(),
                                    dataGridView1[1, i].Value.ToString(),
                                    dataGridView1[2, i].Value.ToString()
                            })
                        );
                }

                ReporteCrystal FrmReporte = new ReporteCrystal();
                FrmReporte.mostrarReporteArticulo(DsArticulo, opc);
                FrmReporte.ShowDialog();
            }


            else if (opc == 3)
            {
                DsVentas_Mes DsMes = new DsVentas_Mes();
                for (int i = 0; i <= filas - 2; i++)
                {
                    DsMes.Tables[0].Rows.Add
                        (
                            (new object[]
                            {
                                    dataGridView1[0, i].Value.ToString(),
                                    dataGridView1[1, i].Value.ToString(),
                                    dataGridView1[2, i].Value.ToString()
                            })
                        );
                }

                ReporteCrystal FrmReporte = new ReporteCrystal();
                FrmReporte.mostrarReporteMes(DsMes, opc);
                FrmReporte.ShowDialog();
            }

            else if (opc == 4)
            {
                DsVentas_Empleado DsEmp = new DsVentas_Empleado();
                for (int i = 0; i <= filas - 2; i++)
                {
                    DsEmp.Tables[0].Rows.Add
                        (
                            (new object[]
                            {
                                    dataGridView1[0, i].Value.ToString(),
                                    dataGridView1[1, i].Value.ToString(),
                                    dataGridView1[2, i].Value.ToString(),
                                    dataGridView1[3, i].Value.ToString()
                            })
                        );
                }

                ReporteCrystal FrmReporte = new ReporteCrystal();
                FrmReporte.mostrarReporteEmpleado(DsEmp, opc);
                FrmReporte.ShowDialog();
            }

            else if (opc == 5)
            {
                DsCompras_Cliente DsCliente= new DsCompras_Cliente();
                for (int i = 0; i <= filas - 2; i++)
                {
                    DsCliente.Tables[0].Rows.Add
                        (
                            (new object[]
                            {
                                    dataGridView1[0, i].Value.ToString(),
                                    dataGridView1[1, i].Value.ToString(),
                                    dataGridView1[2, i].Value.ToString(),
                                    dataGridView1[3, i].Value.ToString()
                            })
                        );
                }

                ReporteCrystal FrmReporte = new ReporteCrystal();
                FrmReporte.mostrarReporteCliente(DsCliente, opc);
                FrmReporte.ShowDialog();
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbtnCodigo.Checked)
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    string strFila = fila.Index.ToString();
                    string valor = (Convert.ToString(fila.Cells[0].Value)).ToLower();
                   
                    if (valor==txtCodigo.Text.ToLower())
                    {
                       
                        dataGridView1.Rows[Convert.ToInt32(strFila)].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[Convert.ToInt32(strFila)].Cells[0];

                    }
  
                }
            }
            else if (rbtnNombre.Checked)
            {
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    string strFila = Row.Index.ToString();
                    string valor = (Convert.ToString(Row.Cells[1].Value)).ToLower();

                    if (valor.Contains(txtCodigo.Text.ToLower()))
                    {
                        dataGridView1.Rows[Convert.ToInt32(strFila)].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[Convert.ToInt32(strFila)].Cells[1];

                    }
                    
                }
            }

            else if (rbtnMes.Checked && opc==3)
            {
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    string strFila = Row.Index.ToString();
                    string valor = (Convert.ToString(Row.Cells[0].Value)).ToLower();

                    if (valor == txtCodigo.Text.ToLower())
                    {
                        dataGridView1.Rows[Convert.ToInt32(strFila)].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[Convert.ToInt32(strFila)].Cells[2];

                    }

                }

            }
            
        }
            
           

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
