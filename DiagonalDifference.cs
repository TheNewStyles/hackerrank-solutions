// Given a square matrix, calculate the absolute difference between the sums of its diagonals.

// Function Description

// Complete the diagonalDifference function described below to calculate the absolute difference between diagonal sums.

// diagonalDifference( integer: a_size_rows, integer: a_size_cols, integer array: arr)
// Parameters:
// a_size_rows: number of rows in array
// a_size_cols: number of columns in array
// a: array of integers to process
// Returns: integer value that was calculated
// Constraints

// Raw Input Format

// The first line contains a single integer,  denoting the number of rows and columns in the matrix . 
// The next  lines denote the matrix 's rows, with each line containing  space-separated integers describing the columns.

// Sample Input 0

// 3
// 11 2 4
// 4 5 6
// 10 8 -12
// Sample Output 0

// 15
// Explanation 0

// The primary diagonal is:

// 11
//    5
//      -12
// Sum across the primary diagonal: 11 + 5 - 12 = 4

// The secondary diagonal is:

//      4
//    5
// 10
// Sum across the secondary diagonal: 4 + 5 + 10 = 19 
// Difference: |4 - 19| = 15

// Note: |x| is the absolute value of x

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the diagonalDifference function below.
     */
    static int diagonalDifference(int[][] a) {
        /*
         * Write your code here.
         */
        var arrSize = a.GetLength(0);
        var primSum = 0;
        var secSum = 0;
        var count = 0;
        
        for (var i=0; i<arrSize; i++) {
            for (var j=0; j<arrSize; j++) {  
                if (i == j) {                    
                    primSum += a[i][j];
                }
            } 
        }    
        
        for (var i=arrSize-1; i>=0; i--) {  
            
            secSum += a[count][i];
            count++;
        }
        
        return Math.Abs(primSum - secSum);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++) {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}