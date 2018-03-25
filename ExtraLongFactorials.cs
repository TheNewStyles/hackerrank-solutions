// using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

class Solution {

    static void extraLongFactorials(int n) {
        // Complete this function
        BigInteger result = n;
        
        for (var i=n-1; i>0; i--) { 
            result = i * result; 
        }
        
        Console.Write(result);        
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        extraLongFactorials(n);
    }
}
