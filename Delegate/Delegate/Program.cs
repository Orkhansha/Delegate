using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> names = new List<string>() { "Orxan", "Sabir","Cavid", "Emil", "Seid"};
            Console.WriteLine(GetCheckNames(CheckName, names));
      
        }

        public static bool CheckName(string str)
        {
            return str != "Cavid";
        }

        public static string GetCheckNames(Predicate<string> predicate, List<string> names)
        {
            string result = null;
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    result += (item+" ");
                }
            }
            return result;
        }
    }

}
