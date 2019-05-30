using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
        public class FizzBuzz
        {
            public string Get(int num)
            {
                if (num % 3 == 0)
                {
                    return "Fizz";
                }
                if (num % 5 == 0)
                {
                    return "Buzz";
                }
                return num.ToString();
            }

        }
}
