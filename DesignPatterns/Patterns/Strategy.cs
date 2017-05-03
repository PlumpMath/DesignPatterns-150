using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Helpers;

namespace DesignPatterns.Patterns
{
    public class Strategy
    {
        public int CompareByAge(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }        
    }
}
