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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxBusqueda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnBusqueda = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 1);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Buscar Stock";
            // 
            // BoxBusqueda
            // 
            this.BoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BoxBusqueda.Location = new System.Drawing.Point(12, 54);
            this.BoxBusqueda.Name = "BoxBusqueda";
            this.BoxBusqueda.Size = new System.Drawing.Size(571, 30);
            this.BoxBusqueda.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 13);
            this.panel3.TabIndex = 37;
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelSup.Controls.Add(this.label6);
            this.PanelSup.Controls.Add(this.pictureBox1);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(720, 25);
            this.PanelSup.TabIndex = 36;
            this.PanelSup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverPanel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(10, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Eliminar";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXTitu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(691, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.cerrar);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.Image = global::ProyectoPeluquería.Properties.Resources.basura__2_;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(535, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 38);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBusqueda
            // 
            this.BtnBusqueda.BackgroundImage = global::ProyectoPeluquería.Properties.Resources.busqueda;
            this.BtnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBusqueda.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBusqueda.ForeColor = System.Drawing.Color.Black;
            this.BtnBusqueda.Location = new System.Drawing.Point(625, 54);
            this.BtnBusqueda.Name = "BtnBusqueda";
            this.BtnBusqueda.Size = new System.Drawing.Size(82, 30);
            this.BtnBusqueda.TabIndex = 21;
            this.BtnBusqueda.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnBusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBusqueda.UseVisualStyleBackColor = true;
            this.BtnBusqueda.Click += new System.EventHandler(this.BtnBusqueda_Click);
            // 
            // btnF5
            // 
            this.btnF5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnF5.Image = global::ProyectoPeluquería.Properties.Resources.x_b;
            this.btnF5.Location = new System.Drawing.Point(589, 54);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(30, 30);
            this.btnF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnF5.TabIndex = 5;
            this.btnF5.TabStop = false;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // DeleteStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(720, 397);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnBusqueda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxBusqueda);
            this.Controls.Add(this.btnF5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnF5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnF5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxBusqueda;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}