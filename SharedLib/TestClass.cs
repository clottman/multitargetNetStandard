using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
    public class TestClass
    {
        public void SayHi()
        {
            Console.WriteLine($"Hello from {nameof(TestClass)}!");
        }
    }
}
