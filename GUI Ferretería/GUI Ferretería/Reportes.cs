using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Ferretería
{
    public partial class Reportes : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Reportes(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
        }

        
        Usuario usuarioActivo;

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int  opcion;
            string encabezado;

            if (rbtnVentas.Checked == true)
            {
                encabezado = rbtnVentas.Text;
                opcion = 1;
                Reportes1 Rprt1 = new Reportes1();
                Rprt1.llenarGrid(opcion,encabezado);
                Rprt1.ShowDialog();
                

            }
            else if (rbtnArticulos_mas_vendidos.Checked == true)
            {
                encabezado = rbtnArticulos_mas_vendidos.Text;
                opcion = 2;
                Reportes1 Rprt1 = new Reportes1();
                Rprt1.llenarGrid(opcion,encabezado);
                Rprt1.ShowDialog();
                
            }
            else if (rbtnVentas_Mes.Checked == true)
            {
                encabezado = rbtnVentas_Mes.Text;
                opcion = 3;
                Reportes1 Rprt1 = new Reportes1();
                Rprt1.llenarGrid(opcion,encabezado);
                Rprt1.ShowDialog();
               
            }
            else if (rbtnVentas_Empleados.Checked == true)
            {
                encabezado = rbtnVentas_Empleados.Text;
                opcion = 4;
                Reportes1 Rprt1 = new Reportes1();
                Rprt1.llenarGrid(opcion,encabezado);
                Rprt1.ShowDialog();
                
            }
            else if (rbtnClientes.Checked == true)
            {
                encabezado = rbtnClientes.Text;
                opcion = 5;
                Reportes1 Rprt1 = new Reportes1();
                Rprt1.llenarGrid(opcion,encabezado);
                Rprt1.ShowDialog();
                
            }
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            
        }

        private void rbtnClientes_CheckedChanged(object sender, EventArgs e)
        {

        }





        
    }
}