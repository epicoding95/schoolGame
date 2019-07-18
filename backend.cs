using System;
using System.Collections.Generic;


namespace userGame
{


    class Game
    {
       public static void gameTitle()
       {
           Console.WriteLine("Welcome to my game!");
           Console.WriteLine("Press 'enter' to begin.");
           Console.ReadLine();
           Console.Clear();
           first();
       }
        public static void first()
        {
         string choice;
             Console.WriteLine("You wake up in class with your teacher standing over you");
             Console.WriteLine("what do you do?");
             Console.WriteLine("1. punch him.");
             Console.WriteLine("2. yell at him.");
             Console.WriteLine("3. politely ask him what he wants.");
             Console.Write("choice: ");
             choice = Console.ReadLine().ToLower();
             Console.Clear();

             switch(choice)
             {
                case "1":
                case "punch him":
                case "punch":
                {
                    Console.WriteLine("your fist pounds into the teachers face.");
                    Console.WriteLine("All the other students in class cheer your name.");
                    Console.WriteLine("Mrs. Storm hears the commotion and comes to investigate.");
                    Console.WriteLine("When she sees her husband crying in the corner she shoots you with her laser.");
                     Console.WriteLine("press 'enter' to continue.");
                    Console.ReadLine();
                    gameOver();
                    break;
                }
                case "2":
                case "cry":
                {
                     Console.WriteLine("The teachers face becomes the color of ripe tomatoes");
                     Console.WriteLine("you wanna cry? do it in the hall!");
                     Console.WriteLine("Press 'enter' to continue");
                     Console.ReadLine();
                     second();
                     break;

                }
                case "3":
                case "pee":
                {
                     Console.WriteLine("The teachers sniffs the air. the other students begin plugging their noses");
                     Console.WriteLine("get out of my class!!");
                     Console.WriteLine("Press 'enter' to continue");
                     Console.ReadLine();
                     second();
                     break;

                }
                default:
                {
                    Console.WriteLine("i dont understand that command press 'enter' to try again.");
                    first();
                    break;

                }

             }

        }
        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = {"In the hallway, you see that the cops are searching lockers.","In the hallway, you see your stalker walking towards you"};
            int randomNumber = rnd.Next(0,3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you try to hide in the bathroom, yes or no?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();

            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("a meteor slams into the school at that exact moment");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                gameOver();

            }
            else
            {
                Console.WriteLine("i dont understand that command press 'enter' to try again.");
                second();
            }

        }
       public static void third()
       {
           int age;

           Console.WriteLine("you burst into the bathroom and all of your friends are there");
            Console.WriteLine("they yell surprise! and you remember its your birthday.");
            Console.WriteLine("How old are you today?");
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);

            while (age < 100)
            {
                Console.WriteLine("seriously? you look older than that!");
                Console.WriteLine("How old are you really?");
                Console.Write("age: ");
                int.TryParse(Console.ReadLine(), out age);

            }
            Console.WriteLine("youre old! you must have been held back alot!");
            youWin();

       }
       public static void gameOver()
       {
           Console.Clear();
           Console.WriteLine("At your funeral they sing songs of your bravery, then they remember whose funeral theyre attending and take it all back");
           Console.WriteLine("better luck next time");
           Console.WriteLine("press 'enter' to try again");
           Console.ReadLine();
           Console.Clear();
           gameTitle();

       }
        public static void youWin()
       {
            Console.Clear();
           Console.WriteLine("Your birthday party was a big hit. \nThe cake gave everyone superpowers.. /nYou will all live for another 100 years!");
           Console.WriteLine("great job! you won!");
           Console.WriteLine("press 'enter' to try again");
           Console.ReadLine();
           Console.Clear();
           gameTitle();
       }
    }
}