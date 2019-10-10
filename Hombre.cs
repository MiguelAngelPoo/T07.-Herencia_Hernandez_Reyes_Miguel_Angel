using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Hombre: Persona
    {
        //encapsular
        public int id { get; set; }
        public string direccion { get; set; }
        public string peso { get; set; }
        public string ocupacion { get; set; }
    }
}
