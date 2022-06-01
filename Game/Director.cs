using System;
using System.Text;

namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Word word = new Word();
        private Jumper jumper = new Jumper();
        private bool isPlaying = true;
        private char guess;
        StringBuilder guessList = new StringBuilder();
        private TerminalService terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Gets letter guess from user
        /// </summary>
        private void GetInputs()
        {
            // display word, prompt for guess, add guess to list
            Console.WriteLine();
            word.Display();
            Console.Write("\nGuess a letter [a-z]: ");
            guess = Console.ReadLine()[0];
            guessList.Append(guess);
            Console.WriteLine();
        }

        /// <summary>
        /// Updates word and jumper according to guesses
        /// </summary>
        private void DoUpdates()
        {
            // check guess and update word
            word.checkGuess(guess);

            // update jumper
            jumper.UpdateJumper(word.currentWord, guess);
        }

        /// <summary>
        /// Display current word and jumper
        /// </summary>
        private void DoOutputs()
        {

            // display jumper
            jumper.Display();

            // display previous guesses
            Console.Write("Previous guesses: ");
            Console.Write(guessList[0]);
            for (int i = 1; i < guessList.Length; i++)
            {
                Console.Write(", " + guessList[i]);
            }
            Console.WriteLine();


        }
    }
}