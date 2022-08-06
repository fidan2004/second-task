using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string Sentence = "bu fenn maraqlidir";
            Console.WriteLine( "sentence contains {0} spaces ", Countspaces(spaces));
        }
        public static int  Countspaces (string str)
        {

            int spaces = 0;
            string strone;
            for (int i = 0; i < str.Length; i++)
            {
                if (str == " ")
                    spaces++;
                }
                return spaces;

            }
        
      
    }
}
