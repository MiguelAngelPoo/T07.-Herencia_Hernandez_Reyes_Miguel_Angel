using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   //heredamos la clase paciente con persona
    public class Paciente: Persona
    {
        //encapsular
        public int Id { get; set; }
        public string TipoPaciente { get; set; }
    }
}
