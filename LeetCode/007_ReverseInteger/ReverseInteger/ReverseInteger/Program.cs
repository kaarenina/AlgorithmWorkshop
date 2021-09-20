using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            SolutionIterative s1 = new SolutionIterative();
            int k = s.Reverse(-2147483648);
            int k1 = s1.Reverse(-123);
            Console.WriteLine(k + " " + k1);
        }
    }

    public class Solution
    {
        private int counter = 1;
        public int Reverse(int x)
        {
            
            if (x < 0)
            {
                try
                {
                    counter = -1;
                    x = Math.Abs(x);
                }
                catch (OverflowException)
                {
                    return 0;
                } 
            }

            string reverseNumber = ReverseString(x.ToString());
            
            Int32.TryParse(reverseNumber, out int number);
            return number * counter;
        }

        private string ReverseString(string number)
        {
            if (number.Length <= 1)
                return number;
            int middle = number.Length / 2;
            
            string left = ReverseString(number.Substring(0, middle));
            string right = ReverseString(number.Substring(middle));

            return right + left;
        }
    }

    public class SolutionIterative
    {
        public int Reverse(int x)
        {
            string numberString = x.ToString();
            string result = string.Empty;

            for (int i = numberString.Length - 1; i >= 0 ; i--)
            {
                result += numberString[i];
            }

            if (result.EndsWith("-"))
            {
                result = result.Replace("-", "");
                result = result.Insert(0, "-");
            }
            Int32.TryParse(result, out int number);
            return number;

        }
    }
  
}
