using System;

namespace Ejercicios_Data_Type
{
    public class Ejercicio3
    {
        public static void Solution()
        {
            string password, userID, testUser = "", testPass;
            short intentos = 3;
            bool loginOK;
            Console.Write("Registrese con su usuario y contraseña.\nUsuario: ");
            userID = Console.ReadLine();
            Console.Write("Contraseña: ");
            password = Console.ReadLine();
            do{
                Console.Write("Inicie sesión:\nUsuario: ");
                if(testUser !=  userID){
                    testUser = Console.ReadLine();
                }else{
                    Console.WriteLine(userID);
                }
                Console.Write("Contraseña: ");
                testPass = Console.ReadLine();
                loginOK = (testUser==userID)&&(testPass==password);
                if(testUser!=userID)
                {
                    Console.WriteLine("Este usuario no existe, intente de nuevo.");
                }else if(testPass!=password)
                {
                    Console.WriteLine($"Contraseña incorrecta, intentos restantes: {intentos-1}.");
                    intentos--;
                }
            }while(!loginOK&&intentos>0);
            if(intentos==0)
            {
                Console.WriteLine("Se acabaron tus intentos, cerrando programa.");
            }else
            {
                Console.WriteLine("Sesión iniciada.");
            }
        }
    }
}