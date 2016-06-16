namespace MercadoEnvio.ABM_Visibilidad
{
    partial class Visibilidad
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
            this.groupBox_SeleccionarVisibilidad = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_Cerrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.agregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.modificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ListadoVisibilidades = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_SeleccionarVisibilidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVisibilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SeleccionarVisibilidad
            // 
            this.groupBox_SeleccionarVisibilidad.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox_SeleccionarVisibilidad.Controls.Add(this.btnEliminar);
            this.groupBox_SeleccionarVisibilidad.Controls.Add(this.button_Cerrar);
            this.groupBox_SeleccionarVisibilidad.Controls.Add(this.agregar);
            this.groupBox_SeleccionarVisibilidad.Controls.Add(this.modificar);
            this.groupBox_SeleccionarVisibilidad.Controls.Add(this.ListadoVisibilidades);
            this.groupBox_SeleccionarVisibilidad.Location = new System.Drawing.Point(24, 92);
            this.groupBox_SeleccionarVisibilidad.Name = "groupBox_SeleccionarVisibilidad";
            this.groupBox_SeleccionarVisibilidad.Size = new System.Drawing.Size(924, 400);
            this.groupBox_SeleccionarVisibilidad.TabIndex = 23;
            this.groupBox_SeleccionarVisibilidad.TabStop = false;
            this.groupBox_SeleccionarVisibilidad.Text = "Visibilidades";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(469, 347);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(130, 23);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Depth = 0;
            this.button_Cerrar.Location = new System.Drawing.Point(787, 348);
            this.button_Cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Primary = true;
            this.button_Cerrar.Size = new System.Drawing.Size(122, 23);
            this.button_Cerrar.TabIndex = 26;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // agregar
            // 
            this.agregar.Depth = 0;
            this.agregar.Location = new System.Drawing.Point(307, 348);
            this.agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregar.Name = "agregar";
            this.agregar.Primary = true;
            this.agregar.Size = new System.Drawing.Size(131, 23);
            this.agregar.TabIndex = 25;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Depth = 0;
            this.modificar.Location = new System.Drawing.Point(129, 348);
            this.modificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificar.Name = "modificar";
            this.modificar.Primary = true;
            this.modificar.Size = new System.Drawing.Size(143, 23);
            this.modificar.TabIndex = 24;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
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
            this.Id,
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Porcentaje,
            this.CostoEnvio});
            this.ListadoVisibilidades.Location = new System.Drawing.Point(100, 39);
            this.ListadoVisibilidades.Name = "ListadoVisibilidades";
            this.ListadoVisibilidades.ReadOnly = true;
            this.ListadoVisibilidades.Size = new System.Drawing.Size(679, 225);
            this.ListadoVisibilidades.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            // Visibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(968, 502);
            this.Controls.Add(this.groupBox_SeleccionarVisibilidad);
            this.MaximizeBox = false;
            this.Name = "Visibilidad";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Visibilidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_SeleccionarVisibilidad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVisibilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SeleccionarVisibilidad;
        private MaterialSkin.Controls.MaterialRaisedButton button_Cerrar;
        private MaterialSkin.Controls.MaterialRaisedButton agregar;
        private MaterialSkin.Controls.MaterialRaisedButton modificar;
        private System.Windows.Forms.DataGridView ListadoVisibilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoEnvio;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;

    }
}