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
    public partial class Principal : Form
    {
        //  Declara la lista de viajes a nivel de clase
        public List<Cla_Viaje> ListaViajes { get; set; } = new List<Cla_Viaje>();
        public List<Cla_Terminal> ListaTerminales { get; set; } = new List<Cla_Terminal>();
        public Principal()
        {
            InitializeComponent();
            InicializarDatosEjemplo();
        }

        private void InicializarDatosEjemplo()
        {
            // Datos iniciales para prueba (opcional)
            ListaViajes.Add(new Cla_Viaje
            {
                Codigo = "01",
                TerminalSalida = "SAN JOSE",
                TerminalLlegada = "EL COCO",
                Costo = 3500
            });

            ListaViajes.Add(new Cla_Viaje
            {
                Codigo = "02",
                TerminalSalida = "EL COCO",
                TerminalLlegada = "SAN JOSE",
                Costo = 4000
            });
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Crea una instancia del formulario de mantenimiento
            FrmMantenimientoViajes frmMantenimiento = new FrmMantenimientoViajes(ListaViajes);

            // Muestra el formulario como diálogo (modal)
            DialogResult result = frmMantenimiento.ShowDialog();

            // Puedes agregar lógica post-cierre si es necesario
            if (result == DialogResult.OK)
            {
                // Ejemplo: Actualizar lista si hubo cambios
                MessageBox.Show("Mantenimiento de viajes completado",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void MantenimientoViajes_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenimientoTerminales_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de terminales pasando la lista de terminales
            FrmTerminales frmTerminales = new FrmTerminales(ListaTerminales);

            // Muestra el formulario como diálogo (modal)
            DialogResult result = frmTerminales.ShowDialog();

            // Lógica post-cierre si es necesario
            if (result == DialogResult.OK)
            {
                // Aquí puede actualizar datos si el formulario hizo cambios
                MessageBox.Show("Mantenimiento de terminales completado",
                               "Información",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
