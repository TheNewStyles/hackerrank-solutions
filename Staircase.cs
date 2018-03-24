// Consider a staircase of size :

//    #
//   ##
//  ###
// ####
// Observe that its base and height are both equal to , and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.

// Write a program that prints a staircase of size .

// Input Format

// A single integer, , denoting the size of the staircase.

// Output Format

// Print a staircase of size  using # symbols and spaces.

// Note: The last line must have  spaces in it.

// Sample Input

// 6 
// Sample Output

//      #
//     ##
//    ###
//   ####
//  #####
// ######
// Explanation

// The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of .
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the staircase function below.
     */
    static void staircase(int n) {
        /*
         * Write your code here.
         */
        var space = " ";
        var pound = "#";
        var spaceCount = n - 1;
        var poundCount = 1;
        
        for (var i=0; i<n; i++) {            
            //spaces
            for (var j=spaceCount; j>0; j--) {
                Console.Out.Write(space);                
            }
            spaceCount--;
            //pounds
            for (var k=0; k<poundCount; k++) {
                Console.Out.Write(pound);
            } 
            poundCount++;
            Console.Out.Write("\r\n");
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
