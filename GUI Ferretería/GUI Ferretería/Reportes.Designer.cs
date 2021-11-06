namespace GUI_Ferretería
{
    partial class Reportes
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
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnClientes = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.rbtnVentas_Empleados = new System.Windows.Forms.RadioButton();
            this.rbtnVentas_Mes = new System.Windows.Forms.RadioButton();
            this.rbtnArticulos_mas_vendidos = new System.Windows.Forms.RadioButton();
            this.rbtnVentas = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(318, 73);
            this.panel1.TabIndex = 5;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnClientes);
            this.groupBox1.Controls.Add(this.rbtnVentas_Empleados);
            this.groupBox1.Controls.Add(this.rbtnVentas_Mes);
            this.groupBox1.Controls.Add(this.rbtnArticulos_mas_vendidos);
            this.groupBox1.Controls.Add(this.rbtnVentas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el Reporte ";
            // 
            // rbtnClientes
            // 
            this.rbtnClientes.AutoSize = true;
            this.rbtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClientes.ForeColor = System.Drawing.Color.Khaki;
            this.rbtnClientes.Location = new System.Drawing.Point(63, 126);
            this.rbtnClientes.Name = "rbtnClientes";
            this.rbtnClientes.Size = new System.Drawing.Size(171, 24);
            this.rbtnClientes.TabIndex = 14;
            this.rbtnClientes.TabStop = true;
            this.rbtnClientes.Text = "Compras por Cliente";
            this.rbtnClientes.UseVisualStyleBackColor = true;
            this.rbtnClientes.CheckedChanged += new System.EventHandler(this.rbtnClientes_CheckedChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAceptar.Location = new System.Drawing.Point(122, 278);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(101, 35);
            this.buttonAceptar.TabIndex = 13;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // rbtnVentas_Empleados
            // 
            this.rbtnVentas_Empleados.AutoSize = true;
            this.rbtnVentas_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVentas_Empleados.ForeColor = System.Drawing.Color.Khaki;
            this.rbtnVentas_Empleados.Location = new System.Drawing.Point(63, 100);
            this.rbtnVentas_Empleados.Name = "rbtnVentas_Empleados";
            this.rbtnVentas_Empleados.Size = new System.Drawing.Size(181, 24);
            this.rbtnVentas_Empleados.TabIndex = 3;
            this.rbtnVentas_Empleados.TabStop = true;
            this.rbtnVentas_Empleados.Text = "Ventas por Empleado";
            this.rbtnVentas_Empleados.UseVisualStyleBackColor = true;
            // 
            // rbtnVentas_Mes
            // 
            this.rbtnVentas_Mes.AutoSize = true;
            this.rbtnVentas_Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVentas_Mes.ForeColor = System.Drawing.Color.Khaki;
            this.rbtnVentas_Mes.Location = new System.Drawing.Point(63, 77);
            this.rbtnVentas_Mes.Name = "rbtnVentas_Mes";
            this.rbtnVentas_Mes.Size = new System.Drawing.Size(139, 24);
            this.rbtnVentas_Mes.TabIndex = 2;
            this.rbtnVentas_Mes.TabStop = true;
            this.rbtnVentas_Mes.Text = "Ventas por Mes";
            this.rbtnVentas_Mes.UseVisualStyleBackColor = true;
            // 
            // rbtnArticulos_mas_vendidos
            // 
            this.rbtnArticulos_mas_vendidos.AutoSize = true;
            this.rbtnArticulos_mas_vendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnArticulos_mas_vendidos.ForeColor = System.Drawing.Color.Khaki;
            this.rbtnArticulos_mas_vendidos.Location = new System.Drawing.Point(63, 54);
            this.rbtnArticulos_mas_vendidos.Name = "rbtnArticulos_mas_vendidos";
            this.rbtnArticulos_mas_vendidos.Size = new System.Drawing.Size(162, 24);
            this.rbtnArticulos_mas_vendidos.TabIndex = 1;
            this.rbtnArticulos_mas_vendidos.TabStop = true;
            this.rbtnArticulos_mas_vendidos.Text = "Ventas por Artículo";
            this.rbtnArticulos_mas_vendidos.UseVisualStyleBackColor = true;
            // 
            // rbtnVentas
            // 
            this.rbtnVentas.AutoSize = true;
            this.rbtnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnVentas.ForeColor = System.Drawing.Color.Khaki;
            this.rbtnVentas.Location = new System.Drawing.Point(63, 30);
            this.rbtnVentas.Name = "rbtnVentas";
            this.rbtnVentas.Size = new System.Drawing.Size(171, 24);
            this.rbtnVentas.TabIndex = 0;
            this.rbtnVentas.TabStop = true;
            this.rbtnVentas.Text = "Ventas por Sucursal";
            this.rbtnVentas.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(342, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.RadioButton rbtnVentas_Empleados;
        private System.Windows.Forms.RadioButton rbtnVentas_Mes;
        private System.Windows.Forms.RadioButton rbtnArticulos_mas_vendidos;
        private System.Windows.Forms.RadioButton rbtnVentas;
        private System.Windows.Forms.RadioButton rbtnClientes;
    }
}