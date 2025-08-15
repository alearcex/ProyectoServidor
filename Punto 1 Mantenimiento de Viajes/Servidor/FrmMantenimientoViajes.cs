using Servidor.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Servidor
{
    public partial class FrmMantenimientoViajes : Form
    {
        public List<Cla_Viaje> ListaViajes { get; set; }

        public FrmMantenimientoViajes(List<Cla_Viaje> listaViajes)
        {
            InitializeComponent();
            ListaViajes = listaViajes;
            ConfigurarControlesIniciales();
            //ConfigurarDataGridView();//esto no sirve de nada ignorar
        }

        private void ConfigurarControlesIniciales()
        {
            // Configurar ComboBox
            cboTerminalSalida.Items.AddRange(new string[] { " " });
            cboTerminalLlegada.Items.AddRange(new string[] { " " });

            // Configurar campo capacidad
            textCapacidad.Text = "67";
            textCapacidad.ReadOnly = true;

            // Configurar validación de campos
           // txtCodigoViaje.MaxLength = 2;
            //txtCodigoViaje.CharacterCasing = CharacterCasing.Upper;
        }
        private bool ValidarNumeroViaje()
        {
            if (txtCodigoViaje.Text != "1" && txtCodigoViaje.Text != "2")
            {
                MessageBox.Show("El número de viaje debe ser '1' o '2'", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoViaje.Focus();
                return false;
            }
            return true;
        }

        private void txtCodigoViaje_TextChanged(object sender, EventArgs e)
        { //validacion en tiempo real para el numero de viaje
            if (txtCodigoViaje.Text.Length > 1)
            {
                txtCodigoViaje.Text = txtCodigoViaje.Text.Substring(0,1);
                txtCodigoViaje.SelectionStart = 1;
            }
        }

        private void txtCodigoViaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo permite 1 o 2 viajes
            if (e.KeyChar != '1' && e.KeyChar != '2' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMontoViaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool ValidarCampos()
        {
            // Validar número de viaje
            if (!ValidarNumeroViaje())
                return false;

            // Validar terminales seleccionadas
            if (cboTerminalSalida.SelectedItem == null || cboTerminalLlegada.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar terminal de salida y llegada", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que terminales sean diferentes
            if (cboTerminalSalida.SelectedItem.ToString() == cboTerminalLlegada.SelectedItem.ToString())
            {
                MessageBox.Show("La terminal de salida y llegada deben ser diferentes", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar monto
            if (!decimal.TryParse(txtMontoViaje.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("Ingrese un monto válido mayor que cero", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoViaje.Text) ||
            string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
            cboTerminalSalida.SelectedIndex == -1 ||
            cboTerminalLlegada.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(txtMontoViaje.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Cla_Viaje nuevoViaje = new Cla_Viaje
            {
                Codigo = txtCodigoViaje.Text,
                Descripcion = txtDescripcion.Text,
                TerminalSalida = cboTerminalSalida.SelectedItem.ToString(),
                TerminalLlegada = cboTerminalLlegada.SelectedItem.ToString(),
                Capacidad = int.Parse(textCapacidad.Text),
                Costo = decimal.Parse(txtMontoViaje.Text)
            };

            // Inicializar asientos y capacidad disponible
            nuevoViaje.InicializarAsientos();

            // Validar código duplicado
            if (ListaViajes.Any(v => v.Codigo == nuevoViaje.Codigo))
            {
                MessageBox.Show("El código de viaje ya existe", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar en la lista
            ListaViajes.Add(nuevoViaje);

            MessageBox.Show("Viaje registrado con éxito", "Éxito",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarCampos();
        }



        private void LimpiarCampos()
        {
            txtCodigoViaje.Clear();
            txtDescripcion.Clear();
            cboTerminalSalida.SelectedIndex = -1;
            cboTerminalLlegada.SelectedIndex = -1;
            txtMontoViaje.Clear();
            textCapacidad.Text = "67";
            txtCodigoViaje.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos no utilizados (pueden quedar vacíos)
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textCapacidad_TextChanged(object sender, EventArgs e) { }
        private void txtMontoViaje_TextChanged(object sender, EventArgs e) { }
        private void cboTerminalSalida_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboTerminalLlegada_SelectedIndexChanged(object sender, EventArgs e) { }
        private void FrmMantenimientoViajes_Load(object sender, EventArgs e)
        {
            txtCodigoViaje.Focus();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoViaje.Text;

            var viaje = ListaViajes.FirstOrDefault(v => v.Codigo == codigo);

            if (viaje != null)
            {
                ListaViajes.Remove(viaje);
                MessageBox.Show("Viaje eliminado", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el viaje con ese código", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
        }

        private void VerAsientos_Click(object sender, EventArgs e)
        {

        }

        private void dgvAsientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
       

       

    }
    }