using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# provides the while loop to repeatedly execute a block of code as long as the specified condition returns true.

            /*The while loop starts with the while keyword, and it must include a boolean conditional expression inside brackets 
            that returns either true or false. It executes the code block until the specified conditional expression returns false.*/

            /*When using the while loop, initialization should be done before the loop starts, and increment or decrement
            steps should be inside the loop.*/

            //Use the break or return keyword to exit from a while loop on some condition.

            //this is a while loop.
            
            int i = 0; // initialization
            Console.WriteLine("This is the output of the while loop.");
            
            while (i < 10) //boolean comparison condition
            {                
                Console.WriteLine("i = {0}", i);
                i++; // increment
                if (i > 10)
                    break;
            }

            Console.WriteLine();

            /*The do-while loop is the same as while loop except that it executes the code block at least once.*/


            /*The do/while loop is a variant of the while loop. This loop will execute the code block once, 
            before checking if the condition is true, then it will repeat the loop as long as the condition is true.*/

            /*The do-while loop starts with the 'do' keyword followed by a code block and a boolean expression with the while keyword. 
            The do-while loop stops execution exits when a boolean condition evaluates to false. Because the while(condition) is 
            specified at the end of the code block, it certainly executes the code block at least once.*/

            //this is a do-while loop

            Console.WriteLine("This is the output of the do-while loop.");
            
            int y = 0; //initialiization

            do
            {
                Console.WriteLine("y = {0}", y);
                y++;

                if (y > 5)
                    break;

            } while (y < 10); //Boolean comparison expression.
            
            Console.Read();
        }
    }
}
