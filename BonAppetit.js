// Anna and Brian are sharing a meal at a restuarant and they agree to split the bill equally. Brian wants to order something that Anna is allergic to though, and they agree that Anna won't pay for that item. Brian gets the check and calculates Anna's portion. You must determine if his calculation is correct.

// For example, assume the bill has the following prices: . Anna declines to eat item  which costs . If Brian calculates the bill correctly, Anna will pay . If he includes the cost of , he will calculate . In the second case, he should refund  to Anna.

// You are given an array of prices, , the cost of each of the  items, , the item Anna doesn't eat, and , the total amount of money that Brian charged Anna for her portion of the bill. If the bill is fairly split, print Bon Appetit. Otherwise, print the integer amount of money that Brian must refund to Anna.

// Input Format

// The first line contains two space-separated integers  and , the number of items ordered and the -based index of the item that Anna did not eat. 
// The second line contains  space-separated integers  where . 
// The third line contains an integer, , the amount of money that Brian charged Anna for her share of the bill.

// Constraints

// Output Format

// If Brian did not overcharge Anna, print Bon Appetit on a new line; otherwise, print the difference (i.e., ) that Brian must refund to Anna. This will always be an integer.

// Sample Input 0

// 4 1
// 3 10 2 9
// 12
// Sample Output 0

// 5
// Explanation 0 
// Anna didn't eat item , but she shared the rest of the items with Brian. The total cost of the shared items is  and, split in half, the cost per person is . Brian charged her  for her portion of the bill. We print the amount Anna was overcharged, , on a new line.

// Sample Input 1

// 4 1
// 3 10 2 9
// 7
// Sample Output 1

// Bon Appetit
// Explanation 1 
// Anna didn't eat item , but she shared the rest of the items with Brian. The total cost of the shared items is  and, split in half, the cost per person is . Because , we print Bon Appetit on a new line.

process.stdin.resume();
process.stdin.setEncoding("ascii");
var input = "";
process.stdin.on("data", function (chunk) {
    input += chunk;
});
process.stdin.on("end", function () {
    // now we can read/parse input
    var splitStr = input.split(/\s/);
    var length = splitStr[0];
    var indexOfItem = parseInt(splitStr[1]);
    var billed = splitStr[splitStr.length - 1];
    var items = [];
    var billPrice = 0;
    var average = 0;
    
    for (var i=2; i<splitStr.length-1; i++) {
        items.push(splitStr[i]);   
    }
    
    for (var i=0; i<items.length; i++) {
        if (i !== indexOfItem) {
            billPrice += parseInt(items[i]);
        }
    }
    
    average = billPrice / 2;
    
    if (average != billed) {
        console.log(billed - average);
    } else {
        console.log("Bon Appetit");
    }
    
});