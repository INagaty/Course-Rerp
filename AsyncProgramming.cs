using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class AsyncProgramming
    {
        //Simulate downloading file
        public static async Task DownloadFile()
        {
            await Task.Delay(5000);
            Console.WriteLine("File downloaded");
        }
    }
}
