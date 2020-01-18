using System;

namespace Capitulo_3_1 //pedir un numero y decir si es par o impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
        }
    }
}
