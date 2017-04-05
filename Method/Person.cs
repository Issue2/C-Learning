using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Person
    {
        public string GetFullname(string Firstname, string Lastname)
        {
            return $"The fullname of the person is {Firstname} {Lastname}";
        }
    }
}
