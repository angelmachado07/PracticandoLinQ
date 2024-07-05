using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ciudad> ciudades = new List<Ciudad>();
            Ciudad Salto = new Ciudad(1, "Salto", 80000);
            Ciudad Melo = new Ciudad(2, "Melo", 60000);
            Ciudad Maldonado = new Ciudad(3, "Maldonado", 120000);
            Ciudad SanCarlos = new Ciudad(4, "San Carlos", 20000);
            Ciudad Montevideo = new Ciudad(5, "Montevideo", 1200000);

            ciudades.Add(Salto);
            ciudades.Add(Melo);
            ciudades.Add(Maldonado);
            ciudades.Add(SanCarlos);
            ciudades.Add(Montevideo);

            //List<Ciudad> ciudOrdenadas = ciudades.OrderBy(x => x.poblacion).ToList();

            //A la vieja andanza 
            //foreach (var ciudad in ciudOrdenadas)
            //{
            //    Console.WriteLine(ciudad.nombre);
            //}

            //El where es como un if, un filtro
            //ciudades.OrderBy(x => x.poblacion).ToList().Where(x => x.poblacion > 50000 && x.nombre == "Maldonado").ToList().ForEach(x => Console.WriteLine(x.nombre));

            //Crea una lista solo con los nombres
            //List<string> nomCiudades = ciudades.OrderBy(x => x.poblacion).Select(x => x.nombre).ToList();

            ciudades.OrderBy(x => x.poblacion)
                .Where(x => x.poblacion > 50000)
                .Where(x => x.nombre == "Melo")
                .Select(x => x.poblacion).ToList()
                .ForEach(x => Console.WriteLine(x));


        }
    }
}
