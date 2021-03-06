﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DesignPatterns.Patterns;
using DesignPatterns.Helpers;

namespace DesignPatterns
{
    [TestFixture]
    class Program
    {
           static void Main(string[] args)
        {
            Program p = new Program();
            //p.UseSingleton();   
            //p.UseFactory();
            p.UseStrategy();
        }

        [Test]
        public void UseSingleton()
        {
            Console.WriteLine("Start of Singleton Test");
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1, s2);
        }

        [Test]
        public void UseFactory()
        {
            Factory duration = Factory.FromTicks(10);
            Assert.AreEqual(10, duration.Ticks);
        }

        [Test]
        public void UseStrategy()
        {
            Strategy s = new Strategy();
            Person p = new Person();
            var list = p.GetPeople().ToList();
            list.Sort(s.CompareByAge);
            list.Sort((x, y) => x.Age.CompareTo(y.Age));

            foreach(var person in list)
            {
                Console.WriteLine(person);
            }
        }
    }
}
