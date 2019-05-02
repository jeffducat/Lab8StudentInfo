using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our class!");
            bool run = true;
            

            string[] arrNames = new string[6] { "Steve Rogers", "Tony Stark", "Bruce Banner", "Thor Odinson", "Natasha Romanoff", "Clint Barton" };
            string[] arrHometown = new string[6] { "Brooklyn", "Manhattan", "Dayton", "Asgard", "Stalingrad", "Waverly" };
            string[] arrFood = new string[6] { "Grilled Chicken", "Vegetarian Lasagna", "Tacos", "Steak", "Pad Thai", "Pizza" };

            while (run)
            {

                int number = 1;


                foreach (string student in arrNames)
                {
                    Console.WriteLine($"{number}: {student}");
                    number++;
                }

                try
                {
                    Console.WriteLine("Which student would you like to learn about today(enter a number 1-6)?  ");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Would you like learn to more about {arrNames[index - 1]}? Enter: y/n ");
                    string response = Console.ReadLine().ToLower();

                    if (response == "y")
                    {
                        Console.WriteLine("Would you like to know their hometown or favorite food? Enter: home/food");
                        string answer = Console.ReadLine().ToLower();

                        if (answer == "home")
                        {
                            Console.WriteLine($"{ arrNames[index - 1]} hometown is {arrHometown[index - 1]}");
                            Console.WriteLine($"Would you like to learn more about {arrNames[index - 1]}? Enter: y/n ");
                            string option = Console.ReadLine().ToLower();

                            if (option == "y")
                            {
                                Console.WriteLine("Would you like to know their hometown or favorite food? Enter: home/food");
                                string choice = Console.ReadLine().ToLower();

                                if (choice == "home")
                                {
                                    Console.WriteLine($"{ arrNames[index - 1]} hometown is {arrHometown[index - 1]}");
                                }
                                else if (choice == "food")
                                {
                                    Console.WriteLine($"{ arrNames[index - 1]} favorite food is {arrFood[index - 1]}");
                                }
                                else
                                {
                                    Console.WriteLine("Have a great day!  ");
                                    break;
                                }
                                
                            }
                            else if (option == "n")
                            {
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Have a great day!  ");
                                break;
                            }
                        }

                        else if (answer == "food")
                        {
                            Console.WriteLine($"{ arrNames[index - 1]} favorite food is {arrFood[index - 1]}");
                            Console.WriteLine($"Would you like to learn more about {arrNames[index - 1]}? Enter: y/n ");
                            string reply = Console.ReadLine().ToLower();

                            if ( reply == "y")
                            {
                                Console.WriteLine("Would you like to know their hometown or favorite food? Enter: home/food");
                                string choice = Console.ReadLine().ToLower();

                                if (choice == "home")
                                {
                                    Console.WriteLine($"{ arrNames[index - 1]} hometown is {arrHometown[index - 1]}");
                                }
                                else if (choice == "food")
                                {
                                    Console.WriteLine($"{ arrNames[index - 1]} favorite food is {arrFood[index - 1]}");
                                }
                                else
                                {
                                    Console.WriteLine("Have a great day!  ");
                                    break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Entry ");
                            Console.WriteLine($"Would you like to learn more about {arrNames[index - 1]}? Enter: y/n ");
                            string choice = Console.ReadLine().ToLower();
                        }
                    }

                    else if (response == "n")
                    {
                        Console.WriteLine("Would you like to know about a different student? Enter: y/n ");
                        string selection = Console.ReadLine();
                        if (selection == "y")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Have a great day!  ");
                            break;
                        }

                    }
                    
                    else
                    {
                        Console.WriteLine("invalid entry");
                        return;
                    }
                        
                        
                    
                }


                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That student does not exist. Please try again.");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid entry.  Please try again.");
                }
                
            }

        }
    }
}
