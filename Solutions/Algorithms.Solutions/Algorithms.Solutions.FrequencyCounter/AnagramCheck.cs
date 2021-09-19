using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Solutions.FrequencyCounter{
    public class AnagramCheck
    {
        public static bool? IsAnagram2(string str1, string str2)
        {
            if(string.IsNullOrWhiteSpace(str1) && string.IsNullOrWhiteSpace(str2))
                return true;

            if(str1.Length != str2.Length)
                return false;
            
            int sumAsciiStr1 = 0;
            foreach (var chr in str1.ToLower())
                sumAsciiStr1 += (int) chr;

            int sumAsciiStr2 = 0;
            foreach (var chr in str2.ToLower())
                sumAsciiStr2 += (int) chr;
            
            if (sumAsciiStr1 == sumAsciiStr2)
                return true;

            return false;
        }
        public static bool? IsAnagram(string str1, string str2)
        {
            if(string.IsNullOrWhiteSpace(str1) && string.IsNullOrWhiteSpace(str2))
                return true;

            if(str1.Length != str2.Length)
                return false;
            
            Dictionary<char,int> lookupChar = new Dictionary<char, int>();

            foreach (var chr in str1.ToLower())
            {
                if (lookupChar.ContainsKey(chr))
                {
                    lookupChar[chr]++;
                }
                else
                    lookupChar.Add(chr,1);
            }

            foreach (var chr in str2.ToLower())
            {
                if (!lookupChar.ContainsKey(chr) || lookupChar[chr] == 0 )
                {
                    return false;
                }
                lookupChar[chr]--;
            }

            return true;
        }
    }

}

