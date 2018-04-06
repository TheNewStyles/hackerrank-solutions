// Objective

// In this challenge, we practice creating objects. Check out the attached tutorial for more details.

// Task

// Complete the function in the editor. It has two parameters:  and . It must return an object modeling a rectangle that has the following properties:

// : This value is equal to .
// : This value is equal to .
// : This value is equal to 
// : This value is equal to 
// Note: The names of the object's properties must be spelled correctly to pass this challenge.

// Input Format

// The first line contains an integer denoting . 
// The second line contains an integer denoting .

// Constraints

// Output Format

// Return a object that has the properties specified above. Locked code in the editor prints the returned object's , , , and  to STDOUT.

// Sample Input 0

// 4
// 5
// Sample Output 0

// 4
// 5
// 18
// 20
// Explanation 0

// Given a  of  and a  of , the Rectangle object's  is  and its  is .

/*
 * Complete the Rectangle function
 */
function Rectangle(a, b) {
    const rec = {
        length: a,
        width: b,
        perimeter: 2  * (a + b),
        area: (a * b)
    }
    
    return rec;
}