namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialCliente
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
            this.consultafac_button = new System.Windows.Forms.Button();
            this.tipoDocCombobox = new System.Windows.Forms.ComboBox();
            this.docTextbox = new System.Windows.Forms.TextBox();
            this.facturasGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.filtroPorFecha = new System.Windows.Forms.CheckBox();
            this.filtroPorImporte = new System.Windows.Forms.CheckBox();
            this.filtroContieneEnDetalle = new System.Windows.Forms.CheckBox();
            this.fechaDesde = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.fechaHasta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturasGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultafac_button
            // 
            this.consultafac_button.Location = new System.Drawing.Point(535, 102);
            this.consultafac_button.Name = "consultafac_button";
            this.consultafac_button.Size = new System.Drawing.Size(158, 36);
            this.consultafac_button.TabIndex = 0;
            this.consultafac_button.Text = "Consultar facturas";
            this.consultafac_button.UseVisualStyleBackColor = true;
            // 
            // tipoDocCombobox
            // 
            this.tipoDocCombobox.FormattingEnabled = true;
            this.tipoDocCombobox.Location = new System.Drawing.Point(13, 19);
            this.tipoDocCombobox.Name = "tipoDocCombobox";
            this.tipoDocCombobox.Size = new System.Drawing.Size(74, 21);
            this.tipoDocCombobox.TabIndex = 3;
            // 
            // docTextbox
            // 
            this.docTextbox.Location = new System.Drawing.Point(93, 20);
            this.docTextbox.Name = "docTextbox";
            this.docTextbox.Size = new System.Drawing.Size(136, 20);
            this.docTextbox.TabIndex = 5;
            // 
            // facturasGridView
            // 
            this.facturasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturasGridView.Location = new System.Drawing.Point(13, 29);
            this.facturasGridView.Name = "facturasGridView";
            this.facturasGridView.Size = new System.Drawing.Size(961, 349);
            this.facturasGridView.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.tipoDocCombobox);
            this.groupBox1.Controls.Add(this.docTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.facturasGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 398);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial facturas";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.fechaHasta);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.fechaDesde);
            this.groupBox3.Controls.Add(this.filtroContieneEnDetalle);
            this.groupBox3.Controls.Add(this.filtroPorImporte);
            this.groupBox3.Controls.Add(this.filtroPorFecha);
            this.groupBox3.Controls.Add(this.consultafac_button);
            this.groupBox3.Location = new System.Drawing.Point(308, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 144);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros consulta";
            // 
            // filtroPorFecha
            // 
            this.filtroPorFecha.AutoSize = true;
            this.filtroPorFecha.Location = new System.Drawing.Point(16, 21);
            this.filtroPorFecha.Name = "filtroPorFecha";
            this.filtroPorFecha.Size = new System.Drawing.Size(75, 17);
            this.filtroPorFecha.TabIndex = 1;
            this.filtroPorFecha.Text = "Por Fecha";
            this.filtroPorFecha.UseVisualStyleBackColor = true;
            // 
            // filtroPorImporte
            // 
            this.filtroPorImporte.AutoSize = true;
            this.filtroPorImporte.Location = new System.Drawing.Point(16, 57);
            this.filtroPorImporte.Name = "filtroPorImporte";
            this.filtroPorImporte.Size = new System.Drawing.Size(79, 17);
            this.filtroPorImporte.TabIndex = 1;
            this.filtroPorImporte.Text = "Por importe";
            this.filtroPorImporte.UseVisualStyleBackColor = true;
            // 
            // filtroContieneEnDetalle
            // 
            this.filtroContieneEnDetalle.AutoSize = true;
            this.filtroContieneEnDetalle.Location = new System.Drawing.Point(16, 102);
            this.filtroContieneEnDetalle.Name = "filtroContieneEnDetalle";
            this.filtroContieneEnDetalle.Size = new System.Drawing.Size(122, 17);
            this.filtroContieneEnDetalle.TabIndex = 1;
            this.filtroContieneEnDetalle.Text = "Palabra en el detalle";
            this.filtroContieneEnDetalle.UseVisualStyleBackColor = true;
            // 
            // fechaDesde
            // 
            this.fechaDesde.Location = new System.Drawing.Point(196, 19);
            this.fechaDesde.Name = "fechaDesde";
            this.fechaDesde.Size = new System.Drawing.Size(136, 20);
            this.fechaDesde.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(196, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 10;
            // 
            // fechaHasta
            // 
            this.fechaHasta.Location = new System.Drawing.Point(415, 18);
            this.fechaHasta.Name = "fechaHasta";
            this.fechaHasta.Size = new System.Drawing.Size(136, 20);
            this.fechaHasta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Palabra:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MaximizeBox = false;
            this.Name = "HistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button consultafac_button;
        private System.Windows.Forms.ComboBox tipoDocCombobox;
        private System.Windows.Forms.TextBox docTextbox;
        private System.Windows.Forms.DataGridView facturasGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox filtroContieneEnDetalle;
        private System.Windows.Forms.CheckBox filtroPorImporte;
        private System.Windows.Forms.CheckBox filtroPorFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fechaHasta;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox fechaDesde;
    }
}