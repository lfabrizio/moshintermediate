using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; set; }

        public int Age
        {
            get
            { 
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
        }
    }
}