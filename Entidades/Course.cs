using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }
        public string Worktime { get; set; }

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}