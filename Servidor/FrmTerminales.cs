using Servidor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{

    public partial class FrmTerminales : Form
    {

        public List<Cla_Terminal> ListaTerminales { get; set; }

        public FrmTerminales(List<Cla_Terminal> terminales)
        {
            InitializeComponent();
            ListaTerminales = terminales;
            ConfigurarControles();
            CargarTerminales();
            ActualizarGridTerminales();
            
            ActualizarGridTerminales();
            
        }
        private void ConfigurarControles()
        {
            // Configuración básica del DataGridView
            dgvTerminales.AutoGenerateColumns = false;
            dgvTerminales.AllowUserToAddRows = false;
            dgvTerminales.Columns.Clear();

            // Configurar columnas
            dgvTerminales.Columns.Add("Codigo", "Código");
            dgvTerminales.Columns["Codigo"].DataPropertyName = "Codigo";

            dgvTerminales.Columns.Add("Nombre", "Nombre");
            dgvTerminales.Columns["Nombre"].DataPropertyName = "Nombre";

            dgvTerminales.Columns.Add("Ubicacion", "Ubicación");
            dgvTerminales.Columns["Ubicacion"].DataPropertyName = "Ubicacion";

            //columna del botos editar
            var colEditar = new DataGridViewButtonColumn
            {
                Name = "colEditar",
                HeaderText = "Editar",
                Text = "Editar",
                UseColumnTextForButtonValue = true
            };
            dgvTerminales.Columns.Add(colEditar);

            //columna para el boton eliminar
            var colEliminar = new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dgvTerminales.Columns.Add(colEliminar);

            // Configurar botones del formulario
            btnGuardar.Text = "Guardar";
            btnEliminar.Text = "Eliminar";
            btnLimpiar.Text = "Limpiar";
            btnCerrar.Text = "Cerrar";

            // Deshabilitar eliminar inicialmente
            btnEliminar.Enabled = false;

            //eventos del DataGridView
            dgvTerminales.CellContentClick += dgvTerminales_CellContentClick;
        }

        public void CargarTerminales()
        {
            dgvTerminales.Rows.Clear();

            foreach (var terminal in ListaTerminales)
            {
                dgvTerminales.Rows.Add(
                    terminal.Codigo,
                    terminal.Nombre,
                    terminal.Ubicacion
                );
            }
        }

        private void FrmTerminales_Load(object sender, EventArgs e)
        {

        }

        private void dgvTerminales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Solo manejar clicks en columnas de botones y no en encabezados
            if (e.RowIndex >= 0 && (e.ColumnIndex == dgvTerminales.Columns["colEditar"].Index ||
                                   e.ColumnIndex == dgvTerminales.Columns["colEliminar"].Index))
            {
                var terminal = (Cla_Terminal)dgvTerminales.Rows[e.RowIndex].DataBoundItem;

                if (e.ColumnIndex == dgvTerminales.Columns["colEditar"].Index)
                {
                    EditarTerminal(terminal);
                }
                else if (e.ColumnIndex == dgvTerminales.Columns["colEliminar"].Index)
                {
                    EliminarTerminal(terminal);
                }
            }
        }

        private void EditarTerminal(Cla_Terminal terminal)
        {
            // Llenar formulario con datos existentes
            txtCodigo.Text = terminal.Codigo;
            txtNombre.Text = terminal.Nombre;
            txtUbicacion.Text = terminal.Ubicacion;

            //  Deshabilitar campo código si no debe editarse
            txtCodigo.Enabled = false;
            btnGuardar.Text = "Actualizar"; // Cambiar texto del botón a "Actualizar"
            btnEliminar.Enabled = true; // Habilitar botón eliminar
        }

        private void EliminarTerminal(Cla_Terminal terminal)
        {
            if (MessageBox.Show($"¿Eliminar la terminal {terminal.Nombre}?", "Confirmar",
                              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ListaTerminales.Remove(terminal);
                ActualizarGridTerminales();
                LimpiarCampos(); // Limpiar campos después de eliminar
                MessageBox.Show("Terminal eliminada correctamente", "Éxito");
            }
        }
        private void ActualizarGridTerminales()
        {
            // Método seguro para actualizar el DataSource
            var bindingList = new BindingList<Cla_Terminal>(ListaTerminales);
            dgvTerminales.DataSource =new BindingSource(bindingList, null);

            //  Autoajustar columnas después de actualizar
            dgvTerminales.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dgvTerminales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evita el encabezado

            var terminal = ListaTerminales[e.RowIndex];

            if (dgvTerminales.Columns[e.ColumnIndex].Name == "colEditar")
            {
                EditarTerminal(terminal);
            }
            else if (dgvTerminales.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                EliminarTerminal(terminal);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var terminal = new Cla_Terminal
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Ubicacion = txtUbicacion.Text
            };

            // Validar límite de terminales 
            if (ListaTerminales.Count >= 2 && !ListaTerminales.Any(t => t.Codigo == terminal.Codigo))
            {
                MessageBox.Show("No se pueden agregar más de 2 terminales", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar código único para San José
            if (terminal.Nombre.ToLower().Contains("san josé") ||
                terminal.Nombre.ToLower().Contains("san jose"))
            {
                if (ListaTerminales.Any(t => t.Codigo == terminal.Codigo &&
                    (t.Nombre.ToLower().Contains("san josé") ||
                     t.Nombre.ToLower().Contains("san jose"))))
                {
                    MessageBox.Show("Ya existe una terminal de San José con este código", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Verificar si es nuevo o edición
            var existente = ListaTerminales.FirstOrDefault(t => t.Codigo == terminal.Codigo);

            if (existente != null)
            {
                // Actualizar existente
                existente.Nombre = terminal.Nombre;
                existente.Ubicacion = terminal.Ubicacion;
                MessageBox.Show("Terminal actualizada", "Éxito");
            }
            else
            {
                // Agregar nueva
                ListaTerminales.Add(terminal);
                MessageBox.Show("Terminal agregada", "Éxito");
            }

            ActualizarGridTerminales();
            LimpiarCampos();
            
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("El código es requerido", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error");
                return false;
            }
            // Validar formato del código sea numerico
            if (!int.TryParse(txtCodigo.Text, out int codigoNum) || codigoNum <= 0)
            {
                MessageBox.Show("El código debe ser un número mayor que 0", "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error");
                return false;
            }

            return true;
        }


        private void dgvTerminales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTerminales.SelectedRows.Count > 0)
            {
                var terminal = ListaTerminales[dgvTerminales.SelectedRows[0].Index];
                txtCodigo.Text = terminal.Codigo;
                txtNombre.Text = terminal.Nombre;
                txtUbicacion.Text = terminal.Ubicacion;
                btnEliminar.Enabled = true;
                btnGuardar.Text = "Actualizar";
                txtCodigo.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTerminales.SelectedRows.Count > 0)
            {
                var terminal = ListaTerminales[dgvTerminales.SelectedRows[0].Index];
                EliminarTerminal(terminal);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtUbicacion.Clear();
            txtCodigo.Enabled = true; // Habilitar campo código para nuevas entradas

            btnEliminar.Enabled = false;
            btnGuardar.Text = "Guardar"; // Resetear texto del botón
            dgvTerminales.ClearSelection();
           
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
