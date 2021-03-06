﻿namespace MercadoEnvio.ComprarOfertar
{
    partial class Ofertar
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblValorActual = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValorOfertado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnOfertar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(104, 19);
            this.materialLabel2.TabIndex = 115;
            this.materialLabel2.Text = "Valor minimo:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // lblValorActual
            // 
            this.lblValorActual.AutoSize = true;
            this.lblValorActual.Depth = 0;
            this.lblValorActual.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblValorActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblValorActual.Location = new System.Drawing.Point(123, 84);
            this.lblValorActual.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblValorActual.Name = "lblValorActual";
            this.lblValorActual.Size = new System.Drawing.Size(0, 19);
            this.lblValorActual.TabIndex = 116;
            this.lblValorActual.Click += new System.EventHandler(this.lblValorActual_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 116);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 117;
            this.materialLabel3.Text = "Oferta:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtValorOfertado
            // 
            this.txtValorOfertado.BackColor = System.Drawing.SystemColors.Menu;
            this.txtValorOfertado.Depth = 0;
            this.txtValorOfertado.Hint = "";
            this.txtValorOfertado.Location = new System.Drawing.Point(127, 114);
            this.txtValorOfertado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValorOfertado.Name = "txtValorOfertado";
            this.txtValorOfertado.PasswordChar = '\0';
            this.txtValorOfertado.SelectedText = "";
            this.txtValorOfertado.SelectionLength = 0;
            this.txtValorOfertado.SelectionStart = 0;
            this.txtValorOfertado.Size = new System.Drawing.Size(163, 23);
            this.txtValorOfertado.TabIndex = 118;
            this.txtValorOfertado.UseSystemPasswordChar = false;
            this.txtValorOfertado.Click += new System.EventHandler(this.txtValorOfertado_Click);
            this.txtValorOfertado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorOfertado_KeyPress);
            // 
            // btnOfertar
            // 
            this.btnOfertar.Depth = 0;
            this.btnOfertar.Location = new System.Drawing.Point(185, 145);
            this.btnOfertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOfertar.Name = "btnOfertar";
            this.btnOfertar.Primary = true;
            this.btnOfertar.Size = new System.Drawing.Size(105, 23);
            this.btnOfertar.TabIndex = 121;
            this.btnOfertar.Text = "Ofertar";
            this.btnOfertar.UseVisualStyleBackColor = true;
            this.btnOfertar.Click += new System.EventHandler(this.btnOfertar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(72, 116);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 122;
            this.materialLabel1.Text = "ARS $";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // Ofertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(305, 181);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnOfertar);
            this.Controls.Add(this.txtValorOfertado);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblValorActual);
            this.Controls.Add(this.materialLabel2);
            this.Name = "Ofertar";
            this.Text = "Ofertar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblValorActual;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValorOfertado;
        private MaterialSkin.Controls.MaterialRaisedButton btnOfertar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}