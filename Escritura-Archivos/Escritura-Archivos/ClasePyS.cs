using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_Archivos
{
        public class SeriesYPeliculas
        {
            public string seriesypeliculas;
            private float calificacion;

            public SeriesYPeliculas(string seriesypeliculas, float calificacion)
            {
                this.seriesypeliculas = seriesypeliculas;
                this.Calificacion = calificacion;
            }

            public float Calificacion
            {
                get { return calificacion; }
                set
                {
                    if (value <= 10 && value > 0)
                    {
                        calificacion = value;
                    }
                    else if (value > 10)
                    {
                        calificacion = 10;
                    }
                    else if (value < 0)
                    {
                        calificacion = 0;
                    }
                }
            }

            public void DesplegarDatos()
            {
                Console.WriteLine("La pelicula o serie que vi es: " + seriesypeliculas + " y le doy una calificacion de: " + calificacion);
            }
        }
    }

