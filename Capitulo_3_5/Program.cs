using System;

namespace Capitulo_3_5 //calcular el perimetro y el area de un poligono regular que el usuario desee
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            float bas, altura, ladoIzq, ladoDer;
            float perimetro = 0.0f, area = 0.0f;

            Console.Write("Elija un poligono: \n" +
                "1-Triangulo\n" +
                "2-Cuadrado\n" +
                "3-Rectangulo\n" +
                "-");
            op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.Write("Ingrese la base: ");
                    bas = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    altura = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Ingrese el lado izquierdo: ");
                    ladoIzq = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Ingrese el lado derecho: ");
                    ladoDer = Convert.ToSingle(Console.ReadLine());

                    perimetro = ladoIzq + bas + ladoDer;
                    area = (bas * altura) / 2;
                    break;
                case 2:
                    float lado;

                    Console.Write("Ingrese el lado: ");
                    lado = Convert.ToSingle(Console.ReadLine());

                    perimetro = 4 * lado;
                    area = lado * lado;
                    break;
                case 3:
                    Console.Write("Ingrese la base: ");
                    bas = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Ingrese la altura: ");
                    altura = Convert.ToSingle(Console.ReadLine());

                    perimetro = (2 * bas) + (2 * altura);
                    area = bas * altura;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            Console.WriteLine("El perimetro es: {0}\n" +
                "El area es: {1}", perimetro, area);

        }
    }
}
