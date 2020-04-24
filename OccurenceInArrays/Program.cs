using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OccurenceInArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[9] { 2, 1, 3, 5, 3, 2,8,2,6 };

            int count = 0;

            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length - 1; i++)
            {

                int run = a[i];
                b[i] = run;
                //Console.WriteLine(a[i]);
            }

            Dictionary<int, int> mydict = new Dictionary<int, int>();
            for (int j = 0; j < a.Length - 1; j++)
            {

                for (int k = 0; k < b.Length - 1; k++)
                {

                    if (a[j] == b[k])
                    {
                        count++;
                        //Console.WriteLine("Number: " + a[j] + " occurs: " + count + " time");
                        //mydict.Add(a[j], count);
                    }

                }
                count = 0;
            }
            mydict.OrderBy(u=>u.Value);
            Console.WriteLine(" "+mydict.Values+" "+mydict.Keys);
            Console.ReadKey();
        }
    }
}
