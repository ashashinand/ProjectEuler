/* 
 *
 */

using System;

namespace Euler.problems
{
    class EProblemTemplate : EulerProblem
    {
        private bool _verboseOutput = false;

        public void Start()
        {
        }

        public void Output()
        {
        }

        public void SetVerboseOutput(bool b)
        {
            _verboseOutput = b;
        }
    }
}
