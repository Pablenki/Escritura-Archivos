using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_Archivos
{
    class program
    { 
    public class SeriesYPeliculas
    {
            string seriesypeliculas;
            float calificacion;

        public SeriesYPeliculas(string seriesypeliculas, float calificacion)
        {
            this.seriesypeliculas = seriesypeliculas;
            this.calificacion = calificacion;
        }

        public void DesplegarDatos()
        {                                             
        Console.WriteLine("La pelicula o serie que vi es: " + seriesypeliculas + " y le doy una calificacion de: " + calificacion);                      
        }
    }

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Series&Peliculas.txt", true);

            string seriesypeliculas;
            float calificacion;
            char inciso;
         
            do
            {
                Console.WriteLine("Si deseas seguir escribiendo ingresa la *S* por lo contrario, ingresa *N*");
                Console.Write("¿Deseas seguir escribiendo?: ");
                inciso = char.Parse(Console.ReadLine());

                Console.Clear();

                // Switch para elegir entre un menu de opciones
                switch (inciso)
                {
                    case 'S':
                        {
                            // Captura de variables auxiliares
                            Console.Write("Nombre de la serie o de la pelicula: ");
                            seriesypeliculas = Console.ReadLine();
                            Console.Write("Calificacion de la serie o de la pelicula: ");
                            calificacion = float.Parse(Console.ReadLine());

                            //comienza a escribir la serie 
                            sw.WriteLine(seriesypeliculas + "\t\t" + calificacion);                            
                            SeriesYPeliculas Nombres = new SeriesYPeliculas(seriesypeliculas, calificacion);
                            Nombres.DesplegarDatos();

                            Console.WriteLine("Escribiendo archivo...");                          
                            Console.ReadKey(); 
                            Console.Clear();
                        }
                        break;

                    case 'N':
                        {
                            Console.WriteLine("Has decidido dejar de escribir");
                            sw.Close();//El archivo siempre se cierra
                        }
                        break;

                    default:
                        Console.WriteLine("Opcion incorrecta, elige una de las opciones que se muestran al inicio");
                        break;
                }
            } while (inciso != 'N');
          
        }
     }
}
