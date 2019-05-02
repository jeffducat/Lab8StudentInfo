using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6DiceRolling
{
    class DiceRollerApp
    {
        public static bool Continue(string message, string option1, string option2)
        {
            Console.Write(message);
            string response = Console.ReadLine();

            if (response == option1)
            {
                return true;
            }
            else if(response == option2)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry!");
                return Continue(message, option1, option2);
            }

        }
        public static int GetUserSides(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int userSides))
            {
                return userSides;
            }
            else
            {
                Console.WriteLine("Invalid Entry!");
                return GetUserSides(message);
            }

        }



    }
}
