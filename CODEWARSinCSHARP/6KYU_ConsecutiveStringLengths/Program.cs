using System;
using System.Linq;
using System.Collections.Generic;

namespace _6KYU_ConsecutiveStringLengths
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.codewars.com/kata/56a5d994ac971f1ac500003e/csharp
            // You are given an array(list) strarr of strings and an integer k. Your task is to return the first longest string consisting of k consecutive strings taken in the array.
            // n being the length of the string array, if n = 0 or k > n or k <= 0 return "".

            Console.WriteLine(LongestConsec(new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2));
            Console.WriteLine(LongestConsec(new string[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1));
            Console.WriteLine(LongestConsec(new string[] {  }, 3));
            Console.WriteLine(LongestConsec(new string[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2));
            Console.WriteLine(LongestConsec(new string[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2));
            Console.WriteLine(LongestConsec(new string[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2));
            Console.WriteLine(LongestConsec(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3));
            Console.WriteLine(LongestConsec(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15));
            Console.WriteLine(LongestConsec(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0));
        }
        public static String LongestConsec(string[] strarr, int k)
        {
            List<string> concat = new List<string>();
            
            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
            {
                return "";
            }
            else
            {
                for (int i = 0; i <= strarr.Length - (k); i++)
                {
                    int x = 1;
                    string tempString = strarr[i];
                    while (x < k)
                    {
                        tempString += strarr[i + x];
                        x++;
                    }
                    concat.Add(tempString);
                }
                return concat.OrderByDescending(s => s.Length).First();
            }
        }
    }
}