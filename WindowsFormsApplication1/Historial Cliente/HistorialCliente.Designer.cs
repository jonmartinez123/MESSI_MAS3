namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialCliente
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
            this.historialGridView = new System.Windows.Forms.DataGridView();
            this.idPubli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPubli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.porCalificar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCalificadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertasGanadoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.historialGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // historialGridView
            // 
            this.historialGridView.AllowUserToAddRows = false;
            this.historialGridView.AllowUserToDeleteRows = false;
            this.historialGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPubli,
            this.fechaP,
            this.tipoPubli,
            this.valor,
            this.detalle});
            this.historialGridView.Location = new System.Drawing.Point(13, 29);
            this.historialGridView.Name = "historialGridView";
            this.historialGridView.Size = new System.Drawing.Size(961, 349);
            this.historialGridView.TabIndex = 6;
            // 
            // idPubli
            // 
            this.idPubli.HeaderText = "Publicacion ID";
            this.idPubli.Name = "idPubli";
            this.idPubli.ReadOnly = true;
            this.idPubli.Width = 120;
            // 
            // fechaP
            // 
            this.fechaP.HeaderText = "Fecha";
            this.fechaP.Name = "fechaP";
            this.fechaP.ReadOnly = true;
            // 
            // tipoPubli
            // 
            this.tipoPubli.HeaderText = "Tipo Publicacion";
            this.tipoPubli.Name = "tipoPubli";
            this.tipoPubli.ReadOnly = true;
            this.tipoPubli.Width = 130;
            // 
            // valor
            // 
            this.valor.HeaderText = "Precio/Oferta";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle Publicacion";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 450;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.historialGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(995, 398);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial como cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 509);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.porCalificar,
            this.comprasCalificadas,
            this.totalEstrellas,
            this.ofertasGanadoras});
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 116);
            this.dataGridView1.TabIndex = 7;
            // 
            // porCalificar
            // 
            this.porCalificar.HeaderText = "Compras sin calificar";
            this.porCalificar.Name = "porCalificar";
            this.porCalificar.ReadOnly = true;
            this.porCalificar.Width = 150;
            // 
            // comprasCalificadas
            // 
            this.comprasCalificadas.HeaderText = "Compras calificadas";
            this.comprasCalificadas.Name = "comprasCalificadas";
            this.comprasCalificadas.ReadOnly = true;
            this.comprasCalificadas.Width = 150;
            // 
            // totalEstrellas
            // 
            this.totalEstrellas.HeaderText = "Total estrellas otorgadas";
            this.totalEstrellas.Name = "totalEstrellas";
            this.totalEstrellas.ReadOnly = true;
            this.totalEstrellas.Width = 150;
            // 
            // ofertasGanadoras
            // 
            this.ofertasGanadoras.HeaderText = "Cantidad ofertas ganadoras";
            this.ofertasGanadoras.Name = "ofertasGanadoras";
            this.ofertasGanadoras.ReadOnly = true;
            this.ofertasGanadoras.Width = 200;
            // 
            // HistorialCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 714);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "HistorialCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial del cliente";
            this.Load += new System.EventHandler(this.HistorialCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historialGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historialGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPubli;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPubli;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn porCalificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCalificadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofertasGanadoras;
    }
}