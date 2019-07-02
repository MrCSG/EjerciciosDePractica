using System;

namespace Ejercicio_HerenciaVsInterfaces
{
    public class EstudianteConTrabajo : Persona, IEmpleado, IEstudiante
    {
        string ocupation {get;}
        string career {get;}

        public EstudianteConTrabajo (string firstName, string lastName, string ocupation, string career) : base (firstName, lastName)
        {
            this.ocupation = ocupation;
            this.career = career;
        }
        override public void ShowInfo()
        {
            Console.WriteLine($"Nombre: {this.FullName}");
            Console.WriteLine($"Estudio: {this.career}");
            Console.WriteLine($"Trabajo: {this.ocupation}");
            Console.WriteLine($"ID: {this.ID}");
        }

        public void Trabajar()
        {
            Console.WriteLine($"Ahora estoy trabajando en {ocupation}.");
        }
        public void Estudiar()
        {
            Console.WriteLine($"Ahora estoy estudiando {career}.");
        }
    }
}