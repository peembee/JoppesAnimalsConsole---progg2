using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace safeprojectname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetOwner petOwner = new PetOwner("Joppe", 42, 200);
            petOwner.Menu();
            Console.WriteLine("Press any key to exit program");
            Console.ReadKey();
        }
    }
}
