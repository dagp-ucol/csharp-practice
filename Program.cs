namespace Etapa_01;

using System;
using CoreEscuela.Entidades;

class Program
{
    static void Main(string[] args)
    {

        var escuela = new Escuela( name:"Platzi Academy", age:2012, country:"Mexico", city:"Colima" );

        escuela.Cursos = new Course[]
        {
            new Course {  Name = "101" },
            new Course {  Name = "201" },
            new Course {  Name = "301" }
        };
        
        Console.WriteLine(escuela);

        ImprimirCursosEscuela(escuela);

    }

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        Console.WriteLine("==================");
        Console.WriteLine("Cursos de la escuela");
        foreach (var course in escuela.Cursos)
        {
            Console.WriteLine($"{course.Name} con ID: {course.UniqueId}");
        }
    }
}
