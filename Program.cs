using System;

namespace HolaInicial
{

    public class DatosPersonales{
        public string Nombre{get;set;}
        public int Edad{get;set;}

    }

    class Program
    {
        static void Main(string[] args)
        {
            DatosPersonales uno=new DatosPersonales();
            uno.Nombre="Ramiro";
            Console.Write("Ingrese la edad: ");
            uno.Edad=int.Parse(Console.ReadLine());
            Console.WriteLine(uno.Nombre +" tiene: "+uno.Edad);
        }
    }
}
