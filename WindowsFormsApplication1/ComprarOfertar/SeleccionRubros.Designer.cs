namespace MercadoEnvio.ABM_Rubro
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
            this.SuspendLayout();
            // 
            // clbRubros
            // 
            this.clbRubros.FormattingEnabled = true;
            this.clbRubros.Location = new System.Drawing.Point(12, 76);
            this.clbRubros.Name = "clbRubros";
            this.clbRubros.Size = new System.Drawing.Size(276, 169);
            this.clbRubros.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Depth = 0;
            this.btnSeleccionar.Location = new System.Drawing.Point(183, 251);
            this.btnSeleccionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Primary = true;
            this.btnSeleccionar.Size = new System.Drawing.Size(105, 23);
            this.btnSeleccionar.TabIndex = 123;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // SeleccionRubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 285);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.clbRubros);
            this.Name = "SeleccionRubros";
            this.Text = "Seleccionar Rubros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRubros;
        private MaterialSkin.Controls.MaterialRaisedButton btnSeleccionar;
    }
}