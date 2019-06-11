using System;

namespace Studet_Teacher
{
    public class Teacher : Person
    {
        //private string subject;
        
        public Teacher(ushort age)
        {
            SetAge(age);
        }

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }

    }
}