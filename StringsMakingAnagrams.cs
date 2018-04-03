// Check out the resources on the page's right side to learn more about strings. The video tutorial is by Gayle Laakmann McDowell, author of the best-selling interview book Cracking the Coding Interview.

// Alice is taking a cryptography class and finding anagrams to be very useful. We consider two strings to be anagrams of each other if the first string's letters can be rearranged to form the second string. In other words, both strings must contain the same exact letters in the same exact frequency For example, bacdc and dcbac are anagrams, but bacdc and dcbad are not.

// Alice decides on an encryption scheme involving two large strings where encryption is dependent on the minimum number of character deletions required to make the two strings anagrams. Can you help her find this number?

// Given two strings,  and , that may or may not be of the same length, determine the minimum number of character deletions required to make  and  anagrams. Any characters can be deleted from either of the strings.

// This challenge is also available in the following translations:

// Chinese
// Russian
// Input Format

// The first line contains a single string, . 
// The second line contains a single string, .

// Constraints

// It is guaranteed that  and  consist of lowercase English alphabetic letters (i.e., through ).
// Output Format

// Print a single integer denoting the number of characters you must delete to make the two strings anagrams of each other.

// Sample Input

// cde
// abc
// Sample Output

// 4
// Explanation

// We delete the following characters from our two strings to turn them into anagrams of each other:

// Remove d and e from cde to get c.
// Remove a and b from abc to get c.
// We must delete  characters to make both strings anagrams, so we print  on a new line.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void anagram(string a, string b) {
        var list = new List<char>();
        var count = 0;
        
            for (var j=0; j<b.Length; j++) {
                if (a.IndexOf(b[j]) == -1) {
                    count++;
                }
                if (a.IndexOf(b[j]) > -1) {
                    var aCount = a.Length - a.Replace(b[j] , ' ').Length;
                    var bCount = b.Length - b.Replace(b[j] , ' ').Length;          
                    if (bCount != aCount && list.IndexOf(b[j]) == -1) {
                        list.Add(b[j]);
                        count += Math.Abs(bCount - aCount);
                    }                    
                }
            }
                   
            for (var i=0; i<a.Length; i++) {
                if (b.IndexOf(a[i]) == -1) {
                    count++;
                }
                if (b.IndexOf(a[i]) > -1) {
                    var aCount = a.Count(f => f == a[i]);
                    var bCount = b.Count(f => f == a[i]);  
                    if (bCount != aCount && !list.Contains(a[i])) {
                        list.Add(a[i]);
                        count += Math.Abs(bCount - aCount);
                    }
                }   
            }
        
            Console.Write(count);
    }

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        anagram(a, b);
    }
}
