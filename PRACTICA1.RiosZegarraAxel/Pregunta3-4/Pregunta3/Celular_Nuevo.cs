using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    internal class Celular_Nuevo : Celular
    {
        public DateTime Fecha_Ingreso { get; set; }
        public int Precio { get; set; }

        public override void MostrarCelular()
        {
            Console.WriteLine("La marca es: " + Marca + "\nEl modelo: " + Modelo + "\nEl sistema ooperativo es:" + SO +"\nLa memoria RAM es:"+RAM+"\nY el almacenamiento: " + Almacenamiento);
        }
    }
}
