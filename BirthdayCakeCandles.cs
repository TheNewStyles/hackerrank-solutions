// Colleen is having a birthday! She will have a cake with one candle for each year of her age. When she blows out the candles, she’ll only be able to blow out the tallest ones.

// Find and print the number of candles she can successfully blow out.

// Input Format

// The first line contains a single integer, , denoting the number of candles on the cake. 
// The second line contains  space-separated integers, where each integer  describes the height of candle .

// Constraints

// Output Format 
// Print the number of candles the can be blown out on a new line.

// Sample Input 0

// 4
// 3 2 1 3
// Sample Output 0

// 2
// Explanation 0

// The maximum candle height is 3 and there are two candles of that height.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the birthdayCakeCandles function below.
     */
    static int birthdayCakeCandles(int n, int[] ar) {
        /*
         * Write your code here.
         */
        var maxValue = ar.Max();
        var candles = 0;
        
        foreach (var element in ar) {
            if (element == maxValue) {
                candles++;
            }
        }
        
        return candles;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(n, ar);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}