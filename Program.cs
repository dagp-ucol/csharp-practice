namespace Etapa_01;
using CoreEscuela.Entidades;

class Program
{
    static void Main(string[] args)
    {
        var escuela = new Escuela( name:"Platzi Academy", age:2012, country:"Mexico", city:"Colima" );
        // escuela.Country = "Colombia";
        // escuela.Ciudad = "Bogota";
        // escuela.SchoolType = SchoolTypes.Secundaria;
        
        Console.WriteLine(escuela);
    }
}
