using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_Archivos
{
   internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo 2.txt", true);
            // Si el archivo no existe, lo creará
            // y  si ya es un archivo existente, escribira en el 
            Console.Write("Indica cuantas personas quieres agregar:");
            int cantidad = int.Parse(Console.ReadLine());

            string[] lines = new string[cantidad];
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write("Indique el nombre de la persona que desea escribir: ");
                lines[i] = Console.ReadLine();
            }

            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
