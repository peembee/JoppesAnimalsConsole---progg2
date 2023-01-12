using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Cat : Animal
    {
        public Cat(string breed, string name, int age, string favFood)
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("_____________________________________");
                Console.WriteLine("Joppe playing with cat with a bell");
                Console.ResetColor();
                Console.ReadKey();
                hungry = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Wallet Increased with $5");
                Console.ResetColor();
                earnedMoney = earnedMoney + 5;                
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
                if (hungry == false)
                {
                    Random rnd = new Random();
                    int getAction = rnd.Next(1, 4);
                    if (getAction == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(name + " Really running away.. He did not like the ball");
                        ball.LowerQuality(0);
                    }
                    else if (getAction == 2)
                    {
                        getAction = rnd.Next(1, 11);
                        Console.WriteLine("");
                        Console.WriteLine(name + " likes to scratch the ball");
                        if (getAction == 1) // 10% chance for ball to be destroyd
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("Wow that ball just popped! ");
                            Console.WriteLine(" ");
                            Console.WriteLine(name + " really have sharp claws!");
                            Console.WriteLine("_______________________________________");
                            Console.ResetColor();
                            ball.LowerQuality(20);
                        }
                        ball.LowerQuality(2);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine(name + " attacking the ball. this wasn't such a good idea...");
                        ball.LowerQuality(3);
                    }
                }
                hungry = true;
            }
            else
            {
                JustWantToEat();
                return earnedMoney;
            }
            Console.WriteLine("Your Wallet Increased with $10");
            Console.ResetColor();
            return earnedMoney + 10;
        }
        public int patCat(int earnedMoney)
        {
            if (hungry == false)
            {                
                Console.WriteLine("_______________________________________");
                Console.WriteLine(name + " likes being pat");
                Console.WriteLine("_______________________________________");
                Console.WriteLine("Your Wallet Increased with $2");
                earnedMoney = earnedMoney + 2;
                Random rnd = new Random();
                int getAction = rnd.Next(1, 4);
                if (getAction == 1) // 33% chance will make the cat hungry
                {
                    hungry = true;
                } 
            }
            else
            {
                Console.WriteLine(name + " don't like being pat while he's hungry");                
            }
            return earnedMoney;
        }
        public override void HungryAnimals()
        {
            Random rnd = new Random();
            int catchMouse = rnd.Next(1, 3);
            Console.WriteLine(name + " did not want to have this food and now he runs from me");
            Console.WriteLine(name + " likes to chase mouses instead.. ");
            System.Threading.Thread.Sleep(1000);
            if (catchMouse == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("_______________________________________");
                Console.WriteLine(" Look, he caught a mouse!");
                Console.WriteLine("_______________________________________");
                Console.ResetColor();
                hungry = false;
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("_______________________________________");
                Console.WriteLine(" ");
                Console.WriteLine("Nope, no mouse this time.. ");
                Console.WriteLine("_______________________________________");
                Console.ResetColor();
            }
            Console.WriteLine("");
            Console.WriteLine("Back to menu, just press button");
            Console.ReadKey();
        }

        public int HuntBird(int earnedMoney)
        {
            Random rnd = new Random();
            int getAction = rnd.Next(1, 5); // 50/50 chance that cat catches a bird
            if (hungry == false)
            {                
                Console.WriteLine(name + " is looking for birds to catch");
                System.Threading.Thread.Sleep(1000);
                if (getAction == 1 || getAction == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("__________________________________");
                    Console.WriteLine("OH look, he catched a bird!");
                    Console.WriteLine("Your Wallet Increased with $20");
                    Console.WriteLine("__________________________________");
                    Console.ResetColor();
                    earnedMoney = earnedMoney + 20;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("________________________________________");
                    Console.WriteLine(name + " did not catch any bird this time");
                    Console.WriteLine("________________________________________");
                    Console.ResetColor();
                }
                hungry = true;                
            }
            else
            {
                JustWantToEat();               
            }
            return earnedMoney;
        }
        public int MouseCatchContest(int earnedMoney)
        {
            if ((hungry == false && earnedMoney > 29))
            {
                int kittyCatches = 0;
                int catserCatches = 0;
                Random rnd = new Random();
                int mousecatch = rnd.Next();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("__________________________________");
                Console.WriteLine("Welcome to the Cat Mouse Catcher Contest");
                Console.WriteLine(name + " Will compete with a cat called Kitty");
                Console.WriteLine("Whoever catches most mouses win the contest!");
                Console.WriteLine("Let the contest begin!");
                Console.WriteLine("__________________________________");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.ReadKey();
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("___________________________________________________________");
                    mousecatch = rnd.Next(1, 10); // represent the amount of mouses cat catches.
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine(name + " got " + mousecatch + " mouse(s)");
                    catserCatches = catserCatches + mousecatch;
                    System.Threading.Thread.Sleep(500);
                    mousecatch = rnd.Next(1, 10);
                    Console.WriteLine("Kitty got " + mousecatch + " mouse(s)");
                    kittyCatches = kittyCatches + mousecatch;
                }
                Console.WriteLine(" ");
                Console.WriteLine("_____________");
                Console.WriteLine("Getting results...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(name + " got " + catserCatches + " Mouse(s)");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Kitty got " + catserCatches + " Mouse(s)");
                Console.WriteLine("_____________");
                if(catserCatches > kittyCatches)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Congratulations! " + name + " Won the Contest with " + (catserCatches - kittyCatches) + " more mouse(s)!");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $30");
                    earnedMoney = earnedMoney + 30;
                }
                else if(catserCatches == kittyCatches)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Both " + name + " and Kitty got the same amount of mouses");
                    Console.WriteLine("_______________________________________");
                    Console.ResetColor();
                    Console.WriteLine("Your Wallet Increased with $15");
                    earnedMoney = earnedMoney + 15;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("Kitty Won the Contest!");
                    Console.WriteLine("_______________________________________");
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
                    Console.WriteLine("_______________________________________");
                    Console.WriteLine("You need to have atleast $30 to participate in the contest");
                    Console.WriteLine("_______________________________________");
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
