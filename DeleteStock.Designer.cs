namespace ProyectoPeluquería
{
    partial class DeleteStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStock));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxBusqueda = new System.Windows.Forms.TextBox();
            this.Seleccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 1);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(546, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Eliminar);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBusqueda.BackgroundImage")));
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.White;
            this.BtnBusqueda.Location = new System.Drawing.Point(582, 24);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 24;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.Buscar);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Buscar Stock";
            // 
            // TexboxBuscador
            // 
            this.TexboxBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TexboxBuscador.Location = new System.Drawing.Point(12, 24);
            this.TexboxBuscador.Name = "TexboxBuscador";
            this.TexboxBuscador.Size = new System.Drawing.Size(564, 30);
            this.TexboxBuscador.TabIndex = 25;
            // 
            // btnF5
            // 
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Image = ((System.Drawing.Image)(resources.GetObject("btnF5.Image")));
            this.btnF5.Location = new System.Drawing.Point(589, 28);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(30, 30);
            this.btnF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnF5.TabIndex = 5;
            this.btnF5.TabStop = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 1);
            this.panel2.TabIndex = 22;
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBusqueda.BackgroundImage")));
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.White;
            this.BtnBusqueda.Location = new System.Drawing.Point(625, 28);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 21;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Buscar Stock";
            // 
            // BoxBusqueda
            // 
            this.BoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BoxBusqueda.Location = new System.Drawing.Point(12, 28);
            this.BoxBusqueda.Name = "BoxBusqueda";
            this.BoxBusqueda.Size = new System.Drawing.Size(571, 30);
            this.BoxBusqueda.TabIndex = 23;
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSize = true;
            this.Seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Seleccion.Location = new System.Drawing.Point(12, 322);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(100, 17);
            this.Seleccion.TabIndex = 34;
            this.Seleccion.Text = "Se selecciono:";
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(720, 357);
            this.Controls.Add(this.Seleccion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxBusqueda);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteStock";
            this.Text = "DeleteStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox btnF5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxBusqueda;
        private System.Windows.Forms.Label Seleccion;
    }
}