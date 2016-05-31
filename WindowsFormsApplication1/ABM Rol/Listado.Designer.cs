namespace MercadoEnvio.ABM_Rol
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
            this.ListadoRoles = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_habilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox_SeleccionarRol = new System.Windows.Forms.GroupBox();
            this.modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).BeginInit();
            this.groupBox_SeleccionarRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListadoRoles
            // 
            this.ListadoRoles.AllowUserToAddRows = false;
            this.ListadoRoles.AllowUserToDeleteRows = false;
            this.ListadoRoles.AllowUserToResizeColumns = false;
            this.ListadoRoles.AllowUserToResizeRows = false;
            this.ListadoRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListadoRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_rol,
            this.col_habilitado});
            this.ListadoRoles.Location = new System.Drawing.Point(115, 36);
            this.ListadoRoles.Name = "ListadoRoles";
            this.ListadoRoles.Size = new System.Drawing.Size(346, 335);
            this.ListadoRoles.TabIndex = 0;
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_rol
            // 
            this.col_rol.HeaderText = "Rol";
            this.col_rol.Name = "col_rol";
            this.col_rol.ReadOnly = true;
            // 
            // col_habilitado
            // 
            this.col_habilitado.HeaderText = "Habilitado";
            this.col_habilitado.Name = "col_habilitado";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.SystemColors.Menu;
            this.agregar.Location = new System.Drawing.Point(724, 348);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 22;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Cerrar.Location = new System.Drawing.Point(815, 348);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 1;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = false;
            this.button_Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox_SeleccionarRol.Controls.Add(this.modificar);
            this.groupBox_SeleccionarRol.Controls.Add(this.ListadoRoles);
            this.groupBox_SeleccionarRol.Controls.Add(this.agregar);
            this.groupBox_SeleccionarRol.Controls.Add(this.button_Cerrar);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(44, 88);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(924, 400);
            this.groupBox_SeleccionarRol.TabIndex = 22;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Roles";
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.Menu;
            this.modificar.Location = new System.Drawing.Point(629, 348);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 23;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 550);
            this.Controls.Add(this.groupBox_SeleccionarRol);
            this.MaximizeBox = false;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.Rol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).EndInit();
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_habilitado;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.Button modificar;


    }
}