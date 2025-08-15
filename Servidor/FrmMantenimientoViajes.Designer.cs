namespace Servidor
{
    partial class FrmMantenimientoViajes
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
            this.TerminalSalida = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Capacidad = new System.Windows.Forms.Label();
            this.TerminalLlegada = new System.Windows.Forms.Label();
            this.CodigoViaje = new System.Windows.Forms.Label();
            this.textCapacidad = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCodigoViaje = new System.Windows.Forms.TextBox();
            this.txtMontoViaje = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cboTerminalSalida = new System.Windows.Forms.ComboBox();
            this.Costo = new System.Windows.Forms.Label();
            this.cboTerminalLlegada = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TerminalSalida
            // 
            this.TerminalSalida.AutoSize = true;
            this.TerminalSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalSalida.Location = new System.Drawing.Point(25, 180);
            this.TerminalSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TerminalSalida.Name = "TerminalSalida";
            this.TerminalSalida.Size = new System.Drawing.Size(115, 14);
            this.TerminalSalida.TabIndex = 0;
            this.TerminalSalida.Text = "Terminal de Salida";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(63, 121);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(77, 14);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSize = true;
            this.Capacidad.Location = new System.Drawing.Point(69, 280);
            this.Capacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(71, 14);
            this.Capacidad.TabIndex = 2;
            this.Capacidad.Text = "Capacidad";
            // 
            // TerminalLlegada
            // 
            this.TerminalLlegada.AutoSize = true;
            this.TerminalLlegada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalLlegada.Location = new System.Drawing.Point(13, 228);
            this.TerminalLlegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TerminalLlegada.Name = "TerminalLlegada";
            this.TerminalLlegada.Size = new System.Drawing.Size(127, 14);
            this.TerminalLlegada.TabIndex = 3;
            this.TerminalLlegada.Text = "Terminal De Llegada";
            // 
            // CodigoViaje
            // 
            this.CodigoViaje.AutoSize = true;
            this.CodigoViaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoViaje.Location = new System.Drawing.Point(42, 70);
            this.CodigoViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodigoViaje.Name = "CodigoViaje";
            this.CodigoViaje.Size = new System.Drawing.Size(98, 14);
            this.CodigoViaje.TabIndex = 4;
            this.CodigoViaje.Text = "Codigo de Viaje";
            // 
            // textCapacidad
            // 
            this.textCapacidad.Location = new System.Drawing.Point(182, 282);
            this.textCapacidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.ReadOnly = true;
            this.textCapacidad.Size = new System.Drawing.Size(132, 21);
            this.textCapacidad.TabIndex = 5;
            this.textCapacidad.Text = "67";
            this.textCapacidad.TextChanged += new System.EventHandler(this.textCapacidad_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 118);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCodigoViaje
            // 
            this.txtCodigoViaje.Location = new System.Drawing.Point(182, 67);
            this.txtCodigoViaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Size = new System.Drawing.Size(120, 21);
            this.txtCodigoViaje.TabIndex = 7;
            this.txtCodigoViaje.TextChanged += new System.EventHandler(this.txtCodigoViaje_TextChanged);
            // 
            // txtMontoViaje
            // 
            this.txtMontoViaje.Location = new System.Drawing.Point(182, 331);
            this.txtMontoViaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoViaje.MaxLength = 10;
            this.txtMontoViaje.Name = "txtMontoViaje";
            this.txtMontoViaje.Size = new System.Drawing.Size(120, 21);
            this.txtMontoViaje.TabIndex = 8;
            this.txtMontoViaje.TextChanged += new System.EventHandler(this.txtMontoViaje_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(214, 402);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 25);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(333, 402);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 25);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(457, 402);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 25);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboTerminalSalida
            // 
            this.cboTerminalSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerminalSalida.FormattingEnabled = true;
            this.cboTerminalSalida.Items.AddRange(new object[] {
            "SAN JOSE",
            "EL COCO"});
            this.cboTerminalSalida.Location = new System.Drawing.Point(182, 180);
            this.cboTerminalSalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTerminalSalida.Name = "cboTerminalSalida";
            this.cboTerminalSalida.Size = new System.Drawing.Size(160, 22);
            this.cboTerminalSalida.TabIndex = 14;
            this.cboTerminalSalida.SelectedIndexChanged += new System.EventHandler(this.cboTerminalSalida_SelectedIndexChanged);
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Location = new System.Drawing.Point(99, 331);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(41, 14);
            this.Costo.TabIndex = 15;
            this.Costo.Text = "Costo";
            // 
            // cboTerminalLlegada
            // 
            this.cboTerminalLlegada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTerminalLlegada.ForeColor = System.Drawing.Color.SlateGray;
            this.cboTerminalLlegada.FormattingEnabled = true;
            this.cboTerminalLlegada.Items.AddRange(new object[] {
            "SAN JOSE",
            "EL COCO"});
            this.cboTerminalLlegada.Location = new System.Drawing.Point(182, 225);
            this.cboTerminalLlegada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTerminalLlegada.Name = "cboTerminalLlegada";
            this.cboTerminalLlegada.Size = new System.Drawing.Size(160, 22);
            this.cboTerminalLlegada.TabIndex = 16;
            this.cboTerminalLlegada.SelectedIndexChanged += new System.EventHandler(this.cboTerminalLlegada_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(565, 402);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 25);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMantenimientoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 456);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cboTerminalLlegada);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.cboTerminalSalida);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMontoViaje);
            this.Controls.Add(this.txtCodigoViaje);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textCapacidad);
            this.Controls.Add(this.CodigoViaje);
            this.Controls.Add(this.TerminalLlegada);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.TerminalSalida);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Viajes-BUSUH";
            this.Load += new System.EventHandler(this.FrmMantenimientoViajes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TerminalSalida;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Capacidad;
        private System.Windows.Forms.Label TerminalLlegada;
        private System.Windows.Forms.Label CodigoViaje;
        private System.Windows.Forms.TextBox textCapacidad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCodigoViaje;
        private System.Windows.Forms.TextBox txtMontoViaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cboTerminalSalida;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.ComboBox cboTerminalLlegada;
        private System.Windows.Forms.Button btnCerrar;
    }
}