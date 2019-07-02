using System;

namespace Ejercicio_HerenciaVsInterfaces
{
    public class Empleado : Persona, IEmpleado
    {
        string ocupation {get;}

        public Empleado(string firstName, string lastName, string ocupation) : base(firstName, lastName)
        {
            this.ocupation = ocupation;
        }
        override public void ShowInfo()
        {
            Console.WriteLine($"Nombre: {this.FullName}");
            Console.WriteLine($"Trabajo: {this.ocupation}");
            Console.WriteLine($"ID: {this.ID}");
        }

        public void Trabajar()
        {
            Console.WriteLine($"Ahora estoy trabajando en {ocupation}.");
        }
    }
}