using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class PetOwner
    {
        private string petOwnerName;
        private int petOwnerAge;
        private int wallet;
        private int menuNavigation = 1;

        private List<Animal> animals = new List<Animal>();

        Dog dog1 = new Dog("Dog", "Dogster", 7, "Steak");
        Puppy puppy1 = new Puppy("Puppy", "Bagster", 9, "Milk");
        Cat cat1 = new Cat("Cat", "Catster", 4, "Fish");
        Ball ball = new Ball();
        Store store = new Store();
        LotteryGame lottery1 = new LotteryGame();
        public PetOwner(string petOwnerName, int petOwnerAge, int wallet)
        {
            this.petOwnerName = petOwnerName;
            this.petOwnerAge = petOwnerAge;
            this.wallet = wallet;
        }
        public void Menu()
        {
            animals.Add(dog1);
            animals.Add(cat1);
            animals.Add(puppy1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the animals");
            Console.WriteLine("My name is " + petOwnerName + " , i'm " + petOwnerAge + " years old and my job is to take care of the animals ");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The animals i got is:");
            Console.WriteLine("DOG");
            Console.WriteLine("PUPPY");
            Console.WriteLine("CAT");
            System.Threading.Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------");
            Console.WriteLine("In the menu, you can choose what i'm suppose to do to take care of these animals");
            Console.WriteLine("------------------------");
            Console.WriteLine("Let's go to menu, just press any button");
            Console.ReadKey();
            Console.ResetColor();
            do
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" WALLET$ " + wallet);
                        Console.WriteLine("");
                        if (ball.Quality == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You have no ball");
                            Console.WriteLine("Visit Store to buy one");
                            Console.ResetColor();
                            Console.WriteLine("_________");
                        }
                        else
                        {
                            if (ball.Color == StorePantry.Red.ToString()) { Console.ForegroundColor = ConsoleColor.Red; }
                            else if (ball.Color == StorePantry.Yellow.ToString()) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (ball.Color == StorePantry.Pink.ToString()) { Console.ForegroundColor = ConsoleColor.Magenta; }
                            else { Console.ForegroundColor = ConsoleColor.DarkYellow; }
                            Console.WriteLine("Color on ball: " + ball.Color);
                            Console.ResetColor();
                            Console.WriteLine("_________");
                        }
                        foreach (var animals in animals)
                        {
                            if (animals.Hungry == false)
                            {
                                Console.WriteLine(animals.NameOfTheAnimal() + ": Not hungry.");
                            }
                            else
                            {
                                Console.WriteLine(animals.NameOfTheAnimal() + ": Hungry");
                            }
                        }
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("______________________________________");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("# 1: Play with animal");
                        Console.WriteLine("# 2: Play fetch with a ball");
                        Console.WriteLine("# 3: Feed animal");
                        Console.WriteLine("# 4: Check quality on ball");
                        Console.WriteLine("# 5: Visit store");
                        Console.WriteLine("# 6: Pet Information");
                        Console.WriteLine("# 7: Lottery");
                        Console.WriteLine("# 8: Special abilities");
                        Console.WriteLine("# 0: Exit ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("______________________________________");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("What should we do now?: ");
                        Console.ResetColor();
                        menuNavigation = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        NotRecognizedInput();
                    }
                }
                Console.Clear();
                switch (menuNavigation)
                {
                    case 0:
                        menuNavigation = 0;
                        break;
                    case 1:
                        play();
                        break;
                    case 2:
                        fetch();
                        break;
                    case 3:
                        feed();
                        break;
                    case 4:
                        checkBall();
                        break;
                    case 5:
                        visitStore();
                        break;
                    case 6:
                        Console.WriteLine("My Pets");
                        listAnimals();
                        break;
                    case 7:
                        lottery();
                        break;
                    case 8:
                        specialAbilities();
                        break;
                    default:
                        NotRecognizedInput();
                        break;
                }
            } while (menuNavigation != 0);
        }
        public void NotRecognizedInput()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("_____________________");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("No sorry, no can do..");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("_____________________");
            Console.ResetColor();
            System.Threading.Thread.Sleep(1000);
        }
        private void play()
        {
            string choosenPet;
            while (true)
            {
                Console.WriteLine("____________");
                foreach (var animalList in animals)
                {
                    Console.WriteLine(animalList);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("____________");
                Console.Write("which animal would you like to play with: ");
                choosenPet = Console.ReadLine();
                choosenPet = choosenPet.ToLower();
                choosenPet = char.ToUpper(choosenPet[0]) + choosenPet.Substring(1);
                Console.Clear();
                if (choosenPet == dog1.BreedOfTheAnimal() || choosenPet == dog1.NameOfTheAnimal())
                {
                    wallet = dog1.Interact(wallet);
                    break;
                }
                else if (choosenPet == puppy1.BreedOfTheAnimal() || choosenPet == puppy1.NameOfTheAnimal())
                {
                    wallet = puppy1.Interact(wallet);
                    break;
                }
                else if (choosenPet == cat1.BreedOfTheAnimal() || choosenPet == cat1.NameOfTheAnimal())
                {
                    Console.Clear();
                    int getChoice;
                    while (true)
                    {
                        Console.WriteLine("#1: Pat " + cat1.NameOfTheAnimal());
                        Console.WriteLine("#2: Play with " + cat1.NameOfTheAnimal());
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
                            NotRecognizedInput();
                        }

                    }
                    if (getChoice == 1)
                    {
                        wallet = cat1.patCat(wallet);
                        break;
                    }
                    else
                    {
                        wallet = cat1.Interact(wallet);
                        break;
                    }
                }
                else
                {
                    NotRecognizedInput();
                }
                Console.Clear();
            }
            Console.WriteLine("Button to menu");
            Console.ReadKey();
            Console.Clear();
        }
        private void fetch()
        {
            if (ball.Quality > 0)
            {
                string choosenPet;
                while (true)
                {
                    Console.WriteLine("____________");
                    foreach (var animalList in animals)
                    {
                        Console.WriteLine(animalList);
                        Console.WriteLine(" ");
                    }
                    Console.WriteLine("____________");

                    Console.Write("which animal would you like to play with: ");
                    choosenPet = Console.ReadLine();
                    choosenPet = choosenPet.ToLower();
                    choosenPet = char.ToUpper(choosenPet[0]) + choosenPet.Substring(1);
                    Console.Clear();
                    if (choosenPet == dog1.BreedOfTheAnimal() || choosenPet == dog1.NameOfTheAnimal())
                    {
                        wallet = dog1.Interact(ball, wallet);
                        break;
                    }
                    else if (choosenPet == puppy1.BreedOfTheAnimal() || choosenPet == puppy1.NameOfTheAnimal())
                    {
                        wallet = puppy1.Interact(ball, wallet);
                        break;
                    }
                    else if (choosenPet == cat1.BreedOfTheAnimal() || choosenPet == cat1.NameOfTheAnimal())
                    {
                        wallet = cat1.Interact(ball, wallet);
                        break;
                    }
                    else
                    {
                        NotRecognizedInput();
                    }
                }
            }
            else
            {
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You need to buy me a ball");
                Console.ResetColor();
            }
            Console.WriteLine("Button to menu");
            Console.ReadKey();
        }
        private void feed()
        {
            string name;
            string foodType;
            while (true)
            {
                int endTopLoop = 0;
                Console.WriteLine("Choose pet to feed");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal);
                }
                Console.WriteLine("--------------------------");
                Console.Write("Feed pet: ");
                name = Console.ReadLine();
                name = name.ToLower();
                name = char.ToUpper(name[0]) + name.Substring(1);
                foreach (var animal in animals)
                {
                    if (name == animal.NameOfTheAnimal() && animal.Hungry == false)
                    {
                        Console.WriteLine(animal.NameOfTheAnimal() + " is not hungry, push key for menu");
                        Console.ReadKey();
                        return;
                    }
                    else if (name == animal.BreedOfTheAnimal() && animal.Hungry == false)
                    {
                        Console.WriteLine(animal.NameOfTheAnimal() + " is not hungry, push key for menu");
                        Console.ReadKey();
                        return;
                    }
                    else if (name == animal.NameOfTheAnimal() || name == animal.BreedOfTheAnimal())
                    {
                        endTopLoop = 1;
                        break;
                    }
                }
                if (endTopLoop == 1)
                {
                    break;
                }
                else
                {
                    NotRecognizedInput();
                }
            }
            Console.Clear();
            wallet = store.BuyFood(wallet);   // Sending in wallet to the store
            foodType = store.Food; // gets the information about the food user bought

            if (store.TransactionCompleted == "accepted") // Transaction accept, user can now feed the animal, else the order will get aborted
            {
                if (name == dog1.NameOfTheAnimal() || name == dog1.BreedOfTheAnimal())
                {
                    dog1.Eat(foodType);
                }
                else if (name == puppy1.NameOfTheAnimal() || name == puppy1.BreedOfTheAnimal())
                {
                    puppy1.Eat(foodType);
                }
                else
                {
                    cat1.Eat(foodType);
                }
            }
            else
            {
                Console.WriteLine("button to menu..");
                Console.ReadKey();
            }
        }
        private void checkBall()
        {
            if (ball.Quality == 0)
            {
                string YesOrNo;
                while (true)
                {
                    Console.Write("You have no ball, Visit Store? Y/N/1: ");
                    YesOrNo = Console.ReadLine();
                    YesOrNo.ToLower();
                    if (YesOrNo == "y" || YesOrNo == "yes" || YesOrNo == "1")
                    {
                        visitStore();
                        break;
                    }
                    else if (YesOrNo == "n" || YesOrNo == "no")
                    {
                        break;
                    }
                    else
                    {
                        NotRecognizedInput();
                    }
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ball);
                Console.ReadKey();
            }
        }
        private void visitStore()
        {
            string userInput;
            if (wallet == 0)
            {
                Console.WriteLine("Your out of money.");
                Console.WriteLine("But the petfarm going well");
                Console.WriteLine("You get $70");
                Console.ReadKey();
                wallet = 70;
                return;
            }
            Console.WriteLine("Menu from store");
            Console.WriteLine("____________");
            Console.WriteLine(StorePantry.Steak + " $" + (int)StorePantry.Steak);
            Console.WriteLine(StorePantry.Fish + " $" + (int)StorePantry.Fish);
            Console.WriteLine(StorePantry.Milk + " $" + (int)StorePantry.Milk);
            Console.WriteLine(StorePantry.Red + " Ball $" + (int)StorePantry.Red);
            Console.WriteLine(StorePantry.Yellow + " Ball $" + (int)StorePantry.Yellow);
            Console.WriteLine(StorePantry.Pink + " Ball $" + (int)StorePantry.Pink);
            Console.WriteLine(StorePantry.Gold + " Ball $" + (int)StorePantry.Gold);
            Console.WriteLine("____________");
            Console.Write("Do you want to buy a new ball? Y/N");
            userInput = Console.ReadLine();
            userInput = userInput.ToLower();
            if (userInput == "y" || userInput == "yes")
            {
                wallet = store.BuyBall(wallet); // sending in wallet to store
                if (store.TransactionCompleted == "accepted") // If accepted, then continue with code to get a new ball
                {
                    ball.Color = store.ColorOfBall; // Getting the new color on ball
                    ball.Quality = store.NewQualityOnBall;         // Getting the new quality for the ball, 
                }
            }

        }
        private void listAnimals()
        {
            foreach (var showAnimals in animals)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("____________________________________________________________________");
                Console.WriteLine(showAnimals);
            }
            Console.WriteLine("____________________________________________________________________");
            Console.ReadKey();
            Console.ResetColor();
        }
        private void lottery()
        {
            wallet = lottery1.RunLotteryGame(wallet); // Send in wallet to the lottery
        }
        private void specialAbilities()
        {
            string choosenPet;
            int chooseOption;
            while (true)
            {
                Console.WriteLine("____________");
                foreach (var animalList in animals)
                {
                    Console.WriteLine(animalList);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("____________");

                Console.Write("which animal would you like to play with: ");
                choosenPet = Console.ReadLine();
                choosenPet = choosenPet.ToLower();
                choosenPet = char.ToUpper(choosenPet[0]) + choosenPet.Substring(1);
                Console.Clear();
                if (choosenPet == dog1.BreedOfTheAnimal() || choosenPet == dog1.NameOfTheAnimal())
                {
                    while (true)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("____________________");
                        Console.WriteLine("#1: Hunt");
                        Console.WriteLine("#2: Running Contest. You need to have minimum $30");
                        Console.WriteLine("____________________");
                        Console.Write("Enter your option: ");
                        try
                        {
                            chooseOption = Convert.ToInt32(Console.ReadLine());
                            if (chooseOption == 1 || chooseOption == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Only accept numbers 1 to 2");
                            }
                        }
                        catch (Exception e)
                        {
                            NotRecognizedInput();
                        }
                    }
                    Console.Clear();
                    if (chooseOption == 1)
                    {
                        Console.WriteLine("Let " + dog1.NameOfTheAnimal() + " out for a hunt");
                        wallet = dog1.GoHunt(wallet);
                    }
                    else
                    {
                        wallet = dog1.RunningContest(wallet);
                    }
                    Console.WriteLine("Go back home, enter button");
                    Console.ReadKey();
                    break;
                }
                else if (choosenPet == puppy1.BreedOfTheAnimal() || choosenPet == puppy1.NameOfTheAnimal())
                {
                    while (true)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("#1: Hunt");
                        Console.WriteLine("#2: Puppy Show Contest. You need to have minimum $50");
                        Console.Write("Enter your option: ");
                        try
                        {
                            chooseOption = Convert.ToInt32(Console.ReadLine());
                            if (chooseOption == 1 || chooseOption == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Only accept numbers 1 to 2");
                            }
                        }
                        catch (Exception e)
                        {
                            NotRecognizedInput();
                        }
                    }
                    Console.Clear();
                    if (chooseOption == 1)
                    {
                        Console.WriteLine("Let " + puppy1.NameOfTheAnimal() + " out for a hunt");
                        wallet = puppy1.GoHunt(wallet);
                    }
                    else
                    {
                        wallet = puppy1.PuppyShow(wallet);
                    }
                    Console.WriteLine("Go back home, enter button");
                    Console.ReadKey();
                    break;
                }
                else if (choosenPet == cat1.BreedOfTheAnimal() || choosenPet == cat1.NameOfTheAnimal())
                {
                    while (true)
                    {
                        Console.WriteLine("What do you want to do?");
                        Console.WriteLine("#1: Hunt");
                        Console.WriteLine("#2: Mouse Catch Contest. You need to have minimum $30");
                        Console.Write("Enter option: ");
                        try
                        {
                            chooseOption = Convert.ToInt32(Console.ReadLine());
                            if (chooseOption == 1 || chooseOption == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Only accept numbers 1 to 2");
                            }
                        }
                        catch (Exception e)
                        {
                            NotRecognizedInput();
                        }
                    }
                    Console.Clear();
                    if (chooseOption == 1)
                    {
                        Console.WriteLine("Let " + cat1.NameOfTheAnimal() + " out for a hunt");
                        wallet = cat1.HuntBird(wallet);
                    }
                    else
                    {
                        wallet = cat1.MouseCatchContest(wallet);
                    }
                    Console.WriteLine("Go back home, enter button");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    NotRecognizedInput();
                }
            }
        }
    }
}
