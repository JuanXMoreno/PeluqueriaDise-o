namespace ProyectoPeluquería
{
    partial class FormEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panelinf = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdminServicios = new System.Windows.Forms.Button();
            this.btnAdminTurnos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.user3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.user2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Hoy = new System.Windows.Forms.Timer(this.components);
            this.btnStock = new System.Windows.Forms.Button();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panelinf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.PanelSup.Size = new System.Drawing.Size(927, 25);
            this.PanelSup.TabIndex = 37;
            this.PanelSup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelSup_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Formulario Empleados";
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXTitu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(902, 0);
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
            this.Panelinf.Controls.Add(this.label8);
            this.Panelinf.Controls.Add(this.pictureBox2);
            this.Panelinf.Controls.Add(this.label10);
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 500);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(927, 26);
            this.Panelinf.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Kelly Slab", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Configuracion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ProyectoPeluquería.Properties.Resources.configuraciones;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Kelly Slab", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(829, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cerrar sesion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // btnAdminServicios
            // 
            this.btnAdminServicios.BackColor = System.Drawing.Color.White;
            this.btnAdminServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminServicios.Font = new System.Drawing.Font("Kelly Slab", 15F);
            this.btnAdminServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminServicios.Location = new System.Drawing.Point(12, 124);
            this.btnAdminServicios.Name = "btnAdminServicios";
            this.btnAdminServicios.Size = new System.Drawing.Size(161, 87);
            this.btnAdminServicios.TabIndex = 41;
            this.btnAdminServicios.Text = "Servicios y \r\nVentas";
            this.btnAdminServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminServicios.UseVisualStyleBackColor = false;
            this.btnAdminServicios.Click += new System.EventHandler(this.btnAdminServicios_Click);
            // 
            // btnAdminTurnos
            // 
            this.btnAdminTurnos.BackColor = System.Drawing.Color.White;
            this.btnAdminTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminTurnos.Font = new System.Drawing.Font("Kelly Slab", 15F);
            this.btnAdminTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminTurnos.Location = new System.Drawing.Point(12, 31);
            this.btnAdminTurnos.Name = "btnAdminTurnos";
            this.btnAdminTurnos.Size = new System.Drawing.Size(161, 87);
            this.btnAdminTurnos.TabIndex = 40;
            this.btnAdminTurnos.Text = "Turnos";
            this.btnAdminTurnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminTurnos.UseVisualStyleBackColor = false;
            this.btnAdminTurnos.Click += new System.EventHandler(this.btnAdminTurnos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(150)))), ((int)(((byte)(167)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(179, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 463);
            this.panel1.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel7.Controls.Add(this.user3);
            this.panel7.Location = new System.Drawing.Point(380, 39);
            this.panel7.Margin = new System.Windows.Forms.Padding(25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 140);
            this.panel7.TabIndex = 7;
            // 
            // user3
            // 
            this.user3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user3.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.user3.Location = new System.Drawing.Point(0, 0);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(167, 140);
            this.user3.TabIndex = 3;
            this.user3.Text = "[Hora]\r\n\r\n[Nombre]\r\n";
            this.user3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel6.Controls.Add(this.user2);
            this.panel6.Location = new System.Drawing.Point(203, 39);
            this.panel6.Margin = new System.Windows.Forms.Padding(25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 140);
            this.panel6.TabIndex = 7;
            // 
            // user2
            // 
            this.user2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user2.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.user2.Location = new System.Drawing.Point(0, 0);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(167, 140);
            this.user2.TabIndex = 3;
            this.user2.Text = "[Hora]\r\n\r\n[Nombre]\r\n";
            this.user2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel5.Controls.Add(this.user1);
            this.panel5.Location = new System.Drawing.Point(25, 39);
            this.panel5.Margin = new System.Windows.Forms.Padding(25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 140);
            this.panel5.TabIndex = 6;
            // 
            // user1
            // 
            this.user1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user1.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.user1.Location = new System.Drawing.Point(0, 0);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(167, 140);
            this.user1.TabIndex = 2;
            this.user1.Text = "[Hora]\r\n\r\n[Nombre]\r\n";
            this.user1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kelly Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turnos restantes: 0";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Kelly Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Turnos actuales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(150)))), ((int)(((byte)(167)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(751, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 463);
            this.panel2.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 19);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hoy";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label6.Location = new System.Drawing.Point(7, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 57);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ganancia total\r\nde stock:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label1.Location = new System.Drawing.Point(7, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ganancia total\r\nde servicios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 57);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ventas realizadas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 57);
            this.label4.TabIndex = 0;
            this.label4.Text = "Turnos cancelados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Hoy
            // 
            this.Hoy.Interval = 1;
            this.Hoy.Tick += new System.EventHandler(this.Hoy_Tick);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Kelly Slab", 15F);
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.Location = new System.Drawing.Point(12, 217);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(161, 87);
            this.btnStock.TabIndex = 44;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 526);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdminServicios);
            this.Controls.Add(this.btnAdminTurnos);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.PanelSup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmpleado_FormClosed);
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panelinf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panelinf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdminServicios;
        private System.Windows.Forms.Button btnAdminTurnos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label user3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Hoy;
        private System.Windows.Forms.Button btnStock;
    }
}