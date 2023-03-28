using System;
using System.Security.Cryptography.X509Certificates;

namespace RTS_Labs_Take_Home_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RTSLabsClass rTSLabsClass = new RTSLabsClass();

            List<int> aboveBelowList = new List<int>() { 1, 5, 6, 2, 1, 10};
            int comparisonValue = 6;

            Dictionary<string, int> dictionaryResult = rTSLabsClass.AboveBelow(aboveBelowList, comparisonValue);

            // string stringUpForRotation = "MyString" , 2 =>  "ngMyStri";
            // string stringUpForRotation = "MyString" , 8 =>  "MyString";
            // string stringUpForRotation = "MyS" , 1 =>  "SMy";
            string stringUpForRotation = "MyString";
            int rotate = 2;

            string rotatedString = rTSLabsClass.StringRotation(stringUpForRotation, rotate);
        }
    }
}
