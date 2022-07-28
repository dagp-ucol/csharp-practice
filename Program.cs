namespace Etapa_01;

using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;

class Program
{
    static void Main(string[] args)
    {        
        var engine = new EscuelaEngine();
        engine.Inicializar();
        ImprimirCursosEscuela(engine.Escuela);
    }



    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        string title = $"| Cursos de la escuela \"{escuela.Name}\" |";
        Printer.DibujarLinea(title.Length);
        Console.WriteLine(title);
        Printer.DibujarLinea(title.Length);

        if (escuela != null && escuela.Courses != null)
        {            
            foreach (var course in escuela.Courses) // Alt + Shift + F
            {
                Console.WriteLine($"{course.Name} con ID: {course.UniqueId}");
            }
        }

    }
}
