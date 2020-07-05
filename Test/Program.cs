using System;
using System.Reflection;
using System.ComponentModel;
using Microservices.Extension;
using Microservices.Extension.Models;
namespace Test {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine(EnumTest.one.GetDescription());
            foreach (ListItem item in EnumTest.one.ToList())
            {
                Console.Write($"Label: {item.Label}");
            }
        }

        public enum EnumTest {
            [Description ("第一")]
            one, 
            [Description ("第二")]
            two,
            three
        }
    }
}