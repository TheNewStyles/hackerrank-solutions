// You will be given two arrays of integers. You will be asked to determine all integers that satisfy the following two conditions:

// The elements of the first array are all factors of the integer being considered
// The integer being considered is a factor of all elements of the second array
// These numbers are referred to as being between the two arrays. You must determine how many such numbers exist.

// Function Description

// Complete the getTotalX function described below to return the number of items between two sets.

// getTotalX(integer arrays: a, b)
// Parameters:
// a: an array
// b: another array
// Returns: integer representing number of elements between sets a and b
// Constraints

// Raw Input Format

// The first line contains two space-separated integers describing the respective values of , the number of elements in array , and , the number of elements in array . 
// The second line contains  distinct space-separated integers describing . 
// The third line contains  distinct space-separated integers describing .

// Sample Input 0

// 2 3
// 2 4
// 16 32 96
// Sample Output 0

// 3
// Explanation 0

// 2 and 4 divide evenly into 4, 8, 12 and 16. 
// 4, 8 and 16 divide evenly into 16, 32, 96.

// 4, 8 and 16 are the only three numbers for which each element of A is a factor and each is a factor of all elements of B.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getTotalX function below.
     */
    static int getTotalX(int[] a, int[] b) {
        /*
         * Write your code here.
         */
        var factors = new List<int>();
        var groupedFactors = new List<int>();
        var commonFactors = new List<int>();
        
        for (var i=0; i<a.Length; i++) {
            for (var j=1; j<=b[0]; j++) {
                if (j % a[i] == 0) {
                    factors.Add(j);                 
                }
            }         
        }
                
        var grouped = factors
            .GroupBy(e => e)
            .Where(e => e.Count() == a.Length)
            .Select(e => e);
        
        
        foreach ( var element in grouped) {
            groupedFactors.Add((int)element.Key);
        }
        
        foreach (var element in b) {    
            for(var i=0; i<groupedFactors.Count(); i++) {
                if (element % groupedFactors[i] == 0) {
                    Console.Write(element + " % " + groupedFactors[i] + " == 0 \n");
                    commonFactors.Add(groupedFactors[i]);
                }    
            }            
        }
        
        var groupedCommonFactors = commonFactors
            .GroupBy(e => e)
            .Where(e => e.Count() == b.Length)
            .Select(e => e);

        return groupedCommonFactors.Count();
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}