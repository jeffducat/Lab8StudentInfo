using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueLoop
{
    class Method
    {
        public static bool Continue(string message, string option1, string option2)
        {
            Console.Write(message);
            string response = Console.ReadLine();

            if (response == option1)
            {
                return true;
            }
            else if (response == option2)
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Entry!");
                return Continue(message, option1, option2);
            }

        }
    }
}
