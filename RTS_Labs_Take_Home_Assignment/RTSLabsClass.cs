using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RTS_Labs_Take_Home_Assignment
{
    internal class RTSLabsClass
    {
        private const string above = "above";
        private const string below = "below";

        public Dictionary<string, int> AboveBelow(List<int> numbersList, int numberToCheck)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>() { { above, 0 }, { below, 0 } };

            if (numbersList != null)
            {
                foreach (int number in numbersList)
                {
                    int count = 0;

                    if (number > numberToCheck)
                    {
                        count = dictionary[above];
                        dictionary[above] = count + 1;
                    }
                    else if (number < numberToCheck)
                    {
                        count = dictionary[below];
                        dictionary[below] = count + 1;
                    }
                }
            }

            return dictionary;
        }

        public string StringRotation(string stringToRotate, int rotationCount)
        {
            string rotatedString = string.Empty;

            if (!string.IsNullOrEmpty(stringToRotate))
            {
                if (stringToRotate.Length == 1)
                {
                    rotatedString = stringToRotate;
                }
                else
                {
                    rotationCount = rotationCount % stringToRotate.Length;

                    if (rotationCount == 0)
                    {
                        rotatedString = stringToRotate;
                    }
                    else
                    {
                        StringBuilder stringBuilder = new StringBuilder();

                        string reversedString = ReverseString(0, stringToRotate.Length - 1, stringToRotate);
                        string leftString = ReverseString(0, rotationCount - 1, reversedString);
                        string rightString = ReverseString(rotationCount, leftString.Length - 1, leftString);

                        rotatedString = rightString;
                    }
                }
            }

            return rotatedString;
        }

        private string ReverseString(int leftIndex, int rightIndex, string stringToBeReversed)
        {
            string reversedString = string.Empty;

            char[] charArray = stringToBeReversed.ToCharArray();

            bool exit = false;

            do
            {
                char leftValue = stringToBeReversed[leftIndex];
                char rightValue = stringToBeReversed[rightIndex];

                charArray[leftIndex] = rightValue;
                charArray[rightIndex] = leftValue;

                if (leftIndex == rightIndex || leftIndex + 1 == rightIndex)
                {
                    exit = true;
                }

                leftIndex++;
                rightIndex--;
            }
            while (!exit);

            reversedString = string.Join("", charArray);

            return reversedString;
        }
    }
}
