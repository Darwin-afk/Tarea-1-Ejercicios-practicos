using System;

namespace Capitulo_4_2 //calcular un numero elevado a una potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero, resultado;
            int potencia;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToSingle(Console.ReadLine());
            resultado = numero;

            Console.Write("Ingrese la potencia: ");
            potencia = Convert.ToInt32(Console.ReadLine());

            for(;potencia > 1;potencia--)
            {
                resultado *= numero;
            }

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
