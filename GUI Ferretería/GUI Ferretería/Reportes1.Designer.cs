namespace GUI_Ferretería
{
    partial class Reportes1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAtrás = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 241);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonAtrás
            // 
            this.buttonAtrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtrás.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAtrás.Location = new System.Drawing.Point(659, 406);
            this.buttonAtrás.Name = "buttonAtrás";
            this.buttonAtrás.Size = new System.Drawing.Size(112, 43);
            this.buttonAtrás.TabIndex = 14;
            this.buttonAtrás.Text = "Cerrar";
            this.buttonAtrás.UseVisualStyleBackColor = true;
            this.buttonAtrás.Click += new System.EventHandler(this.buttonAtrás_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(539, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reporte General en Crystal Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCrystal_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::GUI_Ferretería.Properties.Resources.Barra_Título;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblEncabezado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 73);
            this.panel1.TabIndex = 10;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEncabezado.Location = new System.Drawing.Point(14, 39);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(64, 16);
            this.lblEncabezado.TabIndex = 4;
            this.lblEncabezado.Text = "Reportes";
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
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCodigo.Location = new System.Drawing.Point(121, 33);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 24);
            this.txtCodigo.TabIndex = 17;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMes);
            this.groupBox1.Controls.Add(this.rbtnNombre);
            this.groupBox1.Controls.Add(this.rbtnCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(29, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 88);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda por Filtro";
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMes.Location = new System.Drawing.Point(35, 56);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(45, 17);
            this.rbtnMes.TabIndex = 20;
            this.rbtnMes.TabStop = true;
            this.rbtnMes.Text = "Mes";
            this.rbtnMes.UseVisualStyleBackColor = true;
            this.rbtnMes.CheckedChanged += new System.EventHandler(this.rbtnMes_CheckedChanged);
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNombre.Location = new System.Drawing.Point(35, 39);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 19;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigo
            // 
            this.rbtnCodigo.AutoSize = true;
            this.rbtnCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCodigo.Location = new System.Drawing.Point(35, 23);
            this.rbtnCodigo.Name = "rbtnCodigo";
            this.rbtnCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtnCodigo.TabIndex = 18;
            this.rbtnCodigo.TabStop = true;
            this.rbtnCodigo.Text = "Código";
            this.rbtnCodigo.UseVisualStyleBackColor = true;
            // 
            // Reportes1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(798, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAtrás);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reportes1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAtrás;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnCodigo;
    }
}