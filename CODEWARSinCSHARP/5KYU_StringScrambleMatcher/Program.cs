using System;
using System.Collections.Generic;

namespace _5KYU_StringScrambleMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("rkqodlw", "world"));
            Console.WriteLine(Scramble("katas", "steak"));
            Console.WriteLine(Scramble("scriptjavx", "javascript"));
            Console.WriteLine(Scramble("scriptingjava", "javascript"));
            Console.WriteLine(Scramble("scriptsjava", "javascripts"));
            Console.WriteLine(Scramble("javscripts", "javascript"));
            Console.WriteLine(Scramble("aabbcamaomsccdd", "commas"));
            Console.WriteLine(Scramble("commas", "commas"));
            Console.WriteLine(Scramble("sammoc", "commas"));
        }
        public static bool Scramble(string str1, string str2)
        {
            List<char> pool = new List<char>();
            pool.AddRange(str1);

            List<char> gather = new List<char>();
            
            foreach (char x in str2)
            {
                for (int i = 0; i < pool.Count; i++)
                {
                    if (x == pool[i])
                    {
                        gather.Add(x);
                        pool.RemoveAt(i);
                        break;
                    }
                }
            }
            bool match = false;
            if (str2 == new string(gather.ToArray()))
            {
                match = true;
            }
            return match;
        }
    }
}
