namespace Etapa_01;

using System;
using CoreEscuela.Entidades;

class Program
{
    static void Main(string[] args)
    {

        var escuela = new Escuela(name: "Platzi Academy", age: 2012, country: "Mexico", city: "Colima");

        escuela.Courses = new List<Course>()
        {
            new Course {  Name = "101" },
            new Course {  Name = "201" },
            new Course {  Name = "301" }
        };

        var otrCol = new List<Course>()
        {
            new Course {  Name = "102" },
            new Course {  Name = "202" },
            new Course {  Name = "302" }
        };

        escuela.Courses.Add( new Course() { Name = "Hola", Worktime = WorktimeTypes.Tarde } );
        escuela.Courses.AddRange(otrCol);

        // Ctrl + .
        ImprimirCursosEscuela(escuela);

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
