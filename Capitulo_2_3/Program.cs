using System;

namespace Capitulo_2_3 //convertir de grado a radian
{
    class Program
    {
        static void Main(string[] args)
        {
            float grado, radian;

            Console.Write("Ingrese los radianes a convertir: ");
            grado = Convert.ToSingle(Console.ReadLine());

            radian = grado * 0.0174f;

            Console.WriteLine("Es igual a {0} radianes", radian);
        }
    }
}
