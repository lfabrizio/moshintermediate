using System;

namespace Indexers
{
    class Program
    {
        public class HttpCookie
        {
            var cookie = new HttpCookie();
            cookie["name"] = "mosh";
            Console.WriteLine(cookie["name"]);
        }
        static void Main(string[] args)
        {

        }
    }
}