using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies[] MovieListArray = new Movies[10];
            InitializeObjectsInArray(MovieListArray);
            DeclareMovieData(MovieListArray);
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Welcome to the Movie List Application!\nThere are 10 movies in this list.\nWhat category are you interested in?");
                Console.WriteLine("[1]Sci-Fi\n[2]Animated\n[3]Drama\n[4]Horror");
                CompareInputToData(MovieListArray, Console.ReadLine());
                Console.WriteLine("Would you like to search another category? (Y/N)");
                repeat = ValidateRepeatInput(Console.ReadLine().ToUpper());
            }
        }
        private static void InitializeObjectsInArray(Movies[] MovieListArray)
        {
            for (int i = 0; i < MovieListArray.Length; i++)
            {
                MovieListArray[i] = new Movies();
            }
        }
        private static void DeclareMovieData(Movies[] MovieListArray)
        {
            MovieListArray[0].MovieTitle = "Star Wars";
            MovieListArray[0].Category = "Sci- Fi";
            MovieListArray[1].MovieTitle = "2001 A Space Odessey";
            MovieListArray[1].Category = "Sci- Fi";
            MovieListArray[2].MovieTitle = "A Clockwork Orange";
            MovieListArray[2].Category = "Sci- Fi";
            MovieListArray[3].MovieTitle = "Close Encounters of the Third Kind";
            MovieListArray[3].Category = "Sci- Fi";
            MovieListArray[4].MovieTitle = "It";
            MovieListArray[4].Category = "Horror";
            MovieListArray[5].MovieTitle = "Mulan";
            MovieListArray[5].Category = "Animated";
            MovieListArray[6].MovieTitle = "Ants";
            MovieListArray[6].Category = "Animated";
            MovieListArray[7].MovieTitle = "Storks";
            MovieListArray[7].Category = "Animated";
            MovieListArray[8].MovieTitle = "The Lobster";
            MovieListArray[8].Category = "Drama";
            MovieListArray[9].MovieTitle = "Arrival";
            MovieListArray[9].Category = "Drama";
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
                UserInput = "Animated";
            }
            else if (UserInput == "3")
            {
                UserInput = "Drama";
            }
            else if (UserInput == "4")
            {
                UserInput = "Horror";
            }
            Console.WriteLine($"You selected {UserInput}!\nThe available titles are:");
            ArrayList MoviesInCategory = new ArrayList();//Create Arraylist to hold movies in selected category
            foreach (Movies item in MovieListArray)
            {
                if (item.Category == UserInput)
                {
                    MoviesInCategory.Add(item.MovieTitle);//add matching movies to ArrayList
                }
            }
            MoviesInCategory.Sort();
            foreach (var item in MoviesInCategory)
            {
                Console.WriteLine(item);
            }
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
    }
}
