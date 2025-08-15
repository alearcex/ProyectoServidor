using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servidor.Models
{
    public class Cla_Viaje
    {
        public string Codigo { get; set; }
        public string TerminalSalida { get; set; }
        public string TerminalLlegada { get; set; }
        public int Capacidad { get; set; } = 67;
        public decimal Costo { get; set; }
        public int AsientosDisponibles { get; set; } = 67;


        //matriz de asientos
        //(13 filas, 5 asientos por fila excepto la última que tiene 7)
        public bool[,] Disponibilidad { get; private set; } = new bool[13, 7];
        public Cla_Viaje()
        {
            // Inicializar todos los asientos como disponibles (true)
            for (int i = 0; i < 13; i++)
                for (int j = 0; j < 7; j++)
                    Disponibilidad[i, j] = true;
        
    }

      
        

      
    }
}