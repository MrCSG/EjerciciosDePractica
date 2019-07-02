using System;

namespace Ejercicio_HerenciaVsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante("Jose","Achoa","Ing. Social");
            Empleado emp1 = new Empleado("Luis","Lopez","Gerente");
            EstudianteConTrabajo est2 = new EstudianteConTrabajo("Jorge","Gomez","Pasante","Ing. Electrónica");

            Curso cursada = new Curso(2);
            cursada.Add(est1);
            cursada.Add(est2);
            cursada.ShowCurso();
        }
    }
}