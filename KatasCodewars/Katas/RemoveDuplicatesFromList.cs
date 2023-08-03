using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class RemoveDuplicatesFromList
    {
        public static int[] Distinct(int[] a)
        {
            return a.Distinct().ToArray();
        }
    }
}

/*
 List<int> originalList = new List<int>(a);
      List<int> newList = new List<int>();
      
      for (int i = 0; i < originalList.Count; i++)
      {
        if (!newList.Contains(originalList[i]))
        {
          newList.Add(originalList[i]);
        }
      }
      int[] myArray = newList.ToArray();
      return myArray;
*/


/*
 DESCRIPTION:
Define a function that removes duplicates from an array of non negative numbers and returns it as a result.

The order of the sequence has to stay the same.
*/