using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    class HangmanService : IGameService
    {
        public string RandomWord { get; set; }
        public char[] RandomWordChars { get; set; }
        public int IncorrectGuesses { get; set; }
        public HangmanService()
        {
            RandomWord = GetRandomWord();
            RandomWordChars = new string('_', RandomWord.Length).ToCharArray();
            IncorrectGuesses = 0;
        }
        public string GetRandomWord()
        {
            return Utility.ChooseRandom<string>(new string[] { "ğmehmet",
                                                "ğahmet",
                                                "ğselim", });
        }

        public void RenderGameState()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 3);
            Console.CursorLeft = 4;
            Render(Utility.Renders[IncorrectGuesses]);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("    Guess: ");
            foreach (char c in RandomWordChars)
            {
                Console.Write(c + " ");
            }
        }

        public void Render(string @string)
        {
            int x = Console.CursorLeft;
            int y = Console.CursorTop + 1;
            foreach (char c in @string)
            {
                if (c == '\n')
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(x, y++);
                }
                else
                {
                    Console.Write(c);
                }
            }
        }

        public bool CheckContinue()
        {
            return IncorrectGuesses < Utility.Renders.Length && RandomWordChars.Contains('_');
        }

        public bool CheckGuessCorrect(char guess)
        {
            bool correctGuess = false;
            for (int i = 0; i < RandomWordChars.Length; i++)
            {
                if (RandomWordChars[i] == '_' && RandomWord[i] == guess)
                {
                    RandomWordChars[i] = guess;
                    correctGuess = true;
                }
            }
            if (!correctGuess)
            {
                IncorrectGuesses++;
            }
            return correctGuess;
        }

        public void Results()
        {
            if (IncorrectGuesses >= Utility.Renders.Length)
            {
                for (int i = 0; i < Utility.DeathAnimation.Length; i++)
                {
                    Console.SetCursorPosition(4, 3);
                    Render(Utility.DeathAnimation[i]);
                    Thread.Sleep(150);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("    Answer: " + RandomWord);
                Console.WriteLine("    You lose...");
            }
            else
            {
                RenderGameState();
                Console.WriteLine();
                Console.WriteLine("    You win!");
            }
        }
    }
}
