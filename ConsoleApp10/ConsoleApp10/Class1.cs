using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp10
{
    class array : ICalc, IOutput, Icalc2
    {
        int[] arr = { 1, 2, 4, 4, 5, 6, 7, 8, 9, 10 };
        public void print()
        {
            for(int i=0;i<arr.Length;i++)
            {
                Write("{0,4}", arr[i]);
            }
        }


        public int Less(int valuetocompare)
        {
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < valuetocompare) m++;
            }
            WriteLine(m);
            return m;
        }
        public int greater(int valuetocompare)
        {
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > valuetocompare) b++;
            }
            WriteLine(b);
            return b;
        }

        //-----------------------------

        public void showeven()
        {
            int e = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0) e++;
            }
            WriteLine(e);
        }
        public void showodd()
        {
            int r = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) r++;
            }
            WriteLine(r);
        }

        //-----------------------------

        public int countdistinct()
        {
            int unigue = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    if (arr[i] == arr[j])   
                    {
                        unigue++;   break;                             
                    }
                }
            }
            WriteLine(unigue);
            return unigue;
        }
        public int equaltovalue(int value)
        {
            int rez = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == value)
                {
                    rez++;
                }
            }
            WriteLine(rez);
            return rez++;
        }
    }
}
