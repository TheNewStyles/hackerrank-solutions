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
        var row2 = new List<int>();
        var row3 = new List<int>();  
        var biggestSum = 0;

        for (var i=0; i<arr[0].Length; i++)
        {           
            for (var j=0; j<arr[i].Length; j++)
            {
                if (i < arr[0].Length - 2)
                {
                    row1.Add(arr[i][j]);
                }   
                if (!IsEdge( i, j, arr))
                {
                    row2.Add(arr[i][j]);
                }
                
                if (i >= 2)
                {
                    row3.Add(arr[i][j]);
                }
            }
        }
        
        var row1Chunked = ChunkBy(row1, 6);
        var row2Chunked = ChunkBy(row2, 4);
        var row3Chunked = ChunkBy(row3, 6);   
        var row1Sums = new List<int>();
        var row2Singles = new List<int>();
        var row3Sums = new List<int>();
                
        for (var i=0; i<row1Chunked.Count; i++)
        {
            for (var j=0; j<row1Chunked[i].Count-2; j++)
            {
                var top3 = row1Chunked[i].Skip(j).Take(3);
                var top3Sum = 0;
                foreach(var value in top3)
                {
                    top3Sum += value;                  
                }
                row1Sums.Add(top3Sum);
            }
            
            
            for (var j=0; j<row2Chunked[i].Count; j++)
            {
                var middle1 = row2Chunked[i][j];
                row2Singles.Add(middle1);
            }
            
            
            for (var j=0; j<row1Chunked[i].Count-2; j++)
            {
                var bottom3 = row3Chunked[i].Skip(j).Take(3);
                var bottom3Sum = 0;
                foreach(var value in bottom3)
                {
                    bottom3Sum += value;
                }
                row3Sums.Add(bottom3Sum);                
            }            
        }        
       
        for (var i=0; i<row1Sums.Count; i++)
        {
            if (i == 0)
            {                
                biggestSum = row1Sums[i] + row2Singles[i] + row3Sums[i];
            }
            
            var hourGlassSum = row1Sums[i] + row2Singles[i] + row3Sums[i];
            if (hourGlassSum >= biggestSum)
            {
                biggestSum = hourGlassSum;                
            }
        }  

        return biggestSum;                
    }
    
    public static List<List<T>> ChunkBy<T>(List<T> source, int chunkSize) 
    {
        return source
            .Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / chunkSize)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
    }
    
    static bool IsEdge(int i, int j, int[][] arr)
    {
        if (i == 0 || i == arr[i].Length-1 || j == 0 || j == arr[j].Length-1)
        {
            return true;
        }
        return false;
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