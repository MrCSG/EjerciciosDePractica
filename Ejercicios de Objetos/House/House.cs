using System;

namespace House
{
    public class House
    {
        public double area {get;set;} //m2
        public Door door {get;set;}

        public House(double area)
        {
            this.area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I'm a house, my area is {this.area}m2.");
        }
    }
}