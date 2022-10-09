
namespace ProyectoPeluquería
{
    partial class FormAdmin
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
            this.btnAdminTurnos = new System.Windows.Forms.Button();
            this.btnAdminEmpleados = new System.Windows.Forms.Button();
            this.btnAdminServicios = new System.Windows.Forms.Button();
            this.btnAdminStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminTurnos
            // 
            this.btnAdminTurnos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdminTurnos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminTurnos.Location = new System.Drawing.Point(3, 3);
            this.btnAdminTurnos.Name = "btnAdminTurnos";
            this.btnAdminTurnos.Size = new System.Drawing.Size(161, 87);
            this.btnAdminTurnos.TabIndex = 0;
            this.btnAdminTurnos.Text = "Administrar\r\nturnos";
            this.btnAdminTurnos.UseVisualStyleBackColor = false;
            // 
            // btnAdminEmpleados
            // 
            this.btnAdminEmpleados.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdminEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminEmpleados.Location = new System.Drawing.Point(3, 94);
            this.btnAdminEmpleados.Name = "btnAdminEmpleados";
            this.btnAdminEmpleados.Size = new System.Drawing.Size(161, 87);
            this.btnAdminEmpleados.TabIndex = 1;
            this.btnAdminEmpleados.Text = "Administrar\r\nempleados";
            this.btnAdminEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnAdminServicios
            // 
            this.btnAdminServicios.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdminServicios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminServicios.Location = new System.Drawing.Point(3, 278);
            this.btnAdminServicios.Name = "btnAdminServicios";
            this.btnAdminServicios.Size = new System.Drawing.Size(161, 87);
            this.btnAdminServicios.TabIndex = 2;
            this.btnAdminServicios.Text = "Administrar\r\nservicios";
            this.btnAdminServicios.UseVisualStyleBackColor = false;
            this.btnAdminServicios.Click += new System.EventHandler(this.btnAdminServicios_Click);
            // 
            // btnAdminStock
            // 
            this.btnAdminStock.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdminStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminStock.Location = new System.Drawing.Point(3, 185);
            this.btnAdminStock.Name = "btnAdminStock";
            this.btnAdminStock.Size = new System.Drawing.Size(161, 87);
            this.btnAdminStock.TabIndex = 3;
            this.btnAdminStock.Text = "Administrar\r\nstock";
            this.btnAdminStock.UseVisualStyleBackColor = false;
            this.btnAdminStock.Click += new System.EventHandler(this.btnAdminStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(170, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 455);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Turnos actuales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hoy:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(742, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 320);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 44);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ganancia total\r\nde stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ganancia total\r\nde servivios:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ventas realizadas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Turnos cancelados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 87);
            this.button1.TabIndex = 6;
            this.button1.Text = "Estadísticas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnConfig.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(742, 3);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(161, 87);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Configuración";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(742, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(909, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdminStock);
            this.Controls.Add(this.btnAdminEmpleados);
            this.Controls.Add(this.btnAdminServicios);
            this.Controls.Add(this.btnAdminTurnos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario administrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminTurnos;
        private System.Windows.Forms.Button btnAdminEmpleados;
        private System.Windows.Forms.Button btnAdminServicios;
        private System.Windows.Forms.Button btnAdminStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button button3;
    }
}