using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio2
    {
        public static void Solution()
        {
            int number = 0, width = 0;
            bool isNumber;
            do{
                Console.Write("Ingrese primero un número y luego el ancho de la base para formar un tríangulo invertido.\nNúmero: ");
                if(isNumber = Int32.TryParse(Console.ReadLine(), out number)){
                    Console.Write("Base: ");
                    if(isNumber = Int32.TryParse(Console.ReadLine(), out width)){
                        Console.WriteLine($"Se va a formar un triangulo de \"{number}\" con una base de {width}: ");
                    }
                }
                if(!isNumber)
                    Console.WriteLine("El dato ingresado no es un número.");
            }while(!isNumber);

            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}