using System;

namespace Ejercicios_de_Objetos.House
{
    public class Door
    {
        private string color;

        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return this.color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a door, my color is {this.color}.");
        }
    }
}