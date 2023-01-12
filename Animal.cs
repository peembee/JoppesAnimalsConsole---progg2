using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    abstract class Animal
    {
        protected string breed;
        protected string name;
        protected int age;
        protected string favFood;
        protected bool hungry = false;
        public bool Hungry
        {
            get { return hungry; }
            private set { hungry = value; }
        }
        public string NameOfTheAnimal()
        {
            return name;
        }
        public string BreedOfTheAnimal()
        {
            return breed;
        }
        protected void JustWantToEat()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("____________________________________");
            Console.WriteLine(name + " needs to eat for play around");
            Console.WriteLine("____________________________________");
            Console.ResetColor();
            Console.ReadKey();
        }
        public virtual int Interact(int earnedMoney)
        {
            if (hungry == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("_________________________");
                Console.WriteLine("Joppe are now playing with " + name);
                Console.WriteLine("_________________________");
                Console.ResetColor();
                Console.WriteLine("Key to get back home");
                Console.ReadKey();
                hungry = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your Wallet Increased with $5");
                Console.ResetColor();
                earnedMoney = earnedMoney + 5;
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("____________________________________");
                Console.WriteLine(name + " needs to eat for play around");
                Console.WriteLine("____________________________________");
                Console.ResetColor();
                Console.ReadKey();
            }
            return earnedMoney;
        }
        public virtual int Interact(Ball ball, int earnedMoney)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your Wallet Increased with $10");
            Console.ResetColor();
            earnedMoney = earnedMoney + 10;
            Console.WriteLine(name + " playing with the ball..");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Quality for the ball decreases with 1");
            Console.ResetColor();
            ball.LowerQuality(1);
            hungry = true;
            Console.WriteLine("");
            Console.WriteLine("Fun over, let's go home");            
            Console.ReadKey();
            return earnedMoney;
        }
        public void Eat(string food)
        {
            if (hungry == true)
            {
                if (favFood == food)
                {
                    hungry = false;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("______________________________________________");
                    Console.WriteLine(name + " was pretty hungry, but not anymore");
                    Console.WriteLine("______________________________________________");
                    Console.ResetColor();
                }
                else
                {
                    HungryAnimals();                   
                }
            }
            else
            {
                Console.WriteLine("Pet is not hungry yet, try to play with the pet");                ;
            }
            Console.WriteLine("tap to menu");
            Console.ReadKey();
        }
        public virtual void HungryAnimals()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.WriteLine("Looks like the pet didn't like the food, " + name + " are whining... and now he runs away!");
            Console.WriteLine("__________________________________________________________________________________________________");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return "Breed: " + breed + " | Name: " + name + " | Age: " + age + " | Favorite food: " + favFood;
        }
    }
}
