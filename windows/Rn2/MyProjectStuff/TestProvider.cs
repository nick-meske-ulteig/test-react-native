using Microsoft.ReactNative.Managed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rn2.MyProjectStuff
{
    [ReactModule]
    public class TestProvider
    {
        [ReactMethod]
        public string DoWork(string input)
        {
            Console.WriteLine(input);
            return input + "Added to the input";
        }

        [ReactMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
