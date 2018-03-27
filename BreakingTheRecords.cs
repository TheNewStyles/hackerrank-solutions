// Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.

// For example, assume her scores for the season are represented in the array . Scores are in the same order as the games played. She would tabulate her results as follows:

//                                  Count
// Game  Score  Minimum  Maximum   Min Max
//  0      12     12       12       0   0
//  1      24     12       24       0   1
//  2      10     10       24       1   1
//  3      24     10       24       1   1
// Given Maria's array of  for a season of  games, find and print the number of times she breaks her records for most and least points scored during the season.

// Input Format

// The first line contains an integer , the number of games. 
// The second line contains  space-separated integers describing the respective values of .

// Constraints

// Output Format

// Print two space-seperated integers describing the respective numbers of times her best (highest) score increased and her worst (lowest) score decreased.

// Sample Input 0

// 9
// 10 5 20 20 4 5 2 25 1
// Sample Output 0

// 2 4
// Explanation 0

// The diagram below depicts the number of times Maria broke her best and worst records throughout the season:

// image

// She broke her best record twice (after games  and ) and her worst record four times (after games , , , and ), so we print 2 4 as our answer. Note that she did not break her record for best score during game , as her score during that game was not strictly greater than her best record at the time.

// Sample Input 1

// 10
// 3 4 21 36 10 28 35 5 24 42
// Sample Output 1

// 4 0
// Explanation 1

// The diagram below depicts the number of times Maria broke her best and worst records throughout the season:

// image

// She broke her best record four times (after games , , , and ) and her worst record zero times (no score during the season was lower than the one she earned during her first game), so we print 4 0 as our answer.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the breakingRecords function below.
     */
    static int[] breakingRecords(int[] score) {
        /*
         * Write your code here.
         */
        var results = new int[2];
        var lowScore = score[0];
        var highScore = score[0];
        var lowScoreCount = 0;
        var highScoreCount = 0;
        
        foreach (var element in score) {         
            if (element > highScore) {  
                highScore = element;
                highScoreCount++;
            } else if (element < lowScore) {
                lowScore = element;
                lowScoreCount++;
            }
        }

        results[0] = highScoreCount;
        results[1] = lowScoreCount;       
        
        return results;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
        ;
        int[] result = breakingRecords(score);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}