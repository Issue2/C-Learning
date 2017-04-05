using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            var fullname = person.GetFullname("Avetis", "Ghukasyan");

            Console.WriteLine(fullname);
        }
    }
}
