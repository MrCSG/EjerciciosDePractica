using System;

namespace Ejercicios_de_Objetos.House
{
    public class House
    {
        protected uint area; //m2
        protected Door door = new Door();

        public House(uint area)
        {
            this.area = area;
        }

        protected House(){}

        public void SetArea(uint area)
        {
            this.area = area;
        }
        public int GetArea()
        {
            return Convert.ToInt32(this.area);
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {this.area}m2.");
        }

        public void GetDoor(string color)
        {
            door.SetColor(color);
        }
    }
}