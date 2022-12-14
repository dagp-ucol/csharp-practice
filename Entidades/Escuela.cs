namespace CoreEscuela.Entidades
{

    public class Escuela
    {
        public string UniqueId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int FoundationAge { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public SchoolTypes SchoolType { get; set; }
        public List<Course> Courses { get; set; }


        public Escuela(string name, int age, string country = "N/A", string city = "N/A")
        {
            Name = name;
            FoundationAge = age;
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Nombre: {Name}, Tipo: {SchoolType}\nPais: {Country} Ciudad: {City}";
        }

    }

}