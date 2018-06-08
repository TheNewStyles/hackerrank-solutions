// Create a list, , of  empty sequences, where each sequence is indexed from  to . The elements within each of the  sequences also use -indexing.
// Create an integer, , and initialize it to .
// The  types of queries that can be performed on your list of sequences () are described below:
// Query: 1 x y
// Find the sequence, , at index  in .
// Append integer  to sequence .
// Query: 2 x y
// Find the sequence, , at index  in .
// Find the value of element  in  (where  is the size of ) and assign it to .
// Print the new value of  on a new line
// Task 
// Given , , and  queries, execute each query.

// Note:  is the bitwise XOR operation, which corresponds to the ^ operator in most languages. Learn more about it on Wikipedia.

// Input Format

// The first line contains two space-separated integers,  (the number of sequences) and  (the number of queries), respectively. 
// Each of the  subsequent lines contains a query in the format defined above.

// Constraints

// It is guaranteed that query type  will never query an empty sequence or index.
// Output Format

// For each type  query, print the updated value of  on a new line.

// Sample Input

// 2 5
// 1 0 5
// 1 1 7
// 1 0 3
// 2 1 0
// 2 1 1
// Sample Output

// 7
// 3
// Explanation

// Initial Values: 
 
 
//  = [ ] 
//  = [ ]

// Query 0: Append  to sequence . 
 
//  = [5] 
//  = [ ]

// Query 1: Append  to sequence . 
//  = [5] 
//  = [7]

// Query 2: Append  to sequence . 
 
//  = [5, 3] 
//  = [7]

// Query 3: Assign the value at index  of sequence  to , print . 
 
//  = [5, 3] 
//  = [7]

// 7
// Query 4: Assign the value at index  of sequence  to , print . 
 
//  = [5, 3] 
//  = [7]

// 3

    /*
     * Complete the dynamicArray function below.
     */
    static int[] dynamicArray(int n, int[][] queries) {
        /*
         * Write your code here.
         */   
        var seqList = new List<List<int>>();
        var answers = new List<int>();        
        var lastAnswer = 0;     
        
        for (int i = 0; i < n; i++)
        {
            seqList.Add(new List<int>());
        }         
               
        for (var i = 0; i < queries.Length; i++)
        {
            for (var j = 0; j < queries[i].Length; j++)
            {   
                if (j == 0 && queries[i][j] == 1)
                {                    
                    var seqIndex = (queries[i][1] ^ lastAnswer) % n;                    
                    var seq = seqList[seqIndex];
                    seq.Add(queries[i][2]);             
                } 
                else if (j == 0 && queries[i][0] == 2)
                {
                    var index = queries[i][2];
                    var seqIndex = (queries[i][1] ^ lastAnswer) % n;  
                    var seq = seqList[seqIndex];
                    lastAnswer = seq[index];
                    answers.Add(lastAnswer);      
                    Console.Write(lastAnswer);
                }
            }
        }                    
        
        return answers.ToArray();
    }
