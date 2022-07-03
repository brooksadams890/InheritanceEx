using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }
    }
    public ClassNamePlaceholder()
    {

    }
    public bool CanFly { get; set; }
    public bool HasFeathers { get; set; }
    public bool CanSing { get; set; }
    public bool BuildsNest { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"{GetType().Name}");
        Console.WriteLine($"Can Fly: {CanFly}");
        Console.WriteLine($"Can Sing: {CanSing}");

    }
}
