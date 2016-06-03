namespace MercadoEnvio.Calificar
{
    partial class darCalificacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidad1 = new System.Windows.Forms.RadioButton();
            this.cantidad2 = new System.Windows.Forms.RadioButton();
            this.cantidad3 = new System.Windows.Forms.RadioButton();
            this.cantidad4 = new System.Windows.Forms.RadioButton();
            this.cantidad5 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cantidad5);
            this.groupBox1.Controls.Add(this.cantidad4);
            this.groupBox1.Controls.Add(this.cantidad3);
            this.groupBox1.Controls.Add(this.cantidad2);
            this.groupBox1.Controls.Add(this.cantidad1);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cantidad estrellas";
            // 
            // cantidad1
            // 
            this.cantidad1.AutoSize = true;
            this.cantidad1.Checked = true;
            this.cantidad1.Location = new System.Drawing.Point(7, 22);
            this.cantidad1.Name = "cantidad1";
            this.cantidad1.Size = new System.Drawing.Size(31, 17);
            this.cantidad1.TabIndex = 0;
            this.cantidad1.TabStop = true;
            this.cantidad1.Text = "1";
            this.cantidad1.UseVisualStyleBackColor = true;
            // 
            // cantidad2
            // 
            this.cantidad2.AutoSize = true;
            this.cantidad2.Location = new System.Drawing.Point(7, 45);
            this.cantidad2.Name = "cantidad2";
            this.cantidad2.Size = new System.Drawing.Size(31, 17);
            this.cantidad2.TabIndex = 0;
            this.cantidad2.Text = "2";
            this.cantidad2.UseVisualStyleBackColor = true;
            // 
            // cantidad3
            // 
            this.cantidad3.AutoSize = true;
            this.cantidad3.Location = new System.Drawing.Point(6, 68);
            this.cantidad3.Name = "cantidad3";
            this.cantidad3.Size = new System.Drawing.Size(31, 17);
            this.cantidad3.TabIndex = 0;
            this.cantidad3.Text = "3";
            this.cantidad3.UseVisualStyleBackColor = true;
            // 
            // cantidad4
            // 
            this.cantidad4.AutoSize = true;
            this.cantidad4.Location = new System.Drawing.Point(6, 91);
            this.cantidad4.Name = "cantidad4";
            this.cantidad4.Size = new System.Drawing.Size(31, 17);
            this.cantidad4.TabIndex = 0;
            this.cantidad4.Text = "4";
            this.cantidad4.UseVisualStyleBackColor = true;
            // 
            // cantidad5
            // 
            this.cantidad5.AutoSize = true;
            this.cantidad5.Location = new System.Drawing.Point(6, 114);
            this.cantidad5.Name = "cantidad5";
            this.cantidad5.Size = new System.Drawing.Size(31, 17);
            this.cantidad5.TabIndex = 0;
            this.cantidad5.Text = "5";
            this.cantidad5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 124);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(133, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensaje:";
            // 
            // darCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "darCalificacion";
            this.Text = "Dar calificacion";
            this.Load += new System.EventHandler(this.darCalificacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cantidad5;
        private System.Windows.Forms.RadioButton cantidad4;
        private System.Windows.Forms.RadioButton cantidad3;
        private System.Windows.Forms.RadioButton cantidad2;
        private System.Windows.Forms.RadioButton cantidad1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}