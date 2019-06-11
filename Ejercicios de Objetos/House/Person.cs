using System;

namespace Ejercicios_de_Objetos.House
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"{name}\n{house.GetArea()}");
        }

        public void GetHouse(uint area)
        {
            House house = new House(area);
        }

        public void GetSmallAppartment()
        {
            SmallApartment sAppartment = new SmallApartment();
        }
    }
}