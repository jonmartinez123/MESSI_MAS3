namespace MercadoEnvio.Publicar
{
    partial class Publicar
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
            this.btnGenerar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAplicar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbSubasta = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Depth = 0;
            this.btnGenerar.Location = new System.Drawing.Point(136, 557);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Primary = true;
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Depth = 0;
            this.btnAplicar.Location = new System.Drawing.Point(24, 557);
            this.btnAplicar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Primary = true;
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 1;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Location = new System.Drawing.Point(627, 580);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Primary = true;
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rbSubasta
            // 
            this.rbSubasta.AutoSize = true;
            this.rbSubasta.Depth = 0;
            this.rbSubasta.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSubasta.Location = new System.Drawing.Point(21, 16);
            this.rbSubasta.Margin = new System.Windows.Forms.Padding(0);
            this.rbSubasta.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSubasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSubasta.Name = "rbSubasta";
            this.rbSubasta.Ripple = true;
            this.rbSubasta.Size = new System.Drawing.Size(79, 30);
            this.rbSubasta.TabIndex = 3;
            this.rbSubasta.TabStop = true;
            this.rbSubasta.Text = "Subasta";
            this.rbSubasta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialRadioButton1);
            this.groupBox1.Controls.Add(this.rbSubasta);
            this.groupBox1.Location = new System.Drawing.Point(136, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(21, 50);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(143, 30);
            this.materialRadioButton1.TabIndex = 4;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Compra Inmediata";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // Publicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnGenerar);
            this.MaximizeBox = false;
            this.Name = "Publicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Publicacion";
            this.Load += new System.EventHandler(this.Publicar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAplicar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
        private MaterialSkin.Controls.MaterialRadioButton rbSubasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
    }
}