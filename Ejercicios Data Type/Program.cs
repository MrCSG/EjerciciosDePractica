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
                    Console.WriteLine("-----");
                    Ejercicio1.Solution();
                    break;
                case "2":
                    Console.WriteLine("-----");
                    Ejercicio2.Solution();
                    break;
                case "3":
                    Console.WriteLine("-----");
                    Ejercicio3.Solution();
                    break;
                case "4":
                    Console.WriteLine("-----");
                    Ejercicio4.Solution();
                    break;
                case "5":
                    Console.WriteLine("-----");
                    Ejercicio5.Solution();
                    break;
                case "6":
                    Console.WriteLine("-----");
                    Ejercicio6.Solution();
                    break;
                default:
                    Console.WriteLine("Número de ejercicio no encontrado.");
                    break;
            }
        }
    }
}
