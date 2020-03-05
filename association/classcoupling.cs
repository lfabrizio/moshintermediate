// a measure of how interconnected classes and subsytems are 
using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copy");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}