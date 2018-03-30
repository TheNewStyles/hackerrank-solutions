// You are given an array of  integers, , and a positive integer, . Find and print the number of  pairs where  and  +  is divisible by .

// Input Format

// The first line contains  space-separated integers,  and . 
// The second line contains  space-separated integers describing the values of .

// Constraints

// Output Format

// Print the number of  pairs where  and  +  is evenly divisible by .

// Sample Input

// 6 3
// 1 3 2 6 1 2
// Sample Output

//  5
// Explanation

// Here are the  valid pairs when :

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
        var counter = 0;
        var divisibleSumPairCount = 0;
        
        while (counter < n) {
            for (var i=counter+1; i<n; i++) {
                if (((int)ar[counter] + (int)ar[i]) % k ==0 ) {
                    divisibleSumPairCount++;
                }
            }
            counter++;
        }
        
        return divisibleSumPairCount;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = divisibleSumPairs(n, k, ar);
        Console.WriteLine(result);
    }
}