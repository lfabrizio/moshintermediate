using System;

namespace Constructors
{
       public class Car : Vehicle
    {
        public Car(string registrationNumber)
        : base(registrationNumber)
        {
            Console.WriteLine("Car being intialized {0}", registrationNumber);
        }
    }