// Objective

// In this challenge, we practice declaring variables using the let and const keywords. Check out the attached tutorial for more details.

// Task

// Declare a constant variable, , and assign it the value Math.PI. You will not pass this challenge unless the variable is declared as a constant and named PI (uppercase).
// Read a number, , denoting the radius of a circle from stdin.
// Use  and  to calculate the  and  of a circle having radius .
// Print  as the first line of output and print  as the second line of output.
// Input Format

// A single integer, , denoting the radius of a circle.

// Constraints

//  is a floating-point number scaled to at most  decimal places.
// Output Format

// Print the following two lines:

// On the first line, print the  of the circle having radius .
// On the second line, print the  of the circle having radius .
// Sample Input 0

// 2.6
// Sample Output 0

// 21.237166338267002
// 16.336281798666924
// Explanation 0

// Given the radius , we calculate the following:

// We then print  as our first line of output and  as our second line of output.

'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

function main() {
    // Write your code here. Read input using 'readLine()' and print output using 'console.log()'.
    const PI = Math.PI;
    let r = readLine('r');    
    // Print the area of the circle:
    console.log(Math.pow(r, 2) * PI);
    // Print the perimeter of the circle:
    console.log(2 * PI * r);
}