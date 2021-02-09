﻿using System.Text;
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

            Console.WriteLine("Enter '+word' or '-word' to add or remove a word;");
            Console.WriteLine("Enter 's' to show the list or 'q' to quit and return to the main menu.");

            // TODO: Guards against wrong input?

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrEmpty(input.Trim()))
                {
                    Console.WriteLine("Please enter a '+string', '-string', 's' or 'q':");
                    continue;
                }
                var word = input.Substring(1).Trim();
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
                        Console.WriteLine($"List Capacity = {theList.Capacity}: {ListTotString(theList)}");
                        // foreach (var l in theList)
                        // {
                        //     Console.Write($"{l}, ");
                        // }
                        // Console.WriteLine();
                        break;
                    case 'q':
                        return;
                    default:
                        Console.WriteLine("Please enter a '+string', '-string', 's' or 'q':");
                        break;
                }
            }
        }

        public static string ListTotString<T>(List<T> list)
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

            Console.WriteLine("Enter '+word' to add 'word' to the queue or '-' to remove an element;");
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

        public static string QueueToString<T>(Queue<T> queue)
        {
            var sb = new StringBuilder();
            foreach (var e in queue)
            {
                sb.Append(e).Append(" < ");
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
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}
