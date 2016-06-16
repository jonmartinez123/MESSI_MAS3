namespace MercadoEnvio.Publicar
{
    partial class Detalles
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
            this.listadoRubro = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionLarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl = new MaterialSkin.Controls.MaterialLabel();
            this.lblPublicacion = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoRubro
            // 
            this.listadoRubro.AllowUserToAddRows = false;
            this.listadoRubro.AllowUserToDeleteRows = false;
            this.listadoRubro.AllowUserToResizeColumns = false;
            this.listadoRubro.AllowUserToResizeRows = false;
            this.listadoRubro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoRubro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DescripcionCorta,
            this.DescripcionLarga});
            this.listadoRubro.Location = new System.Drawing.Point(47, 172);
            this.listadoRubro.Name = "listadoRubro";
            this.listadoRubro.ReadOnly = true;
            this.listadoRubro.Size = new System.Drawing.Size(561, 129);
            this.listadoRubro.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DescripcionCorta
            // 
            this.DescripcionCorta.HeaderText = "Descripcion Corta";
            this.DescripcionCorta.Name = "DescripcionCorta";
            this.DescripcionCorta.ReadOnly = true;
            // 
            // DescripcionLarga
            // 
            this.DescripcionLarga.HeaderText = "Descripcion Larga";
            this.DescripcionLarga.Name = "DescripcionLarga";
            this.DescripcionLarga.ReadOnly = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Depth = 0;
            this.lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl.Location = new System.Drawing.Point(12, 77);
            this.lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(223, 19);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Usted selecciono la publicacion";
            // 
            // lblPublicacion
            // 
            this.lblPublicacion.AutoSize = true;
            this.lblPublicacion.Depth = 0;
            this.lblPublicacion.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPublicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPublicacion.Location = new System.Drawing.Point(241, 77);
            this.lblPublicacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPublicacion.Name = "lblPublicacion";
            this.lblPublicacion.Size = new System.Drawing.Size(0, 19);
            this.lblPublicacion.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 141);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Listado De Rubros";
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Location = new System.Drawing.Point(508, 321);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Primary = true;
            this.btnVolver.Size = new System.Drawing.Size(122, 23);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(632, 356);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblPublicacion);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.listadoRubro);
            this.MaximizeBox = false;
            this.Name = "Detalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Detalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionLarga;
        private MaterialSkin.Controls.MaterialLabel lbl;
        private MaterialSkin.Controls.MaterialLabel lblPublicacion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
    }
}