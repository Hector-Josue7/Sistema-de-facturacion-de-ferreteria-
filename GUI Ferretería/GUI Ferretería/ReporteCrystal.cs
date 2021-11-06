using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using System.IO;
using System.Data.Common;
using Oracle.ManagedDataAccess.Client;

namespace GUI_Ferretería
{
    public partial class ReporteCrystal : Form
    {
        
        string archivo;
    

        public ReporteCrystal()
        {
            InitializeComponent();
        }

        private void ReporteCrystal_Load(object sender, EventArgs e)
        {

        }

        public void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void mostrarReporteSucursal(DSVentas_Sucursal DsReporte,int opc)
        {
            archivo = "Ventas_Sucursal.rpt";
            string directorio = Application.StartupPath.ToString();
            string resto = "bin\\Debug";
            int r = resto.Length;
            int l = (Application.StartupPath.ToString()).Length;
            directorio = directorio.Substring(0, (l - r)) + archivo;

            ReportDocument Reporte = new ReportDocument();
            Reporte.Load(directorio);
            Reporte.SetDataSource(DsReporte);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        public void mostrarReporteArticulo(DsVentas_Articulo DsReporte, int opc)
        {
            archivo = "Ventas_Articulo.rpt";
            string directorio = Application.StartupPath.ToString();
            string resto = "bin\\Debug";
            int r = resto.Length;
            int l = (Application.StartupPath.ToString()).Length;
            directorio = directorio.Substring(0, (l - r)) + archivo;

            ReportDocument Reporte = new ReportDocument();
            Reporte.Load(directorio);
            Reporte.SetDataSource(DsReporte);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        public void mostrarReporteMes(DsVentas_Mes DsReporte, int opc)
        {
            archivo = "Ventas_Mes.rpt";
            string directorio = Application.StartupPath.ToString();
            string resto = "bin\\Debug";
            int r = resto.Length;
            int l = (Application.StartupPath.ToString()).Length;
            directorio = directorio.Substring(0, (l - r)) + archivo;

            ReportDocument Reporte = new ReportDocument();
            Reporte.Load(directorio);
            Reporte.SetDataSource(DsReporte);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        public void mostrarReporteEmpleado(DsVentas_Empleado DsReporte, int opc)
        {
            archivo = "Ventas_Empleado.rpt";
            string directorio = Application.StartupPath.ToString();
            string resto = "bin\\Debug";
            int r = resto.Length;
            int l = (Application.StartupPath.ToString()).Length;
            directorio = directorio.Substring(0, (l - r)) + archivo;

            ReportDocument Reporte = new ReportDocument();
            Reporte.Load(directorio);
            Reporte.SetDataSource(DsReporte);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }

        public void mostrarReporteCliente(DsCompras_Cliente DsReporte, int opc)
        {
            archivo = "Compras_Cliente.rpt";
            string directorio = Application.StartupPath.ToString();
            string resto = "bin\\Debug";
            int r = resto.Length;
            int l = (Application.StartupPath.ToString()).Length;
            directorio = directorio.Substring(0, (l - r)) + archivo;

            ReportDocument Reporte = new ReportDocument();
            Reporte.Load(directorio);
            Reporte.SetDataSource(DsReporte);
            crystalReportViewer1.ReportSource = Reporte;
            crystalReportViewer1.Refresh();
        }


        
            
            
                
            
            
                
      
            
                
    }
}
