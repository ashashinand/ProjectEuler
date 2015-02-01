/* ====================================================
 *  EProblem0 is a non-existant problem that only exists
 *  as to ensure that the compiler doesn't freak out
 *  that theres no problem assigned to a temporary variable.
 *  However, this class should never be created directly
 *  and as such has bare minimum functions defined and
 *  will throw exceptions the moment you try to start execution.
 * ==================================================== */

using System;

namespace Euler.problems
{
    class EProblem0 : EulerProblem
    {
        public void Start()
        {
            //AKA: You're an idiot. Stop.
            throw new InvalidOperationException();
        }

        public void SetVerboseOutput(bool b)
        {
            throw new InvalidOperationException();
        }

        public void Output()
        {
            throw new InvalidOperationException();
        }
    }
}
