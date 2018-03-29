// There are two kangaroos on a number line ready to jump in the positive direction (i.e, toward ). Each kangaroo takes the same amount of time to make a jump, regardless of distance. That is, if kangaroo one jumps 3 meters and kangaroo two jumps 5 meters, they each do it in one second, for example.

// Given the starting locations and jump distances for each kangaroo, determine if and when they will land at the same location at the same time.

// Input Format

// A single line of four space-separated integers denoting the respective values of , , , and .

// Constraints

// Output Format

// Print YES if they can land on the same location at the same time; otherwise, print NO.

// Note: The two kangaroos must land at the same location after making the same number of jumps.

// Sample Input 0

// 0 3 4 2
// Sample Output 0

// YES
// Explanation 0

// The two kangaroos jump through the following sequence of locations: 
// image
// The kangaroos meet after 4 jumps.

// Sample Input 1

// 0 2 5 3
// Sample Output 1

// NO
// Explanation 1

// Kangaroo 2 is travelling faster than kangaroo 1, so they will never meet.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        var counter = 0;
        var roo1 = x1;
        var roo2 = x2;
        var output = " ";        
          
        while (counter < 10000) {
            roo1 += v1;
            roo2 += v2;            
            
            if (roo1 == roo2) {
                return "YES";
            } 
            
            counter++;
        }
        
        return "NO";             
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}
