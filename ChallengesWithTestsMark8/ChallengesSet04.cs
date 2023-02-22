using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;

            for (int i = 0;  i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }
        

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string>() { str1, str2, str3, str4 };

            int min = stringList.Min(x => x.Length);

            return min;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>() {number1, number2, number3, number4};

            int min = intList.Min(x => x);

            return min;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            double num;
            bool result;
            if (input == null || input.Length == 0)
            {
                return false;
            }
            else
            {
                result = double.TryParse(input, out num);
                return result;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            if (!objs.Any())
            {
                return true;
            }
            else if (objs.Length == 0)
            {
                return true;
            }
            else
            {
                double mark = objs.Length / 2;
                int counter = 0;
                for (int i = 0; i < objs.Length; i++)
                {
                    if (objs[i] == null)
                    {
                        counter++;
                    }
                    if (counter > mark)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers  == null || numbers.Length == 0) { return 0; }
            else
            {
                var newList = numbers.Where(x => x % 2 == 0).ToList();
                if (newList.Count == 0)
                {
                    return 0;
                }
                else
                {
                    double answer = newList.Average(x => x);
                    return answer;
                }
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Out of Range");
            }
            else if (number == 0)
            {
                return 1;
            }
            else
            {
                List<int> listNums = new List<int>();

                for (int i = 1; i <= number; i++)
                {
                    listNums.Add(i);
                }

                int answer = listNums.Aggregate((x, y) => x * y);
                return answer;
            }
        }
    }
}
