using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n >= startNumber)
            {
                return n;
            }
            else
            {
                int number = startNumber / n;
                return ((number + 1) * n);
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue <= 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            else
            {
                var ascList = numbers.OrderBy(x => x);

                int counter = 0;

                foreach (var number in ascList)
                {
                    if (number != numbers[counter])
                    {
                        return false;
                    }
                    counter++;
                }
                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                int answer = 0;
                
                for (int i = 0;  i + 1 < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        answer += numbers[i + 1];
                    }
                }
                return answer;
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            List <string> noEmpty = new List<string> ();
            int counter = 0;
            if (words == null || words.Length == 0)
            {
                return "";
            }
            foreach(string word in words)
            {
                if (string.IsNullOrWhiteSpace(word) == false)
                {
                    noEmpty.Add(word);
                }
                else
                {
                    counter++;
                }
            }
            if (counter == words.Length)
            {
                return "";
            }
            else
            {
                List<char> characters = new List<char>();
                foreach (string word in noEmpty)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != ' ')
                        {
                            characters.Add(word[i]);
                        }
                    }
                    characters.Add(' ');
                }
                characters.RemoveAt(characters.Count - 1);
                characters.Add('.');

                string answer = string.Concat(characters);
                return answer;
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //int listLength = elements.Count % 4;
            double[] answer = new double[] { };
            if (elements == null || elements.Count == 0)
            {
                return answer;
            }
            else
            {
                List<double> result = new List<double>();
                for (int i = 3; i < elements.Count; i += 4)
                {
                    result.Add(elements[i]);
                }
                answer = result.ToArray();
                return answer;
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums  == null || nums.Length <= 1)
            { return false; }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == targetNumber)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

        }
    }
}
