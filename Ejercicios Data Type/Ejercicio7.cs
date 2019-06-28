/* 7. Write a C# Sharp program that takes distance and time as input and displays the speed in kilometers per hour and miles per hour. 
Test Data:
Input distance(meters): 50000 
Input timeSec(hour): 1 
Input timeSec(minutes): 35
Input timeSec(seconds): 56
Expected Output:
Your speed in meters/sec is 8.686588
Your speed in km/h is 31.27172 
Your speed in miles/h is 19.4355 */

using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio7
    {
        public static void Solution()
        {
            float meters, hour, minutes, seconds;
            Console.Write("Distancia (metros): ");
            float.TryParse(Console.ReadLine(),out meters);
            Console.Write("Tiempo (horas): ");
            float.TryParse(Console.ReadLine(),out hour);
            Console.Write("Tiempo (minutos): ");
            float.TryParse(Console.ReadLine(),out minutes);
            Console.Write("Tiempo (segundos): ");
            float.TryParse(Console.ReadLine(),out seconds);

            seconds += minutes*60 + hour*360;
            hour += minutes/60 + seconds/360;

        }
    }
}