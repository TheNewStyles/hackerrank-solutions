// Objective

// Today, we're discussing JavaScript functions. Check out the attached tutorial for more details.

// Task

// Implement a function named factorial that has one parameter: an integer, . It must return the value of  (i.e.,  factorial).

// Input Format

// Locked stub code in the editor reads a single integer, , from stdin and passes it to a function named factorial.

// Constraints

// Output Format

// The function must return the value of .

// Sample Input 0

// 4
// Sample Output 0

// 24
// Explanation 0

// We return the value of .

/*
 * Create the function factorial here
 */

var factorial = function (input) {
    var temp = input;
    
    for (var i=input-1; i>0; i--) {
        temp *= i;    
    }
    
    return temp;
}