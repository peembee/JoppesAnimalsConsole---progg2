using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Dog : Animal
    {

        public Dog(string breed, string name, int age, string favFood)
        {
            this.breed = breed;
            this.name = name;
            this.age = age;
            this.favFood = favFood;
        }
        public override int Interact(int earnedMoney)
        {
            if (hungry == false)
            {
                int getChoice;
                while (true)
                {                    
                    Console.WriteLine("#1: Dance with " + name);
                    Console.WriteLine("#2: Run around with " + name);
                    Console.Write("Enter option: ");
                    try
                    {
                        getChoice = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Only accepting numbers 1 or 2");
                    }
                }
                if (getChoice == 1)
                {
                    Console.WriteLine(name + " and Joppe are dancing to the moon");                                                            
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine(name + " do like to run. Joppe is tired now");
                    Console.WriteLine("______________________________________________");
                    Console.ResetColor();
                }
                Console.WriteLine("Your Wallet Increased with $10");
                hungry = true;
                return earnedMoney + 10;
            }
            else
            {
                JustWantToEat();
            }
            return earnedMoney;
        }
        public override int Interact(Ball ball, int earnedMoney)
        {
            if (hungry == false)
            {
                Random rnd = new Random();
                int getAction = rnd.Next(1, 4);
                if (getAction == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Joppe playing catch ball with " + name);
                    Console.WriteLine("_______________________________________");
                    getAction = rnd.Next(1, 5);
                    if (getAction == 1) // 25% chance for a higher value in LowerQuality()
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("_______________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("You forgot to cut " + name + " claws");
                        Console.WriteLine("He really messed up the ball..");
                        Console.WriteLine("_______________________________________");
                        Console.ResetColor();
                        ball.LowerQuality(8);
                    }
                    else
                    {
                        ball.LowerQuality(4);
                    }
                }
                else if (getAction == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Joppe and " + name + " kicking the ball to eachother");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    ball.LowerQuality(4);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("");
                    Console.WriteLine(name + " kicking and eating on the ball");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    ball.LowerQuality(5);
                }
                hungry = true;
                Console.ResetColor();
                Console.WriteLine("Your Wallet Increased with $10");
                earnedMoney = earnedMoney + 10;
            }
            else
            {
                JustWantToEat();
            }            
            return earnedMoney;
        }
        public virtual int GoHunt(int earnedMoney)
        {
            if (hungry == false)
            {
                int getChoice;
                while (true)
                {
                    Console.WriteLine(name + " likes to hunt Roedeer and Bears");
                    Console.WriteLine("#1: Hunt Roedeer");
                    Console.WriteLine("#2: Hunt Bears");
                    Console.Write("Enter option: ");
                    try
                    {
                        getChoice = Convert.ToInt32(Console.ReadLine());
                        if (getChoice == 1 || getChoice == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid option");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Only accept numbers 1 or 2");
                    }
                }
                if (getChoice == 1)
                {
                    Random rnd = new Random();
                    int getAction = rnd.Next(1, 4); // 33% chance dog catches a Roedeer.
                    Console.WriteLine(name + " are looking for a Roedeer in the forest");
                    System.Threading.Thread.Sleep(1000);
                    if (getAction == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("____________________________________________");
                        Console.WriteLine(name + " got a Roedeer!");
                        Console.WriteLine("____________________________________________");
                        Console.ResetColor();
                        Console.WriteLine("Your Wallet Increased with $25");
                        earnedMoney = earnedMoney + 25;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("____________________________________________");
                        Console.WriteLine(name + " did not find any animals this times.");
                        Console.WriteLine("____________________________________________");
                        Console.ResetColor();
                    }                    
                }
                else
                {
                    Console.WriteLine(name + " are loking carefully for bears");
                    System.Threading.Thread.Sleep(1000);
                    Random rnd = new Random();
                    int getAction = rnd.Next(1, 5); // 25% chance dog catches a Bear.
                    if (getAction == 1) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("____________________________________________");
                        Console.WriteLine("Wow! " + name + " catched a bear!");
                        Console.WriteLine("____________________________________________");
                        Console.ResetColor();
                        Console.WriteLine("Your Wallet Increased with $40");
                        earnedMoney = earnedMoney + 40;
                    }
                    else
                    {
                        Console.WriteLine(name + " did not find any animals this times.");
                    }                    
                }
                hungry = true;
                return earnedMoney;
            }
            else
            {
                JustWantToEat();
                return earnedMoney;
            }
        }
        public int RunningContest(int earnedMoney)
        {
            if (hungry == false && earnedMoney > 29)
            {
                int race = 1;
                int dogsterTime = 0;
                int shibaTime = 0;
                Random rnd = new Random();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Welcome the Running Contest!");
                Console.WriteLine(name + " will have a contest with another dog called Shiba");
                Console.WriteLine("Whoever has the fastest time in 4 races win!");
                Console.WriteLine("Let the Contest begin!");
                Console.WriteLine("____________________________________________________");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.ReadKey();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("___________________________________________________________");
                    int raceTime = rnd.Next(20, 45); // represents in racetime in seconds/race
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(name + ": Race " + race + ": Time: " + raceTime + " seconds");
                    dogsterTime = dogsterTime + raceTime;
                    System.Threading.Thread.Sleep(500);
                    raceTime = rnd.Next(20, 45);                    
                    Console.WriteLine("Shiba: Race " + race + ": Time: " + raceTime + " seconds");
                    shibaTime = shibaTime + raceTime;
                    race++;
                }
                Console.WriteLine(" ");
                Console.WriteLine("_____________");
                Console.WriteLine("Calculating time...");                
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(name + ": Racetime: " + dogsterTime + " Seconds");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Shiba: Racetime: " + shibaTime + " Seconds");
                Console.WriteLine("_____________");
                if (dogsterTime > shibaTime)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Congratulation! " + name + " won the contest");
                    Console.WriteLine("____________________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $30");
                    earnedMoney = earnedMoney + 30;
                }
                else if (dogsterTime == shibaTime)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Time was even!");
                    Console.WriteLine("____________________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $15");
                    earnedMoney = earnedMoney + 15;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("Shiba won the contest!");
                    Console.WriteLine("____________________________________________");
                    Console.ResetColor();
                    Console.WriteLine("You loose $30");
                    earnedMoney = earnedMoney - 30;
                }
                hungry = true;
            }
            else
            {
                if (hungry == true)
                {
                    JustWantToEat();
                }
                else if (earnedMoney < 30)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("____________________________________________");
                    Console.WriteLine("You need to have atleast $30 to participate in the contest");
                    Console.WriteLine("____________________________________________");
                    Console.ResetColor();
                }
            }
            return earnedMoney;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
