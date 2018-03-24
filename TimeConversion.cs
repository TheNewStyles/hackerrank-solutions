// 

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        var ampm = s.Substring (s.Length-2); 
        var hours = s.Split(':')[0];
        var mins = s.Split(':')[1];
        var secs = s.Split(':')[2];
        secs = secs.Substring(0,2);
        var militaryTime  = "";
        
        if (ampm.Equals("PM")) {
            switch (hours)
            {
                case "12":
                  militaryTime = "12" + ":" + mins + ":" + secs;
                  break;
                case "01":
                  militaryTime = "13" + ":" + mins + ":" + secs;
                  break;
                case "02":
                  militaryTime = "14" + ":" + mins + ":" + secs;
                  break;
                case "03":
                  militaryTime = "15" + ":" + mins + ":" + secs;
                  break;
                case "04":
                  militaryTime = "16" + ":" + mins + ":" + secs;
                  break;
                case "05":
                  militaryTime = "17" + ":" + mins + ":" + secs;
                  break;
                case "06":
                  militaryTime = "18" + ":" + mins + ":" + secs;
                  break;
                case "07":
                  militaryTime = "19" + ":" + mins + ":" + secs;
                  break;
                case "08":
                  militaryTime = "20" + ":" + mins + ":" + secs;
                  break;
                case "09":
                  militaryTime = "21" + ":" + mins + ":" + secs;
                  break;
                case "10":
                  militaryTime = "22" + ":" + mins + ":" + secs;
                  break;
                case "11":
                  militaryTime = "23" + ":" + mins + ":" + secs;
                  break;
            }
        } else {
            if (hours.Equals("12")) {
                militaryTime = "00" + ":" + mins + ":" + secs;
            } else{
                militaryTime = hours + ":" + mins + ":" + secs;
            }         
        }
        
        return militaryTime;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
