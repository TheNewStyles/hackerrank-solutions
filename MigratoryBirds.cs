// You have been asked to help study the population of birds migrating across the continent. Each type of bird you are interested in will be identified by an integer value. Each time a particular kind of bird is spotted, its id number will be added to your array of sightings. You would like to be able to find out which type of bird is most common given a list of sightings.If two or more types of birds are equally common, choose the type with the smallest ID number.

// Function Description

// Complete the migratoryBirds function described below to return the most common birds sighted.

// migratoryBirds( integer: n, integer: ar_size, integer array: ar)
// Parameters:
// ar_size: number of elements (sightings) in array
// ar: array of integer id's of birds sighted
// Returns: integer id of most common bird sightings
// Constraints

// It is guaranteed that each type is , , , , or .
// Raw Input Format

// The first line contains an integer denoting , the number of birds sighted and reported in the array . 
// The second line describes  as  space-separated integers representing the type numbers of each bird sighted.

// Sample Input 0

// 6
// 1 4 4 4 5 3
// Sample Output 0

// 4
// Explanation 0

// The different types of birds occur in the following frequencies:

// Type :  bird
// Type :  birds
// Type :  bird
// Type :  birds
// Type :  bird
// The type number that occurs at the highest frequency is type , so we print  as our answer.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
        var count = 0;
        var highKey = 0;
        var numberGroups = ar.GroupBy(i => i);
        foreach(var grp in numberGroups)
        {
            var number = grp.Key;
            var total  = grp.Count();
            
            if (total >= count) {
                count = total;
                highKey = number;
            }
        }
        
        return highKey;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}