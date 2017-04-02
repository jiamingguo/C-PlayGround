using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.PrintEverything();
        }
    }

    class TestClass
    {
        string hw = "HelloWorld";

        public void PrintEverything()
        {
            Console.WriteLine(hw);
        }
    }



}
