using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Store
    {
        private string food;
        private string colorOfBall;
        private int newQualityOnBall;
        private string transactionCompleted = "accepted";
        public string Food
        {
            get
            {
                return food;
            }
            private set
            {
                food = value;
            }
        }
        public string ColorOfBall // Get color data
        {
            get
            {
                return colorOfBall;
            }
            private set
            {
                colorOfBall = value;
            }
        }
        public int NewQualityOnBall // get new quality on ball
        {
            get
            {
                return newQualityOnBall;
            }
            private set
            {
                newQualityOnBall = value;
            }
        }
        public string TransactionCompleted // transaction will get accepted if the user has money on the wallet
        {
            get { return transactionCompleted; }
            private set { transactionCompleted = value; }
        }
        public int BuyFood(int wallet)
        {
            string buyFood; // saves the information about foodchoice
            int cost = 0;   // price for the food.             
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("This is what we have..");
                Console.WriteLine("____________");
                Console.WriteLine(" #1: " + StorePantry.Steak + " $" + (int)StorePantry.Steak);
                Console.WriteLine(" #2: " + StorePantry.Fish + " $" + (int)StorePantry.Fish);
                Console.WriteLine(" #3: " + StorePantry.Milk + " $" + (int)StorePantry.Milk);
                Console.WriteLine("____________");
                Console.ResetColor();
                Console.Write("What do you want to buy: ");
                buyFood = Console.ReadLine();
                buyFood = buyFood.ToLower();

                if (buyFood == "1" || buyFood == "steak")
                {
                    if (wallet < (int)StorePantry.Steak)
                    {
                        Console.WriteLine("You don't have money for this one");
                        transactionCompleted = "not accepted";
                        break;
                    }                    
                    Food = StorePantry.Steak.ToString();
                    cost = (int)StorePantry.Steak;
                    break;
                }
                else if (buyFood == "2" || buyFood == "fish")
                {
                    if (wallet < (int)StorePantry.Fish)
                    {
                        Console.WriteLine("You don't have money for this one");
                        transactionCompleted = "not accepted";
                        Console.ReadKey();
                        break;
                    }
                    Food = StorePantry.Fish.ToString();
                    cost = (int)StorePantry.Fish;
                    break;
                }
                else if (buyFood == "3" || buyFood == "milk")
                {
                    if (wallet < (int)StorePantry.Milk)
                    {
                        Console.WriteLine("You don't have money for this one");
                        transactionCompleted = "not accepted";
                        Console.ReadKey();
                        break;
                    }                    
                    Food = StorePantry.Milk.ToString();
                    cost = (int)StorePantry.Milk;
                    break;
                }
                else
                {
                    Console.WriteLine("Only pick something from the menu please");
                }
            }
            wallet = wallet - cost;
            return wallet; // Returning the amount of money back to main wallet
        }
        public int BuyBall(int wallet)
        {
            string buyBall; // gets the information about what color the user want
            int cost = 0; ;  // gets the information about the price for the ball
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("There are four colors you can choose..");
                Console.WriteLine("________________");
                Console.WriteLine(" #1: " + StorePantry.Red + " $" + (int)StorePantry.Red);
                Console.WriteLine(" #2: " + StorePantry.Yellow + " $" + (int)StorePantry.Yellow);
                Console.WriteLine(" #3: " + StorePantry.Pink + " $" + (int)StorePantry.Pink);
                Console.WriteLine(" #4: " + StorePantry.Gold + " $" + (int)StorePantry.Gold);
                Console.WriteLine("________________");
                Console.ResetColor();
                Console.Write("Enter the color you want for your ball: ");
                buyBall = Console.ReadLine();
                buyBall = buyBall.ToLower();
                buyBall = char.ToUpper(buyBall[0]) + buyBall.Substring(1);
                if (buyBall == "Red" || buyBall == "1")
                {
                    if (wallet < (int)StorePantry.Red)
                    {
                        Console.WriteLine("Sorry, you not have the money for this..");
                        
                        Console.ReadKey();
                        break;
                    }                   
                    ColorOfBall = StorePantry.Red.ToString();
                    NewQualityOnBall = 20;
                    cost = (int)StorePantry.Red;
                    break;
                }
                else if (buyBall == "Yellow" || buyBall == "2")
                {
                    if (wallet < (int)StorePantry.Yellow)
                    {
                        Console.WriteLine("Sorry, you not have the money for this..");
                        transactionCompleted = "not accepted";
                        Console.ReadKey();
                        break;
                    }                    
                    ColorOfBall = StorePantry.Yellow.ToString();
                    NewQualityOnBall = 20;
                    cost = (int)StorePantry.Yellow;
                    break;
                }
                else if (buyBall == "Pink" || buyBall == "3")
                {
                    if (wallet < (int)StorePantry.Pink)
                    {
                        Console.WriteLine("Sorry, you not have the money for this..");
                        transactionCompleted = "not accepted";
                        Console.ReadKey();
                        break;
                    }                    
                    ColorOfBall = StorePantry.Pink.ToString();
                    NewQualityOnBall = 20;
                    cost = (int)StorePantry.Pink;
                    break;
                }
                else if (buyBall == "Gold" || buyBall == "4")
                {
                    if (wallet < (int)StorePantry.Gold)
                    {
                        Console.WriteLine("Sorry, you not have the money for this..");
                        transactionCompleted = "not accepted";
                        Console.ReadKey();
                        break;
                    }                    
                    ColorOfBall = StorePantry.Gold.ToString();
                    NewQualityOnBall = 20;
                    Console.WriteLine("WOW, a Gold Ball?!?");
                    cost = (int)StorePantry.Gold;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("_______");
                    Console.WriteLine("What is that?, Try Again");
                    Console.WriteLine("_______");
                    Console.ResetColor();
                }
            }
            wallet = wallet - cost;
            if (transactionCompleted == "accepted")
            {
                Console.WriteLine("You bought a " + colorOfBall + " ball");
            }
            Console.WriteLine("Get back home, enter ");
            Console.ReadKey();
            return wallet;
        }
    }
}
