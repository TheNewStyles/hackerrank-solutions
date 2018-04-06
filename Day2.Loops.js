// Objective

// In this challenge, we practice looping over the characters of string. Check out the attached tutorial for more details.

// Task

// Complete the vowelsAndConsonants function in the editor below. It has one parameter, a string, , consisting of lowercase English alphabetic letters (i.e., a through z). The function must do the following:

// First, print each vowel in  on a new line. The English vowels are a, e, i, o, and u, and each vowel must be printed in the same order as it appeared in .
// Second, print each consonant (i.e., non-vowel) in  on a new line in the same order as it appeared in .
// Input Format

// Locked stub code in the editor reads string  from stdin and passes it to the function.

// Output Format

// First, print each vowel in  on a new line (in the same order as they appeared in ). Second, print each consonant (i.e., non-vowel) in  on a new line (in the same order as they appeared in ).

// Sample Input 0

// javascriptloops
// Sample Output 0

// a
// a
// i
// o
// o
// j
// v
// s
// c
// r
// p
// t
// l
// p
// s
// Explanation 0

// Observe the following:

// Each letter is printed on a new line.
// Then the vowels are printed in the same order as they appeared in .
// Then the consonants are printed in the same order as they appeared in .

/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
    const VOWELS = ['a', 'e', 'i', 'o', 'u'];
    let vowelString = '';    
    let consonantString = '';
    let finalString;
    
    for (var i=0; i<s.length; i++) {
        if (VOWELS.includes(s[i].toLowerCase())) {
            vowelString += s[i];
            vowelString.split('').sort().join('');
        } else {
            consonantString += s[i];   
            consonantString.split('').sort().join('');
        }
    }
    
    finalString = vowelString + consonantString;
    
    for (var index of finalString) {
        console.log(index);
    }
    
}