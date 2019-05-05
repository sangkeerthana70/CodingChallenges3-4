 class Program
    {
        static void Main(string[] args)
        {
			string inputStr = "a  b cd  e";
			
			deleteWhitespaces(inputStr);
		}
		
        static string deleteWhitespaces(string inputStr) {
           return System.Text.RegularExpressions.Regex.Replace(inputStr, @"\s+", "");     
        }
	   
	}
