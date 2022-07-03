using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string Movement { get; set; }
        public bool HasScales { get; set; }
        public bool HasForkedTonge { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($"Is Cold Blooded: {IsColdBlooded}");
            Console.WriteLine($"Mobility: {Movement}");
        }
    }
}
