namespace Constructors
{
    public class Vehicle
    {
        public vehicle()
        {
            Console.WriteLine("vehicle intialized");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being intialized {0}", registrationNumber);
        }
    }

 