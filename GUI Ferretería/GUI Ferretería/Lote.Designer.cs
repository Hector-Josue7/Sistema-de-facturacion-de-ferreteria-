namespace GUI_Ferretería
{
    partial class Lote
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblisv = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CMBXDESCUENTO = new System.Windows.Forms.ComboBox();
            this.CHKBISV = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.DGVBusqueda = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTCANTIDAD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTMARCA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTVIDAUTIL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTPRECIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.TXTCODIGO = new System.Windows.Forms.TextBox();
            this.lblSTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.CODIGO_ARTICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTO_ACUMULADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compras por lote";
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
            // lblisv
            // 
            this.lblisv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblisv.AutoSize = true;
            this.lblisv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblisv.Location = new System.Drawing.Point(871, 455);
            this.lblisv.Name = "lblisv";
            this.lblisv.Size = new System.Drawing.Size(0, 24);
            this.lblisv.TabIndex = 90;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(871, 550);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 89;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(720, 492);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 24);
            this.label17.TabIndex = 88;
            this.label17.Text = "DESCUENTO:";
            // 
            // CMBXDESCUENTO
            // 
            this.CMBXDESCUENTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBXDESCUENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBXDESCUENTO.FormattingEnabled = true;
            this.CMBXDESCUENTO.Items.AddRange(new object[] {
            "",
            "0%",
            "10%",
            "20%",
            "30%",
            "50%"});
            this.CMBXDESCUENTO.Location = new System.Drawing.Point(869, 495);
            this.CMBXDESCUENTO.Name = "CMBXDESCUENTO";
            this.CMBXDESCUENTO.Size = new System.Drawing.Size(67, 21);
            this.CMBXDESCUENTO.TabIndex = 87;
            this.CMBXDESCUENTO.SelectedIndexChanged += new System.EventHandler(this.CMBXDESCUENTO_SelectedIndexChanged);
            // 
            // CHKBISV
            // 
            this.CHKBISV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CHKBISV.AutoSize = true;
            this.CHKBISV.Checked = true;
            this.CHKBISV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKBISV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKBISV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CHKBISV.Location = new System.Drawing.Point(724, 454);
            this.CHKBISV.Name = "CHKBISV";
            this.CHKBISV.Size = new System.Drawing.Size(105, 28);
            this.CHKBISV.TabIndex = 86;
            this.CHKBISV.Text = "15% ISV";
            this.CHKBISV.UseVisualStyleBackColor = true;
            this.CHKBISV.CheckedChanged += new System.EventHandler(this.CHKBISV_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(720, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 85;
            this.label6.Text = "SUB-TOTAL";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(968, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 56);
            this.button3.TabIndex = 84;
            this.button3.Text = "COMPRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(968, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "Eliminar Producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(968, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(409, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 24);
            this.label13.TabIndex = 81;
            this.label13.Text = "Buscar:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbuscar.Location = new System.Drawing.Point(968, 132);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(136, 23);
            this.btnbuscar.TabIndex = 80;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBUSCAR.Location = new System.Drawing.Point(413, 134);
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(549, 20);
            this.TXTBUSCAR.TabIndex = 79;
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
            this.DGVBusqueda.Location = new System.Drawing.Point(413, 167);
            this.DGVBusqueda.MultiSelect = false;
            this.DGVBusqueda.Name = "DGVBusqueda";
            this.DGVBusqueda.ReadOnly = true;
            this.DGVBusqueda.RowHeadersVisible = false;
            this.DGVBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBusqueda.Size = new System.Drawing.Size(691, 157);
            this.DGVBusqueda.TabIndex = 78;
            this.DGVBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.DGVBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.DGVBusqueda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.DGVBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(12, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 76;
            this.label11.Text = "Compras:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTCANTIDAD);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXTMARCA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TXTVIDAUTIL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXTPRECIO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXTDESCRIPCION);
            this.groupBox1.Controls.Add(this.TXTCODIGO);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 229);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // TXTCANTIDAD
            // 
            this.TXTCANTIDAD.Location = new System.Drawing.Point(110, 194);
            this.TXTCANTIDAD.Name = "TXTCANTIDAD";
            this.TXTCANTIDAD.Size = new System.Drawing.Size(237, 20);
            this.TXTCANTIDAD.TabIndex = 44;
            this.TXTCANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCANTIDAD_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(52, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Código artículo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(38, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Descripción:";
            // 
            // TXTMARCA
            // 
            this.TXTMARCA.Location = new System.Drawing.Point(110, 159);
            this.TXTMARCA.Name = "TXTMARCA";
            this.TXTMARCA.ReadOnly = true;
            this.TXTMARCA.Size = new System.Drawing.Size(237, 20);
            this.TXTMARCA.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Precio unitario:";
            // 
            // TXTVIDAUTIL
            // 
            this.TXTVIDAUTIL.Location = new System.Drawing.Point(110, 124);
            this.TXTVIDAUTIL.Name = "TXTVIDAUTIL";
            this.TXTVIDAUTIL.ReadOnly = true;
            this.TXTVIDAUTIL.Size = new System.Drawing.Size(237, 20);
            this.TXTVIDAUTIL.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(17, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Días de vida útil:";
            // 
            // TXTPRECIO
            // 
            this.TXTPRECIO.Location = new System.Drawing.Point(110, 89);
            this.TXTPRECIO.Name = "TXTPRECIO";
            this.TXTPRECIO.ReadOnly = true;
            this.TXTPRECIO.Size = new System.Drawing.Size(237, 20);
            this.TXTPRECIO.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(64, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Marca:";
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(110, 54);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.ReadOnly = true;
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(237, 20);
            this.TXTDESCRIPCION.TabIndex = 38;
            // 
            // TXTCODIGO
            // 
            this.TXTCODIGO.Location = new System.Drawing.Point(110, 19);
            this.TXTCODIGO.Name = "TXTCODIGO";
            this.TXTCODIGO.ReadOnly = true;
            this.TXTCODIGO.Size = new System.Drawing.Size(237, 20);
            this.TXTCODIGO.TabIndex = 37;
            // 
            // lblSTotal
            // 
            this.lblSTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSTotal.AutoSize = true;
            this.lblSTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSTotal.Location = new System.Drawing.Point(871, 419);
            this.lblSTotal.Name = "lblSTotal";
            this.lblSTotal.Size = new System.Drawing.Size(0, 24);
            this.lblSTotal.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(720, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 73;
            this.label9.Text = "TOTAL:";
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
            this.CODIGO_ARTICULO,
            this.DESCRIPCION,
            this.MARCA,
            this.PRECIO_UNITARIO,
            this.CANTIDAD,
            this.COSTO_ACUMULADO});
            this.dgvDatos.Location = new System.Drawing.Point(16, 379);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.Size = new System.Drawing.Size(670, 195);
            this.dgvDatos.TabIndex = 72;
            this.dgvDatos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDatos_RowsAdded);
            this.dgvDatos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDatos_RowsRemoved);
            // 
            // CODIGO_ARTICULO
            // 
            this.CODIGO_ARTICULO.HeaderText = "CODIGO ARTICULO";
            this.CODIGO_ARTICULO.Name = "CODIGO_ARTICULO";
            this.CODIGO_ARTICULO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // COSTO_ACUMULADO
            // 
            this.COSTO_ACUMULADO.HeaderText = "COSTO ACUMULADO";
            this.COSTO_ACUMULADO.Name = "COSTO_ACUMULADO";
            this.COSTO_ACUMULADO.ReadOnly = true;
            // 
            // Lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1121, 587);
            this.Controls.Add(this.lblisv);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CMBXDESCUENTO);
            this.Controls.Add(this.CHKBISV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.DGVBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "Lote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Lote";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblisv;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CMBXDESCUENTO;
        private System.Windows.Forms.CheckBox CHKBISV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        public System.Windows.Forms.DataGridView DGVBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TXTCANTIDAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TXTMARCA;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TXTVIDAUTIL;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox TXTPRECIO;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TXTDESCRIPCION;
        public System.Windows.Forms.TextBox TXTCODIGO;
        public System.Windows.Forms.Label lblSTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_ARTICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTO_ACUMULADO;
    }
}