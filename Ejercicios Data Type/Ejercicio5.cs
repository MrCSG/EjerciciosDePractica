using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio5
    {
        public static void Solution()
        {
            const float pi = 3.14159265359f;
            float radius, perimeter, area;
            Console.Write("Radio: ");
            float.TryParse(Console.ReadLine(),out radius);
            perimeter = 2f * pi * radius;
            area = pi * (radius * radius);
            Console.WriteLine($"Perímetro: {perimeter}");
            Console.WriteLine($"Área: {area}");
        }
    }
}