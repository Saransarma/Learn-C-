using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Console.WriteLine(t.Displayname());
            Console.ReadLine();
        }
    }
}
