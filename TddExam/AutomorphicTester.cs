using System;

namespace TddExam
{
    public class AutomorphicTester 
    {
        public bool IsAutomorphic(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException($"Input must be positive number. Input: {number}");

            var res = checked (number * number);
            return res.ToString().EndsWith(number.ToString());
        }
    }
}
