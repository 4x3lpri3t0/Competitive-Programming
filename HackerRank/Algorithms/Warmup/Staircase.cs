using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        
        int numberMax = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= numberMax; i++)
        {
            int whiteSpaces = numberMax - i;
            string whiteSpacesString = "";
            string hashesString = "";
            
            for (int j = 0; j < whiteSpaces; j++)
                whiteSpacesString += ' ';
            
            for (int j = 0; j < i; j++)
                hashesString += '#';
            
            Console.WriteLine(whiteSpacesString + hashesString);
        }
    }
}