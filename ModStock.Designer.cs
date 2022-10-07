namespace ProyectoPeluquería
{
    partial class ModStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModStock));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Vistas = new System.Windows.Forms.DataGridView();
            this.btnMod = new System.Windows.Forms.Button();
            this.precio = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Idtex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnF5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 1);
            this.panel1.TabIndex = 0;
            // 
            // Vistas
            // 
            this.Vistas.AllowUserToAddRows = false;
            this.Vistas.AllowUserToDeleteRows = false;
            this.Vistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Vistas.Location = new System.Drawing.Point(12, 66);
            this.Vistas.Name = "Vistas";
            this.Vistas.ReadOnly = true;
            this.Vistas.Size = new System.Drawing.Size(598, 216);
            this.Vistas.TabIndex = 1;
            this.Vistas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Vistas_CellClick);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(170, 379);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(281, 36);
            this.btnMod.TabIndex = 13;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(325, 352);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(281, 20);
            this.precio.TabIndex = 12;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(15, 352);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(281, 20);
            this.Stock.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(325, 312);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(281, 20);
            this.Nombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBusqueda.BackgroundImage")));
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.White;
            this.BtnBusqueda.Location = new System.Drawing.Point(528, 30);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 21;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Buscar Stock";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 30);
            this.textBox1.TabIndex = 22;
            // 
            // Idtex
            // 
            this.Idtex.Location = new System.Drawing.Point(15, 312);
            this.Idtex.Name = "Idtex";
            this.Idtex.Size = new System.Drawing.Size(281, 20);
            this.Idtex.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID";
            // 
            // btnF5
            // 
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Image = ((System.Drawing.Image)(resources.GetObject("btnF5.Image")));
            this.btnF5.Location = new System.Drawing.Point(492, 30);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(30, 30);
            this.btnF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnF5.TabIndex = 26;
            this.btnF5.TabStop = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // ModStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(622, 427);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.Idtex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vistas);
            this.Controls.Add(this.panel1);
            this.Name = "ModStock";
            this.Text = "Modificar stock";
            ((System.ComponentModel.ISupportInitialize)(this.Vistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Vistas;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Idtex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnF5;
    }
}