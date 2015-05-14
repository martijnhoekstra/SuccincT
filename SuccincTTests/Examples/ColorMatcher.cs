﻿using System;
using SuccincT.PatternMatchers;

namespace SuccincTTests.Examples
{
    /*
     * This is an implementaion of the F# color matcher pattern matching example at https://msdn.microsoft.com/en-us/library/dd547125.aspx.
     */
    public static class ColorMatcher
    {
        public enum Color { Red, Green, Blue }

        public static void PrintColorName(Color color)
        {
            color.Match()
                 .Case(Color.Red, () => Console.WriteLine("Red"))
                 .Case(Color.Green, () => Console.WriteLine("Green"))
                 .Case(Color.Blue, () => Console.WriteLine("Blue"))
                 .Exec();
        }
    }
}
