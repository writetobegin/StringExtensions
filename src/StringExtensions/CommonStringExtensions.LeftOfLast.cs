﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static partial class CommonStringExtensions
    {
        /// <summary>
        /// Extracts the left part of the input string limited by the last character
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="character">The character to find in the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the character (excluding the character) or the whole input string if the character was not found</returns>
        public static string LeftOfLast(this string input, char character)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");

            string result;
            int lastCharacterPosition = input.LastIndexOf(character);

            if (lastCharacterPosition == -1)
            {
                result = input;
            }
            else
            {
                result = input.Substring(0, lastCharacterPosition);
            }

            return result;
        }

        /// <summary>
        /// Extracts the left part of the input string limited by the last occurrence of value
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="value">The value to find in the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the last occurrence of value or the whole input string if the value was not found</returns>
        public static string LeftOfLast(this string input, string value)
        {
            return LeftOfLast(input, value, StringComparison.Ordinal);
        }

        /// <summary>
        /// Extracts the left part of the input string limited by the last occurrence of value
        /// </summary>
        /// <param name="input">The input string to take the left part from</param>
        /// <param name="value">The value to find in the input string</param>
        /// <param name="comparisonType">The way startsWith should be compared to the input string</param>
        /// <returns>The substring starting at startIndex 0 until either the position of the last occurrence of value or the whole input string if the value was not found</returns>
        public static string LeftOfLast(this string input, string value, StringComparison comparisonType)
        {
            // preconditions
            if (input == null)
                throw new ArgumentNullException("input");
            if (value == null)
                throw new ArgumentNullException("value");

            string result;
            int lastValuePosition = input.LastIndexOf(value, comparisonType);

            if (lastValuePosition == -1)
            {
                result = input;
            }
            else
            {
                result = input.Substring(0, lastValuePosition);
            }

            return result;
        }
    }
}
