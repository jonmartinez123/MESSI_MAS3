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
            this.label1 = new System.Windows.Forms.Label();
            this.docTextbox = new System.Windows.Forms.TextBox();
            this.facturasGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.facturasGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultafac_button
            // 
            this.consultafac_button.Location = new System.Drawing.Point(344, 133);
            this.consultafac_button.Name = "consultafac_button";
            this.consultafac_button.Size = new System.Drawing.Size(158, 36);
            this.consultafac_button.TabIndex = 0;
            this.consultafac_button.Text = "Consultar facturas";
            this.consultafac_button.UseVisualStyleBackColor = true;
            // 
            // tipoDocCombobox
            // 
            this.tipoDocCombobox.FormattingEnabled = true;
            this.tipoDocCombobox.Location = new System.Drawing.Point(56, 142);
            this.tipoDocCombobox.Name = "tipoDocCombobox";
            this.tipoDocCombobox.Size = new System.Drawing.Size(121, 21);
            this.tipoDocCombobox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(22, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo";
            // 
            // docTextbox
            // 
            this.docTextbox.Location = new System.Drawing.Point(183, 142);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar datos";
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
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 637);
            this.Controls.Add(this.docTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoDocCombobox);
            this.Controls.Add(this.consultafac_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "HistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consultafac_button;
        private System.Windows.Forms.ComboBox tipoDocCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox docTextbox;
        private System.Windows.Forms.DataGridView facturasGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}