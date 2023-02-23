using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || word.Length == 0)
            {  return false; }
            else
            {
                if (ignoreCase == true)
                {
                    foreach (string temp in words)
                    {

                        if (temp != null && temp.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    foreach (string temp in words)
                    {
                        if (temp != null && temp == word)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            string ordered = string.Concat(str.OrderBy(x => x));

            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            else if (str.Length == 1)
            {
                return 0;
            }
            else if (str.Length == 2)
            {
                return str[0] != str[1] ? 1 : -1;
            }
            else
            {
                char marker = '!';
                if (ordered[ordered.Length - 2] != ordered[ordered.Length - 1])
                {
                    marker = ordered[ordered.Length - 1];
                }
                else
                {
                    for (int i = ordered.Length - 2; i >= 1; i--)
                    {
                        if (ordered[i] != ordered[i + 1] && ordered[i] != ordered[i - 1])
                        {
                            marker = ordered[i];
                        }
                    }
                }
                if (marker == '!')
                {
                    if (ordered[0] != ordered[1])
                    {
                        marker = ordered[0];
                    }
                }
                if (marker == '!')
                {
                    return -1;
                }
                else
                {
                    int index = 0;
                    for (int i = str.Length - 1; i >= 0; i--)
                    {
                        if (str[i] == marker)
                        {
                            index = i;
                            break;
                        }
                    }
                    return index;
                }
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers  == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                int maxStreak = 1;
                int currentMax = 1;
                for (int i = 0; i + 1 < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        currentMax++;
                        if (i + 1 == numbers.Length - 1 && currentMax > maxStreak)
                        {
                            maxStreak = currentMax;
                        }
                    }
                    else
                    {
                        if (currentMax > maxStreak)
                        {
                            maxStreak = currentMax;
                            currentMax = 1;
                        }
                    }
                }
                return maxStreak;
            }

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            double[] answer = new double[] { };

            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return answer;
            }
            else
            {
                for (int i = n - 1; i < elements.Count; i += n)
                {
                    result.Add(elements[i]);
                }

                return result.ToArray();
            }
        }
    }
}
