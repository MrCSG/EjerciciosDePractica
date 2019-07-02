using System;
using System.Collections.Generic;

namespace Ejercicio_HerenciaVsInterfaces
{
    public class Curso
    {
        private List<Persona> listaAlumnos;

        public Curso(int quantity)
        {
            listaAlumnos = new List<Persona>(quantity);
        }
        public void Add(Estudiante alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void Add(EstudianteConTrabajo alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void ShowCurso()
        {
            foreach (Persona alumno in listaAlumnos)
            {
                alumno.ShowInfo();
            }
        }
    }
}