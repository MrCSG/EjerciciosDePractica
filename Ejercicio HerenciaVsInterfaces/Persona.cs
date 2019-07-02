using System;

namespace Ejercicio_HerenciaVsInterfaces
{
    public abstract class Persona
    {
        private string firstName;
        private string lastName;
        protected string FullName
        {
            get {return ($"{firstName} {lastName}");}
        }
        private static uint id = 0;
        public uint ID = id;

        protected Persona(string firstName, string lastName)
        {
            id ++;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        abstract public void ShowInfo();
    }
}