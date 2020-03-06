using System;

namespace Inheritance
{
    public class PresentationObject{
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("object was duplicated");
        }