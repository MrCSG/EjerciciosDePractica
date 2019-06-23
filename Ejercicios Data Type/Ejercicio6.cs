using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio6
    {
        public static void Solution()
        {
            int x;
            Console.WriteLine("Esta función mostrará algunos resultados de la función: x = y2 + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                x = (y*y) + (2*y) + 1;
                Console.WriteLine($"Para y={y}, x={x}");
            }
        }
    }
}