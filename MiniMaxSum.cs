// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

// Input Format

// A single line of five space-separated integers.

// Constraints

// Each integer is in the inclusive range .
// Output Format

// Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

// Sample Input

// 1 2 3 4 5
// Sample Output

// 10 14
// Explanation

// Our initial numbers are , , , , and . We can calculate the following sums using four of the five integers:

// If we sum everything except , our sum is .
// If we sum everything except , our sum is .
// If we sum everything except , our sum is .
// If we sum everything except , our sum is .
// If we sum everything except , our sum is .
// Hints: Beware of integer overflow! Use 64-bit Integer.

// Need help to get started? Try the Solve Me First problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the miniMaxSum function below.
     */
    static void miniMaxSum(int[] arr) {
        /*
         * Write your code here.
         */        
        long min = 0;
        long max = 0;
        
        //bubble sort
        for (int i=0; i < arr.Length-1; i++) {
            var temp = 0;
            for (int j=0; j< arr.Length-1; j++) {
                if (arr[j] > arr[j + 1]) {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        for (var i=0; i<arr.Length-1; i++) {
            min += arr[i];
        } 
        
        for (var i=arr.Length-1; i>0; i--) {
            max += arr[i];
        }     
        
        Console.Out.Write(min + " " + max);
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}