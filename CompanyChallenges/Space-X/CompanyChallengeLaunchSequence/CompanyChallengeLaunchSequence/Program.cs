using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyChallengeLaunchSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] systemNames = { "Falcon 9", "Falcon 9", "Falcon 9", "Falcon 9", "Falcon 9", "Falcon 9" };
            int[] stepNumbers = { 1, 3, 5, 7, 7, 9 };
            bool result = launchSequenceChecker(systemNames, stepNumbers);
            Console.WriteLine("result: " + result);
        }

        static bool launchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {

           for(int i = 0; i < systemNames.Length; i++)
           {
                //Console.WriteLine("i: " + i);
                //Console.WriteLine(systemNames[i]);
                for (int j = i+ 1; j < systemNames.Length ; j++)
                {
                    //Console.WriteLine("j: " + j);
                    if (systemNames[i] == systemNames[j])
                    {
                        
                        
                        //Console.WriteLine(systemNames[j]);
                        //Console.WriteLine("match found");
                        if(stepNumbers[i] >= stepNumbers[j])
                        {
                            
                            return false;
                        }                      
                    }                  
                }
           }
           return true;


        }

    }
}
