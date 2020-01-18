using System;

namespace Capitulo_2_4
{
    class Program  //convertir de grados Centigrados a grados Fahrenheit
    {
        static void Main(string[] args)
        {
            float gradoC, gradoF;

            Console.Write("Ingrese los grados centigrados: ");
            gradoC = Convert.ToSingle(Console.ReadLine());

            gradoF = (gradoC * 9 / 5) + 32;

            Console.WriteLine("Son {0} grados Fahrenheit", gradoF);
        }
    }
}
