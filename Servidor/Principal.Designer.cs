namespace Servidor
{
    partial class Principal
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
            this.MantenimientoViajes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuPrincipal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMantenimientoTerminales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MantenimientoViajes
            // 
            this.MantenimientoViajes.Location = new System.Drawing.Point(569, 103);
            this.MantenimientoViajes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MantenimientoViajes.Name = "MantenimientoViajes";
            this.MantenimientoViajes.Size = new System.Drawing.Size(122, 42);
            this.MantenimientoViajes.TabIndex = 2;
            this.MantenimientoViajes.Text = "Mantenimiento de Terminales";
            this.MantenimientoViajes.UseVisualStyleBackColor = true;
            this.MantenimientoViajes.Click += new System.EventHandler(this.MantenimientoViajes_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 141);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mantenimiento de Viajes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Location = new System.Drawing.Point(36, 12);
            this.MenuPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(354, 20);
            this.MenuPrincipal.TabIndex = 14;
            this.MenuPrincipal.Text = "MENU PRINCIPAL";
            this.MenuPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "Socket de Comunicación";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMantenimientoTerminales
            // 
            this.btnMantenimientoTerminales.Location = new System.Drawing.Point(148, 67);
            this.btnMantenimientoTerminales.Name = "btnMantenimientoTerminales";
            this.btnMantenimientoTerminales.Size = new System.Drawing.Size(122, 52);
            this.btnMantenimientoTerminales.TabIndex = 16;
            this.btnMantenimientoTerminales.Text = "Mantenimiento de Terminales";
            this.btnMantenimientoTerminales.UseVisualStyleBackColor = true;
            this.btnMantenimientoTerminales.Click += new System.EventHandler(this.btnMantenimientoTerminales_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 364);
            this.Controls.Add(this.btnMantenimientoTerminales);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MenuPrincipal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.MantenimientoViajes);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MantenimientoViajes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox MenuPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMantenimientoTerminales;
    }
}