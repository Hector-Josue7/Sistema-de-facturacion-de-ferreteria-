namespace GUI_Ferretería
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.congelarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descongelarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDePlanillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteríaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarArtículosABodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprarLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesDeInterfazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GUI_Ferretería.Properties.Resources.GIF;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1116, 622);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::GUI_Ferretería.Properties.Resources.Fondo_Menú;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiónToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.opcionesDeInterfazToolStripMenuItem,
            this.reporteríaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.congelarSesiónToolStripMenuItem,
            this.descongelarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.sesiónToolStripMenuItem.Text = "&Sesión";
            // 
            // congelarSesiónToolStripMenuItem
            // 
            this.congelarSesiónToolStripMenuItem.Name = "congelarSesiónToolStripMenuItem";
            this.congelarSesiónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.congelarSesiónToolStripMenuItem.Text = "Congelar sesión";
            this.congelarSesiónToolStripMenuItem.Click += new System.EventHandler(this.congelarSesiónToolStripMenuItem_Click);
            // 
            // descongelarSesiónToolStripMenuItem
            // 
            this.descongelarSesiónToolStripMenuItem.Enabled = false;
            this.descongelarSesiónToolStripMenuItem.Name = "descongelarSesiónToolStripMenuItem";
            this.descongelarSesiónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.descongelarSesiónToolStripMenuItem.Text = "Restaurar sesión";
            this.descongelarSesiónToolStripMenuItem.Click += new System.EventHandler(this.descongelarSesiónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Salir";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem1,
            this.planillaToolStripMenuItem,
            this.reporteríaToolStripMenuItem1,
            this.controlDeInventarioToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.facturaciónToolStripMenuItem.Text = "&Módulos";
            // 
            // facturaciónToolStripMenuItem1
            // 
            this.facturaciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem,
            this.cotizaciónToolStripMenuItem,
            this.administrarClientesToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.facturaciónToolStripMenuItem1.Enabled = false;
            this.facturaciónToolStripMenuItem1.Name = "facturaciónToolStripMenuItem1";
            this.facturaciónToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.facturaciónToolStripMenuItem1.Text = "Facturación";
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "Nueva Factura...";
            this.nuevaFacturaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFacturaToolStripMenuItem_Click);
            // 
            // cotizaciónToolStripMenuItem
            // 
            this.cotizaciónToolStripMenuItem.Name = "cotizaciónToolStripMenuItem";
            this.cotizaciónToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cotizaciónToolStripMenuItem.Text = "Cotización...";
            this.cotizaciónToolStripMenuItem.Click += new System.EventHandler(this.cotizaciónToolStripMenuItem_Click);
            // 
            // administrarClientesToolStripMenuItem
            // 
            this.administrarClientesToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Clientes;
            this.administrarClientesToolStripMenuItem.Name = "administrarClientesToolStripMenuItem";
            this.administrarClientesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.administrarClientesToolStripMenuItem.Text = "Administrar Clientes...";
            this.administrarClientesToolStripMenuItem.Click += new System.EventHandler(this.administrarClientesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Calculadora;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora...";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // planillaToolStripMenuItem
            // 
            this.planillaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPlanillaToolStripMenuItem,
            this.historialDePlanillasToolStripMenuItem});
            this.planillaToolStripMenuItem.Enabled = false;
            this.planillaToolStripMenuItem.Name = "planillaToolStripMenuItem";
            this.planillaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.planillaToolStripMenuItem.Text = "Planilla";
            // 
            // nuevaPlanillaToolStripMenuItem
            // 
            this.nuevaPlanillaToolStripMenuItem.Name = "nuevaPlanillaToolStripMenuItem";
            this.nuevaPlanillaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevaPlanillaToolStripMenuItem.Text = "Nueva Planilla...";
            this.nuevaPlanillaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPlanillaToolStripMenuItem_Click);
            // 
            // historialDePlanillasToolStripMenuItem
            // 
            this.historialDePlanillasToolStripMenuItem.Name = "historialDePlanillasToolStripMenuItem";
            this.historialDePlanillasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.historialDePlanillasToolStripMenuItem.Text = "Historial de planillas...";
            this.historialDePlanillasToolStripMenuItem.Click += new System.EventHandler(this.historialDePlanillasToolStripMenuItem_Click);
            // 
            // reporteríaToolStripMenuItem1
            // 
            this.reporteríaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteXToolStripMenuItem});
            this.reporteríaToolStripMenuItem1.Enabled = false;
            this.reporteríaToolStripMenuItem1.Name = "reporteríaToolStripMenuItem1";
            this.reporteríaToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.reporteríaToolStripMenuItem1.Text = "Reportería";
            // 
            // reporteXToolStripMenuItem
            // 
            this.reporteXToolStripMenuItem.Name = "reporteXToolStripMenuItem";
            this.reporteXToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reporteXToolStripMenuItem.Text = "Reportes...";
            this.reporteXToolStripMenuItem.Click += new System.EventHandler(this.reporteXToolStripMenuItem_Click);
            // 
            // controlDeInventarioToolStripMenuItem
            // 
            this.controlDeInventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoArtículoToolStripMenuItem,
            this.ingresarArtículosABodegaToolStripMenuItem,
            this.verInventarioToolStripMenuItem,
            this.comprarLoteToolStripMenuItem,
            this.verLotesToolStripMenuItem});
            this.controlDeInventarioToolStripMenuItem.Enabled = false;
            this.controlDeInventarioToolStripMenuItem.Name = "controlDeInventarioToolStripMenuItem";
            this.controlDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.controlDeInventarioToolStripMenuItem.Text = "Control de Inventario";
            // 
            // crearNuevoArtículoToolStripMenuItem
            // 
            this.crearNuevoArtículoToolStripMenuItem.Name = "crearNuevoArtículoToolStripMenuItem";
            this.crearNuevoArtículoToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.crearNuevoArtículoToolStripMenuItem.Text = "Crear nuevo artículo...";
            this.crearNuevoArtículoToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoArtículoToolStripMenuItem_Click);
            // 
            // ingresarArtículosABodegaToolStripMenuItem
            // 
            this.ingresarArtículosABodegaToolStripMenuItem.Name = "ingresarArtículosABodegaToolStripMenuItem";
            this.ingresarArtículosABodegaToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.ingresarArtículosABodegaToolStripMenuItem.Text = "Ingresar artículos a bodega...";
            this.ingresarArtículosABodegaToolStripMenuItem.Click += new System.EventHandler(this.ingresarArtículosABodegaToolStripMenuItem_Click);
            // 
            // verInventarioToolStripMenuItem
            // 
            this.verInventarioToolStripMenuItem.Name = "verInventarioToolStripMenuItem";
            this.verInventarioToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.verInventarioToolStripMenuItem.Text = "Ver inventario...";
            this.verInventarioToolStripMenuItem.Click += new System.EventHandler(this.verInventarioToolStripMenuItem_Click);
            // 
            // comprarLoteToolStripMenuItem
            // 
            this.comprarLoteToolStripMenuItem.Name = "comprarLoteToolStripMenuItem";
            this.comprarLoteToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.comprarLoteToolStripMenuItem.Text = "Comprar lote...";
            this.comprarLoteToolStripMenuItem.Click += new System.EventHandler(this.comprarLoteToolStripMenuItem_Click);
            // 
            // verLotesToolStripMenuItem
            // 
            this.verLotesToolStripMenuItem.Name = "verLotesToolStripMenuItem";
            this.verLotesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.verLotesToolStripMenuItem.Text = "Ver lotes...";
            this.verLotesToolStripMenuItem.Click += new System.EventHandler(this.verLotesToolStripMenuItem_Click);
            // 
            // opcionesDeInterfazToolStripMenuItem
            // 
            this.opcionesDeInterfazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.opcionesDeInterfazToolStripMenuItem.Name = "opcionesDeInterfazToolStripMenuItem";
            this.opcionesDeInterfazToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.opcionesDeInterfazToolStripMenuItem.Text = "&Ventana";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Layout_Vertical;
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Layout_Horizontal;
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // reporteríaToolStripMenuItem
            // 
            this.reporteríaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.reporteríaToolStripMenuItem.Name = "reporteríaToolStripMenuItem";
            this.reporteríaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.reporteríaToolStripMenuItem.Text = "&Ayuda";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Manual;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.ayudaToolStripMenuItem.Text = "Manual de uso...";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Image = global::GUI_Ferretería.Properties.Resources.Info;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1116, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Información Ferretería X";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteríaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem controlDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesDeInterfazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevoArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarArtículosABodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDePlanillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprarLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem congelarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descongelarSesiónToolStripMenuItem;
    }
}

