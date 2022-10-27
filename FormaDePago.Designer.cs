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
            this.Panelinf = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.PanelSup.Size = new System.Drawing.Size(324, 25);
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
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Metodos de pago";
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXTitulo);
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 189);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(324, 19);
            this.Panelinf.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(299, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.radioButton4.Image = global::ProyectoPeluquería.Properties.Resources.tarjeta_de_credito;
            this.radioButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton4.Location = new System.Drawing.Point(23, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(176, 27);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Credito / Debito";
            this.radioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.radioButton2.Image = global::ProyectoPeluquería.Properties.Resources.banco;
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton2.Location = new System.Drawing.Point(23, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 27);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Transferencia";
            this.radioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Kelly Slab", 14F);
            this.radioButton1.Image = global::ProyectoPeluquería.Properties.Resources.monedas;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButton1.Location = new System.Drawing.Point(23, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Efectivo";
            this.radioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(324, 208);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panelinf;
    }
}