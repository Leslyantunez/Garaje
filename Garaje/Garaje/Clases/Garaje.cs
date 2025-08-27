using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGaraje.Clases
{
    internal class Garaje
    {
        public int NumeroGaraje { get; set; }
        public string Descripcion { get; set; }
        public int CapacidadEspacios { get; set; }
        public int EspaciosOcupados { get; set; }


        public Garaje(int numeroGaraje, string descripcion, int capacidadEspacios)
        {
            this.NumeroGaraje = numeroGaraje;
            this.Descripcion = descripcion;
            this.CapacidadEspacios = capacidadEspacios;
            this.EspaciosOcupados = 0;
        }

        public Garaje()
        { }
        

        public int getEspaciosDisponibles() 
        {
            return CapacidadEspacios - EspaciosOcupados;
        }

        public void getEspaciosOcupados(int EspaciosSolicitados)
        {
            if (EspaciosOcupados - EspaciosSolicitados <= CapacidadEspacios)
            {
                EspaciosOcupados = EspaciosOcupados + EspaciosSolicitados;
                Console.WriteLine("Espacios ocupados actualizados " + EspaciosOcupados);
            }
            else
            {
                Console.WriteLine("No hay suficientes espacios disponibles");
            }
        }
    }
}

