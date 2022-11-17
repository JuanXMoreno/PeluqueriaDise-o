namespace ProyectoPeluquería
{
    partial class Turnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbPeluquero = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtDia = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Horarios = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaNac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBNum = new System.Windows.Forms.TextBox();
            this.PanelSup = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Cerrarpic = new System.Windows.Forms.PictureBox();
            this.Panelinf = new System.Windows.Forms.Panel();
            this.pbF5 = new System.Windows.Forms.PictureBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).BeginInit();
            this.Panelinf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbF5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peluquero encargado:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(158, 22);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(191, 23);
            this.txtCliente.TabIndex = 3;
            // 
            // cmbPeluquero
            // 
            this.cmbPeluquero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPeluquero.FormattingEnabled = true;
            this.cmbPeluquero.ItemHeight = 15;
            this.cmbPeluquero.Location = new System.Drawing.Point(159, 168);
            this.cmbPeluquero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbPeluquero.Name = "cmbPeluquero";
            this.cmbPeluquero.Size = new System.Drawing.Size(191, 23);
            this.cmbPeluquero.TabIndex = 7;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(167)))));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(391, 31);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(547, 272);
            this.dgvDatos.TabIndex = 11;
            this.dgvDatos.TabStop = false;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            // 
            // txtDia
            // 
            this.txtDia.CustomFormat = "";
            this.txtDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDia.Location = new System.Drawing.Point(158, 110);
            this.txtDia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDia.MinDate = new System.DateTime(1779, 12, 9, 0, 0, 0, 0);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(191, 23);
            this.txtDia.TabIndex = 1;
            this.txtDia.Value = new System.DateTime(2022, 11, 17, 0, 0, 0, 0);
            this.txtDia.CloseUp += new System.EventHandler(this.txtDia_CloseUp);
            this.txtDia.ValueChanged += new System.EventHandler(this.txtDia_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Horarios);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FechaNac);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtBNum);
            this.groupBox1.Controls.Add(this.txtDia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.cmbPeluquero);
            this.groupBox1.Location = new System.Drawing.Point(13, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(370, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turnos";
            // 
            // Horarios
            // 
            this.Horarios.FormattingEnabled = true;
            this.Horarios.Location = new System.Drawing.Point(158, 139);
            this.Horarios.Name = "Horarios";
            this.Horarios.Size = new System.Drawing.Size(191, 23);
            this.Horarios.TabIndex = 12;
            this.Horarios.Click += new System.EventHandler(this.Horarios_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // FechaNac
            // 
            this.FechaNac.CustomFormat = "";
            this.FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNac.Location = new System.Drawing.Point(158, 81);
            this.FechaNac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FechaNac.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Size = new System.Drawing.Size(191, 23);
            this.FechaNac.TabIndex = 10;
            this.FechaNac.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono";
            // 
            // TxtBNum
            // 
            this.TxtBNum.Location = new System.Drawing.Point(158, 52);
            this.TxtBNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtBNum.Name = "TxtBNum";
            this.TxtBNum.Size = new System.Drawing.Size(191, 23);
            this.TxtBNum.TabIndex = 8;
            this.TxtBNum.Text = "+5493549";
            this.TxtBNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBNum_KeyPress);
            // 
            // PanelSup
            // 
            this.PanelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PanelSup.Controls.Add(this.label6);
            this.PanelSup.Controls.Add(this.Cerrarpic);
            this.PanelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSup.Location = new System.Drawing.Point(0, 0);
            this.PanelSup.Name = "PanelSup";
            this.PanelSup.Size = new System.Drawing.Size(951, 25);
            this.PanelSup.TabIndex = 33;
            this.PanelSup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoverXPanel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Turnos";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // Cerrarpic
            // 
            this.Cerrarpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrarpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cerrarpic.Image = global::ProyectoPeluquería.Properties.Resources.x;
            this.Cerrarpic.Location = new System.Drawing.Point(926, 0);
            this.Cerrarpic.Name = "Cerrarpic";
            this.Cerrarpic.Size = new System.Drawing.Size(25, 25);
            this.Cerrarpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cerrarpic.TabIndex = 0;
            this.Cerrarpic.TabStop = false;
            this.Cerrarpic.Click += new System.EventHandler(this.Cerrarpic_Click);
            // 
            // Panelinf
            // 
            this.Panelinf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Panelinf.Controls.Add(this.pbF5);
            this.Panelinf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panelinf.Location = new System.Drawing.Point(0, 309);
            this.Panelinf.Name = "Panelinf";
            this.Panelinf.Size = new System.Drawing.Size(951, 20);
            this.Panelinf.TabIndex = 34;
            // 
            // pbF5
            // 
            this.pbF5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbF5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbF5.Image = global::ProyectoPeluquería.Properties.Resources.actualizar_flecha;
            this.pbF5.Location = new System.Drawing.Point(926, 0);
            this.pbF5.Name = "pbF5";
            this.pbF5.Size = new System.Drawing.Size(25, 20);
            this.pbF5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbF5.TabIndex = 1;
            this.pbF5.TabStop = false;
            this.pbF5.Click += new System.EventHandler(this.pbF5_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.Transparent;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.btnInsertar.Image = global::ProyectoPeluquería.Properties.Resources.agregar_tiempo;
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Location = new System.Drawing.Point(14, 241);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(183, 62);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Agregar";
            this.btnInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.btnEliminar.Image = global::ProyectoPeluquería.Properties.Resources.basura__2_;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(942, 31);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(35, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Kelly Slab", 12F);
            this.btnModificar.Image = global::ProyectoPeluquería.Properties.Resources.seleccione;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(205, 241);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(178, 62);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Turnos
            // 
            this.AcceptButton = this.btnInsertar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(951, 329);
            this.Controls.Add(this.Panelinf);
            this.Controls.Add(this.PanelSup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Validated += new System.EventHandler(this.Turnos_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelSup.ResumeLayout(false);
            this.PanelSup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrarpic)).EndInit();
            this.Panelinf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbF5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbPeluquero;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DateTimePicker txtDia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel PanelSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Cerrarpic;
        private System.Windows.Forms.Panel Panelinf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBNum;
        private System.Windows.Forms.PictureBox pbF5;
        private System.Windows.Forms.ComboBox Horarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaNac;
    }
}