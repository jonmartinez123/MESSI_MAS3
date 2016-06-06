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
            this.groupBox_SeleccionarRol = new System.Windows.Forms.GroupBox();
            this.button_Cerrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.agregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.modificar = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.ListadoRoles.ReadOnly = true;
            this.ListadoRoles.Size = new System.Drawing.Size(611, 255);
            this.ListadoRoles.TabIndex = 0;
            this.ListadoRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoRoles_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.DataPropertyName = "col_id";
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_rol
            // 
            this.col_rol.DataPropertyName = "col_rol";
            this.col_rol.HeaderText = "Rol";
            this.col_rol.Name = "col_rol";
            this.col_rol.ReadOnly = true;
            // 
            // col_habilitado
            // 
            this.col_habilitado.DataPropertyName = "col_habilitado";
            this.col_habilitado.HeaderText = "Habilitado";
            this.col_habilitado.Name = "col_habilitado";
            // 
            // groupBox_SeleccionarRol
            // 
            this.groupBox_SeleccionarRol.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox_SeleccionarRol.Controls.Add(this.button_Cerrar);
            this.groupBox_SeleccionarRol.Controls.Add(this.agregar);
            this.groupBox_SeleccionarRol.Controls.Add(this.modificar);
            this.groupBox_SeleccionarRol.Controls.Add(this.ListadoRoles);
            this.groupBox_SeleccionarRol.Location = new System.Drawing.Point(44, 88);
            this.groupBox_SeleccionarRol.Name = "groupBox_SeleccionarRol";
            this.groupBox_SeleccionarRol.Size = new System.Drawing.Size(924, 400);
            this.groupBox_SeleccionarRol.TabIndex = 22;
            this.groupBox_SeleccionarRol.TabStop = false;
            this.groupBox_SeleccionarRol.Text = "Roles";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Depth = 0;
            this.button_Cerrar.Location = new System.Drawing.Point(583, 348);
            this.button_Cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Primary = true;
            this.button_Cerrar.Size = new System.Drawing.Size(143, 23);
            this.button_Cerrar.TabIndex = 26;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // agregar
            // 
            this.agregar.Depth = 0;
            this.agregar.Location = new System.Drawing.Point(365, 348);
            this.agregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.agregar.Name = "agregar";
            this.agregar.Primary = true;
            this.agregar.Size = new System.Drawing.Size(156, 23);
            this.agregar.TabIndex = 25;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Depth = 0;
            this.modificar.Location = new System.Drawing.Point(115, 348);
            this.modificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificar.Name = "modificar";
            this.modificar.Primary = true;
            this.modificar.Size = new System.Drawing.Size(154, 23);
            this.modificar.TabIndex = 24;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 506);
            this.Controls.Add(this.groupBox_SeleccionarRol);
            this.MaximizeBox = false;
            this.Name = "Listado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoRoles)).EndInit();
            this.groupBox_SeleccionarRol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoRoles;
        private System.Windows.Forms.GroupBox groupBox_SeleccionarRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_habilitado;
        private MaterialSkin.Controls.MaterialRaisedButton button_Cerrar;
        private MaterialSkin.Controls.MaterialRaisedButton agregar;
        private MaterialSkin.Controls.MaterialRaisedButton modificar;


    }
}