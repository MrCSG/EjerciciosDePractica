using System;

namespace Ejercicios_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número del ejercicio que desea ver:");
            switch (Console.ReadLine())
            {
                case "1":
                    Ejercicio1.Solution();
                    break;
                case "2":
                    Ejercicio2.Solution();
                    break;
                case "3":
                    Ejercicio3.Solution();
                    break;
                default:
                    Console.WriteLine("Número de ejercicio no encontrado.");
                    break;
            }
        }
    }
}
