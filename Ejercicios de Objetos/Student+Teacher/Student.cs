using System;

namespace Studet_Teacher
{
    public class Student : Person
    {
        public Student(ushort age)
        {
            SetAge(age);
        }

        public void ShowAge()
        {
            Console.WriteLine($"Mi edad es {age}.");
        }

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

    }
}