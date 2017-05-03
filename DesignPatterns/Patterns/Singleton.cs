using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton() { }

        public Singleton()
        {
            // Stuff that must only happen once.
            Console.WriteLine("Singleton constructor");
        }

        public static Singleton Instance { get { return instance; } }

        public void DoSomething()
        {

        }
    }
}
