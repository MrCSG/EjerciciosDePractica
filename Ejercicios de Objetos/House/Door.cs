using System;

namespace House
{
    public class Door
    {
        public string color {get;set;}

        public Door(string color)
        {
            this.color = color;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a door, my color is {this.color}.");
        }
    }
}