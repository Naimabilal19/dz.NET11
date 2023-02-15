using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            array v = new array();
            v.print();
            WriteLine();
            WriteLine("колчество меньших значений \t");
            v.Less(4);
            WriteLine("колчество больших значений \t");
            v.greater(4);
            WriteLine("колчество четных \t");
            v.showeven();
            WriteLine("колчество нечетных \t");
            v.showodd();
            WriteLine("колчество уникальных \t");
            v.countdistinct();
            WriteLine("колчество значений равных value\t");
            v.equaltovalue(2);
            
        }
    }
}
