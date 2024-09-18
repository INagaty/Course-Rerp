using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class DIFirstApp
    {
    }

    class DIClassA
    {
        private IDIClassA _idiclassA;
        public DIClassA(IDIClassA log)
        {
            _idiclassA = log;
        }

        public void Run()
        {
            _idiclassA.Method1("Message to be Printed");
        }
    }

    interface IDIClassA
    {
        void Method1(string str1);
    }

    public class DIClassB : IDIClassA 
    {
        public void Method1(string method)
        {
            Console.WriteLine(method);
        }
    }
}
