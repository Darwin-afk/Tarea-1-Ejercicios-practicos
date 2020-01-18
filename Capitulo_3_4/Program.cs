using System;

namespace Capitulo_3_4 //pedir un numero del 1 al 7 y decir el dia de la semana correspondiente
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un numero del 1 al 7: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch(numero)
            {
                case 1:
                    Console.WriteLine("Es lunes");
                    break;
                case 2:
                    Console.WriteLine("Es martes");
                    break;
                case 3:
                    Console.WriteLine("Es miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es jueves");
                    break;
                case 5:
                    Console.WriteLine("Es viernes");
                    break;
                case 6:
                    Console.WriteLine("Es sabado");
                    break;
                case 7:
                    Console.WriteLine("Es domingo");
                    break;
                default:
                    Console.WriteLine("Valor no valido");
                    break;
            }
        }
    }
}
