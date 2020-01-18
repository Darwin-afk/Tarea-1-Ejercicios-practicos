using System;

namespace Capitulo_2_1 //calcular el perimetro de un poligono regular
{
    class Program
    {
        static void Main(string[] args)
        {
            float cantidad, lado, perimetro;

            Console.Write("Ingrese el numero de lados: ");
            cantidad = Convert.ToSingle(Console.ReadLine());

            Console.Write("Ingrese la longitud del lado: ");
            lado = Convert.ToSingle(Console.ReadLine());

            perimetro = cantidad * lado;

            Console.WriteLine("El perimetro es igual a: {0}", perimetro);
        }
    }
}
