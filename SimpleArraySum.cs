// Given an array of integers, find the sum of its elements.

// Function Description

// Complete the simpleArraySum function described below to return the sum of all elements of the array.

// simpleArraySum(integer: n, integer array: arr)
// Parameters:
// n: array size
// ar: array of integers to sum
// Returns: integer sum of all array elements
// Raw Input Format

// The first line contains an integer, , denoting the size of the array. 
// The second line contains  space-separated integers representing the array's elements.

// Sample Input 0

// 6
// 1 2 3 4 10 11
// Sample Output 0

// 31
// Explanation 0

// We print the sum of the array's elements: .


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
        /*
         * Write your code here.
         */
        var arSum = 0;
        
        foreach (var i in ar) {
            arSum += i;
        }       
        
        return arSum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}