using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launchSequenceChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] systemNames = { "stage_1", "stage_2", "dragon", "stage_1", "stage_2", "dragon" };
            int[] stepNumbers = { 1, 10, 11, 2, 12, 111 };
            bool result = launchSequenceChecker(systemNames, stepNumbers);
        }

        static bool launchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            Dictionary<string, List<int>> sequenceDict  = new Dictionary<string, List<int>>();
            for(int i = 0; i < systemNames.Length; i++)
            {
                
            }

        }

    }
}
