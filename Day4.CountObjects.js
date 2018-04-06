// Objective

// In this challenge, we learn about iterating over objects. Check the attached tutorial for more details.

// Task

// Complete the function in the editor. It has one parameter: an array, , of objects. Each object in the array has two integer properties denoted by  and . The function must return a count of all such objects  in array  that satisfy .

// Input Format

// The first line contains an integer denoting . 
// Each of the  subsequent lines contains two space-separated integers describing the values of  and .

// Constraints

// Output Format

// Return a count of the total number of objects  such that . Locked stub code in the editor prints the returned value to STDOUT.

// Sample Input 0

// 5
// 1 1
// 2 3
// 3 3
// 3 4
// 4 5
// Sample Output 0

// 2
// Explanation 0

// There are  objects in the  array:

// Because we have two objects  that satisfy  (i.e.,  and ), we return  as our answer.

/*
 * Return a count of the total number of objects 'o' satisfying o.x == o.y.
 * 
 * Parameter(s):
 * objects: an array of objects with integer properties 'x' and 'y'
 */
function getCount(objects) {
    let counter = 0;
    
    for (let p in objects) {
        if (objects[p].x === objects[p].y) {
            counter++;
        }
    }
    
    return counter;
}