using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;



namespace Algorithms.Solutions.FrequencyCounter
{
    public class SameInArrays
    {
        public static bool? Same(int[] singleArr, int[] squaredArr)
        {
            if (singleArr.Length != squaredArr.Length)
            {
                return false;
            }

            ArrayList indexes = new ArrayList();
            //foreach (var sqItem in squaredArr)
            //{
            //    //isFound = false;
                
            //    foreach (var singleItem in singleArr)
            //    {
            //        if (sqItem == singleItem * singleItem)
            //        {
            //            result[int, j] = { singleItem, sqItem};
            //            isFound = true;
            //            break;
            //        }
            //    }
            //}
            for (int i = 0; i < singleArr.Length; i++)
            {
                bool isFound = false;
                long squaredValue = singleArr[i] * singleArr[i];
                for (int j = 0; j < squaredArr.Length; j++)
                {
                    if (squaredValue  == squaredArr[j] && indexes.IndexOf(j) == -1)
                    {
                        indexes.Add(j);
                        isFound = true;
                        break;
                    }
                }
                if (isFound == false)
                {
                    return false;
                }
            }

            if (indexes.Count == singleArr.Length)
            {
                return true;
            }
            return false;
        }
        public static bool? EnhancedSame(int[] singleArr, int[] squaredArr)
        {
            if (singleArr.Length != squaredArr.Length)
            {
                return false;
            }

            Dictionary<int, int> SingleFrequencyCounter = new Dictionary<int, int>();
            Dictionary<int, int> SquaredFrequencyCounter = new Dictionary<int, int>();


            foreach (var item in singleArr)
            {
                if (SingleFrequencyCounter.ContainsKey(item))
                {
                    ++SingleFrequencyCounter[item];
                }
                else
                {
                    SingleFrequencyCounter.Add(item, 1);
                }
            }

            foreach (var item in squaredArr)
            {
                if (SquaredFrequencyCounter.ContainsKey(item))
                {
                    ++SquaredFrequencyCounter[item];
                }
                else
                {
                    SquaredFrequencyCounter.Add(item, 1);
                }
            }

            foreach (var key in SingleFrequencyCounter.Keys)
            {
                if (!SquaredFrequencyCounter.ContainsKey(key* key))
                {
                    return false;
                }
                if (SquaredFrequencyCounter[key * key] != SingleFrequencyCounter[key])
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
