using System;
using System.ComponentModel.Design;
using System.Drawing;

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

            Console.WriteLine("1. Red");
            Console.WriteLine("2. Orange");
            Console.WriteLine("3. Yellow");
            Console.WriteLine("4. Green");
            Console.WriteLine("5. Blue");
            Console.WriteLine("6. Indigo");
            Console.WriteLine("7. Violet");
            Console.WriteLine("8. Help");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    string color1 = "You will be fat";
                    break;
                case "2":
                    Console.WriteLine("You will be in shape");
                    break;
                case "3":
                    Console.WriteLine("You will recieve round house kick to the face by Chuck Norris");
                    break;
                case "4":
                    Console.WriteLine("You will travel the world");
                    break;
                case "5":
                    Console.WriteLine("You fall in love with Jennifer Lopez");
                    break;
                case "6":
                    Console.WriteLine("Your wife will get fat");
                    break;
                case "7":
                    Console.WriteLine("You will be in good health");
                    break;
            }



            int numberOfSiblings;
            do {
                Console.WriteLine("How many siblings do you have?");
                string userSibilings = Console.ReadLine();
                numberOfSiblings = Convert.ToInt32(userSibilings);
            } while (numberOfSiblings < 0);

            bool isEven = age1 % 2 == 0;

            //age
            string lifeSpan = "";
            if (isEven) 
            {
                lifeSpan = "You have 1 month to live";
            }
            else
            {
                lifeSpan = "You will live another 40 years";
            }
            Console.WriteLine(lifeSpan);

            //siblings
            if (numberOfSiblings <= 0) 
            {
                Console.WriteLine("You will have a bunch of kids");   
            }
            else if (numberOfSiblings == 1)
            {
                Console.WriteLine("You will inherit your grandparents house");
            }
            else if (numberOfSiblings == 2)
            {
                Console.WriteLine("You will inherit LeBron James basketball skills");
            }
            else if (numberOfSiblings == 3)
            {
                Console.WriteLine("You will inherit your parents credit card bills");
            }
            else if (numberOfSiblings > 3)
            {
                Console.WriteLine("You will get drafted into the military have fun lol");
            }
            
            












        }
    }
}
