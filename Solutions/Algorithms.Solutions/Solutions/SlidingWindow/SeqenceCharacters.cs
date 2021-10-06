using System;
using System.Collections.Generic;

namespace Solutions.SlidingWindow
{
    public class SeqenceCharacters
    {
        public static string GetLongestSequenceOfUniqueCharacters(string str)
        {
            Dictionary<char, int> uniqueChar = new Dictionary<char, int>();

            int newStartingIndex = 0;
            int tempUniqueLength = 0;

            int firstCharIndex = 0;
            int maxUniqueLength = 0;

            for (int j = 0; j < str.Length; j++)
            {
                char charAtStr = str[j];
                if (uniqueChar.ContainsKey(charAtStr))
                {
                    //tempUniqueLength = j - uniqueChar[charAtStr];

                    if (maxUniqueLength < tempUniqueLength)
                    {
                        maxUniqueLength = tempUniqueLength;
                        firstCharIndex = newStartingIndex;
                    }

                    tempUniqueLength = 0;
                    newStartingIndex = uniqueChar[charAtStr] + 1;
                    uniqueChar.Clear();
                }
                
                uniqueChar.Add(charAtStr, j);
                tempUniqueLength++;
            }

            if (tempUniqueLength > maxUniqueLength)
            {
                return str.Substring(newStartingIndex, tempUniqueLength);
            }
            else
            {
                return str.Substring(firstCharIndex, maxUniqueLength);
            }
            
        }
    }
}
