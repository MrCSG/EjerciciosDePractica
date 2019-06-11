using System;

namespace Studet_Teacher
{
    public class Person
    {
        protected ushort age = 0;
        public void SetAge(ushort n)
        {
            age = n;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }
}