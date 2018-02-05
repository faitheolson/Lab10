using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    public static class Validate
    {
        public static bool RepeatInput(string Input)
        {
            while (!Regex.IsMatch(Input, @"^(Y|N)$"))
            {
                Console.WriteLine("Please enter a valid input!");
                Input = Console.ReadLine();
            }
            if (Input == "Y")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("GoodBye!");
                return false;
            }
        }
        public static string UserInput(string UserInput)
        {
            while (!Regex.IsMatch(UserInput, @"^(1|2|3|4)$"))
            {
                Console.WriteLine("Please enter a valid selection!");
                UserInput = Console.ReadLine();
            }
            return UserInput;

        }
        

}
}
