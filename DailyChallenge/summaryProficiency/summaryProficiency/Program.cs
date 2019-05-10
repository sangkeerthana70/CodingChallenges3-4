using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summaryProficiency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 2, 3, 6, 2, 5, 4 };
            int n = 3;
            int pl = 4;
            int result = summaryProficiency(a, n, pl);
            Console.WriteLine("result : " + result);
        }
        static int summaryProficiency(int[] a, int n, int m)
        {
            int sum = 0;
            int count = 0;
            for (int applicants = 0; applicants < a.Length; applicants++)
            {
                if (a[applicants] >= m && !(count >= n))
                {
                    sum = sum + a[applicants];
                    count++;
                }
            }
            return sum;
        }

    }
}
