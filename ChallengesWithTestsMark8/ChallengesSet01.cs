using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double answer = minuend - subtrahend;
            return answer;
        }

        public int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            int answer = (number1 < number2) ? number1 : number2;
            return answer;
        }

        public long Multiply(long factor1, long factor2)
        {
            long answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            Console.WriteLine($"Hello, {nameOfPerson}.");
            return $"Hello, {nameOfPerson}.";
        }

        public string GetHey()
        {
            Console.WriteLine("HEY!");
            return $"HEY!";
        }
    }
}
