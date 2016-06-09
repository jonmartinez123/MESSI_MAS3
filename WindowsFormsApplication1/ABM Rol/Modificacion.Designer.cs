namespace MercadoEnvio.ABM_Rol
{
    partial class Modificacion
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuncionalidadSeleccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cambiarNombre = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Agregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Cerrar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(125, 89);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(149, 20);
            this.Nombre.TabIndex = 30;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.SystemColors.Window;
            this.Estado.Location = new System.Drawing.Point(118, 127);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(73, 17);
            this.Estado.TabIndex = 29;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = false;
            this.Estado.CheckedChanged += new System.EventHandler(this.Estado_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(72, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(72, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre:";
            // 
            // FuncionalidadesRol
            // 
            this.FuncionalidadesRol.AccessibleDescription = "Funcionalidades";
            this.FuncionalidadesRol.AllowUserToAddRows = false;
            this.FuncionalidadesRol.AllowUserToDeleteRows = false;
            this.FuncionalidadesRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionalidadesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_funcionalidades});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(35, 253);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(390, 251);
            this.FuncionalidadesRol.TabIndex = 32;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_funcionalidades
            // 
            this.col_funcionalidades.HeaderText = "Funcionalidades";
            this.col_funcionalidades.Name = "col_funcionalidades";
            // 
            // FuncionalidadSeleccion
            // 
            this.FuncionalidadSeleccion.FormattingEnabled = true;
            this.FuncionalidadSeleccion.Location = new System.Drawing.Point(132, 203);
            this.FuncionalidadSeleccion.Name = "FuncionalidadSeleccion";
            this.FuncionalidadSeleccion.Size = new System.Drawing.Size(187, 21);
            this.FuncionalidadSeleccion.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(50, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Funcionalidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cambiarNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 91);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar nombre Rol";
            // 
            // cambiarNombre
            // 
            this.cambiarNombre.Depth = 0;
            this.cambiarNombre.Location = new System.Drawing.Point(288, 19);
            this.cambiarNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.cambiarNombre.Name = "cambiarNombre";
            this.cambiarNombre.Primary = true;
            this.cambiarNombre.Size = new System.Drawing.Size(125, 23);
            this.cambiarNombre.TabIndex = 0;
            this.cambiarNombre.Text = "Cambiar Nombre";
            this.cambiarNombre.UseVisualStyleBackColor = true;
            this.cambiarNombre.Click += new System.EventHandler(this.cambiarNombre_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.Agregar);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 80);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar funcionalidades";
            // 
            // Agregar
            // 
            this.Agregar.Depth = 0;
            this.Agregar.Location = new System.Drawing.Point(338, 34);
            this.Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar.Name = "Agregar";
            this.Agregar.Primary = true;
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 36;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Depth = 0;
            this.eliminar.Location = new System.Drawing.Point(53, 531);
            this.eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminar.Name = "eliminar";
            this.eliminar.Primary = true;
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 40;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Depth = 0;
            this.Cerrar.Location = new System.Drawing.Point(350, 531);
            this.Cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Primary = true;
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 41;
            this.Cerrar.Text = "Volver";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 595);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FuncionalidadSeleccion);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Modificacion";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.CheckBox Estado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_funcionalidades;
        private System.Windows.Forms.ComboBox FuncionalidadSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton cambiarNombre;
        private MaterialSkin.Controls.MaterialRaisedButton Agregar;
        private MaterialSkin.Controls.MaterialRaisedButton eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton Cerrar;
    }
}