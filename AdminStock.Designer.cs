﻿namespace ProyectoPeluquería
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panelinf = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Informacion = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ModStock = new System.Windows.Forms.Button();
            this.AddPro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panelinf.SuspendLayout();
            this.Informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 305);
            this.dataGridView1.TabIndex = 0;
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
            this.Informacion.Controls.Add(this.dataGridView1);
            this.Informacion.Location = new System.Drawing.Point(12, 67);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(696, 307);
            this.Informacion.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(492, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 48);
            this.button5.TabIndex = 17;
            this.button5.Text = "Holi";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Crimson;
            this.button4.Location = new System.Drawing.Point(332, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 48);
            this.button4.TabIndex = 16;
            this.button4.Text = "Borrar Item";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(608, 30);
            this.textBox1.TabIndex = 19;
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Interval = 1000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // AdminStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(720, 460);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ModStock);
            this.Controls.Add(this.AddPro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Name = "AdminStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panelinf.ResumeLayout(false);
            this.Informacion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Panelinf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Informacion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ModStock;
        private System.Windows.Forms.Button AddPro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer reloj;
    }
}