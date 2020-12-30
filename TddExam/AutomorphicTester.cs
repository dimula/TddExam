using System;

namespace TddExam
{
    public class AutomorphicTester 
    {
        public bool IsAutomorphicTester(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException($"Input must be positiv number. Input: {number}");

            var res = checked (number * number);
            return res.ToString().Substring(res.ToString().Length - number.ToString().Length) == number.ToString();
        }
    }
}
