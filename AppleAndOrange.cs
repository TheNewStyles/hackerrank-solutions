// Sam's house has an apple tree and an orange tree that yield an abundance of fruit. Sam’s two children, Larry and Rob, decide to play a game in which they each climb a tree and throw fruit at their (Sam’s) house. Each fruit that lands on the house scores one point for the one who threw it. Larry climbs the tree on the left (the apple), and Rob climbs the one on the right (the orange).

// We’ll use the following diagram to describe the challenge:

// Apple and orange(2).png

// For simplicity, we’ll assume all of the landmarks are on a number line. Larry climbs the apple tree at point , and Rob climbs the orange tree at point . Sam’s house stands between points  and . Values increase from left to right.

// You will be given a list of distances the fruits are thrown. Negative distances indicate travel left and positive distances, travel right. Your task will be to calculate the scores for Larry and Rob and report them each on a separate line.

// Input Format

// The first line contains two space-separated integers denoting the respective values of and . 
// The second line contains two space-separated integers denoting the respective values of  and . 
// The third line contains two space-separated integers denoting the respective values of and . 
// The fourth line contains  space-separated integers denoting the respective distances that each apple falls from point . 
// The fifth line contains  space-separated integers denoting the respective distances that each orange falls from point .

// Constraints

// Output Format

// Print two lines of output:

// On the first line, print the number of apples that fall on Sam's house.
// On the second line, print the number of oranges that fall on Sam's house.
// Sample Input 0

// 7 11
// 5 15
// 3 2
// -2 2 1
// 5 -6
// Sample Output 0

// 1 1
// Explanation 0

// The first apple falls at position  
// The second apple falls at position  
// The third apple falls at position  
// The first orange falls at position  
// The second orange falls at position  

// Only one fruit (the second apple) falls within the region between  and , so Larry’s score is . 
// Only the second orange falls within the region between  and , so Rob’s score is .

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the countApplesAndOranges function below.
     */
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        /*
         * Write your code here.
         */
        var applesCount = 0;
        var orangeCount = 0;
        
        foreach (var element in apples) {
            var result = a + element;
            if (result >= s && result <= t) {
                applesCount++;
            }
        }
        
        foreach (var element in oranges) {
            var result = b + element;
            if (result <= t && result >=s) {
                orangeCount++;
            }
        }
        
        Console.Write(applesCount + "\n" + orangeCount);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int s = Convert.ToInt32(st[0]);

        int t = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(ab[0]);

        int b = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
        ;

        int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
        ;
        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}
