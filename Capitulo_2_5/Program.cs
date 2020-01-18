using System;

namespace Capitulo_2_5 //convertir de dolares a euros con el tipo de cambio del dia
{
    class Program
    {
        static void Main(string[] args)
        {
            float dolar, euro, valorConversion;

            Console.Write("Ingrese el valor del dolar en euro: ");
            valorConversion = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese los dolares a convertir: ");
            dolar = Convert.ToSingle(Console.ReadLine());

            euro = dolar * valorConversion;

            Console.WriteLine("El resultado es: {0} euros", euro);
        }
    }
}
