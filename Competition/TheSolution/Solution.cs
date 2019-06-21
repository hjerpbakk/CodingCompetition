﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolution
{
    public class Solution
    {
        /// <summary>
        /// Create a method that counts the number 
        /// of lower case letters in a word.
        ///
        /// Example:
        /// Runar
        ///
        /// Return:
        /// 4
        ///
        /// </summary>
        /// <param name="word">The word to check.</param>
        /// <returns>The number of lower case letters in the word.</returns>
        public int CountLowerCasetLetters(string word)
        {
            var sum = 0;
            foreach (var letter in word)
            {
                if (char.IsLower(letter)) ++sum;
            }
            return sum;
        }
    }
}