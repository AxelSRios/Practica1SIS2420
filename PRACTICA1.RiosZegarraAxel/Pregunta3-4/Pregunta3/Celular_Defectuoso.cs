using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pregunta3
{
    internal class Celular_Defectuoso : Celular
    {
        public DateTime Fecha_Defecto { get; set; }
        public String Motivo { get; set; }

        public override void MostrarCelular()
        {
            Console.WriteLine("La marca es: " + Marca + "\nEl modelo: " + Modelo + "\nEl sistema ooperativo es:" + SO +"\nLa memoria RAM es:"+RAM+"\nY el almacenamiento: " + Almacenamiento);
        }
    }
}
