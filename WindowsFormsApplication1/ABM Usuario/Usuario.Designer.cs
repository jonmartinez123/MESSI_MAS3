namespace MercadoEnvio.ABM_Usuario
{
    partial class Usuario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFiltrarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnHabilitadoCliente = new System.Windows.Forms.Button();
            this.btnCambiarPassCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntentosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnResetearIntentosEmpresa = new System.Windows.Forms.Button();
            this.btnLimpiarEmpresa = new System.Windows.Forms.Button();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFiltrarEmpresas = new System.Windows.Forms.Button();
            this.btnModificarEmpresa = new System.Windows.Forms.Button();
            this.btnLogicoEmpresa = new System.Windows.Forms.Button();
            this.btnCambiarPassEmpresa = new System.Windows.Forms.Button();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.colIdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMailEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabilitadoEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntentosEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMailEmpresa = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 343);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnResetear);
            this.tabPage1.Controls.Add(this.btnLimpiarCliente);
            this.tabPage1.Controls.Add(this.cmbTipoDocumento);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.btnFiltrarCliente);
            this.tabPage1.Controls.Add(this.btnModificarCliente);
            this.tabPage1.Controls.Add(this.btnHabilitadoCliente);
            this.tabPage1.Controls.Add(this.btnCambiarPassCliente);
            this.tabPage1.Controls.Add(this.dgvClientes);
            this.tabPage1.Controls.Add(this.txtDni);
            this.tabPage1.Controls.Add(this.txtMailCliente);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.materialLabel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(248, 272);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(100, 23);
            this.btnResetear.TabIndex = 114;
            this.btnResetear.Text = "Resetear Intentos";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(135, 87);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(109, 23);
            this.btnLimpiarCliente.TabIndex = 113;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(469, 62);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(94, 21);
            this.cmbTipoDocumento.TabIndex = 112;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(376, 64);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(87, 19);
            this.materialLabel5.TabIndex = 111;
            this.materialLabel5.Text = "Documento";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(376, 37);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 110;
            this.materialLabel6.Text = "Mail";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 60);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 19);
            this.materialLabel4.TabIndex = 109;
            this.materialLabel4.Text = "Apellido";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 108;
            this.materialLabel2.Text = "Nombre";
            // 
            // btnFiltrarCliente
            // 
            this.btnFiltrarCliente.Location = new System.Drawing.Point(20, 87);
            this.btnFiltrarCliente.Name = "btnFiltrarCliente";
            this.btnFiltrarCliente.Size = new System.Drawing.Size(109, 23);
            this.btnFiltrarCliente.TabIndex = 107;
            this.btnFiltrarCliente.Text = "Filtrar";
            this.btnFiltrarCliente.UseVisualStyleBackColor = true;
            this.btnFiltrarCliente.Click += new System.EventHandler(this.btnFiltrarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(354, 272);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(109, 23);
            this.btnModificarCliente.TabIndex = 105;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnHabilitadoCliente
            // 
            this.btnHabilitadoCliente.Location = new System.Drawing.Point(584, 272);
            this.btnHabilitadoCliente.Name = "btnHabilitadoCliente";
            this.btnHabilitadoCliente.Size = new System.Drawing.Size(109, 23);
            this.btnHabilitadoCliente.TabIndex = 104;
            this.btnHabilitadoCliente.Text = "Dar de Baja";
            this.btnHabilitadoCliente.UseVisualStyleBackColor = true;
            this.btnHabilitadoCliente.Click += new System.EventHandler(this.btnHabilitadoCliente_Click);
            // 
            // btnCambiarPassCliente
            // 
            this.btnCambiarPassCliente.Location = new System.Drawing.Point(469, 272);
            this.btnCambiarPassCliente.Name = "btnCambiarPassCliente";
            this.btnCambiarPassCliente.Size = new System.Drawing.Size(109, 23);
            this.btnCambiarPassCliente.TabIndex = 106;
            this.btnCambiarPassCliente.Text = "Cambiar Password";
            this.btnCambiarPassCliente.UseVisualStyleBackColor = true;
            this.btnCambiarPassCliente.Click += new System.EventHandler(this.btnCambiarPassCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUsuario,
            this.colNombre,
            this.colApellido,
            this.colDNI,
            this.colMail,
            this.colHabilitado,
            this.IntentosCliente});
            this.dgvClientes.Location = new System.Drawing.Point(20, 116);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(673, 150);
            this.dgvClientes.TabIndex = 103;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.HeaderText = "Documento";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            // 
            // colMail
            // 
            this.colMail.HeaderText = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.ReadOnly = true;
            // 
            // colHabilitado
            // 
            this.colHabilitado.HeaderText = "Deleted";
            this.colHabilitado.Name = "colHabilitado";
            this.colHabilitado.ReadOnly = true;
            // 
            // IntentosCliente
            // 
            this.IntentosCliente.HeaderText = "Intentos";
            this.IntentosCliente.Name = "IntentosCliente";
            this.IntentosCliente.ReadOnly = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(574, 63);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(119, 20);
            this.txtDni.TabIndex = 94;
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(420, 37);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(273, 20);
            this.txtMailCliente.TabIndex = 93;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(91, 59);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(269, 20);
            this.txtApellido.TabIndex = 92;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 20);
            this.txtNombre.TabIndex = 91;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(16, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 90;
            this.materialLabel3.Text = "Filtros";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnResetearIntentosEmpresa);
            this.tabPage2.Controls.Add(this.btnLimpiarEmpresa);
            this.tabPage2.Controls.Add(this.materialLabel9);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.btnFiltrarEmpresas);
            this.tabPage2.Controls.Add(this.btnModificarEmpresa);
            this.tabPage2.Controls.Add(this.btnLogicoEmpresa);
            this.tabPage2.Controls.Add(this.btnCambiarPassEmpresa);
            this.tabPage2.Controls.Add(this.dgvEmpresas);
            this.tabPage2.Controls.Add(this.txtMailEmpresa);
            this.tabPage2.Controls.Add(this.txtCUIT);
            this.tabPage2.Controls.Add(this.txtRazonSocial);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empresas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnResetearIntentosEmpresa
            // 
            this.btnResetearIntentosEmpresa.Location = new System.Drawing.Point(248, 272);
            this.btnResetearIntentosEmpresa.Name = "btnResetearIntentosEmpresa";
            this.btnResetearIntentosEmpresa.Size = new System.Drawing.Size(100, 23);
            this.btnResetearIntentosEmpresa.TabIndex = 115;
            this.btnResetearIntentosEmpresa.Text = "Resetear Intentos";
            this.btnResetearIntentosEmpresa.UseVisualStyleBackColor = true;
            this.btnResetearIntentosEmpresa.Click += new System.EventHandler(this.btnResetearIntentosEmpresa_Click);
            // 
            // btnLimpiarEmpresa
            // 
            this.btnLimpiarEmpresa.Location = new System.Drawing.Point(135, 87);
            this.btnLimpiarEmpresa.Name = "btnLimpiarEmpresa";
            this.btnLimpiarEmpresa.Size = new System.Drawing.Size(109, 23);
            this.btnLimpiarEmpresa.TabIndex = 114;
            this.btnLimpiarEmpresa.Text = "Limpiar";
            this.btnLimpiarEmpresa.UseVisualStyleBackColor = true;
            this.btnLimpiarEmpresa.Click += new System.EventHandler(this.btnLimpiarEmpresa_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(398, 35);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(38, 19);
            this.materialLabel9.TabIndex = 111;
            this.materialLabel9.Text = "Mail";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(21, 59);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(42, 19);
            this.materialLabel8.TabIndex = 110;
            this.materialLabel8.Text = "CUIT";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(22, 35);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(96, 19);
            this.materialLabel7.TabIndex = 109;
            this.materialLabel7.Text = "Razón Social";
            // 
            // btnFiltrarEmpresas
            // 
            this.btnFiltrarEmpresas.Location = new System.Drawing.Point(20, 87);
            this.btnFiltrarEmpresas.Name = "btnFiltrarEmpresas";
            this.btnFiltrarEmpresas.Size = new System.Drawing.Size(109, 23);
            this.btnFiltrarEmpresas.TabIndex = 108;
            this.btnFiltrarEmpresas.Text = "Filtrar";
            this.btnFiltrarEmpresas.UseVisualStyleBackColor = true;
            this.btnFiltrarEmpresas.Click += new System.EventHandler(this.btnFiltrarEmpresas_Click);
            // 
            // btnModificarEmpresa
            // 
            this.btnModificarEmpresa.Location = new System.Drawing.Point(354, 272);
            this.btnModificarEmpresa.Name = "btnModificarEmpresa";
            this.btnModificarEmpresa.Size = new System.Drawing.Size(109, 23);
            this.btnModificarEmpresa.TabIndex = 101;
            this.btnModificarEmpresa.Text = "Modificar";
            this.btnModificarEmpresa.UseVisualStyleBackColor = true;
            this.btnModificarEmpresa.Click += new System.EventHandler(this.btnModificarEmpresa_Click);
            // 
            // btnLogicoEmpresa
            // 
            this.btnLogicoEmpresa.Location = new System.Drawing.Point(584, 272);
            this.btnLogicoEmpresa.Name = "btnLogicoEmpresa";
            this.btnLogicoEmpresa.Size = new System.Drawing.Size(109, 23);
            this.btnLogicoEmpresa.TabIndex = 100;
            this.btnLogicoEmpresa.Text = "Dar de Baja";
            this.btnLogicoEmpresa.UseVisualStyleBackColor = true;
            this.btnLogicoEmpresa.Click += new System.EventHandler(this.btnLogicoEmpresa_Click);
            // 
            // btnCambiarPassEmpresa
            // 
            this.btnCambiarPassEmpresa.Location = new System.Drawing.Point(469, 272);
            this.btnCambiarPassEmpresa.Name = "btnCambiarPassEmpresa";
            this.btnCambiarPassEmpresa.Size = new System.Drawing.Size(109, 23);
            this.btnCambiarPassEmpresa.TabIndex = 102;
            this.btnCambiarPassEmpresa.Text = "Cambiar Password";
            this.btnCambiarPassEmpresa.UseVisualStyleBackColor = true;
            this.btnCambiarPassEmpresa.Click += new System.EventHandler(this.btnCambiarPassEmpresa_Click);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToAddRows = false;
            this.dgvEmpresas.AllowUserToDeleteRows = false;
            this.dgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdEmpresa,
            this.colUsuarioEmpresa,
            this.colRazonSocial,
            this.colCUIT,
            this.colMailEmpresa,
            this.colNombreContacto,
            this.colHabilitadoEmpresa,
            this.IntentosEmpresa});
            this.dgvEmpresas.Location = new System.Drawing.Point(20, 116);
            this.dgvEmpresas.MultiSelect = false;
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.ReadOnly = true;
            this.dgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpresas.ShowEditingIcon = false;
            this.dgvEmpresas.Size = new System.Drawing.Size(673, 150);
            this.dgvEmpresas.TabIndex = 99;
            this.dgvEmpresas.SelectionChanged += new System.EventHandler(this.dgvEmpresas_SelectionChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.HeaderText = "Id";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.ReadOnly = true;
            this.colIdEmpresa.Visible = false;
            // 
            // colUsuarioEmpresa
            // 
            this.colUsuarioEmpresa.HeaderText = "Usuario";
            this.colUsuarioEmpresa.Name = "colUsuarioEmpresa";
            this.colUsuarioEmpresa.ReadOnly = true;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razón social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colCUIT
            // 
            this.colCUIT.HeaderText = "CUIT";
            this.colCUIT.Name = "colCUIT";
            this.colCUIT.ReadOnly = true;
            // 
            // colMailEmpresa
            // 
            this.colMailEmpresa.HeaderText = "Mail";
            this.colMailEmpresa.Name = "colMailEmpresa";
            this.colMailEmpresa.ReadOnly = true;
            // 
            // colNombreContacto
            // 
            this.colNombreContacto.HeaderText = "Contacto";
            this.colNombreContacto.Name = "colNombreContacto";
            this.colNombreContacto.ReadOnly = true;
            // 
            // colHabilitadoEmpresa
            // 
            this.colHabilitadoEmpresa.HeaderText = "Deleted";
            this.colHabilitadoEmpresa.Name = "colHabilitadoEmpresa";
            this.colHabilitadoEmpresa.ReadOnly = true;
            // 
            // IntentosEmpresa
            // 
            this.IntentosEmpresa.HeaderText = "Intentos";
            this.IntentosEmpresa.Name = "IntentosEmpresa";
            this.IntentosEmpresa.ReadOnly = true;
            // 
            // txtMailEmpresa
            // 
            this.txtMailEmpresa.Location = new System.Drawing.Point(442, 35);
            this.txtMailEmpresa.Name = "txtMailEmpresa";
            this.txtMailEmpresa.Size = new System.Drawing.Size(251, 20);
            this.txtMailEmpresa.TabIndex = 98;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(125, 58);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(233, 20);
            this.txtCUIT.TabIndex = 97;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(125, 35);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(233, 20);
            this.txtRazonSocial.TabIndex = 96;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 19);
            this.materialLabel1.TabIndex = 95;
            this.materialLabel1.Text = "Filtros";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(509, 425);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(109, 23);
            this.btnCrearUsuario.TabIndex = 1;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(624, 425);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(109, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 471);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLogicoEmpresa;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TextBox txtMailEmpresa;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnFiltrarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnHabilitadoCliente;
        private System.Windows.Forms.Button btnCambiarPassCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnFiltrarEmpresas;
        private System.Windows.Forms.Button btnModificarEmpresa;
        private System.Windows.Forms.Button btnCambiarPassEmpresa;
        private System.Windows.Forms.Button btnCrearUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Button btnLimpiarEmpresa;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabilitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosCliente;
        private System.Windows.Forms.Button btnResetearIntentosEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMailEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabilitadoEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosEmpresa;
    }
}