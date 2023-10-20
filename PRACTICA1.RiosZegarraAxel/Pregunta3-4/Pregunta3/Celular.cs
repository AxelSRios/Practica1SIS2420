using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    internal class Celular
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String SO { get; set; }
        public String RAM { get; set; }
        public String Almacenamiento { get; set; }

        public virtual void MostrarCelular()
        {
            Console.WriteLine("La marca es: "+Marca+"\nEl modelo: "+Modelo+"\nEl sistema ooperativo es:"+SO+"\nLa memoria RAM: "+RAM+"\nY el almacenamiento: "+Almacenamiento);
        }
    }
}
