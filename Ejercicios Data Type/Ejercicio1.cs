using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio1
    {
        public static void Solution()
        {
            string output = "";
            bool isChar;
            do{
                Console.Write("Ingrese 3 caracteres, luego se las mostrará de forma invertida.\nIngrese 1° letra: ");
                if(isChar = Char.TryParse(Console.ReadLine(),out char letter1))
                {
                    Console.Write("Ingrese 2° letra: ");
                    if(isChar = Char.TryParse(Console.ReadLine(),out char letter2))
                    {
                        Console.Write("Ingrese 3° letra: ");
                        if(isChar = Char.TryParse(Console.ReadLine(),out char letter3))
                            output = letter3.ToString() + letter2.ToString() + letter1.ToString();
                    }
                }
                if(!isChar)
                    Console.WriteLine("El valor ingresado no es un caracter, vuelva a intentarlo.");
            }while(!isChar);
            Console.WriteLine($"Output: {output}");
        }
    }
}