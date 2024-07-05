using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticandoLinQ
{
    internal class Ciudad
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int poblacion { get; set; }

        public Ciudad(int id, string nombre, int poblacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.poblacion = poblacion;
        }
    }
}
