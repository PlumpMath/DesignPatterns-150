using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Helpers
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Age);
        }

        public IReadOnlyCollection<Person> GetPeople()
        {
            IReadOnlyCollection<Person> People = new List<Person>()
            {
                new Person{Name = "Jason", Age = 35},
                new Person{Name = "Holly", Age = 28},
                new Person{Name = "Tom", Age = 45},
                new Person{Name = "Terri", Age = 42},
                new Person{Name = "Jason", Age = 62}
            }.AsReadOnly();   

             return People;
        }
    }
}
