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
            this.btnAgregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVerMas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPausar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPublicacionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPublicacionNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPublicacionTieneEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadCostoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimoSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuisoEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActivar
            // 
            this.btnActivar.Depth = 0;
            this.btnActivar.Location = new System.Drawing.Point(105, 24);
            this.btnActivar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Primary = true;
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Depth = 0;
            this.btnAgregar.Location = new System.Drawing.Point(38, 319);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Primary = true;
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.Location = new System.Drawing.Point(267, 24);
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
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(12, 24);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnVerMas);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.listadoPublicaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFinalizar);
            this.groupBox2.Controls.Add(this.btnPausar);
            this.groupBox2.Controls.Add(this.btnActivar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Location = new System.Drawing.Point(38, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controles de Estado";
            // 
            // btnPausar
            // 
            this.btnPausar.Depth = 0;
            this.btnPausar.Location = new System.Drawing.Point(186, 24);
            this.btnPausar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Primary = true;
            this.btnPausar.Size = new System.Drawing.Size(75, 23);
            this.btnPausar.TabIndex = 9;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
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
            this.TipoPublicacionId,
            this.TipoPublicacionNombre,
            this.TipoPublicacionTieneEnvio,
            this.EstadoId,
            this.EstadoNombre,
            this.VisibilidadId,
            this.VisibilidadDescripcion,
            this.VisibilidadPrecio,
            this.VisibilidadPorcentaje,
            this.VisibilidadCostoEnvio,
            this.FechaInicio,
            this.FechaFin,
            this.Descripcion,
            this.MinimoSubasta,
            this.Precio,
            this.QuisoEnvio,
            this.Stock});
            this.listadoPublicaciones.Location = new System.Drawing.Point(38, 59);
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.ReadOnly = true;
            this.listadoPublicaciones.Size = new System.Drawing.Size(862, 169);
            this.listadoPublicaciones.TabIndex = 1;
            this.listadoPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoPublicaciones_CellClick);
            this.listadoPublicaciones.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoPublicaciones_RowLeave);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // TipoPublicacionId
            // 
            this.TipoPublicacionId.HeaderText = "Tipo Publicacion Id";
            this.TipoPublicacionId.Name = "TipoPublicacionId";
            this.TipoPublicacionId.ReadOnly = true;
            this.TipoPublicacionId.Visible = false;
            // 
            // TipoPublicacionNombre
            // 
            this.TipoPublicacionNombre.HeaderText = "Tipo Publicacion";
            this.TipoPublicacionNombre.Name = "TipoPublicacionNombre";
            this.TipoPublicacionNombre.ReadOnly = true;
            // 
            // TipoPublicacionTieneEnvio
            // 
            this.TipoPublicacionTieneEnvio.HeaderText = "Tiene Envio";
            this.TipoPublicacionTieneEnvio.Name = "TipoPublicacionTieneEnvio";
            this.TipoPublicacionTieneEnvio.ReadOnly = true;
            // 
            // EstadoId
            // 
            this.EstadoId.HeaderText = "Estado Id";
            this.EstadoId.Name = "EstadoId";
            this.EstadoId.ReadOnly = true;
            this.EstadoId.Visible = false;
            // 
            // EstadoNombre
            // 
            this.EstadoNombre.HeaderText = "Estado";
            this.EstadoNombre.Name = "EstadoNombre";
            this.EstadoNombre.ReadOnly = true;
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
            // VisibilidadPrecio
            // 
            this.VisibilidadPrecio.HeaderText = "Visiblidad Precio";
            this.VisibilidadPrecio.Name = "VisibilidadPrecio";
            this.VisibilidadPrecio.ReadOnly = true;
            this.VisibilidadPrecio.Visible = false;
            // 
            // VisibilidadPorcentaje
            // 
            this.VisibilidadPorcentaje.HeaderText = "Visibilidad Porcentaje";
            this.VisibilidadPorcentaje.Name = "VisibilidadPorcentaje";
            this.VisibilidadPorcentaje.ReadOnly = true;
            this.VisibilidadPorcentaje.Visible = false;
            // 
            // VisibilidadCostoEnvio
            // 
            this.VisibilidadCostoEnvio.HeaderText = "Visibilidad Costo Envio";
            this.VisibilidadCostoEnvio.Name = "VisibilidadCostoEnvio";
            this.VisibilidadCostoEnvio.ReadOnly = true;
            this.VisibilidadCostoEnvio.Visible = false;
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
            // MinimoSubasta
            // 
            this.MinimoSubasta.HeaderText = "Minimo Subasta";
            this.MinimoSubasta.Name = "MinimoSubasta";
            this.MinimoSubasta.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // QuisoEnvio
            // 
            this.QuisoEnvio.HeaderText = "Quiso Envio";
            this.QuisoEnvio.Name = "QuisoEnvio";
            this.QuisoEnvio.ReadOnly = true;
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
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnActivar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregar;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinalizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerMas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnPausar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPublicacionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPublicacionNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPublicacionTieneEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadCostoEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimoSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuisoEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;

    }
}