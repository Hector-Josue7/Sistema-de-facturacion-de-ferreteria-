using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace GUI_Ferretería
{
    public partial class Principal : Form
    {
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CONSTRUCTOR
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        public Principal(Usuario usuarioActivo)
        {
            InitializeComponent();
            this.usuarioActivo = usuarioActivo;
            this.usuarioActivo.registrarBitácora(this.Text);
            this.Text = this.Text + " --- [" + usuarioActivo.nombreSucursal.ToUpper() + "] ---" + " [" + usuarioActivo.nombreEmpleado.ToUpper() + "]"; // Agrega en la barra de título el nombre del empleado y la sucursal que está haciendo uso del sistema.
            cargarPermisos();
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // CAMPOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        Usuario usuarioActivo;

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // MÉTODOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void cargarPermisos()
        {
            if (usuarioActivo.permisoInventario == "1")
            {
                this.controlDeInventarioToolStripMenuItem.Enabled = true;
            }

            if (usuarioActivo.permisoFacturacion == "1")
            {
                this.facturaciónToolStripMenuItem1.Enabled = true;
            }

            if (usuarioActivo.permisoReportes == "1")
            {
                this.reporteríaToolStripMenuItem1.Enabled = true;
            }

            if (usuarioActivo.permisoPlanilla == "1")
            {
                this.planillaToolStripMenuItem.Enabled = true;
            }
        }

        private void congelarSesión()
        {
            this.pictureBox1.Visible = true;
            this.facturaciónToolStripMenuItem.Enabled = false;
            this.opcionesDeInterfazToolStripMenuItem.Enabled = false;
            this.descongelarSesiónToolStripMenuItem.Enabled = true;
            this.congelarSesiónToolStripMenuItem.Enabled = false;
        }

        private void restaurarSesión()
        {
            Restaurar_Sesión miForm = new Restaurar_Sesión(usuarioActivo.usuario, usuarioActivo.contraseña);
            DialogResult resultado = miForm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.pictureBox1.Visible = false;
                this.congelarSesiónToolStripMenuItem.Enabled = true;
                this.facturaciónToolStripMenuItem.Enabled = true;
                this.opcionesDeInterfazToolStripMenuItem.Enabled = true;   
                this.descongelarSesiónToolStripMenuItem.Enabled = false;
            }                                  
        }

        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        // EVENTOS
        // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturación miForm = new Facturación(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void cotizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Cotizacion miForm = new Cotizacion(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void administrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes miForm = new Clientes(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process calc = new Process { StartInfo = { FileName = @"calc.exe" } };
                calc.Start();
            }
            catch 
            {
                MessageBox.Show("No se encontró la calculadora del sistema operativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void nuevaPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planilla miForm = new Planilla(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void historialDePlanillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historial_de_Planillas miForm = new Historial_de_Planillas(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void reporteXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes miForm = new Reportes(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void crearNuevoArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Artículo miForm = new Nuevo_Artículo(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void ingresarArtículosABodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso_de_Artículos miForm = new Ingreso_de_Artículos(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario miForm = new Inventario(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void comprarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lote miForm = new Lote(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void verLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lotes_Comprados miForm = new Lotes_Comprados(usuarioActivo);
            miForm.MdiParent = this;
            this.pictureBox1.Visible = false;
            miForm.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Splash miSplash = new Splash();
            miSplash.ShowDialog();
        }

        private void congelarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            congelarSesión();
        }

        private void descongelarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            restaurarSesión();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   
    }
}