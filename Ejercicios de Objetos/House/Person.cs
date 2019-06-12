using System;

namespace House
{
    public class Person
    {
        private string name;
        public House house {get;set;}

        public Person(string name)
        {
            this.name = name;
        }

        public void ShowData()
        {
            Console.WriteLine($"{name}\n{this.house.area}\n{this.house.door.color}");
        }
    }
}