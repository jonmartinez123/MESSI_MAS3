﻿namespace MercadoEnvio.Publicar
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
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rbSubasta = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCompra = new MaterialSkin.Controls.MaterialRadioButton();
            this.listadoRubro = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionCorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionLarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.btnAgregarRubro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListadoVisibilidades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubastaMinima = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSubasta = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbEnvio = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRubro)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVisibilidades)).BeginInit();
            this.gbSubasta.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Depth = 0;
            this.btnGenerar.Location = new System.Drawing.Point(150, 622);
            this.btnGenerar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Primary = true;
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Location = new System.Drawing.Point(747, 622);
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
            this.rbSubasta.Location = new System.Drawing.Point(21, 37);
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
            this.rbSubasta.CheckedChanged += new System.EventHandler(this.rbSubasta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCompra);
            this.groupBox1.Controls.Add(this.rbSubasta);
            this.groupBox1.Location = new System.Drawing.Point(592, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rbCompra
            // 
            this.rbCompra.AutoSize = true;
            this.rbCompra.Depth = 0;
            this.rbCompra.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCompra.Location = new System.Drawing.Point(21, 77);
            this.rbCompra.Margin = new System.Windows.Forms.Padding(0);
            this.rbCompra.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCompra.Name = "rbCompra";
            this.rbCompra.Ripple = true;
            this.rbCompra.Size = new System.Drawing.Size(143, 30);
            this.rbCompra.TabIndex = 4;
            this.rbCompra.TabStop = true;
            this.rbCompra.Text = "Compra Inmediata";
            this.rbCompra.UseVisualStyleBackColor = true;
            this.rbCompra.CheckedChanged += new System.EventHandler(this.rbCompra_CheckedChanged);
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
            this.listadoRubro.Location = new System.Drawing.Point(7, 46);
            this.listadoRubro.Name = "listadoRubro";
            this.listadoRubro.ReadOnly = true;
            this.listadoRubro.Size = new System.Drawing.Size(506, 86);
            this.listadoRubro.TabIndex = 7;
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
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(7, 19);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(303, 21);
            this.cmbRubro.TabIndex = 8;
            // 
            // btnAgregarRubro
            // 
            this.btnAgregarRubro.Depth = 0;
            this.btnAgregarRubro.Location = new System.Drawing.Point(433, 17);
            this.btnAgregarRubro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarRubro.Name = "btnAgregarRubro";
            this.btnAgregarRubro.Primary = true;
            this.btnAgregarRubro.Size = new System.Drawing.Size(80, 23);
            this.btnAgregarRubro.TabIndex = 9;
            this.btnAgregarRubro.Text = "Agregar";
            this.btnAgregarRubro.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRubro);
            this.groupBox2.Controls.Add(this.btnAgregarRubro);
            this.groupBox2.Controls.Add(this.listadoRubro);
            this.groupBox2.Location = new System.Drawing.Point(67, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 137);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rubro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListadoVisibilidades);
            this.groupBox3.Location = new System.Drawing.Point(67, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 135);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visibilidad";
            // 
            // ListadoVisibilidades
            // 
            this.ListadoVisibilidades.AllowUserToAddRows = false;
            this.ListadoVisibilidades.AllowUserToDeleteRows = false;
            this.ListadoVisibilidades.AllowUserToResizeColumns = false;
            this.ListadoVisibilidades.AllowUserToResizeRows = false;
            this.ListadoVisibilidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoVisibilidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoVisibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoVisibilidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Porcentaje,
            this.CostoEnvio});
            this.ListadoVisibilidades.Location = new System.Drawing.Point(7, 19);
            this.ListadoVisibilidades.Name = "ListadoVisibilidades";
            this.ListadoVisibilidades.ReadOnly = true;
            this.ListadoVisibilidades.Size = new System.Drawing.Size(506, 110);
            this.ListadoVisibilidades.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // CostoEnvio
            // 
            this.CostoEnvio.HeaderText = "Costo de Envio";
            this.CostoEnvio.Name = "CostoEnvio";
            this.CostoEnvio.ReadOnly = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "Ingrese la descripcion";
            this.txtDescripcion.Location = new System.Drawing.Point(153, 108);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(152, 23);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.UseSystemPasswordChar = false;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion:";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(153, 153);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 20);
            this.dtInicio.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha Inicio:";
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(153, 189);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 20);
            this.dtFin.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Fin:";
            // 
            // txtSubastaMinima
            // 
            this.txtSubastaMinima.Depth = 0;
            this.txtSubastaMinima.Hint = "Ingrese el minimo";
            this.txtSubastaMinima.Location = new System.Drawing.Point(97, 27);
            this.txtSubastaMinima.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubastaMinima.Name = "txtSubastaMinima";
            this.txtSubastaMinima.PasswordChar = '\0';
            this.txtSubastaMinima.SelectedText = "";
            this.txtSubastaMinima.SelectionLength = 0;
            this.txtSubastaMinima.SelectionStart = 0;
            this.txtSubastaMinima.Size = new System.Drawing.Size(123, 23);
            this.txtSubastaMinima.TabIndex = 20;
            this.txtSubastaMinima.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Subasta Minima:";
            // 
            // gbSubasta
            // 
            this.gbSubasta.Controls.Add(this.txtSubastaMinima);
            this.gbSubasta.Controls.Add(this.label4);
            this.gbSubasta.Location = new System.Drawing.Point(592, 367);
            this.gbSubasta.Name = "gbSubasta";
            this.gbSubasta.Size = new System.Drawing.Size(230, 66);
            this.gbSubasta.TabIndex = 22;
            this.gbSubasta.TabStop = false;
            this.gbSubasta.Text = "Subasta";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(55, 622);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbEnvio
            // 
            this.cbEnvio.AutoSize = true;
            this.cbEnvio.Depth = 0;
            this.cbEnvio.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbEnvio.Location = new System.Drawing.Point(592, 447);
            this.cbEnvio.Margin = new System.Windows.Forms.Padding(0);
            this.cbEnvio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbEnvio.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Ripple = true;
            this.cbEnvio.Size = new System.Drawing.Size(63, 30);
            this.cbEnvio.TabIndex = 24;
            this.cbEnvio.Text = "Envio";
            this.cbEnvio.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Depth = 0;
            this.txtPrecio.Hint = "Ingrese Precio";
            this.txtPrecio.Location = new System.Drawing.Point(58, 19);
            this.txtPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.Size = new System.Drawing.Size(138, 23);
            this.txtPrecio.TabIndex = 25;
            this.txtPrecio.UseSystemPasswordChar = false;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStock);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(67, 510);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 87);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "Ingrese Stock";
            this.txtStock.Location = new System.Drawing.Point(58, 58);
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(138, 23);
            this.txtStock.TabIndex = 28;
            this.txtStock.UseSystemPasswordChar = false;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Stock";
            // 
            // Publicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(830, 657);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbEnvio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbSubasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGenerar);
            this.MaximizeBox = false;
            this.Name = "Publicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Publicacion";
            this.Load += new System.EventHandler(this.Publicar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoRubro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVisibilidades)).EndInit();
            this.gbSubasta.ResumeLayout(false);
            this.gbSubasta.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnGenerar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
        private MaterialSkin.Controls.MaterialRadioButton rbSubasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rbCompra;
        private System.Windows.Forms.DataGridView listadoRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionCorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionLarga;
        private System.Windows.Forms.ComboBox cmbRubro;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarRubro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ListadoVisibilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoEnvio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubastaMinima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSubasta;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialCheckBox cbEnvio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private System.Windows.Forms.Label label6;
    }
}