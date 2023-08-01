namespace TP_Baquero_Lucas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtNumRepuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.listaConsulta = new System.Windows.Forms.ListBox();
            this.opcImportado = new System.Windows.Forms.RadioButton();
            this.opcNacional = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarcaConsulta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtNumRepuesto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Repuestos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(484, 69);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(484, 21);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 37);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(173, 161);
            this.txtPrecio.MaxLength = 10;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(173, 129);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(255, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(173, 97);
            this.cmbOrigen.MaxLength = 1;
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(61, 21);
            this.cmbOrigen.TabIndex = 8;
            this.cmbOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOrigen_KeyPress);
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(173, 66);
            this.cmbMarca.MaxLength = 1;
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(61, 21);
            this.cmbMarca.TabIndex = 7;
            this.cmbMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarca_KeyPress);
            // 
            // txtNumRepuesto
            // 
            this.txtNumRepuesto.Location = new System.Drawing.Point(173, 33);
            this.txtNumRepuesto.MaxLength = 6;
            this.txtNumRepuesto.Name = "txtNumRepuesto";
            this.txtNumRepuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNumRepuesto.TabIndex = 6;
            this.txtNumRepuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRepuesto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Repuesto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.listaConsulta);
            this.groupBox2.Controls.Add(this.opcImportado);
            this.groupBox2.Controls.Add(this.opcNacional);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbMarcaConsulta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 235);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de Repuestos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(484, 27);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 37);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // listaConsulta
            // 
            this.listaConsulta.FormattingEnabled = true;
            this.listaConsulta.Location = new System.Drawing.Point(55, 91);
            this.listaConsulta.MultiColumn = true;
            this.listaConsulta.Name = "listaConsulta";
            this.listaConsulta.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listaConsulta.Size = new System.Drawing.Size(504, 121);
            this.listaConsulta.TabIndex = 16;
            // 
            // opcImportado
            // 
            this.opcImportado.AutoSize = true;
            this.opcImportado.Location = new System.Drawing.Point(265, 60);
            this.opcImportado.Name = "opcImportado";
            this.opcImportado.Size = new System.Drawing.Size(72, 17);
            this.opcImportado.TabIndex = 15;
            this.opcImportado.TabStop = true;
            this.opcImportado.Text = "Importado";
            this.opcImportado.UseVisualStyleBackColor = true;
            // 
            // opcNacional
            // 
            this.opcNacional.AutoSize = true;
            this.opcNacional.Location = new System.Drawing.Point(173, 60);
            this.opcNacional.Name = "opcNacional";
            this.opcNacional.Size = new System.Drawing.Size(67, 17);
            this.opcNacional.TabIndex = 14;
            this.opcNacional.TabStop = true;
            this.opcNacional.Text = "Nacional";
            this.opcNacional.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Origen";
            // 
            // cmbMarcaConsulta
            // 
            this.cmbMarcaConsulta.FormattingEnabled = true;
            this.cmbMarcaConsulta.Location = new System.Drawing.Point(173, 24);
            this.cmbMarcaConsulta.MaxLength = 1;
            this.cmbMarcaConsulta.Name = "cmbMarcaConsulta";
            this.cmbMarcaConsulta.Size = new System.Drawing.Size(61, 21);
            this.cmbMarcaConsulta.TabIndex = 12;
            this.cmbMarcaConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbMarcaConsulta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(616, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Auto-Rep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtNumRepuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listaConsulta;
        private System.Windows.Forms.RadioButton opcImportado;
        private System.Windows.Forms.RadioButton opcNacional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMarcaConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConsultar;
    }
}

