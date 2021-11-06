namespace GUI_Ferretería
{
    partial class Cotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.CODIGO_ARTICUO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.TXTPROVEEDOR = new System.Windows.Forms.TextBox();
            this.TXTMARCA = new System.Windows.Forms.TextBox();
            this.TXTVIDAUTIL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.DGVBusqueda = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(25, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(36, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código artículo:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_ARTICUO,
            this.DESCRIPCION,
            this.MARCA,
            this.PRECIO_UNITARIO,
            this.Cantidad,
            this.SUBTOTAL});
            this.dgvDatos.Location = new System.Drawing.Point(12, 360);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(874, 215);
            this.dgvDatos.TabIndex = 22;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDatos_RowsAdded);
            this.dgvDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDatos_RowsRemoved);
            // 
            // CODIGO_ARTICUO
            // 
            this.CODIGO_ARTICUO.HeaderText = "Código artículo";
            this.CODIGO_ARTICUO.Name = "CODIGO_ARTICUO";
            this.CODIGO_ARTICUO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "Descripción";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "Marca";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "Precio unitario";
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "Subtotal";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::GUI_Ferretería.Properties.Resources.Barra_Título;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 73);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cotización";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "FERRETERÍA X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(43, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(62, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(15, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Días de vida útil:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(914, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 35;
            this.label9.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(1003, 551);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 36;
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(108, 20);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.ReadOnly = true;
            this.TXTCODIGO.Size = new System.Drawing.Size(237, 20);
            this.TXTCODIGO.TabIndex = 37;
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(108, 50);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.ReadOnly = true;
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(237, 20);
            this.TXTDESCRIPCION.TabIndex = 38;
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(108, 80);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.ReadOnly = true;
            this.TXTPRECIO.Size = new System.Drawing.Size(237, 20);
            this.TXTPRECIO.TabIndex = 39;
            // 
            // TXTPROVEEDOR
            // 
            this.TXTPROVEEDOR.Location = new System.Drawing.Point(108, 170);
            this.TXTPROVEEDOR.Name = "TXTPROVEEDOR";
            this.TXTPROVEEDOR.ReadOnly = true;
            this.TXTPROVEEDOR.Size = new System.Drawing.Size(237, 20);
            this.TXTPROVEEDOR.TabIndex = 42;
            // 
            // TXTMARCA
            // 
            this.TXTMARCA.Location = new System.Drawing.Point(108, 140);
            this.TXTMARCA.Name = "TXTMARCA";
            this.TXTMARCA.ReadOnly = true;
            this.TXTMARCA.Size = new System.Drawing.Size(237, 20);
            this.TXTMARCA.TabIndex = 41;
            // 
            // TXTVIDAUTIL
            // 
            this.TXTVIDAUTIL.Location = new System.Drawing.Point(108, 110);
            this.TXTVIDAUTIL.Name = "TXTVIDAUTIL";
            this.TXTVIDAUTIL.ReadOnly = true;
            this.TXTVIDAUTIL.Size = new System.Drawing.Size(237, 20);
            this.TXTVIDAUTIL.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTCANTIDAD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTPROVEEDOR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTMARCA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTVIDAUTIL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXTPRECIO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXTDESCRIPCION);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TXTCODIGO);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 229);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(108, 200);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(237, 20);
            this.TXTCANTIDAD.TabIndex = 44;
            this.TXTCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCODIGO_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(50, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(14, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 24);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cotizacion:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Location = new System.Drawing.Point(918, 133);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(182, 23);
            this.btnbuscar.TabIndex = 48;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBUSCAR.Location = new System.Drawing.Point(405, 135);
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(501, 20);
            this.TXTBUSCAR.TabIndex = 47;
            this.TXTBUSCAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTBUSCAR_KeyPress);
            // 
            // DGVBusqueda
            // 
            this.DGVBusqueda.AllowUserToAddRows = false;
            this.DGVBusqueda.AllowUserToDeleteRows = false;
            this.DGVBusqueda.AllowUserToResizeRows = false;
            this.DGVBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVBusqueda.Location = new System.Drawing.Point(405, 168);
            this.DGVBusqueda.MultiSelect = false;
            this.DGVBusqueda.Name = "DGVBusqueda";
            this.DGVBusqueda.ReadOnly = true;
            this.DGVBusqueda.RowHeadersVisible = false;
            this.DGVBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBusqueda.Size = new System.Drawing.Size(695, 157);
            this.DGVBusqueda.TabIndex = 46;
            this.DGVBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(401, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 49;
            this.label13.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(918, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(918, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Eliminar Producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1121, 587);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.DGVBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "Cotizacion";
            this.Text = "Cotización";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox TXTCODIGO;
        public System.Windows.Forms.TextBox TXTDESCRIPCION;
        public System.Windows.Forms.TextBox TXTPRECIO;
        public System.Windows.Forms.TextBox TXTPROVEEDOR;
        public System.Windows.Forms.TextBox TXTMARCA;
        public System.Windows.Forms.TextBox TXTVIDAUTIL;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        public System.Windows.Forms.DataGridView DGVBusqueda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ARTICUO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
    }
}