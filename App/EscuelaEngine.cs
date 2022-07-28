using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Init()
        {
            Escuela = new Escuela(name: "Platzi Academy", age: 2012, country: "Mexico", city: "Colima");    

            Escuela.Courses = new List<Course>()
            {
                new Course {  Name = "101" },
                new Course {  Name = "201" },
                new Course {  Name = "301" },
                new Course {  Name = "102" },
                new Course {  Name = "202" },
                new Course {  Name = "302" }
            };
        }

    }

}

///
/// CODE LEGACY
///

// escuela.Courses.Add( new Course() { Name = "Hola", Worktime = WorktimeTypes.Tarde } );

//         Course tmp = new Course{ Name = "Vacacionales" };
//         escuela.Courses.Add(tmp);
//         escuela.Courses.AddRange(otrCol);
        
//         otrCol.Clear();
//         ImprimirCursosEscuela(escuela);

//         // Eliminar
        
//         // escuela.Courses.Remove(tmp);

//         escuela.Courses.RemoveAll( delegate (Course cur) 
//         {
//             return cur.Name == "301";
//         });

//         escuela.Courses.RemoveAll((Course cur) => cur.Name == "30111");

//         // Ctrl + .
//         ImprimirCursosEscuela(escuela);

//         // Eliminar con predicado
//         Predicate<Course> predFunction = predicado;

// private static bool predicado(Course obj)
// {
//     return obj.Name == "301";
// }