using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    interface ICalc
    {
        int Less(int valuetocompare);
        int greater(int valuetocompare);
    }

    interface IOutput
    {
        void showeven();
        void showodd();
    }

    interface Icalc2
    {
        int countdistinct();
        int equaltovalue(int value);
    }
}
