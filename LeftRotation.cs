// A left rotation operation on an array of size  shifts each of the array's elements  unit to the left. For example, if  left rotations are performed on array , then the array would become .

// Given an array of  integers and a number, , perform  left rotations on the array. Then print the updated array as a single line of space-separated integers.

// Input Format

// The first line contains two space-separated integers denoting the respective values of  (the number of integers) and  (the number of left rotations you must perform). 
// The second line contains  space-separated integers describing the respective elements of the array's initial state.

// Constraints

// Output Format

// Print a single line of  space-separated integers denoting the final state of the array after performing  left rotations.

// Sample Input

// 5 4
// 1 2 3 4 5
// Sample Output

// 5 1 2 3 4
// Explanation

// When we perform  left rotations, the array undergoes the following sequence of changes:

// Thus, we print the array's final state as a single line of space-separated values, which is 5 1 2 3 4.

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    private static void LeftShift(int d, int[] arr)
    {
        var shifted = new int[arr.Length]; 
        var shiftIndex = (shifted.Length-1 * d) % shifted.Length;
        shifted[(shifted.Length-1 * d) % shifted.Length] = arr[0];      

        for (var i=1; i < arr.Length; i++)
        {
            shifted[(shiftIndex + i) % shifted.Length] = arr[i];
        }
        PrintArr(shifted);
    }    
    
    private static void PrintArr(int[] arr)
    {
        foreach (var value in arr) 
        {
            Console.Write(value + " ");
        }
    }

    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        LeftShift(d,a);
    }
}