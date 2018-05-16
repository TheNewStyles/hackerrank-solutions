// Context 
// Given a  2D Array, :

// 1 1 1 0 0 0
// 0 1 0 0 0 0
// 1 1 1 0 0 0
// 0 0 0 0 0 0
// 0 0 0 0 0 0
// 0 0 0 0 0 0
// We define an hourglass in  to be a subset of values with indices falling in this pattern in 's graphical representation:

// a b c
//   d
// e f g
// There are  hourglasses in , and an hourglass sum is the sum of an hourglass' values.

// Task 
// Calculate the hourglass sum for every hourglass in , then print the maximum hourglass sum.

// Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

// Input Format

// There are  lines of input, where each line contains  space-separated integers describing 2D Array ; every value in  will be in the inclusive range of  to .

// Constraints

// Output Format

// Print the largest (maximum) hourglass sum found in .

// Sample Input

// 1 1 1 0 0 0
// 0 1 0 0 0 0
// 1 1 1 0 0 0
// 0 0 2 4 4 0
// 0 0 0 2 0 0
// 0 0 1 2 4 0
// Sample Output

// 19
// Explanation

//  contains the following hourglasses:

// 1 1 1   1 1 0   1 0 0   0 0 0
//   1       0       0       0
// 1 1 1   1 1 0   1 0 0   0 0 0

// 0 1 0   1 0 0   0 0 0   0 0 0
//   1       1       0       0
// 0 0 2   0 2 4   2 4 4   4 4 0

// 1 1 1   1 1 0   1 0 0   0 0 0
//   0       2       4       4
// 0 0 0   0 0 2   0 2 0   2 0 0

// 0 0 2   0 2 4   2 4 4   4 4 0
//   0       0       2       0
// 0 0 1   0 1 2   1 2 4   2 4 0
// The hourglass with the maximum sum () is:

// 2 4 4
//   2
// 1 2 4


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

    // Complete the array2D function below.
    static int array2D(int[][] arr) {
        var row1 = new List<int>();
        //loop through 2 times less than the length of the array
            //loop through row 1 - get all values
                //add to first row list
            //loop through row 2 - get all but the first and last
                //add to second row list
            //loop through row 3 - get all values       
                //add to third row list
        for (var i=0; i<arr[0].Length; i++)
        {           
            for (var j=0; j<arr[i].Length; j++)
            {
                if (i < arr[0].Length - 2)
                {
                    row1.Add(arr[i][j]);
                }                
            }
        }
        
        foreach(var value in row1) 
        {
            Console.Write(value);
        }
        
        //now that you have all the numbers you need
            //loop through 2 times less than lenght of row1
                //row1.Skip(i).Take(i+3)
                //row2.Take(i)
                //row3.Skip(i).Take(i+3)
        return 0;
                
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = array2D(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}