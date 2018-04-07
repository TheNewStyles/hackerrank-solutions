// Objective

// In this challenge, we practice using arrow functions. Check the attached tutorial for more details.

// Task

// Complete the function in the editor. It has one parameter: an array, . It must iterate through the array performing one of the following actions on each element:

// If the element is even, multiply the element by .
// If the element is odd, multiply the element by .
// The function must then return the modified array.

// Input Format

// The first line contains an integer, , denoting the size of . 
// The second line contains  space-separated integers describing the respective elements of .

// Constraints

// , where  is the  element of .
// Output Format

// Return the modified array where every even element is doubled and every odd element is tripled.

// Sample Input 0

// 5
// 1 2 3 4 5
// Sample Output 0

// 3 4 9 8 15
// Explanation 0

// Given , we modify each element so that all even elements are multiplied by and all odd elements are multipled by . In other words, . We then return the modified array as our answer.

/*
 * Modify and return the array so that all even elements are doubled and all odd elements are tripled.
 * 
 * Parameter(s):
 * nums: An array of numbers.
 */
function modifyArray(nums) {
    const newNums = nums.map(s => (s % 2 === 0) ? s * 2 : s * 3);
    return newNums;
}