namespace Etapa_01;

using System;
using CoreEscuela;
using CoreEscuela.Entidades;

class Program
{
    static void Main(string[] args)
    {        
        var engine = new EscuelaEngine();
        engine.Init();
        ImprimirCursosEscuela(engine.Escuela);
    }



    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        Console.WriteLine("==================");
        Console.WriteLine("Cursos de la escuela");

        if (escuela != null && escuela.Courses != null)
        {            
            foreach (var course in escuela.Courses) // Alt + Shift + F
            {
                Console.WriteLine($"{course.Name} con ID: {course.UniqueId}");
            }
        }

    }
}
