using System;

namespace Ejercicio_HerenciaVsInterfaces
{
    public class Estudiante : Persona, IEstudiante
    {
        string career {get;}

        public Estudiante(string firstName, string lastName, string career) : base(firstName, lastName)
        {
            this.career = career;
        }
        override public void ShowInfo()
        {
            Console.WriteLine($"Nombre: {this.FullName}");
            Console.WriteLine($"Estudio: {this.career}");
            Console.WriteLine($"ID: {this.ID}");
        }

        public void Estudiar()
        {
            Console.WriteLine($"Ahora estoy estudiando {career}.");
        }
    }
}