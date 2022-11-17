namespace ProyectoPeluquería
{
    partial class FormaDePago
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
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panelinf = new System.Windows.Forms.Panel();
            this.rb_CreditoDebito = new System.Windows.Forms.RadioButton();
            this.rb_Transferencia = new System.Windows.Forms.RadioButton();
            this.rb_Efectivo = new System.Windows.Forms.RadioButton();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelSup.Controls.Add(this.label7);
            this.PanelSup.Controls.Add(this.pictureBox1);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(443, 25);
            this.PanelSup.TabIndex = 37;
            this.PanelSup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXPanel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Metodos de pago";
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXTitulo);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(418, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 202);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(443, 19);
            this.Panelinf.TabIndex = 36;
            // 
            // rb_CreditoDebito
            // 
            this.rb_CreditoDebito.AutoSize = true;
            this.rb_CreditoDebito.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.rb_CreditoDebito.Image = global::ProyectoPeluquería.Properties.Resources.tarjeta_de_credito;
            this.rb_CreditoDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_CreditoDebito.Location = new System.Drawing.Point(23, 92);
            this.rb_CreditoDebito.Name = "rb_CreditoDebito";
            this.rb_CreditoDebito.Size = new System.Drawing.Size(176, 27);
            this.rb_CreditoDebito.TabIndex = 0;
            this.rb_CreditoDebito.TabStop = true;
            this.rb_CreditoDebito.Text = "Credito / Debito";
            this.rb_CreditoDebito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_CreditoDebito.UseVisualStyleBackColor = true;
            // 
            // rb_Transferencia
            // 
            this.rb_Transferencia.AutoSize = true;
            this.rb_Transferencia.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.rb_Transferencia.Image = global::ProyectoPeluquería.Properties.Resources.banco;
            this.rb_Transferencia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Transferencia.Location = new System.Drawing.Point(23, 140);
            this.rb_Transferencia.Name = "rb_Transferencia";
            this.rb_Transferencia.Size = new System.Drawing.Size(158, 27);
            this.rb_Transferencia.TabIndex = 0;
            this.rb_Transferencia.TabStop = true;
            this.rb_Transferencia.Text = "Transferencia";
            this.rb_Transferencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_Transferencia.UseVisualStyleBackColor = true;
            // 
            // rb_Efectivo
            // 
            this.rb_Efectivo.AutoSize = true;
            this.rb_Efectivo.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.rb_Efectivo.Image = global::ProyectoPeluquería.Properties.Resources.monedas;
            this.rb_Efectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_Efectivo.Location = new System.Drawing.Point(23, 47);
            this.rb_Efectivo.Name = "rb_Efectivo";
            this.rb_Efectivo.Size = new System.Drawing.Size(109, 27);
            this.rb_Efectivo.TabIndex = 0;
            this.rb_Efectivo.TabStop = true;
            this.rb_Efectivo.Text = "Efectivo";
            this.rb_Efectivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rb_Efectivo.UseVisualStyleBackColor = true;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.btn_Aceptar.ForeColor = System.Drawing.Color.Black;
            this.btn_Aceptar.Image = global::ProyectoPeluquería.Properties.Resources.caja__1_;
            this.btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aceptar.Location = new System.Drawing.Point(277, 159);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(154, 37);
            this.btn_Aceptar.TabIndex = 40;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(443, 221);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.rb_CreditoDebito);
            this.Controls.Add(this.rb_Transferencia);
            this.Controls.Add(this.rb_Efectivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaDePago";
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Efectivo;
        private System.Windows.Forms.RadioButton rb_Transferencia;
        private System.Windows.Forms.RadioButton rb_CreditoDebito;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panelinf;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}