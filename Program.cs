using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                HangmanService service = new HangmanService();
                
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("    Hangman");
                Console.WriteLine();
                while (service.CheckContinue())
                {
                    service.RenderGameState();
                    char guess = Console.ReadKey(true).KeyChar;
                    //char[] allowedKeys = new char[] { 'a', 'b', 'c' };
                    if ((guess >= 'a' && guess <= 'z') || guess == 'ğ')
                    {
                        //    char guess = key == ConsoleKey.Oem4 ? 'ğ' : Convert.ToChar(key.ToString().ToLower());
                        //char guess = (char)(key - ConsoleKey.A + 'a');
                        service.CheckGuessCorrect(guess);
                    }
                }

                service.Results();
                bool cont;
                CheckPlayAgain(out cont);
                if (!cont)
                {
                    break;
                }
                Console.Clear();
            }
        }

        static void CheckPlayAgain(out bool cont)
        {
            bool askAgain = true;
            cont = false;
            while (askAgain)
            {
                Console.WriteLine();
                Console.WriteLine("    Play Again [enter], or quit [escape]?");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Enter: 
                        cont = true;
                        askAgain = false;
                        break;
                    case ConsoleKey.Escape:
                        cont = false;
                        askAgain = false;
                        break;
                    default:
                        askAgain = true;
                        break;
                }
            }
        }
    }
}
