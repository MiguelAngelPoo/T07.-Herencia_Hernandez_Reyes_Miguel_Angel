using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class MedicoFamiliar:Medico
    {
        //encapsular
        public String Numconsul { get; set; }
        public String Especialidad { get; set; }
    }
}
