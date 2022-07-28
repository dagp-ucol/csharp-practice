using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academay", 2012);

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Courses)
            {
                var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Name="Matemáticas"} ,
                            new Asignatura{Name="Educación Física"},
                            new Asignatura{Name="Castellano"},
                            new Asignatura{Name="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar( int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos =  from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Name=$"{n1} {n2} {a1}" };
            
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {
            Escuela.Courses = new List<Course>(){
                        new Course(){ Name = "101", Worktime = WorktimeTypes.Mañana },
                        new Course() {Name = "201", Worktime = WorktimeTypes.Mañana},
                        new Course{Name = "301", Worktime = WorktimeTypes.Mañana},
                        new Course(){ Name = "401", Worktime = WorktimeTypes.Tarde },
                        new Course() {Name = "501", Worktime = WorktimeTypes.Tarde},
            };
            
            Random rnd = new Random();
            foreach(var c in Escuela.Courses)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
            }
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