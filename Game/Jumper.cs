using System;
using System.Text;
using System.Collections.Generic;

namespace Unit03.Game
{
    /// <summary>
    /// <para>The person looking for the Hider.</para>
    /// <para>
    /// The responsibility of a Seeker is to keep track of its location.
    /// </para>
    /// </summary>
    public class Jumper
    {
        private int lives = 4;
        List<string> parachute = new List<string>();

        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public Jumper()
        {
            // initialize parachute
            parachute.Add("  ___ ");
            parachute.Add(" /___\\");
            parachute.Add(" \\   /");
            parachute.Add("  \\ /");
            parachute.Add("   O");
            parachute.Add("  /|\\");
            parachute.Add("  / \\");
            parachute.Add("");
            parachute.Add("^^^^^^^");
        }

        /// <summary>
        /// Check if word contains guessed char, if not remove life, update parachute
        /// </summary>
        public void UpdateJumper(string word, char guess)
        {
            if (lives > 0)
            {
                if (!word.Contains(guess))
                {
                    parachute.RemoveAt(0);
                    lives -= 1;
                }
            }

            // if user is out of lives, display end screen
            else
            {
                // replace head with X
                parachute.RemoveAt(0);
                Console.WriteLine("^^^^^^^");
                Console.WriteLine("   X");
                foreach (string str in parachute)
                {
                    Console.WriteLine(str);
                }
                // exit message and close program
                Console.WriteLine("You died! Better luck next time.\n");
                Environment.Exit(1);
            }

        }

        /// <summary>
        /// Display up to date parachute
        /// </summary>
        public void Display()
        {
            Console.WriteLine("^^^^^^^");
            foreach (string str in parachute)
            {
                Console.WriteLine(str);
            }
        }

    }
}