using System;
using System.ComponentModel.Design;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller newFortuneTeller = new FortuneTeller();

            Console.WriteLine("Hello! Welcome to Fortune Teller");

            Console.WriteLine("What is your first name?");
            Console.ReadLine();
            Console.WriteLine("What is your last name?");
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();
            int age1 = Convert.ToInt32(userAge);

            Console.WriteLine("What month you born?");
            string userBirthMonth = Console.ReadLine();


            Console.WriteLine("Pick your favorite ROYGBIV color");
            string userColor = Console.ReadLine();

            Console.WriteLine("How many siblings do you have?");
            string userSibilings = Console.ReadLine();
            int numberOfSiblings = Convert.ToInt32(userSibilings);

            bool isEven = age1 % 2 == 0;

            if (isEven) 
            {
                Console.WriteLine("You have 1 month to live");
            }
            else
            {
                Console.WriteLine("You will live another 40 years");
            }
            if (numberOfSiblings <= 0) 
            {
                Console.WriteLine("You will have a bunch of kids");   
            }
            if (numberOfSiblings == 1)
            {
                Console.WriteLine("You will inherit your grandparents house");
            }
            if (numberOfSiblings == 2)
            {
                Console.WriteLine("You will inherit LeBron James basketball skills");
            }
            if (numberOfSiblings == 3)
            {
                Console.WriteLine("You will inherit your parents credit card bills");
            }
            if (numberOfSiblings > 3)
            {
                Console.WriteLine("You will get drafted into the military have fun lol");
            }
            if (userColor)
            {

            }














        }
    }
}
