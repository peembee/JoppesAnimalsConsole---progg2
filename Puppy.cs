using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Puppy : Dog
    {
        public Puppy(string breed, string name, int age, string favFood) : base(breed, name, age, favFood)
        {
            this.breed = breed;
            this.name = name;
            this.age = age;
            this.favFood = favFood;
        }
        public override int Interact(Ball ball, int earnedMoney)
        {
            if (hungry == false)
            {
                Random rnd = new Random();
                int getAction = rnd.Next(1, 4);
                if (getAction == 1)
                {
                    getAction = rnd.Next(1, 11);
                    if (getAction == 1) // 10% chance for a higher value in LowerQuality()
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Young dogs have very sharp teeths, this ball is pretty messed up..");
                        ball.LowerQuality(13);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(name + " just sniffing and scratches on the ball..");
                        ball.LowerQuality(2);
                    }
                }
                else if (getAction == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine(name + " jumps on the ball.. constantly");
                    ball.LowerQuality(3);

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine(name + " wants to play catch!");
                    ball.LowerQuality(3);
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
        public override int GoHunt(int earnedMoney)
        {
            if (hungry == false)
            {
                Console.WriteLine(name + " running around and catches bugs!");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Your Wallet Increased with $1");
                hungry = true;
                earnedMoney = earnedMoney + 1;
            }
            else
            {
                JustWantToEat();                
            }
            return earnedMoney;
        }
        public int PuppyShow(int earnedMoney)
        {
            if (hungry == false && earnedMoney > 49)
            {
                Random rnd = new Random();
                int rounds = 1;
                int vote;
                int DogsterVotes = 0;
                int DogeVotes = 0;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("____________________________________________________");
                Console.WriteLine("Welcome to the Puppy show Contest");
                Console.WriteLine(name + " will compete with a dog called Doge");
                Console.WriteLine("There will be 10 judges who have one vote");
                Console.WriteLine("Whoever who got the most votes win the contest");
                Console.WriteLine("Let the Contest begin!");
                Console.WriteLine("____________________________________________________");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine(" ");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("Round: " + rounds);
                    Console.WriteLine(name + " Enter the stage and doing the dogwalk");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Doge Enter the stage and doing the dogwalk");
                    System.Threading.Thread.Sleep(500);
                    vote = rnd.Next(1, 3);
                    if (vote == 1)
                    {
                        Console.WriteLine("Vote " + rounds + " goes to " + name);
                        DogsterVotes = DogsterVotes + 1;
                    }
                    else
                    {
                        Console.WriteLine("Vote " + rounds + " goes to Doge");
                        DogeVotes = DogeVotes + 1;
                    }
                    rounds++;                    
                }
                Console.WriteLine(" ");
                Console.WriteLine("_____________");
                Console.WriteLine("Calculating result...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(name +  ": Votes: " + DogsterVotes);
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Shiba: Votes: " + DogeVotes);
                Console.WriteLine("_____________");
                if (DogsterVotes >DogeVotes)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Congratulations!" + name + " Won the contest! with " + (DogsterVotes - DogeVotes) + " Vote(s) more");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $50");
                    earnedMoney = earnedMoney + 50;
                }
                else if (DogsterVotes == DogeVotes)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Votes were even");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $25");
                    earnedMoney = earnedMoney + 25;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Doge won the contest with " + (DogeVotes - DogsterVotes) + " Vote(s) more");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    Console.WriteLine("You loose $50");
                    earnedMoney = earnedMoney - 50;
                }
                hungry = true;
            }
            else
            {
                if (hungry == true)
                {
                    JustWantToEat();
                }
                else if (earnedMoney < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("You need to have atleast $50 to participate in the contest");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                }                
            }            
            return earnedMoney;
        }
        public override string ToString()
        {
            return "Breed: " + breed + " | Name: " + name + " | Age: " + age + " months | Favorite food: " + favFood;
        }
    }
}
