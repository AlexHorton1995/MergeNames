using System;
using System.Linq;

namespace MergeNames
{
    /*
      
        Implement the UniqueNames method. When passed two arrays of names, 
        it will return an array containing the names that appear in either or both arrays.       
        The returned array should have no duplicates.
      
        For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, 
        new string[]{'Olivia', 'Sophia', 'Emma'}) 
        should return an array containing Ava, Emma, Olivia, and Sophia in any order.
        
        Example case: System.NotImplementedException at MergeNames.UniqueNames(String[] names1, String[] names2) in MergeNames.cs:line 7
        Each array has distinct names: System.NotImplementedException at MergeNames.UniqueNames(String[] names1, String[] names2) in MergeNames.cs:line 7
        Each array has duplicate names: System.NotImplementedException at MergeNames.UniqueNames(String[] names1, String[] names2) in MergeNames.cs:line 7
        Arrays have some names in common: System.NotImplementedException at MergeNames.UniqueNames(String[] names1, String[] names2) in MergeNames.cs:line 7           

    */

    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            return names1.Concat(names2).Distinct().ToArray();
        }

        public static void Main(string[] args)
        {
            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }
    }
}
