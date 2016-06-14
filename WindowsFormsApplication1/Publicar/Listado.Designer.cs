namespace MercadoEnvio.Publicar
{
    partial class Listado
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
            this.btnActivar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerMas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RubroId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.Depth = 0;
            this.btnActivar.Enabled = false;
            this.btnActivar.Location = new System.Drawing.Point(263, 319);
            this.btnActivar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Primary = true;
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Enabled = false;
            this.materialRaisedButton1.Location = new System.Drawing.Point(38, 319);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 23);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Agregar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(519, 319);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Primary = true;
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Depth = 0;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(148, 319);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Location = new System.Drawing.Point(814, 319);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Primary = true;
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnVerMas
            // 
            this.btnVerMas.Depth = 0;
            this.btnVerMas.Location = new System.Drawing.Point(823, 234);
            this.btnVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Primary = true;
            this.btnVerMas.Size = new System.Drawing.Size(66, 17);
            this.btnVerMas.TabIndex = 8;
            this.btnVerMas.Text = "Ver Mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerMas);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.btnActivar);
            this.groupBox1.Controls.Add(this.listadoPublicaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listadoPublicaciones
            // 
            this.listadoPublicaciones.AllowUserToAddRows = false;
            this.listadoPublicaciones.AllowUserToDeleteRows = false;
            this.listadoPublicaciones.AllowUserToResizeRows = false;
            this.listadoPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EstadoId,
            this.Estado,
            this.VisibilidadId,
            this.VisibilidadDescripcion,
            this.FechaInicio,
            this.FechaFin,
            this.Descripcion,
            this.Precio,
            this.RubroId,
            this.Rubro,
            this.Stock});
            this.listadoPublicaciones.Location = new System.Drawing.Point(38, 59);
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.ReadOnly = true;
            this.listadoPublicaciones.Size = new System.Drawing.Size(851, 169);
            this.listadoPublicaciones.TabIndex = 1;
            this.listadoPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoPublicaciones_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // EstadoId
            // 
            this.EstadoId.HeaderText = "Estado Id";
            this.EstadoId.Name = "EstadoId";
            this.EstadoId.ReadOnly = true;
            this.EstadoId.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // VisibilidadId
            // 
            this.VisibilidadId.HeaderText = "Visibilidad Id";
            this.VisibilidadId.Name = "VisibilidadId";
            this.VisibilidadId.ReadOnly = true;
            this.VisibilidadId.Visible = false;
            // 
            // VisibilidadDescripcion
            // 
            this.VisibilidadDescripcion.HeaderText = "Visibilidad";
            this.VisibilidadDescripcion.Name = "VisibilidadDescripcion";
            this.VisibilidadDescripcion.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
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
            // RubroId
            // 
            this.RubroId.HeaderText = "Rubro Id";
            this.RubroId.Name = "RubroId";
            this.RubroId.ReadOnly = true;
            this.RubroId.Visible = false;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            this.Rubro.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnActivar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinalizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerMas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn RubroId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;

    }
}