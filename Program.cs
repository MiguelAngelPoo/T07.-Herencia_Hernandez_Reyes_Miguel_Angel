using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar
            Paciente V = new Paciente();
            Enfermera v1 = new Enfermera();
            Hombre v2 = new Hombre();
            Mujer v3 = new Mujer();
            MedicoFamiliar v4 = new MedicoFamiliar();
            Medico v5 = new Medico();
            Fisioterapeuta v6 = new Fisioterapeuta();
            Cirujana v7 = new Cirujana();

            //crear objetos y asignar datos
            V.Id = 1324234;
            V.TipoPaciente = ("Cirugia");
            Console.WriteLine(" Datos de paciente");
            Console.WriteLine("El id es: " + V.Id);
            Console.WriteLine("el tipo de paciente es:" + V.TipoPaciente);
            Console.ReadKey();

            Console.WriteLine(" ");
            
            v1.id = 11241;
            v1.Area = ("Planta alta");
            Console.WriteLine("datos de enfermera ");
            Console.WriteLine("La enfermera id: " + v1.id);
            Console.WriteLine("La enfermera area: " + v1.Area);

            Console.WriteLine(" ");

            v2.id = 312134;
            Console.WriteLine("datos de hombre ");
            v2.ocupacion = ("maquinista");
            Console.WriteLine("ocupacion :" + v2.ocupacion);
            Console.WriteLine("id mujer: " +v2.id);

            Console.WriteLine(" ");

            v3.id = 234112;
            v3.Tipo_sangre = ("A+");
            Console.WriteLine("datos de Mujer: ");
            Console.WriteLine("id: "+ v3.id);
            Console.WriteLine("Tipo de sangre: " + v3.Tipo_sangre);


            Console.WriteLine(" ");

            v4.Numconsul = ("A3");
            v4.Especialidad =("Dentista");
            Console.WriteLine("Medico familiar");
            Console.WriteLine("consultorio: "+ v4.Numconsul);
            Console.WriteLine("numero de consoltorio: "+ v4.Especialidad);

            Console.WriteLine(" ");

            v5.cantidadDoc = ("7");
            v5.Edificio = ("Buena vista");
            Console.WriteLine("Medico");
            Console.WriteLine("cantidad de doctores: " + v5.cantidadDoc);
            Console.WriteLine("edificio: " + v5.Edificio);

            Console.WriteLine(" ");

            v6.NivelStudio = ("Catedratico");
            Console.WriteLine("Fisoterapeuta");
            Console.WriteLine("nivel de estudio: " + v6.NivelStudio);

            Console.WriteLine(" ");

            v7.Experencia = ("7 años");
            v7.Horario = ("10am-4pm");
          
            Console.WriteLine("Cirujana");
            Console.WriteLine("Experiencia: " + v7.Experencia);
            Console.WriteLine("Experiencia: " + v7.Horario);


            Console.ReadKey();
        }
    }
}
