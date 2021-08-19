using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static string ArrayChallenge(string[] strArr)
        {
            int currentArea = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                int pos1 = strArr[i].IndexOf("(");
                int pos2 = strArr[i].IndexOf(")");
                int length = pos2 - pos1;
                string drawString = strArr[i].Substring(pos1 + 1, length - 1);
                //Console.WriteLine("{0} {1}", drawString[0], drawString[2]);

                int number1 = int.Parse(drawString[0].ToString());
                int number2 = int.Parse(drawString[2].ToString());

                if (Math.Abs(number1 - number2) * Math.Abs(number1 - number2) > currentArea)
                {
                    currentArea = Math.Abs(number1 - number2) * Math.Abs(number1 - number2);
                }
            }

            string temp = "" + currentArea;
            List<string> result = new List<string>();
            result.Add(temp);

            return result.ToArray()[0];
        }

        static void Main(string[] args)
        {
            string[] testCase1 = { "(1 1)", "(1 3)", "(3 3)", "(3 1)" };
            string[] testCase2 = { "(0 0)", "(0 1)", "(1 1)", "(1 0)" };
            Console.WriteLine(ArrayChallenge(testCase2));
        }
    }
}
