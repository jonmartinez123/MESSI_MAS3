namespace MercadoEnvio.ComprarOfertar
{
    partial class SeleccionRubros
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
            this.clbRubros = new System.Windows.Forms.CheckedListBox();
            this.btnSeleccionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDeseleccionar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // clbRubros
            // 
            this.clbRubros.FormattingEnabled = true;
            this.clbRubros.Location = new System.Drawing.Point(12, 70);
            this.clbRubros.Name = "clbRubros";
            this.clbRubros.Size = new System.Drawing.Size(344, 229);
            this.clbRubros.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Depth = 0;
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 305);
            this.btnSeleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Primary = true;
            this.btnSeleccionar.Size = new System.Drawing.Size(169, 17);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar Todos";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnDeseleccionar
            // 
            this.btnDeseleccionar.Depth = 0;
            this.btnDeseleccionar.Location = new System.Drawing.Point(187, 305);
            this.btnDeseleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeseleccionar.Name = "btnDeseleccionar";
            this.btnDeseleccionar.Primary = true;
            this.btnDeseleccionar.Size = new System.Drawing.Size(169, 17);
            this.btnDeseleccionar.TabIndex = 2;
            this.btnDeseleccionar.Text = "Deseleccionar Todos";
            this.btnDeseleccionar.UseVisualStyleBackColor = true;
            this.btnDeseleccionar.Click += new System.EventHandler(this.btnDeseleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(268, 328);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Ok";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // SeleccionRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 365);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDeseleccionar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.clbRubros);
            this.Name = "SeleccionRubros";
            this.Text = "Seleccionar Rubros";
            this.Load += new System.EventHandler(this.SeleccionRubros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRubros;
        private MaterialSkin.Controls.MaterialRaisedButton btnSeleccionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnDeseleccionar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
    }
}