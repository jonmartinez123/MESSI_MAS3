namespace MercadoEnvio.ComprarOfertar
{
    partial class Comprar
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
            this.lblPrecioTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnComprar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescripcionProducto = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecioUnitario = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Depth = 0;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecioTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecioTotal.Location = new System.Drawing.Point(77, 173);
            this.lblPrecioTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 19);
            this.lblPrecioTotal.TabIndex = 128;
            // 
            // btnComprar
            // 
            this.btnComprar.Depth = 0;
            this.btnComprar.Location = new System.Drawing.Point(238, 203);
            this.btnComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Primary = true;
            this.btnComprar.Size = new System.Drawing.Size(105, 23);
            this.btnComprar.TabIndex = 127;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(23, 173);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(48, 19);
            this.materialLabel3.TabIndex = 125;
            this.materialLabel3.Text = "Total:";
            // 
            // lblDescripcionProducto
            // 
            this.lblDescripcionProducto.AutoSize = true;
            this.lblDescripcionProducto.Depth = 0;
            this.lblDescripcionProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionProducto.Location = new System.Drawing.Point(103, 73);
            this.lblDescripcionProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionProducto.Name = "lblDescripcionProducto";
            this.lblDescripcionProducto.Size = new System.Drawing.Size(0, 19);
            this.lblDescripcionProducto.TabIndex = 124;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(23, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(74, 19);
            this.materialLabel2.TabIndex = 123;
            this.materialLabel2.Text = "Producto:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Depth = 0;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(140, 106);
            this.lblPrecioUnitario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(0, 19);
            this.lblPrecioUnitario.TabIndex = 130;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(23, 106);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(111, 19);
            this.materialLabel5.TabIndex = 129;
            this.materialLabel5.Text = "Precio unitario:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 139);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 131;
            this.materialLabel4.Text = "Cantidad:";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(107, 136);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(236, 21);
            this.cmbCantidad.TabIndex = 132;
            this.cmbCantidad.SelectedValueChanged += new System.EventHandler(this.cmbCantidad_SelectedValueChanged);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 244);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblDescripcionProducto);
            this.Controls.Add(this.materialLabel2);
            this.Name = "Comprar";
            this.Text = "Comprar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPrecioTotal;
        private MaterialSkin.Controls.MaterialRaisedButton btnComprar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblPrecioUnitario;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cmbCantidad;
    }
}