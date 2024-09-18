using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class FirstApp
    {
    }
    public class ClassA
    {
        private ClassB _classb;
        public ClassA()
        {
            _classb = new ClassB();
        }

        public void Run()
        {
            _classb.Method1("Message to be Printed");
        }
    }

    public class ClassB
    {
        public void Method1(string method)
        {
            Console.WriteLine(method);
        }
    }
}
