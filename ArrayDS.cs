// An array is a type of data structure that stores elements of the same type in a contiguous block of memory. In an array, , of size , each memory location has some unique index,  (where ), that can be referenced as  (you may also see it written as ).

// Given an array, , of  integers, print each element in reverse order as a single line of space-separated integers.

// Note: If you've already solved our C++ domain's Arrays Introduction challenge, you may want to skip this.

// Input Format

// The first line contains an integer,  (the number of integers in ). 
// The second line contains  space-separated integers describing .

// Constraints

// Output Format

// Print all  integers in  in reverse order as a single line of space-separated integers.

// Sample Input 0

// 4
// 1 4 3 2
// Sample Output 0

// 2 3 4 1

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the reverseArray function below.
     */
    static int[] reverseArray(int[] a) {
        /*
         * Write your code here.
         */
        var list = a.ToList();
        list.Reverse();       
        
        return list.ToArray();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int[] res = reverseArray(arr);

        textWriter.WriteLine(string.Join(" ", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
