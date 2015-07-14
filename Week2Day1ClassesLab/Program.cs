using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Day_1_Classes_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student();
            for (bob.rank(); bob.rank() < 6; )
            {
                Console.Clear();
                switch (bob.rank())
                {
                    case 0:
                        Console.WriteLine("Welcome to the Progress Tracker. You are a Beginner.");
                        break;
                    case 1:
                        Console.WriteLine("You are improving, little Grasshopper.");
                        break;
                    case 2:
                        Console.WriteLine("You may now call yourself a Journeyman.");
                        break;
                    case 3:
                        Console.WriteLine("Wow, you're a Rock_Star now!");
                        break;
                    case 4:
                        Console.WriteLine("You earned your blackbelt, Ninja.");
                        break;
                    case 5:
                        Console.WriteLine("The force is strong with you, Jedi.");
                        break;
                }
                Console.WriteLine("\n\nPress any key to continue:\n");
                Console.ReadLine();
                int i = bob.rank();
                int x = bob.rank() + 1;
                for (; i < x; )
                {
                    Console.Write("Have you completed a program correctly? Enter Y/N: ");
                    string userInput = (Console.ReadLine());
                    checkResponse(bob, userInput);
                    if (i != bob.rank())
                        i++;
                }
            }
        }
        public static void checkResponse(Student bob, string userInput)
        {
            string[] ranks = new string[] { "Beginner", "Grasshopper", "Journeyman", "Rock_Star", "Ninja", "Jedi" };
            if (userInput.ToUpper() == "Y")
            {
                bob.achievementIncrementor();
                Console.Write("Did you help a peer complete their program? Enter Y/N: ");
                userInput = (Console.ReadLine());
                if (userInput.ToUpper() == "Y")
                    bob.achievementIncrementor();
            }
            else Console.WriteLine("Keep trying!");
            Console.WriteLine("Your Rank is " + ranks[bob.rank()] + ". Your Level is now: " + bob.level());
        }
    }

    class Student
    {
        public int achievement;
        public string name;

        public Student()
        {
            achievement = 0;
            name = "Bob";
        }

        public int rank()
        {
            return achievement / 5;
        }

        public int level()
        {
            return achievement % 5;
        }

        public void achievementIncrementor()
        {
            achievement += 1;
        }
    }

}