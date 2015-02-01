/* 
 * Simple problem; what's the sum of all multiples of 3 and 5
 * that lie between 1 and 1000?
 * if n mod 3 = 0 || n mod 5 = 0 then add n to a running total.
 * The trick is in the or otherwise you'll add the same multiple twice.
 */

using System;
using System.Collections.Generic;

namespace Euler.problems
{
    class EProblem1 : EulerProblem
    {
        private bool _verboseOutput = false;

        private const int UPPER_BOUND = 1000;

        private int _sum;

        public void Start()
        {
            if (_verboseOutput)
                Console.WriteLine("Initializing for loop and resetting running total.");

            //Reset the running total otherwise it'll keep the old value and add to that.
            _sum = 0;

            //from 1 to 1000 do
            for(int i = 1; i < UPPER_BOUND; i++)
            {
                if (i % 3 == 0)
                {
                    if (_verboseOutput)
                        Console.WriteLine("{0} is a multiple of 3, adding to running total: {1} + {0} = {2}", i, _sum, _sum + i);
                    _sum += i;
                }
                else if (i % 5 == 0)
                {
                    if (_verboseOutput)
                        Console.WriteLine("{0} is a multiple of 5, adding to running total: {1} + {0} = {2}", i, _sum, _sum + i);
                    _sum += i;
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("The total sum of multiples of 3 or 5 between 1 and 1000 is {0}", _sum);
        }

        public void SetVerboseOutput(bool b)
        {
            _verboseOutput = b;
        }
    }
}
