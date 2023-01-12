using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class LotteryGame
    {
        public int RunLotteryGame(int wallet) // Getting player wallet
        {
            int entry = 10;
            int guessNumber;
            int thief;
            if (wallet < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You don't have enough money, welcome back another time");
                Console.WriteLine("We will give you $10 anyway");
                Console.WriteLine("  ");
                Console.ResetColor();
                wallet = wallet + 10;
                Console.WriteLine("Press button to get back to menu");
                Console.ReadKey();
            }
            else
            {
                wallet = wallet - entry;
                Random rnd = new Random();
                int rightNumber = rnd.Next(1, 9);
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("_______________________");
                    Console.WriteLine("WelCome To The Lottery");
                    Console.WriteLine("Win up to $200,   $10 per game");
                    Console.WriteLine("_______________________");
                    Console.WriteLine("Guess what number i think about is.. You have one clue, it is between the numbers 1 - 8");
                    Console.WriteLine("watch out for the thief. He usually steal half of ones money");
                    Console.WriteLine("_______________________");
                    Console.ResetColor();
                    Console.Write("Enter you guess: ");
                    try
                    {
                       guessNumber = Convert.ToInt32(Console.ReadLine());
                        if (guessNumber < 1 || guessNumber > 8)
                        {
                            Console.WriteLine("_____________");
                            Console.WriteLine("Only numbers between 1 - 8");
                            Console.WriteLine("_____________");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" ");
                            Console.WriteLine("____________________________________");
                            Console.WriteLine("You guessed " + guessNumber);
                            Console.WriteLine("____________________________________");                            
                            break;
                        }                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("_____________");
                        Console.WriteLine("Only numbers between 1 - 8");
                        Console.WriteLine("_____________");
                    }
                }
                Console.WriteLine("Loading lottery number");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("____________________________________");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Right number was: " + rightNumber);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("____________________________________");                
                if (guessNumber == rightNumber)
                {
                    wallet = wallet + 200;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(" ");
                    Console.WriteLine("Congratulations! You WON $200");
                    Console.WriteLine(" ");
                    Console.WriteLine("push button and you will get back to menu");                      
                }      
                else
                {
                    Console.WriteLine("Sorry for your loss. Better luck next time");                    
                }
                Console.ReadKey();
                thief = rnd.Next(1, 11); // 10% chance that the thief will steal your money
                if (thief == 1)
                {
                    if (wallet == 0)
                    {
                        Console.WriteLine("The thief tried to steal from you, but you didn't have any money so..");
                    }
                    else
                    {
                        Console.WriteLine("Oh no, the thief stoled half your money");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Anyway...");
                        System.Threading.Thread.Sleep(500);
                        Console.WriteLine("Welcome back again");
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("menu? just press button as always");
                    Console.ReadKey();
                }
            }
            return wallet;
        }

    }
}
