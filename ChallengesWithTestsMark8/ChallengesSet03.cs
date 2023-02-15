using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;
            if (vals == null || vals.Length == 0)
            {
                return false;
            }
            else
            {
                //foreach (bool val in vals)
                //{
                //    if (val == false)
                //    {
                //        containsFalse = true;
                //        break;
                //    }
                //}
                //return containsFalse;

                for (int i = 0; i < vals.Length; i++)
                {
                    if (vals[i] == false)
                    {
                        containsFalse = true;
                        break;
                    }
                }
                return containsFalse;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count(); i++)
                {
                    sum += numbers.ElementAt(i);
                }
               return (sum % 2 != 0) ? true : false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password== null || password.Length == 0)
            { return false; }
            else
            {
                bool upper = false;
                bool lower = false;
                bool number = false;
                foreach (char c in password)
                {
                    if (upper == true && lower == true && number == true)
                    {
                        break;
                    }
                    else if (Char.IsUpper(c) == true) 
                    {
                        upper = true;
                    }
                    else if (Char.IsLower(c) == true)
                    {
                        lower = true;
                    }
                    else if (Char.IsDigit(c) == true)
                    {
                        number = true;
                    }
                }
                return (upper == true && lower == true && number == true) ? true : false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            if (val == null || val.Length == 0)
            { return '\0'; }
            else
            {
                char firstLetter = val[0];
                return firstLetter;
            }
        }

        public char GetLastLetterOfString(string val)
        {
            if (val == null || val.Length == 0)
            { return '\0'; }
            else
            {
                char lastLetter = val[val.Length - 1];
                return lastLetter;
            }
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0; //Can't divide by 0 but must return a decimal so...
            }
            else
            {
                decimal solution = dividend / divisor;
                return solution;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            int answer = nums[nums.Length - 1] - nums[0];
            return answer;
        }

        public int[] GetOddsBelow100()
        {
            int counter = 0;
            int[] odds = new int[50];
            for (int i = 0; i < (odds.Length * 2); i++)
            {
                if (i % 2 != 0)
                {
                    odds[counter] = i;
                    Console.WriteLine(odds[counter]);
                    counter++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
