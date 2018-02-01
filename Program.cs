using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies[] MovieListArray = new Movies[10];
            for (int i = 0; i < MovieListArray.Length; i++)
            {
                MovieListArray[i] = new Movies();
            }
            MovieList(MovieListArray);
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome to the Movie LIst Application!\nThere are 10 movies in this list.\nWhat category are you interested in?");
                Console.WriteLine("1.Sci-Fi\n2.Comedy\n3.Drama");
                CompareInputToData(MovieListArray, Console.ReadLine());
                Console.WriteLine("Would you like to search another category? (Y/N)");
                repeat = ValidateRepeatInput(Console.ReadLine().ToUpper());
            }
        }

        private static void CompareInputToData(Movies[] MovieListArray, string UserInput)
        {
            while (!Regex.IsMatch(UserInput, @"^(1|2|3|4)$"))
            {
                Console.WriteLine("Please enter a valid selection!");
                UserInput = Console.ReadLine();
            }
            if (UserInput == "1")
            {
                UserInput = "Sci- Fi";
            }
            else if (UserInput == "2")
            {
                UserInput = "Comedy";
            }
            else if (UserInput == "3")
            {
                UserInput = "Drama";
            }

            foreach (Movies Movie in MovieListArray)
            {
                if (Movie.Genre == UserInput)
                {
                    Console.WriteLine(Movie.MovieName);
                }
            }

           // return UserInput;
        }

        public static bool ValidateRepeatInput(string Input)
        {
            while (!Regex.IsMatch(Input,@"^(Y|N)$"))
            {
                Console.WriteLine("Please enter a valid input!");
                Input = Console.ReadLine();
            }
            if (Input == "Y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("GoodBye!");
                return false;
            }
        }
        private static void MovieList(Movies[] MovieListArray)
        {
            MovieListArray[0].MovieName = "Star Wars";
            MovieListArray[0].Genre = "Sci- Fi";
            MovieListArray[1].MovieName = "2001 A Space Odessey";
            MovieListArray[1].Genre = "Sci- Fi";
            MovieListArray[2].MovieName = "A Clockwork Orange";
            MovieListArray[2].Genre = "Sci- Fi";
            MovieListArray[3].MovieName = "Close Encounters of the Third Kind";
            MovieListArray[3].Genre = "Sci- Fi";
            MovieListArray[4].MovieName = "Happy Gilmore";
            MovieListArray[4].Genre = "Comedy";
            MovieListArray[5].MovieName = "Step Brothers";
            MovieListArray[5].Genre = "Comedy";
            MovieListArray[6].MovieName = "The Brothers Bloom";
            MovieListArray[6].Genre = "No Pain, No Gain";
            MovieListArray[7].MovieName = "The Other Guys";
            MovieListArray[7].Genre = "Comedy";
            MovieListArray[8].MovieName = "The Lobster";
            MovieListArray[8].Genre = "Drama";
            MovieListArray[9].MovieName = "Arrival";
            MovieListArray[9].Genre = "Drama";
        }
    }
}
