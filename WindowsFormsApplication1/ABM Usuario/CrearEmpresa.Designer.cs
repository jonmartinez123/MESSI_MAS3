namespace MercadoEnvio.ABM_Usuario
{
    partial class CrearEmpresa
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
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.txtCodigoPostal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDepto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPiso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAltura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCalle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUIT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.txtNombreContacto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(352, 626);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(156, 23);
            this.btnOK.TabIndex = 108;
            this.btnOK.Text = "Crear";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(276, 473);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(231, 21);
            this.cmbLocalidad.TabIndex = 107;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Depth = 0;
            this.txtCodigoPostal.Hint = "";
            this.txtCodigoPostal.Location = new System.Drawing.Point(277, 572);
            this.txtCodigoPostal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.PasswordChar = '\0';
            this.txtCodigoPostal.SelectedText = "";
            this.txtCodigoPostal.SelectionLength = 0;
            this.txtCodigoPostal.SelectionStart = 0;
            this.txtCodigoPostal.Size = new System.Drawing.Size(231, 23);
            this.txtCodigoPostal.TabIndex = 105;
            this.txtCodigoPostal.UseSystemPasswordChar = false;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(86, 524);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(55, 19);
            this.materialLabel8.TabIndex = 106;
            this.materialLabel8.Text = "Ciudad";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(86, 475);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(74, 19);
            this.materialLabel9.TabIndex = 104;
            this.materialLabel9.Text = "Localidad";
            // 
            // txtDepto
            // 
            this.txtDepto.Depth = 0;
            this.txtDepto.Hint = "Departamento";
            this.txtDepto.Location = new System.Drawing.Point(351, 421);
            this.txtDepto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.PasswordChar = '\0';
            this.txtDepto.SelectedText = "";
            this.txtDepto.SelectionLength = 0;
            this.txtDepto.SelectionStart = 0;
            this.txtDepto.Size = new System.Drawing.Size(107, 23);
            this.txtDepto.TabIndex = 103;
            this.txtDepto.UseSystemPasswordChar = false;
            this.txtDepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepto_KeyPress);
            // 
            // txtPiso
            // 
            this.txtPiso.Depth = 0;
            this.txtPiso.Hint = "Piso";
            this.txtPiso.Location = new System.Drawing.Point(277, 421);
            this.txtPiso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.PasswordChar = '\0';
            this.txtPiso.SelectedText = "";
            this.txtPiso.SelectionLength = 0;
            this.txtPiso.SelectionStart = 0;
            this.txtPiso.Size = new System.Drawing.Size(68, 23);
            this.txtPiso.TabIndex = 102;
            this.txtPiso.UseSystemPasswordChar = false;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Depth = 0;
            this.txtAltura.Hint = "Altura";
            this.txtAltura.Location = new System.Drawing.Point(433, 392);
            this.txtAltura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.Size = new System.Drawing.Size(75, 23);
            this.txtAltura.TabIndex = 101;
            this.txtAltura.UseSystemPasswordChar = false;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Depth = 0;
            this.txtCalle.Hint = "Calle";
            this.txtCalle.Location = new System.Drawing.Point(276, 392);
            this.txtCalle.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.Size = new System.Drawing.Size(151, 23);
            this.txtCalle.TabIndex = 99;
            this.txtCalle.UseSystemPasswordChar = false;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(86, 396);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(73, 19);
            this.materialLabel7.TabIndex = 100;
            this.materialLabel7.Text = "Dirección";
            // 
            // txtTel
            // 
            this.txtTel.Depth = 0;
            this.txtTel.Hint = "";
            this.txtTel.Location = new System.Drawing.Point(276, 343);
            this.txtTel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.SelectedText = "";
            this.txtTel.SelectionLength = 0;
            this.txtTel.SelectionStart = 0;
            this.txtTel.Size = new System.Drawing.Size(231, 23);
            this.txtTel.TabIndex = 95;
            this.txtTel.UseSystemPasswordChar = false;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(86, 347);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 96;
            this.materialLabel4.Text = "Teléfono";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(87, 251);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(149, 19);
            this.materialLabel5.TabIndex = 94;
            this.materialLabel5.Text = "Nombre de Contacto";
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "";
            this.txtMail.Location = new System.Drawing.Point(276, 294);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(231, 23);
            this.txtMail.TabIndex = 92;
            this.txtMail.UseSystemPasswordChar = false;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(86, 298);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(38, 19);
            this.materialLabel6.TabIndex = 93;
            this.materialLabel6.Text = "Mail";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(87, 107);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(96, 19);
            this.materialLabel3.TabIndex = 89;
            this.materialLabel3.Text = "Razón Social";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Depth = 0;
            this.txtCUIT.Hint = "";
            this.txtCUIT.Location = new System.Drawing.Point(277, 152);
            this.txtCUIT.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.PasswordChar = '\0';
            this.txtCUIT.SelectedText = "";
            this.txtCUIT.SelectionLength = 0;
            this.txtCUIT.SelectionStart = 0;
            this.txtCUIT.Size = new System.Drawing.Size(231, 23);
            this.txtCUIT.TabIndex = 87;
            this.txtCUIT.UseSystemPasswordChar = false;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRazonSocial.Hint = "";
            this.txtRazonSocial.Location = new System.Drawing.Point(277, 107);
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.Size = new System.Drawing.Size(231, 23);
            this.txtRazonSocial.TabIndex = 86;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(87, 156);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 88;
            this.materialLabel2.Text = "CUIT";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(87, 205);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 19);
            this.materialLabel1.TabIndex = 91;
            this.materialLabel1.Text = "Rubro Principal";
            // 
            // cmbRubro
            // 
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Cedula"});
            this.cmbRubro.Location = new System.Drawing.Point(277, 201);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(230, 21);
            this.cmbRubro.TabIndex = 98;
            this.cmbRubro.Tag = "";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Depth = 0;
            this.txtNombreContacto.Hint = "";
            this.txtNombreContacto.Location = new System.Drawing.Point(277, 247);
            this.txtNombreContacto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.PasswordChar = '\0';
            this.txtNombreContacto.SelectedText = "";
            this.txtNombreContacto.SelectionLength = 0;
            this.txtNombreContacto.SelectionStart = 0;
            this.txtNombreContacto.Size = new System.Drawing.Size(231, 23);
            this.txtNombreContacto.TabIndex = 109;
            this.txtNombreContacto.UseSystemPasswordChar = false;
            this.txtNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreContacto_KeyPress);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(86, 576);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(103, 19);
            this.materialLabel10.TabIndex = 111;
            this.materialLabel10.Text = "Código postal";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(276, 522);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(231, 21);
            this.cmbCiudad.TabIndex = 112;
            // 
            // CrearEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 690);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.txtPiso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.materialLabel2);
            this.Name = "CrearEmpresa";
            this.Text = "Crear Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoPostal;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDepto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPiso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAltura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCalle;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTel;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCUIT;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRazonSocial;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cmbRubro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreContacto;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.ComboBox cmbCiudad;
    }
}