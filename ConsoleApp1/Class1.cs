using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DataNotFoundException : Exception
    {
        public DataNotFoundException()
        {

        }

        public DataNotFoundException(string message)
            :base(message) { }
        
        public DataNotFoundException(string message, Exception inner)
            :base(message, inner) { }
    }
}
