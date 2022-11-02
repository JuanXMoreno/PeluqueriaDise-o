
namespace ProyectoPeluquería
{
    partial class Sueldos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarSueldo = new System.Windows.Forms.Button();
            this.txtSueldoActual = new System.Windows.Forms.TextBox();
            this.tablaSueldos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSueldoActual = new System.Windows.Forms.Label();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panelinf = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSueldos)).BeginInit();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label2.Location = new System.Drawing.Point(35, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo actual por hora:";
            // 
            // btnModificarSueldo
            // 
            this.btnModificarSueldo.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarSueldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarSueldo.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.btnModificarSueldo.Location = new System.Drawing.Point(194, 245);
            this.btnModificarSueldo.Name = "btnModificarSueldo";
            this.btnModificarSueldo.Size = new System.Drawing.Size(190, 42);
            this.btnModificarSueldo.TabIndex = 2;
            this.btnModificarSueldo.Text = "Modificar sueldo";
            this.btnModificarSueldo.UseVisualStyleBackColor = false;
            this.btnModificarSueldo.Click += new System.EventHandler(this.btnModificarSueldo_Click);
            // 
            // txtSueldoActual
            // 
            this.txtSueldoActual.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.txtSueldoActual.Location = new System.Drawing.Point(216, 127);
            this.txtSueldoActual.Name = "txtSueldoActual";
            this.txtSueldoActual.Size = new System.Drawing.Size(168, 27);
            this.txtSueldoActual.TabIndex = 3;
            // 
            // tablaSueldos
            // 
            this.tablaSueldos.AllowUserToAddRows = false;
            this.tablaSueldos.AllowUserToDeleteRows = false;
            this.tablaSueldos.AllowUserToOrderColumns = true;
            this.tablaSueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaSueldos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaSueldos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.tablaSueldos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaSueldos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Kelly Slab", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSueldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablaSueldos.ColumnHeadersHeight = 40;
            this.tablaSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaSueldos.EnableHeadersVisualStyles = false;
            this.tablaSueldos.Location = new System.Drawing.Point(400, 44);
            this.tablaSueldos.Margin = new System.Windows.Forms.Padding(1);
            this.tablaSueldos.Name = "tablaSueldos";
            this.tablaSueldos.ReadOnly = true;
            this.tablaSueldos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Kelly Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSueldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaSueldos.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Kelly Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaSueldos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSueldos.Size = new System.Drawing.Size(348, 243);
            this.tablaSueldos.TabIndex = 42;
            this.tablaSueldos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaSueldos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificar sueldo actual:";
            // 
            // lblSueldoActual
            // 
            this.lblSueldoActual.AutoSize = true;
            this.lblSueldoActual.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.lblSueldoActual.Location = new System.Drawing.Point(212, 55);
            this.lblSueldoActual.Name = "lblSueldoActual";
            this.lblSueldoActual.Size = new System.Drawing.Size(17, 19);
            this.lblSueldoActual.TabIndex = 6;
            this.lblSueldoActual.Text = "0";
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelSup.Controls.Add(this.label1);
            this.PanelSup.Controls.Add(this.pictureBox1);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 0);
            this.PanelSup.Margin = new System.Windows.Forms.Padding(1);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(760, 21);
            this.PanelSup.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sueldos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(737, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 306);
            this.Panelinf.Margin = new System.Windows.Forms.Padding(1);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(760, 13);
            this.Panelinf.TabIndex = 45;
            // 
            // Sueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(760, 319);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.lblSueldoActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaSueldos);
            this.Controls.Add(this.txtSueldoActual);
            this.Controls.Add(this.btnModificarSueldo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sueldos";
            this.Text = "Sueldos";
            this.Load += new System.EventHandler(this.Sueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSueldos)).EndInit();
            this.PanelSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarSueldo;
        private System.Windows.Forms.TextBox txtSueldoActual;
        private System.Windows.Forms.DataGridView tablaSueldos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSueldoActual;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panelinf;
    }
}