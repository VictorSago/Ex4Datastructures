using System.Text;
using System.Collections;
using System;
using System.Collections.Generic;

namespace VicsDatastructuresEx4
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; // Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; // Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) // If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}

            Console.Clear();

            var theList = new List<string>();

            Console.WriteLine("Enter '+word' or '-word' to add or remove a word respectively;");
            Console.WriteLine("Enter 's' to show the list or 'q' to quit and return to the main menu.");

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Please enter a '+string', '-string', 's' or 'q':");
                    continue;
                }
                var word = input.Substring(1).Trim();       // The input string minus the first character and surrounding spaces
                switch (input[0])
                {
                    case '+' when (word.Length >= 1):
                        theList.Add(word);
                        Console.WriteLine($"Capacity: {theList.Capacity}");
                        break;
                    case '-' when (word.Length >= 1):
                        theList.Remove(word);
                        Console.WriteLine($"Capacity: {theList.Capacity}");
                        break;
                    case 's':
                        Console.WriteLine($"List Capacity = {theList.Capacity}: {ListToString(theList)}");
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Please enter a '+string', '-string', 's' or 'q':");
                        break;
                }
            }
        }

        /// <summary>
        /// Returns all elements of the list as a simple, one-line string
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string ListToString<T>(List<T> list)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]).Append(i == list.Count - 1 ? "." : ", ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Console.Clear();

            var theQueue = new Queue<string>();

            Console.WriteLine("Enter '+word' to add 'word' to the queue or '-' to remove an element from it;");
            Console.WriteLine("Enter 's' to show the queue or 'q' to quit and return to the main menu.");

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Please enter a '+string', '-', 's' or 'q':");
                    continue;
                }
                var word = input.Substring(1).Trim();
                switch (input[0])
                {
                    case '+' when (word.Length >= 1):
                        theQueue.Enqueue(word);
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                        {
                            Console.WriteLine($"Removing element: {theQueue.Dequeue()}");
                        }
                        else
                        {
                            Console.WriteLine($"The Queue is empty.");
                        }
                        break;
                    case 's':
                        Console.WriteLine($"The Queue: {QueueToString(theQueue)}");
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Please enter a '+string', '-', 's' or 'q':");
                        break;
                }
            }
        }

        /// <summary>
        /// Returns all elements of the queue as a simple, one-line string
        /// </summary>
        /// <param name="queue"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string QueueToString<T>(Queue<T> queue)
        {
            var sb = new StringBuilder();
            if (queue.Count == 0)
            {
                sb.Append("<Empty>");
            }
            else
            {
                foreach (var e in queue)
                {
                    sb.Append(e).Append(" < ");     // Add '<' after each element to show the direction of the queue
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
             */
            // There is a conflict with the exercise text text which instructs us to 
            // "reverse a string using a stack", while the instructions here appear to
            // follow the same pattern as with the queue and the list.
            // So I will be improvising a bit.

            Console.Clear();

            var theStack = new Stack<char>();

            Console.WriteLine("Enter '+string' to add 'string' to the stack or '-' to remove a string from it;");
            Console.WriteLine("Enter '?' to show the stack or '!' to quit and return to the main menu.");

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Please enter a '+string', '-', '?' or '!':");
                    continue;
                }
                var word = input.Substring(1).Trim();
                switch (input[0])
                {
                    case '+' when (word.Length >= 1):
                    // Add each character in the word to the stack,
                    // separating each new word with ';' from the previous
                        if (theStack.Count > 0)
                        {
                            theStack.Push(';');                 // Using ';' to separate words from one another
                        }
                        foreach (var c in word)
                        {
                            theStack.Push(c);
                        }
                        break;
                    case '-':
                        if (theStack.Count > 0)
                        // If there are words in the stack remove the uppermost in reverse character order
                        {
                            Console.WriteLine($"Removing sequence: {ReverseText(theStack)}");
                        }
                        else
                        {
                            Console.WriteLine($"The Stack is empty.");
                        }
                        break;
                    case '?':
                        // Show the stack
                        Console.WriteLine($"The Stack: {StackToString(theStack)}");
                        break;
                    case '!':
                        // Quit
                        return;
                    default:
                        Console.WriteLine("Please enter a '+string', '-', 's' or 'q':");
                        break;
                }
            }
        }

        /// <summary>
        /// Returns the next'word' from the stack as a one line string
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        static string ReverseText(Stack<char> stack)
        {
            var sb = new StringBuilder();

            // Characters are removed from the stack one-by-one in reverse order
            // and appended to the string, until the separator ';' is encountered
            // or the stack runs out of characters
            while (stack.Count > 0)
            {
                char c = stack.Pop();
                if (c == ';')
                {
                    break;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns all elements in the stack as a simple, one-line string
        /// </summary>
        /// <param name="stack"></param>
        /// <returns></returns>
        static string StackToString(Stack<char> stack)
        {
            var sb = new StringBuilder();
            var sarray = stack.ToArray();
            foreach (var c in sarray)
            {
                sb.Append(c);
            }
            return sb.ToString();
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.Clear();

            // Get string from user input
            // If the string is 'quit' -- return, else analyze the string
            // Repeat
            while (true)
            {
                Console.WriteLine("Please enter an expression to analyze or 'quit' to return to the main menu:");
                var expression = Console.ReadLine();
                if (String.IsNullOrEmpty(expression.Trim()))
                {
                    continue;
                }
                if (expression.Equals("q") || expression.ToLower().Equals("quit"))
                {
                    break;
                }
                var success = AnalyzeExpression(expression);
                if (success)
                {
                    Console.WriteLine("The expression is well formed!");
                }
                else
                {
                    Console.WriteLine("The expression is NOT well formed!");
                }
            }

        }
        private static bool AnalyzeExpression(string expression)
        {
            // For matching an opening pranthesis to a corresponding closing character
            var parmatch = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };
            // The stack to hold every opening paranthesis
            var parans = new Stack<char>();
            // Iterate through the string
            foreach (var c in expression)
            {
                // Upon encountering an opening paranthesis put it into a stack
                if (parmatch.ContainsKey(c))
                {
                    parans.Push(c);
                }
                // Upon encountering closing paranthesis check if the top paranthesis in the stack is a match
                // If a match -- discard both and continue
                // If not a match -- fail
                else if (parmatch.ContainsValue(c))
                {
                    // Short-circuiting evaluation: the second condition in the if statement will be evaluated 
                    // only if the first condition is true
                    if (parans.Count > 0 && c == parmatch[parans.Peek()])
                    {
                        parans.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            // At the end if the stack is empty -- succeed, otherwise -- fail
            return parans.Count == 0;
        }
    }
}
