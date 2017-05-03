using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DesignPatterns
{
    [TestFixture]
    class Program
    {
           static void Main(string[] args)
        {
            Program p = new Program();
            p.UseSingleton();            
        }

        [Test]
        public void UseSingleton()
        {
            Console.WriteLine("Start of Singleton Test");
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1, s2);
        }
    }
}
