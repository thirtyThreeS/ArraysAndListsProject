﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            foreach (int oddNum in odds)
            {
                Console.WriteLine($"Cell block #{oddNum} up against the wall this is a shakedown!");
            }
            Console.WriteLine("-----");
            foreach (int evenNum in evens)
            {
                Console.WriteLine($"Cell block #{evenNum} up against the wall this is a shakedown!");
            }
            Console.WriteLine("----- \nBeen watching 60 Days In on Netflix.. lol");
        
        }
    }
}
