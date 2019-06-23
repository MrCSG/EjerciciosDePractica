using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio4
    {
        public static void Solution()
        {
            int number1, number2;
            string operation;
            Console.Write("Número 1: ");
            Int32.TryParse(Console.ReadLine(),out number1);
            Console.Write("Operación: ");
            operation = Console.ReadLine();
            Console.Write("Número 2: ");
            Int32.TryParse(Console.ReadLine(),out number2);
            switch (operation)
            {
                case "+":
                    number1 += number2;
                    break;
                case "-":
                    number1 -= number2;
                    break;
                case "*":
                    number1 *= number2;
                    break;
                case "/":
                    if(number1 >= number2)
                        number1 /= number2;
                    else
                        Console.WriteLine("Esta operación no se puede realizar.");
                    break;
                default:
                    Console.WriteLine("Esa operación no existe.");
                    break;
            }
            Console.WriteLine($"Resultado = {number1}");
        }
    }
}