using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
           int number;
           var result = int.TryParse("abc", out number)
           if(result);]
           Console.WriteLine(number);
           else
            Console.WriteLine("failed");
           }
            
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
    }
}