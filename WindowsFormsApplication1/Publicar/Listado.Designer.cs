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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActivar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnVolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTodas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbActivas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbFinalizadas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbPausadas = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBorradores = new MaterialSkin.Controls.MaterialRadioButton();
            this.listadoPublicaciones = new System.Windows.Forms.DataGridView();
            this.btnVerMas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisibilidadDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerMas);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.materialRaisedButton1);
            this.groupBox1.Controls.Add(this.btnActivar);
            this.groupBox1.Controls.Add(this.listadoPublicaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 370);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnActivar
            // 
            this.btnActivar.Depth = 0;
            this.btnActivar.Location = new System.Drawing.Point(298, 319);
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
            this.materialRaisedButton1.Location = new System.Drawing.Point(51, 319);
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
            this.btnModificar.Location = new System.Drawing.Point(148, 319);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = true;
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Depth = 0;
            this.btnVolver.Location = new System.Drawing.Point(778, 319);
            this.btnVolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Primary = true;
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBorradores);
            this.groupBox2.Controls.Add(this.rbPausadas);
            this.groupBox2.Controls.Add(this.rbFinalizadas);
            this.groupBox2.Controls.Add(this.rbActivas);
            this.groupBox2.Controls.Add(this.rbTodas);
            this.groupBox2.Location = new System.Drawing.Point(766, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar";
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Depth = 0;
            this.rbTodas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbTodas.Location = new System.Drawing.Point(3, 16);
            this.rbTodas.Margin = new System.Windows.Forms.Padding(0);
            this.rbTodas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbTodas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Ripple = true;
            this.rbTodas.Size = new System.Drawing.Size(67, 30);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            this.rbTodas.CheckedChanged += new System.EventHandler(this.rbTodas_CheckedChanged);
            // 
            // rbActivas
            // 
            this.rbActivas.AutoSize = true;
            this.rbActivas.Depth = 0;
            this.rbActivas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbActivas.Location = new System.Drawing.Point(3, 73);
            this.rbActivas.Margin = new System.Windows.Forms.Padding(0);
            this.rbActivas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbActivas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbActivas.Name = "rbActivas";
            this.rbActivas.Ripple = true;
            this.rbActivas.Size = new System.Drawing.Size(75, 30);
            this.rbActivas.TabIndex = 1;
            this.rbActivas.TabStop = true;
            this.rbActivas.Text = "Activas";
            this.rbActivas.UseVisualStyleBackColor = true;
            // 
            // rbFinalizadas
            // 
            this.rbFinalizadas.AutoSize = true;
            this.rbFinalizadas.Depth = 0;
            this.rbFinalizadas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbFinalizadas.Location = new System.Drawing.Point(3, 133);
            this.rbFinalizadas.Margin = new System.Windows.Forms.Padding(0);
            this.rbFinalizadas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbFinalizadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbFinalizadas.Name = "rbFinalizadas";
            this.rbFinalizadas.Ripple = true;
            this.rbFinalizadas.Size = new System.Drawing.Size(99, 30);
            this.rbFinalizadas.TabIndex = 2;
            this.rbFinalizadas.TabStop = true;
            this.rbFinalizadas.Text = "Finalizadas";
            this.rbFinalizadas.UseVisualStyleBackColor = true;
            // 
            // rbPausadas
            // 
            this.rbPausadas.AutoSize = true;
            this.rbPausadas.Depth = 0;
            this.rbPausadas.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbPausadas.Location = new System.Drawing.Point(3, 103);
            this.rbPausadas.Margin = new System.Windows.Forms.Padding(0);
            this.rbPausadas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbPausadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbPausadas.Name = "rbPausadas";
            this.rbPausadas.Ripple = true;
            this.rbPausadas.Size = new System.Drawing.Size(90, 30);
            this.rbPausadas.TabIndex = 3;
            this.rbPausadas.TabStop = true;
            this.rbPausadas.Text = "Pausadas";
            this.rbPausadas.UseVisualStyleBackColor = true;
            // 
            // rbBorradores
            // 
            this.rbBorradores.AutoSize = true;
            this.rbBorradores.Depth = 0;
            this.rbBorradores.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBorradores.Location = new System.Drawing.Point(3, 46);
            this.rbBorradores.Margin = new System.Windows.Forms.Padding(0);
            this.rbBorradores.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBorradores.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBorradores.Name = "rbBorradores";
            this.rbBorradores.Ripple = true;
            this.rbBorradores.Size = new System.Drawing.Size(97, 30);
            this.rbBorradores.TabIndex = 4;
            this.rbBorradores.TabStop = true;
            this.rbBorradores.Text = "Borradores";
            this.rbBorradores.UseVisualStyleBackColor = true;
            // 
            // listadoPublicaciones
            // 
            this.listadoPublicaciones.AllowUserToAddRows = false;
            this.listadoPublicaciones.AllowUserToDeleteRows = false;
            this.listadoPublicaciones.AllowUserToResizeColumns = false;
            this.listadoPublicaciones.AllowUserToResizeRows = false;
            this.listadoPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoPublicaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.listadoPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoPublicaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Estado,
            this.VisibilidadDescripcion,
            this.FechaInicio,
            this.FechaFin,
            this.Descripcion});
            this.listadoPublicaciones.Location = new System.Drawing.Point(24, 59);
            this.listadoPublicaciones.Name = "listadoPublicaciones";
            this.listadoPublicaciones.ReadOnly = true;
            this.listadoPublicaciones.Size = new System.Drawing.Size(736, 169);
            this.listadoPublicaciones.TabIndex = 1;
            this.listadoPublicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoPublicaciones_CellContentClick);
            // 
            // btnVerMas
            // 
            this.btnVerMas.Depth = 0;
            this.btnVerMas.Location = new System.Drawing.Point(683, 234);
            this.btnVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Primary = true;
            this.btnVerMas.Size = new System.Drawing.Size(66, 17);
            this.btnVerMas.TabIndex = 8;
            this.btnVerMas.Text = "Ver Mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // VisibilidadDescripcion
            // 
            this.VisibilidadDescripcion.HeaderText = "Visibilidad Descripcion";
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
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 511);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoPublicaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnVolver;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificar;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinalizar;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnActivar;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rbBorradores;
        private MaterialSkin.Controls.MaterialRadioButton rbPausadas;
        private MaterialSkin.Controls.MaterialRadioButton rbFinalizadas;
        private MaterialSkin.Controls.MaterialRadioButton rbActivas;
        private MaterialSkin.Controls.MaterialRadioButton rbTodas;
        private System.Windows.Forms.DataGridView listadoPublicaciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnVerMas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisibilidadDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}