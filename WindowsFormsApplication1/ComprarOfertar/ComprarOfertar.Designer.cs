namespace MercadoEnvio.ComprarOfertar
{
    partial class ComprarOfertar
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
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSeleccionarRubros = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFiltrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnComprar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnUltimaPag = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSiguientePag = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPrimeraPag = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAtrasPagina = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNumeroPagina = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(450, 96);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 19);
            this.materialLabel6.TabIndex = 115;
            this.materialLabel6.Text = "Rubros";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(28, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 114;
            this.materialLabel2.Text = "Descripción";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 111;
            this.materialLabel3.Text = "Filtros";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(123, 96);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(307, 23);
            this.txtDescripcion.TabIndex = 116;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // btnSeleccionarRubros
            // 
            this.btnSeleccionarRubros.Depth = 0;
            this.btnSeleccionarRubros.Location = new System.Drawing.Point(512, 96);
            this.btnSeleccionarRubros.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionarRubros.Name = "btnSeleccionarRubros";
            this.btnSeleccionarRubros.Primary = true;
            this.btnSeleccionarRubros.Size = new System.Drawing.Size(105, 23);
            this.btnSeleccionarRubros.TabIndex = 118;
            this.btnSeleccionarRubros.Text = "Seleccionar";
            this.btnSeleccionarRubros.UseVisualStyleBackColor = true;
            this.btnSeleccionarRubros.Click += new System.EventHandler(this.btnSeleccionarRubros_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Depth = 0;
            this.btnFiltrar.Location = new System.Drawing.Point(32, 125);
            this.btnFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Primary = true;
            this.btnFiltrar.Size = new System.Drawing.Size(105, 23);
            this.btnFiltrar.TabIndex = 119;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(143, 125);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(105, 23);
            this.btnLimpiar.TabIndex = 120;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 162);
            this.dataGridView1.TabIndex = 121;
            // 
            // btnComprar
            // 
            this.btnComprar.Depth = 0;
            this.btnComprar.Location = new System.Drawing.Point(26, 335);
            this.btnComprar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Primary = true;
            this.btnComprar.Size = new System.Drawing.Size(105, 23);
            this.btnComprar.TabIndex = 122;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.Depth = 0;
            this.btnUltimaPag.Location = new System.Drawing.Point(810, 335);
            this.btnUltimaPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Primary = true;
            this.btnUltimaPag.Size = new System.Drawing.Size(35, 13);
            this.btnUltimaPag.TabIndex = 123;
            this.btnUltimaPag.Text = ">>";
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.Depth = 0;
            this.btnSiguientePag.Location = new System.Drawing.Point(774, 335);
            this.btnSiguientePag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Primary = true;
            this.btnSiguientePag.Size = new System.Drawing.Size(35, 13);
            this.btnSiguientePag.TabIndex = 124;
            this.btnSiguientePag.Text = ">";
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            // 
            // btnPrimeraPag
            // 
            this.btnPrimeraPag.Depth = 0;
            this.btnPrimeraPag.Location = new System.Drawing.Point(653, 335);
            this.btnPrimeraPag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrimeraPag.Name = "btnPrimeraPag";
            this.btnPrimeraPag.Primary = true;
            this.btnPrimeraPag.Size = new System.Drawing.Size(35, 13);
            this.btnPrimeraPag.TabIndex = 126;
            this.btnPrimeraPag.Text = "<<";
            this.btnPrimeraPag.UseVisualStyleBackColor = true;
            // 
            // btnAtrasPagina
            // 
            this.btnAtrasPagina.Depth = 0;
            this.btnAtrasPagina.Location = new System.Drawing.Point(689, 335);
            this.btnAtrasPagina.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtrasPagina.Name = "btnAtrasPagina";
            this.btnAtrasPagina.Primary = true;
            this.btnAtrasPagina.Size = new System.Drawing.Size(35, 13);
            this.btnAtrasPagina.TabIndex = 125;
            this.btnAtrasPagina.Text = "<";
            this.btnAtrasPagina.UseVisualStyleBackColor = true;
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.AutoSize = true;
            this.lblNumeroPagina.Depth = 0;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumeroPagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumeroPagina.Location = new System.Drawing.Point(741, 331);
            this.lblNumeroPagina.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(17, 19);
            this.lblNumeroPagina.TabIndex = 127;
            this.lblNumeroPagina.Text = "1";
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 380);
            this.Controls.Add(this.lblNumeroPagina);
            this.Controls.Add(this.btnPrimeraPag);
            this.Controls.Add(this.btnAtrasPagina);
            this.Controls.Add(this.btnSiguientePag);
            this.Controls.Add(this.btnUltimaPag);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnSeleccionarRubros);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel3);
            this.MaximizeBox = false;
            this.Name = "ComprarOfertar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar/Ofertar";
            this.Load += new System.EventHandler(this.ComprarOfertar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialRaisedButton btnSeleccionarRubros;
        private MaterialSkin.Controls.MaterialRaisedButton btnFiltrar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnComprar;
        private MaterialSkin.Controls.MaterialRaisedButton btnUltimaPag;
        private MaterialSkin.Controls.MaterialRaisedButton btnSiguientePag;
        private MaterialSkin.Controls.MaterialRaisedButton btnPrimeraPag;
        private MaterialSkin.Controls.MaterialRaisedButton btnAtrasPagina;
        private MaterialSkin.Controls.MaterialLabel lblNumeroPagina;
    }
}