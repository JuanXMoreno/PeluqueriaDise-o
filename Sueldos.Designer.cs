
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarSueldo = new System.Windows.Forms.Button();
            this.txtSueldoActual = new System.Windows.Forms.TextBox();
            this.tablaSueldos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSueldoActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaSueldos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo actual por hora:";
            // 
            // btnModificarSueldo
            // 
            this.btnModificarSueldo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnModificarSueldo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSueldo.Location = new System.Drawing.Point(321, 398);
            this.btnModificarSueldo.Name = "btnModificarSueldo";
            this.btnModificarSueldo.Size = new System.Drawing.Size(190, 42);
            this.btnModificarSueldo.TabIndex = 2;
            this.btnModificarSueldo.Text = "Modificar sueldo";
            this.btnModificarSueldo.UseVisualStyleBackColor = false;
            this.btnModificarSueldo.Click += new System.EventHandler(this.btnModificarSueldo_Click);
            // 
            // txtSueldoActual
            // 
            this.txtSueldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoActual.Location = new System.Drawing.Point(321, 225);
            this.txtSueldoActual.Name = "txtSueldoActual";
            this.txtSueldoActual.Size = new System.Drawing.Size(190, 29);
            this.txtSueldoActual.TabIndex = 3;
            // 
            // tablaSueldos
            // 
            this.tablaSueldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaSueldos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaSueldos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tablaSueldos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSueldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaSueldos.ColumnHeadersHeight = 35;
            this.tablaSueldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaSueldos.EnableHeadersVisualStyles = false;
            this.tablaSueldos.Location = new System.Drawing.Point(524, 96);
            this.tablaSueldos.Name = "tablaSueldos";
            this.tablaSueldos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaSueldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaSueldos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaSueldos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaSueldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaSueldos.Size = new System.Drawing.Size(829, 344);
            this.tablaSueldos.TabIndex = 4;
            this.tablaSueldos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaSueldos_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificar sueldo actual:";
            // 
            // lblSueldoActual
            // 
            this.lblSueldoActual.AutoSize = true;
            this.lblSueldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoActual.Location = new System.Drawing.Point(317, 139);
            this.lblSueldoActual.Name = "lblSueldoActual";
            this.lblSueldoActual.Size = new System.Drawing.Size(20, 24);
            this.lblSueldoActual.TabIndex = 6;
            this.lblSueldoActual.Text = "0";
            // 
            // Sueldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1365, 462);
            this.Controls.Add(this.lblSueldoActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablaSueldos);
            this.Controls.Add(this.txtSueldoActual);
            this.Controls.Add(this.btnModificarSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sueldos";
            this.Text = "Sueldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sueldos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaSueldos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarSueldo;
        private System.Windows.Forms.TextBox txtSueldoActual;
        private System.Windows.Forms.DataGridView tablaSueldos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSueldoActual;
    }
}