using System;

namespace Composition
{
    public class Person
    {
        public string FN;
        public string LN;
        private int age;

        public string getJob()
        {
            return "unemployed"
        }

    }

    public class Develper : Person
    {
        static string job = "Developer";
        private override string getJob() 
        {
            return job;
        }
    }
}