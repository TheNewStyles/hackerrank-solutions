// Alice and Bob each created one problem for HackerRank. A reviewer rates the two challenges, awarding points on a scale from  to  for three categories: problem clarity, originality, and difficulty.

// We define the rating for Alice's challenge to be the triplet , and the rating for Bob's challenge to be the triplet .

// Your task is to find their comparison points by comparing  with ,  with , and  with .

// If , then Alice is awarded  point.
// If , then Bob is awarded  point.
// If , then neither person receives a point.
// Comparison points is the total points a person earned.

// Given  and , can you compare the two challenges and print their respective comparison points?

// Input Format

// The first line contains  space-separated integers, , , and , describing the respective values in triplet . 
// The second line contains  space-separated integers, , , and , describing the respective values in triplet .

// Constraints

// Output Format

// Print two space-separated integers denoting the respective comparison points earned by Alice and Bob.

// Sample Input

// 5 6 7
// 3 6 10
// Sample Output

// 1 1 
// Explanation

// In this example:

// Now, let's compare each individual score:

// , so Alice receives  point.
// , so nobody receives a point.
// , so Bob receives  point.
// Alice's comparison score is , and Bob's comparison score is . Thus, we print 1 1 (Alice's comparison score followed by Bob's comparison score) on a single line.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the solve function below.
     */
    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2) {
        /*
         * Write your code here.
         */    
        var aliceScoresArr = new int[] {a0, a1, a2};
        var bobScoresArr = new int[] {b0, b1, b2};   
        var finalPointsArr = new int[2];
        var alisPoints = 0;
        var bobsPoints = 0;           

        for (var i=0; i<3; i++) {
            if (aliceScoresArr[i] > bobScoresArr[i]) {
                alisPoints += 1;
            } else if (aliceScoresArr[i] < bobScoresArr[i]) {
                bobsPoints += 1;
            }
        }
        
        finalPointsArr[0] = alisPoints;
        finalPointsArr[1] = bobsPoints;

        return finalPointsArr;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] a0A1A2 = Console.ReadLine().Split(' ');

        int a0 = Convert.ToInt32(a0A1A2[0]);

        int a1 = Convert.ToInt32(a0A1A2[1]);

        int a2 = Convert.ToInt32(a0A1A2[2]);

        string[] b0B1B2 = Console.ReadLine().Split(' ');

        int b0 = Convert.ToInt32(b0B1B2[0]);

        int b1 = Convert.ToInt32(b0B1B2[1]);

        int b2 = Convert.ToInt32(b0B1B2[2]);

        int[] result = solve(a0, a1, a2, b0, b1, b2);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}