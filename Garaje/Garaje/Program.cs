using ProyectoGaraje.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGaraje 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garaje garaje1 = new Garaje(); 
           
            Console.WriteLine("Espacios disponibles: " + garaje1.getEspaciosDisponibles());
            garaje1.getEspaciosOcupados(20);
            Console.WriteLine("Espacios disponibles ahora: " + garaje1.getEspaciosDisponibles());
            garaje1.getEspaciosOcupados(25);
            Console.WriteLine("Espacios disponibles ahora: " + garaje1.getEspaciosDisponibles());

            Console.ReadLine();

        }
    }
}
