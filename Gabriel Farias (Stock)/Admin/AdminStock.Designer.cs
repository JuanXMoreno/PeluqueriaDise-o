namespace ProyectoPeluquería
{
    partial class AdminStock
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
            this.Panelinf = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Informacion = new System.Windows.Forms.Panel();
            this.Vista = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxBusqueda = new System.Windows.Forms.TextBox();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBajaProduct = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.PictureBox();
            this.Btdel = new System.Windows.Forms.Button();
            this.ModStock = new System.Windows.Forms.Button();
            this.AddPro = new System.Windows.Forms.Button();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.Panelinf.SuspendLayout();
            this.Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vista)).BeginInit();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).BeginInit();
            this.SuspendLayout();
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panelinf.Controls.Add(this.label2);
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 463);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(720, 20);
            this.Panelinf.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(720, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informacion:  Productos Cargados : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Informacion
            // 
            this.Informacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Informacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Informacion.Controls.Add(this.Vista);
            this.Informacion.Location = new System.Drawing.Point(12, 96);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(696, 307);
            this.Informacion.TabIndex = 18;
            // 
            // Vista
            // 
            this.Vista.AllowUserToAddRows = false;
            this.Vista.AllowUserToDeleteRows = false;
            this.Vista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Vista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vista.Location = new System.Drawing.Point(0, 0);
            this.Vista.Name = "Vista";
            this.Vista.ReadOnly = true;
            this.Vista.Size = new System.Drawing.Size(694, 305);
            this.Vista.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 1);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Buscar Stock";
            // 
            // BoxBusqueda
            // 
            this.BoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BoxBusqueda.Location = new System.Drawing.Point(12, 53);
            this.BoxBusqueda.Name = "BoxBusqueda";
            this.BoxBusqueda.Size = new System.Drawing.Size(571, 30);
            this.BoxBusqueda.TabIndex = 19;
            // 
            // Reloj
            // 
            this.Reloj.Enabled = true;
            this.Reloj.Interval = 1000;
            this.Reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelSup.Controls.Add(this.label1);
            this.PanelSup.Controls.Add(this.pictureBox1);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(720, 25);
            this.PanelSup.TabIndex = 31;
            this.PanelSup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelSup_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Stock";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverTitulo);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(695, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Cerrar);
            // 
            // btnBajaProduct
            // 
            this.btnBajaProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProduct.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.btnBajaProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBajaProduct.Image = global::ProyectoPeluquería.Properties.Resources.ojos_cruzados__1_;
            this.btnBajaProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaProduct.Location = new System.Drawing.Point(528, 409);
            this.btnBajaProduct.Name = "btnBajaProduct";
            this.btnBajaProduct.Size = new System.Drawing.Size(179, 48);
            this.btnBajaProduct.TabIndex = 30;
            this.btnBajaProduct.Text = "Historial";
            this.btnBajaProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBajaProduct.UseVisualStyleBackColor = true;
            this.btnBajaProduct.Click += new System.EventHandler(this.btnProductOff);
            // 
            // btnF5
            // 
            this.btnF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Image = global::ProyectoPeluquería.Properties.Resources.x_b;
            this.btnF5.Location = new System.Drawing.Point(589, 53);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(30, 30);
            this.btnF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnF5.TabIndex = 28;
            this.btnF5.TabStop = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // Btdel
            // 
            this.Btdel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btdel.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.Btdel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btdel.Image = global::ProyectoPeluquería.Properties.Resources.fuego;
            this.Btdel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btdel.Location = new System.Drawing.Point(368, 409);
            this.Btdel.Name = "Btdel";
            this.Btdel.Size = new System.Drawing.Size(154, 48);
            this.Btdel.TabIndex = 16;
            this.Btdel.Text = "Borrar Item";
            this.Btdel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btdel.UseVisualStyleBackColor = true;
            this.Btdel.Click += new System.EventHandler(this.BtnDelete);
            // 
            // ModStock
            // 
            this.ModStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModStock.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.ModStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ModStock.Image = global::ProyectoPeluquería.Properties.Resources.editar;
            this.ModStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModStock.Location = new System.Drawing.Point(208, 408);
            this.ModStock.Name = "ModStock";
            this.ModStock.Size = new System.Drawing.Size(154, 48);
            this.ModStock.TabIndex = 15;
            this.ModStock.Text = "Modificar Item";
            this.ModStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModStock.UseVisualStyleBackColor = true;
            this.ModStock.Click += new System.EventHandler(this.ModStock_Click);
            // 
            // AddPro
            // 
            this.AddPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPro.Font = new System.Drawing.Font("Kelly Slab", 13F);
            this.AddPro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddPro.Image = global::ProyectoPeluquería.Properties.Resources.agregar__2_;
            this.AddPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddPro.Location = new System.Drawing.Point(12, 409);
            this.AddPro.Name = "AddPro";
            this.AddPro.Size = new System.Drawing.Size(190, 48);
            this.AddPro.TabIndex = 14;
            this.AddPro.Text = "Agregar Item";
            this.AddPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddPro.UseVisualStyleBackColor = true;
            this.AddPro.Click += new System.EventHandler(this.AddPro_Click);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = global::ProyectoPeluquería.Properties.Resources.busqueda;
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.Black;
            this.BtnBusqueda.Location = new System.Drawing.Point(625, 53);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 12;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // AdminStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(720, 483);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.btnBajaProduct);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.Btdel);
            this.Controls.Add(this.ModStock);
            this.Controls.Add(this.AddPro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStock";
            this.Activated += new System.EventHandler(this.AdminStock_Activated);
            this.Panelinf.ResumeLayout(false);
            this.Informacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Vista)).EndInit();
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Panelinf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Informacion;
        private System.Windows.Forms.Button Btdel;
        private System.Windows.Forms.Button ModStock;
        private System.Windows.Forms.Button AddPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxBusqueda;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.PictureBox btnF5;
        private System.Windows.Forms.Button btnBajaProduct;
        private System.Windows.Forms.DataGridView Vista;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}