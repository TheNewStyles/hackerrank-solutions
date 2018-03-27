// Lily has a chocolate bar consisting of a row of  squares where each square has an integer written on it. She wants to share it with Ron for his birthday, which falls on month  and day . Lily wants to give Ron a piece of chocolate only if it contains  consecutive squares whose integers sum to .

// Given , , and the sequence of integers written on each square of Lily's chocolate bar, how many different ways can Lily break off a piece of chocolate to give to Ron?

// For example, if ,  and the chocolate bar contains  squares with the integers  written on them from left to right, the following diagram shows two ways to break off a piece:

// image

// Input Format

// The first line contains an integer denoting  (the number of squares in the chocolate bar). 
// The second line contains  space-separated integers describing the respective values of  (the numbers written on each consecutive square of chocolate). 
// The third line contains two space-separated integers describing the respective values of (Ron's birth day) and  (Ron's birth month).

// Constraints

// , where ()
// Output Format

// Print an integer denoting the total number of ways that Lily can give a piece of chocolate to Ron.

// Sample Input 0

// 5
// 1 2 1 3 2 
// 3 2
// Sample Output 0

// 2
// Explanation 0

// This sample is already explained in the problem statement.

// Sample Input 1

// 6
// 1 1 1 1 1 1
// 3 2
// Sample Output 1

// 0
// Explanation 1

// Lily only wants to give Ron  consecutive squares of chocolate whose integers sum to . There are no possible pieces satisfying these constraints:

// image

// Thus, we print  as our answer.

// Sample Input 2

// 1
// 4
// 4 1
// Sample Output 2

// 1
// Explanation 2

// Lily only wants to give Ron  square of chocolate with an integer value of . Because the only square of chocolate in the bar satisfies this constraint, we print  as our answer.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
        // Complete this function
        var counter = 0;
        var length = m;
        var correctSumCount = 0;
        
        while (counter <= n) {
            var sumTiles = 0;
            
            if (length <= n) { 
                for (var i=counter; i<length; i++) {
                    sumTiles += s[i];                 
                }
            }

            
            if (sumTiles == d) {
                correctSumCount++;
            }
            
            length++;
            counter++;
        }
        
        return correctSumCount;     
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
