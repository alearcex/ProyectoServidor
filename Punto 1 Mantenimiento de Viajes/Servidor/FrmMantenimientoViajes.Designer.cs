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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.TerminalSalida.BackColor = System.Drawing.Color.Transparent;
            this.TerminalSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalSalida.Location = new System.Drawing.Point(148, 144);
            this.TerminalSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TerminalSalida.Name = "TerminalSalida";
            this.TerminalSalida.Size = new System.Drawing.Size(128, 15);
            this.TerminalSalida.TabIndex = 0;
            this.TerminalSalida.Text = "Terminal de Salida";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.BackColor = System.Drawing.Color.Transparent;
            this.Descripcion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(186, 85);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(86, 15);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Capacidad
            // 
            this.Capacidad.AutoSize = true;
            this.Capacidad.BackColor = System.Drawing.Color.Transparent;
            this.Capacidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacidad.Location = new System.Drawing.Point(192, 244);
            this.Capacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(77, 15);
            this.Capacidad.TabIndex = 2;
            this.Capacidad.Text = "Capacidad";
            // 
            // TerminalLlegada
            // 
            this.TerminalLlegada.AutoSize = true;
            this.TerminalLlegada.BackColor = System.Drawing.Color.Transparent;
            this.TerminalLlegada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TerminalLlegada.Location = new System.Drawing.Point(136, 192);
            this.TerminalLlegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TerminalLlegada.Name = "TerminalLlegada";
            this.TerminalLlegada.Size = new System.Drawing.Size(141, 15);
            this.TerminalLlegada.TabIndex = 3;
            this.TerminalLlegada.Text = "Terminal De Llegada";
            // 
            // CodigoViaje
            // 
            this.CodigoViaje.AutoSize = true;
            this.CodigoViaje.BackColor = System.Drawing.Color.Transparent;
            this.CodigoViaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoViaje.Location = new System.Drawing.Point(165, 34);
            this.CodigoViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodigoViaje.Name = "CodigoViaje";
            this.CodigoViaje.Size = new System.Drawing.Size(108, 15);
            this.CodigoViaje.TabIndex = 4;
            this.CodigoViaje.Text = "Codigo de Viaje";
            // 
            // textCapacidad
            // 
            this.textCapacidad.Location = new System.Drawing.Point(305, 246);
            this.textCapacidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textCapacidad.Name = "textCapacidad";
            this.textCapacidad.ReadOnly = true;
            this.textCapacidad.Size = new System.Drawing.Size(132, 21);
            this.textCapacidad.TabIndex = 5;
            this.textCapacidad.Text = "67";
            this.textCapacidad.TextChanged += new System.EventHandler(this.textCapacidad_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(305, 82);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 21);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCodigoViaje
            // 
            this.txtCodigoViaje.Location = new System.Drawing.Point(305, 31);
            this.txtCodigoViaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Size = new System.Drawing.Size(120, 21);
            this.txtCodigoViaje.TabIndex = 7;
            this.txtCodigoViaje.TextChanged += new System.EventHandler(this.txtCodigoViaje_TextChanged);
            // 
            // txtMontoViaje
            // 
            this.txtMontoViaje.Location = new System.Drawing.Point(305, 295);
            this.txtMontoViaje.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMontoViaje.MaxLength = 10;
            this.txtMontoViaje.Name = "txtMontoViaje";
            this.txtMontoViaje.Size = new System.Drawing.Size(120, 21);
            this.txtMontoViaje.TabIndex = 8;
            this.txtMontoViaje.TextChanged += new System.EventHandler(this.txtMontoViaje_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(508, 351);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(249, 351);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(93, 38);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(124, 351);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 38);
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
            this.cboTerminalSalida.Location = new System.Drawing.Point(305, 144);
            this.cboTerminalSalida.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTerminalSalida.Name = "cboTerminalSalida";
            this.cboTerminalSalida.Size = new System.Drawing.Size(160, 22);
            this.cboTerminalSalida.TabIndex = 14;
            this.cboTerminalSalida.SelectedIndexChanged += new System.EventHandler(this.cboTerminalSalida_SelectedIndexChanged);
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.BackColor = System.Drawing.Color.Transparent;
            this.Costo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costo.Location = new System.Drawing.Point(222, 295);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(45, 15);
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
            this.cboTerminalLlegada.Location = new System.Drawing.Point(305, 189);
            this.cboTerminalLlegada.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTerminalLlegada.Name = "cboTerminalLlegada";
            this.cboTerminalLlegada.Size = new System.Drawing.Size(160, 22);
            this.cboTerminalLlegada.TabIndex = 16;
            this.cboTerminalLlegada.SelectedIndexChanged += new System.EventHandler(this.cboTerminalLlegada_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(386, 351);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 38);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmMantenimientoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Servidor.Properties.Resources.buses;
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
            this.Controls.Add(this.txtDescripcion);
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
        private System.Windows.Forms.TextBox txtDescripcion;
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