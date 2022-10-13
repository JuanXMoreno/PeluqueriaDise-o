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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStock));
            this.Vista = new System.Windows.Forms.DataGridView();
            this.Panelinf = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Informacion = new System.Windows.Forms.Panel();
            this.Btdel = new System.Windows.Forms.Button();
            this.ModStock = new System.Windows.Forms.Button();
            this.AddPro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxBusqueda = new System.Windows.Forms.TextBox();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.btnF5 = new System.Windows.Forms.PictureBox();
            this.btnBajaProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vista)).BeginInit();
            this.Panelinf.SuspendLayout();
            this.Informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).BeginInit();
            this.SuspendLayout();
            // 
            // Vista
            // 
            this.Vista.AllowUserToAddRows = false;
            this.Vista.AllowUserToDeleteRows = false;
            this.Vista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vista.Location = new System.Drawing.Point(0, 0);
            this.Vista.Name = "Vista";
            this.Vista.ReadOnly = true;
            this.Vista.Size = new System.Drawing.Size(694, 305);
            this.Vista.TabIndex = 0;
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Panelinf.Controls.Add(this.label2);
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 440);
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
            this.label2.Text = "Informacion:  Productos Cargados : 100 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Informacion
            // 
            this.Informacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Informacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Informacion.Controls.Add(this.Vista);
            this.Informacion.Location = new System.Drawing.Point(12, 67);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(696, 307);
            this.Informacion.TabIndex = 18;
            // 
            // Btdel
            // 
            this.Btdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btdel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Btdel.ForeColor = System.Drawing.Color.Crimson;
            this.Btdel.Location = new System.Drawing.Point(332, 380);
            this.Btdel.Name = "Btdel";
            this.Btdel.Size = new System.Drawing.Size(154, 48);
            this.Btdel.TabIndex = 16;
            this.Btdel.Text = "Borrar Item";
            this.Btdel.UseVisualStyleBackColor = true;
            this.Btdel.Click += new System.EventHandler(this.BtnDelete);
            // 
            // ModStock
            // 
            this.ModStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModStock.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.ModStock.ForeColor = System.Drawing.Color.Orange;
            this.ModStock.Location = new System.Drawing.Point(172, 380);
            this.ModStock.Name = "ModStock";
            this.ModStock.Size = new System.Drawing.Size(154, 48);
            this.ModStock.TabIndex = 15;
            this.ModStock.Text = "Modificar Item";
            this.ModStock.UseVisualStyleBackColor = true;
            this.ModStock.Click += new System.EventHandler(this.ModStock_Click);
            // 
            // AddPro
            // 
            this.AddPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPro.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.AddPro.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddPro.Location = new System.Drawing.Point(12, 380);
            this.AddPro.Name = "AddPro";
            this.AddPro.Size = new System.Drawing.Size(154, 48);
            this.AddPro.TabIndex = 14;
            this.AddPro.Text = "Agregar Item";
            this.AddPro.UseVisualStyleBackColor = true;
            this.AddPro.Click += new System.EventHandler(this.AddPro_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 1);
            this.panel2.TabIndex = 13;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBusqueda.BackgroundImage")));
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.White;
            this.BtnBusqueda.Location = new System.Drawing.Point(625, 24);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 12;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Buscar Stock";
            // 
            // BoxBusqueda
            // 
            this.BoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BoxBusqueda.Location = new System.Drawing.Point(12, 24);
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
            // btnF5
            // 
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Image = global::ProyectoPeluquería.Properties.Resources.gira_a_la_derecha_f5_negro;
            this.btnF5.Location = new System.Drawing.Point(589, 24);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(30, 30);
            this.btnF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnF5.TabIndex = 28;
            this.btnF5.TabStop = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnBajaProduct
            // 
            this.btnBajaProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaProduct.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnBajaProduct.ForeColor = System.Drawing.Color.Black;
            this.btnBajaProduct.Location = new System.Drawing.Point(492, 380);
            this.btnBajaProduct.Name = "btnBajaProduct";
            this.btnBajaProduct.Size = new System.Drawing.Size(215, 48);
            this.btnBajaProduct.TabIndex = 30;
            this.btnBajaProduct.Text = "Bajas";
            this.btnBajaProduct.UseVisualStyleBackColor = true;
            this.btnBajaProduct.Click += new System.EventHandler(this.btnProductOff);
            // 
            // AdminStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(720, 460);
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
            this.Name = "AdminStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStock";
            ((System.ComponentModel.ISupportInitialize)(this.Vista)).EndInit();
            this.Panelinf.ResumeLayout(false);
            this.Informacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Vista;
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
    }
}