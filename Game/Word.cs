using System;
using System.Collections.Generic;
using System.Text;


namespace Unit03.Game 
{
    /// <summary>
    /// Selects word to be guessed by user and tracks how many letters have been guessed
    /// </summary>
    public class Word
    {    
        List<string> wordList = new List<string>{"apple", "banana", "cherry", "peach", "raspberry", "strawberry", "pineapple", "orange", "blueberry", "blackberry", "apricot", "nectarine", "pear", "mango", "grape", "plum", "kiwi"};
        public string currentWord = "";
        StringBuilder wordProgress = new StringBuilder();
        /// <summary>
        /// Constructs a new instance of Word. 
        /// </summary>
        public Word()
        {
            currentWord = GetWord();
            for (int i = 0; i < currentWord.Length; i++)
            {
                wordProgress.Append("_ ");
            }
        }

        /// <summary>
        /// Gets a new word
        /// </summary>
        private string GetWord()
        {
            Random random = new Random();
            string word = wordList[random.Next(0, 4)];
            return word;
        }

        /// <summary>
        /// Checks if guessed char is in word, update wordProgress
        /// </summary>
        public void checkGuess(char guess)
        {
            if (currentWord.Contains(guess))
            {
                // loop through each char in currentWord and compare with guess
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (guess == currentWord[i])
                    {
                        wordProgress[i*2] = guess;
                    }
                }
            }
        }

        /// <summary>
        /// Displays word progress including blank spaces
        /// </summary>
        public void Display()
        {
            string stringProgress = wordProgress.ToString();
            if (!stringProgress.Contains("_"))
            {
                Console.WriteLine("Congratulations, you won!");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine(wordProgress);
            }

        }
    }
}