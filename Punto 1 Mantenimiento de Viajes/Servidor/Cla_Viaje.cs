using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    public class Cla_Viaje
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string TerminalSalida { get; set; }
        public string TerminalLlegada { get; set; }
        public int Capacidad { get; set; }
        public int CapacidadDisponible { get; set; }
        public decimal Costo { get; set; }

        // Arreglo 13 x 7 para asientos (1 = disponible, 0 = ocupado)
        public int[,] Asientos { get; set; } = new int[13, 7];

        // Método para inicializar asientos como disponibles
        public void InicializarAsientos()
        {
            for (int fila = 0; fila < 13; fila++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Asientos[fila, col] = 1; // todos disponibles
                }
            }
            CapacidadDisponible = Capacidad;
        }

        // Método para representar una fila como string (ejemplo: "1111100")
        public string ObtenerFilaComoTexto(int fila)
        {
            string resultado = "";
            for (int col = 0; col < 7; col++)
            {
                resultado += Asientos[fila, col].ToString();
            }
            return resultado;
        }
    }
}