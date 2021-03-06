﻿namespace MercadoEnvio.ABM_Rol
{
    partial class AltaRol
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
            this.FuncionalidadesRol = new System.Windows.Forms.DataGridView();
            this.col_funcionalidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosRol = new System.Windows.Forms.GroupBox();
            this.Estado = new MaterialSkin.Controls.MaterialCheckBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Agregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Funcionalidad = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.quitar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Cerrar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).BeginInit();
            this.datosRol.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FuncionalidadesRol
            // 
            this.FuncionalidadesRol.AllowUserToAddRows = false;
            this.FuncionalidadesRol.AllowUserToDeleteRows = false;
            this.FuncionalidadesRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionalidadesRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionalidadesRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_funcionalidades});
            this.FuncionalidadesRol.Location = new System.Drawing.Point(45, 298);
            this.FuncionalidadesRol.Name = "FuncionalidadesRol";
            this.FuncionalidadesRol.Size = new System.Drawing.Size(425, 246);
            this.FuncionalidadesRol.TabIndex = 20;
            // 
            // col_funcionalidades
            // 
            this.col_funcionalidades.HeaderText = "Funcionalidades";
            this.col_funcionalidades.Name = "col_funcionalidades";
            this.col_funcionalidades.ReadOnly = true;
            // 
            // datosRol
            // 
            this.datosRol.BackColor = System.Drawing.SystemColors.Window;
            this.datosRol.Controls.Add(this.Estado);
            this.datosRol.Controls.Add(this.Nombre);
            this.datosRol.Controls.Add(this.label2);
            this.datosRol.Controls.Add(this.label1);
            this.datosRol.Location = new System.Drawing.Point(28, 76);
            this.datosRol.Name = "datosRol";
            this.datosRol.Size = new System.Drawing.Size(471, 123);
            this.datosRol.TabIndex = 21;
            this.datosRol.TabStop = false;
            this.datosRol.Text = "Datos del rol a crear";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Depth = 0;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Estado.Location = new System.Drawing.Point(84, 66);
            this.Estado.Margin = new System.Windows.Forms.Padding(0);
            this.Estado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Estado.MouseState = MaterialSkin.MouseState.HOVER;
            this.Estado.Name = "Estado";
            this.Estado.Ripple = true;
            this.Estado.Size = new System.Drawing.Size(93, 30);
            this.Estado.TabIndex = 27;
            this.Estado.Text = "Habilitado";
            this.Estado.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(84, 35);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(149, 20);
            this.Nombre.TabIndex = 26;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.Agregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Funcionalidad);
            this.groupBox1.Location = new System.Drawing.Point(28, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 67);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionalidades disponibles";
            // 
            // Agregar
            // 
            this.Agregar.Depth = 0;
            this.Agregar.Location = new System.Drawing.Point(367, 19);
            this.Agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Agregar.Name = "Agregar";
            this.Agregar.Primary = true;
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 29;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Seleccionar:";
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.FormattingEnabled = true;
            this.Funcionalidad.Location = new System.Drawing.Point(129, 19);
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.Size = new System.Drawing.Size(207, 21);
            this.Funcionalidad.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.Cerrar);
            this.groupBox2.Controls.Add(this.quitar);
            this.groupBox2.Controls.Add(this.guardar);
            this.groupBox2.Location = new System.Drawing.Point(28, 566);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 60);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            // 
            // guardar
            // 
            this.guardar.Depth = 0;
            this.guardar.Location = new System.Drawing.Point(246, 19);
            this.guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.guardar.Name = "guardar";
            this.guardar.Primary = true;
            this.guardar.Size = new System.Drawing.Size(67, 23);
            this.guardar.TabIndex = 27;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // quitar
            // 
            this.quitar.Depth = 0;
            this.quitar.Location = new System.Drawing.Point(319, 19);
            this.quitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.quitar.Name = "quitar";
            this.quitar.Primary = true;
            this.quitar.Size = new System.Drawing.Size(59, 23);
            this.quitar.TabIndex = 28;
            this.quitar.Text = "Quitar";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Depth = 0;
            this.Cerrar.Location = new System.Drawing.Point(384, 19);
            this.Cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Primary = true;
            this.Cerrar.Size = new System.Drawing.Size(58, 23);
            this.Cerrar.TabIndex = 29;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 638);
            this.Controls.Add(this.datosRol);
            this.Controls.Add(this.FuncionalidadesRol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "AltaRol";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta De Rol";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionalidadesRol)).EndInit();
            this.datosRol.ResumeLayout(false);
            this.datosRol.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView FuncionalidadesRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_funcionalidades;
        private System.Windows.Forms.GroupBox datosRol;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Funcionalidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRaisedButton Agregar;
        private MaterialSkin.Controls.MaterialCheckBox Estado;
        private MaterialSkin.Controls.MaterialRaisedButton guardar;
        private MaterialSkin.Controls.MaterialRaisedButton quitar;
        private MaterialSkin.Controls.MaterialRaisedButton Cerrar;
    }
}