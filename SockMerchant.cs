// John works at a clothing store. He has a large pile of socks that he must pair them by color for sale.

// You will be given an array of integers representing the color of each sock. Determine how many pairs of socks with matching colors there are.

// John works at a clothing store and he's going through a pile of socks to find the number of matching pairs. More specifically, he has a pile of  loose socks where each sock  is labeled with an integer, , denoting its color. He wants to sell as many socks as possible, but his customers will only buy them in matching pairs. Two socks,  and , are a single matching pair if they have the same color ().

// Given  and the color of each sock, how many pairs of socks can John sell?

// Input Format

// The first line contains an integer , the number of socks. 
// The second line contains  space-separated integers describing the colors  of the socks in the pile.

// Constraints

//  where 
// Output Format

// Print the total number of matching pairs of socks that John can sell.

// Sample Input

// 9
// 10 20 20 10 10 30 50 10 20
// Sample Output

// 3
// Explanation

// sock.png

// John can match three pairs of socks.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int sockMerchant(int n, int[] ar) {
        // Complete this function
        var pairsList = new List<int>();        
        var pairsCount = 0;
        ar.GroupBy(a => a).ToList().ForEach(g => pairsList.Add(g.Count()));
        
        foreach (var element in pairsList) {
            var temp = 0;
            if (element > 1) {
                if (element % 2 == 0) {
                    pairsCount += element / 2;
                } else {
                    temp = element - 1;
                    pairsCount += temp / 2; 
                }
            }
        }
        
        return pairsCount;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}