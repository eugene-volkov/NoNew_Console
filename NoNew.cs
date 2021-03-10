using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNew_Console
{
    class NoNew
    {
        private NoNew()
        {
            Console.WriteLine("I'm alive!");
        }

        public static NoNew CreateInstance()
        {
            return new NoNew();
        }
    }
}
