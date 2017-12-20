using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelException
{
    class PersonException : Exception
    {
        public PersonException() : base("My first exception is awesome!!!")
        {

        }
    }
}
