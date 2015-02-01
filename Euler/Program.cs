using Euler.problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    //Defining some common tasks for euler problems.

    interface EulerProblem
    {
        void Start();
        void Output();
        void SetVerboseOutput(bool b);
    }

    class Program
    {
        static bool GetUserInput(ref int output)
        {
            const int EULER_PROBLEM_START_INDEX = 1;
            const int EULER_PROBLEM_END_INDEX = 501;

            string input = "";
            int problem = 0;

            //While no valid input
            while (input != "exit" && input != "quit")
            {
                Console.WriteLine("Please input Project Euler problem # to see output");
                Console.WriteLine("Alternatively, type 'exit' or 'quit' to stop execution.");
                input = Console.ReadLine();

                //Exit? Break immediality before sanitation starts.
                if (input == "exit" || input == "quit")
                {
                    problem = -1;
                    break;
                }

                //Input sanitising.
                try
                {
                    problem = Convert.ToInt32(input);
                    if (problem < EULER_PROBLEM_START_INDEX || problem > EULER_PROBLEM_END_INDEX)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input '{0}' appears to not be a number! Please try again.", input);
                    input = "";
                    problem = 0;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Input '{0}' is out of range! Current range is between {1} and {2}", problem, EULER_PROBLEM_START_INDEX, EULER_PROBLEM_END_INDEX);
                    input = "";
                    problem = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown error occured trying to convert input to int32!");
                    input = "";
                    problem = 0;
                }

                //Is the user input not junk?
                if (problem != 0)
                    break;
            }

            output = problem;
            if (problem <= 0)
                return false;
            else
                return true;
        }

        static void Main(string[] args)
        {
            const bool VERBOSE_OUTPUT = true;

            int input = 0;
            EulerProblem currProblem = new EProblem0();

            while(GetUserInput(ref input))
            {
                switch (input)
                {
                    case 1:
                        currProblem = new EProblem1();
                        break;
                    case 2:
                        currProblem = new EProblem2();
                        break;
                    default:
                        break;
                }

                currProblem.SetVerboseOutput(VERBOSE_OUTPUT);
                currProblem.Start();
                currProblem.Output();
            }


        }

    }
}
