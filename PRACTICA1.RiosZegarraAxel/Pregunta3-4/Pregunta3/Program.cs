using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pregunta3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Celular_Nuevo>listCelularN = new List<Celular_Nuevo>();
            listCelularN.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "A74",
                SO = "Android",
                RAM = "12GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("02/08/2022"),
                Precio = 2500,
            }) ;
            listCelularN.Add(new Celular_Nuevo()
            {
                Marca = "Apple",
                Modelo = "iphone 14",
                SO = "IOS",
                RAM = "8GB",
                Almacenamiento = "512GB",
                Fecha_Ingreso = DateTime.Parse("17/10/2023"),
                Precio = 7500,
            });
            listCelularN.Add(new Celular_Nuevo()
            {
                Marca = "Xiaomi",
                Modelo = "RedmiNote 12",
                SO = "Android",
                RAM = "12GB",
                Almacenamiento = "256GB",
                Fecha_Ingreso = DateTime.Parse("07/05/2023"),
                Precio = 1800,
            });
            listCelularN.Add(new Celular_Nuevo()
            {
                Marca = "Samsung",
                Modelo = "A53 5G",
                SO = "Android",
                RAM = "8GB",
                Almacenamiento = "128GB",
                Fecha_Ingreso = DateTime.Parse("12/12/2022"),
                Precio = 2000,
            });
            listCelularN.Add(new Celular_Nuevo()
            {
                Marca = "Xiaomi",
                Modelo = "MI 12",
                SO = "Android",
                RAM = "16GB",
                Almacenamiento = "512GB",
                Fecha_Ingreso = DateTime.Parse("02/04/2023"),
                Precio = 3500,
            });

            List<Celular_Defectuoso> listCelularD = new List<Celular_Defectuoso>();
            listCelularD.Add(new Celular_Defectuoso()
            {
                Marca = "Samsung",
                Modelo = "Grand Prime Neo",
                SO = "Android",
                RAM = "2GB",
                Almacenamiento = "8GB",
                Fecha_Defecto = DateTime.Parse("18/04/2020"),
                Motivo = "Pantalla rota",
            });
            listCelularD.Add(new Celular_Defectuoso()
            {
                Marca = "Apple",
                Modelo = "iphone 7",
                SO = "IOS",
                RAM = "3GB",
                Almacenamiento = "64GB",
                Fecha_Defecto = DateTime.Parse("16/1/2021"),
                Motivo = "Bateria en mal estado",
            });
            listCelularD.Add(new Celular_Defectuoso()
            {
                Marca = "Xiaomi",
                Modelo = "RedmiNote 9",
                SO = "Android",
                RAM = "6GB",
                Almacenamiento = "128GB",
                Fecha_Defecto = DateTime.Parse("27/02/2022"),
                Motivo = "Tarjeta madre quemada",
            });
            listCelularD.Add(new Celular_Defectuoso()
            {
                Marca = "Samsung",
                Modelo = "J4",
                SO = "Android",
                RAM = "4GB",
                Fecha_Defecto = DateTime.Parse("17/06/2019"),
                Motivo = "Extravio",
            });
            listCelularD.Add(new Celular_Defectuoso()
            {
                Marca = "Huawei",
                Modelo = "Y7 2019",
                SO = "Android",
                RAM = "4GB",
                Almacenamiento = "32GB",
                Fecha_Defecto = DateTime.Parse("23/12/2019"),
                Motivo = "Robo",
            });

            //Para Hallar el promedio de los precios 
            double Prom_Celular = listCelularN.Average(x => x.Precio);
            Console.WriteLine("El promedio de los precios es"+Prom_Celular);

            //Para buscar los celulares de marca Samsung en ambas listas
            var Cel_MercaSN = listCelularN.Where(x => x.Marca == "Samsung");
            Console.WriteLine("Celulares de la marca Samsung");
            foreach (var item in Cel_MercaSN)
            {
                Console.WriteLine(item.Modelo);
            }
            var Cel_MercaSD = listCelularD.Where(x => x.Marca == "Samsung");
            Console.WriteLine("Celulares de la marca Samsung");
            foreach (var item in Cel_MercaSD)
            {
                Console.WriteLine(item.Modelo);
            }


            //Celulares que tengan 8GB de RAM, Sistema Operativo Android y 128 GB de almacenamiento
            void Caracteristicas(List<Celular_Nuevo> cel)
            {
                //LinQ
                var Celular_RSA = from celular in cel
                                  where celular.RAM == "8GB" && celular.SO == "Android" && celular.Almacenamiento == "128GB"
                                 select celular;
                Console.WriteLine("Celulares que tengan 8GB de RAM, Sistema Operativo Android y 128 GB de almacenamiento");
                foreach (var item in Celular_RSA)
                {
                    Console.WriteLine(item.Modelo);
                }
            };

            //Para celulares que se ingreso en 2008
            var Celular_Ingreso = listCelularN.Where(x => x.Fecha_Ingreso.Year == 2008);
            Console.WriteLine("Celulares que ingresaron en 2008");
            foreach (var item in Celular_Ingreso)
            {
                Console.WriteLine(item.Modelo);
            }
            Console.ReadKey();
        }
    }
}
