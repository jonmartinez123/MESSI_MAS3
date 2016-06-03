namespace MercadoEnvio.Calificar
{
    partial class Calificar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calificacionesPendientes = new System.Windows.Forms.DataGridView();
            this.calificar_button = new System.Windows.Forms.Button();
            this.historicoCalificacionesUltimas = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPubli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallePublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPubli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasxEstrellas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.estrellasCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrarCalificacion_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoCalificacionesUltimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasxEstrellas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.cerrarCalificacion_button);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(27, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion historica";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.calificar_button);
            this.groupBox2.Controls.Add(this.calificacionesPendientes);
            this.groupBox2.Location = new System.Drawing.Point(27, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calificaciones pendientes";
            // 
            // calificacionesPendientes
            // 
            this.calificacionesPendientes.AllowUserToAddRows = false;
            this.calificacionesPendientes.AllowUserToDeleteRows = false;
            this.calificacionesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calificacionesPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.idPublicacion,
            this.tipoPublicacion,
            this.fechaPubli,
            this.detallePublicacion});
            this.calificacionesPendientes.Location = new System.Drawing.Point(6, 32);
            this.calificacionesPendientes.Name = "calificacionesPendientes";
            this.calificacionesPendientes.Size = new System.Drawing.Size(694, 142);
            this.calificacionesPendientes.TabIndex = 0;
            // 
            // calificar_button
            // 
            this.calificar_button.Location = new System.Drawing.Point(557, 189);
            this.calificar_button.Name = "calificar_button";
            this.calificar_button.Size = new System.Drawing.Size(104, 30);
            this.calificar_button.TabIndex = 1;
            this.calificar_button.Text = "Calificar";
            this.calificar_button.UseVisualStyleBackColor = true;
            // 
            // historicoCalificacionesUltimas
            // 
            this.historicoCalificacionesUltimas.AllowUserToAddRows = false;
            this.historicoCalificacionesUltimas.AllowUserToDeleteRows = false;
            this.historicoCalificacionesUltimas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historicoCalificacionesUltimas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCalificacion,
            this.tipoPubli,
            this.cantEstrellas,
            this.detalleCalificacion});
            this.historicoCalificacionesUltimas.Location = new System.Drawing.Point(6, 19);
            this.historicoCalificacionesUltimas.Name = "historicoCalificacionesUltimas";
            this.historicoCalificacionesUltimas.Size = new System.Drawing.Size(639, 141);
            this.historicoCalificacionesUltimas.TabIndex = 2;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "Compra ID";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            // 
            // idPublicacion
            // 
            this.idPublicacion.HeaderText = "Publicacion ID";
            this.idPublicacion.Name = "idPublicacion";
            this.idPublicacion.ReadOnly = true;
            this.idPublicacion.Width = 110;
            // 
            // tipoPublicacion
            // 
            this.tipoPublicacion.HeaderText = "Tipo Publicacion";
            this.tipoPublicacion.Name = "tipoPublicacion";
            this.tipoPublicacion.ReadOnly = true;
            this.tipoPublicacion.Width = 130;
            // 
            // fechaPubli
            // 
            this.fechaPubli.HeaderText = "Fecha publicacion";
            this.fechaPubli.Name = "fechaPubli";
            this.fechaPubli.ReadOnly = true;
            this.fechaPubli.Width = 120;
            // 
            // detallePublicacion
            // 
            this.detallePublicacion.HeaderText = "Detalle publicacion";
            this.detallePublicacion.Name = "detallePublicacion";
            this.detallePublicacion.ReadOnly = true;
            this.detallePublicacion.Width = 200;
            // 
            // idCalificacion
            // 
            this.idCalificacion.HeaderText = "Calificacion ID";
            this.idCalificacion.Name = "idCalificacion";
            this.idCalificacion.ReadOnly = true;
            // 
            // tipoPubli
            // 
            this.tipoPubli.HeaderText = "Tipo";
            this.tipoPubli.Name = "tipoPubli";
            this.tipoPubli.ReadOnly = true;
            // 
            // cantEstrellas
            // 
            this.cantEstrellas.HeaderText = "Estrellas";
            this.cantEstrellas.Name = "cantEstrellas";
            this.cantEstrellas.ReadOnly = true;
            // 
            // detalleCalificacion
            // 
            this.detalleCalificacion.HeaderText = "Detalle calificacion";
            this.detalleCalificacion.Name = "detalleCalificacion";
            this.detalleCalificacion.ReadOnly = true;
            this.detalleCalificacion.Width = 300;
            // 
            // comprasxEstrellas
            // 
            this.comprasxEstrellas.AllowUserToAddRows = false;
            this.comprasxEstrellas.AllowUserToDeleteRows = false;
            this.comprasxEstrellas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasxEstrellas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estrellasCant,
            this.comprasCantidad});
            this.comprasxEstrellas.Location = new System.Drawing.Point(6, 19);
            this.comprasxEstrellas.Name = "comprasxEstrellas";
            this.comprasxEstrellas.Size = new System.Drawing.Size(272, 117);
            this.comprasxEstrellas.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.historicoCalificacionesUltimas);
            this.groupBox3.Location = new System.Drawing.Point(19, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 172);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ultimas 5 calificaciones";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comprasxEstrellas);
            this.groupBox4.Location = new System.Drawing.Point(19, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 158);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad de compras ";
            // 
            // estrellasCant
            // 
            this.estrellasCant.HeaderText = "Estrellas";
            this.estrellasCant.Name = "estrellasCant";
            this.estrellasCant.ReadOnly = true;
            this.estrellasCant.Width = 70;
            // 
            // comprasCantidad
            // 
            this.comprasCantidad.HeaderText = "Cantidad de compras";
            this.comprasCantidad.Name = "comprasCantidad";
            this.comprasCantidad.ReadOnly = true;
            this.comprasCantidad.Width = 150;
            // 
            // cerrarCalificacion_button
            // 
            this.cerrarCalificacion_button.Location = new System.Drawing.Point(531, 302);
            this.cerrarCalificacion_button.Name = "cerrarCalificacion_button";
            this.cerrarCalificacion_button.Size = new System.Drawing.Size(130, 43);
            this.cerrarCalificacion_button.TabIndex = 5;
            this.cerrarCalificacion_button.Text = "Cerrar";
            this.cerrarCalificacion_button.UseVisualStyleBackColor = true;
            this.cerrarCalificacion_button.Click += new System.EventHandler(this.cerrarCalificacion_button_Click);
            // 
            // Calificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 700);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Calificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calificacion";
            this.Load += new System.EventHandler(this.Calificar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calificacionesPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoCalificacionesUltimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasxEstrellas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView calificacionesPendientes;
        private System.Windows.Forms.Button calificar_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView historicoCalificacionesUltimas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPubli;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleCalificacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView comprasxEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estrellasCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPubli;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallePublicacion;
        private System.Windows.Forms.Button cerrarCalificacion_button;
    }
}