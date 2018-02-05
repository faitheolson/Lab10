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
            try
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
                    repeat = Validate.RepeatInput(Console.ReadLine().ToUpper());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Whoops! Something has gone wrong! Please try again!");
                throw;
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
            MovieListArray[0].MovieDescription = "A Sci- Fi tale about Yoda!";
            MovieListArray[1].MovieTitle = "2001 A Space Odessey";
            MovieListArray[1].Category = "Sci- Fi";
            MovieListArray[1].MovieDescription = "A Sci- Fi tale of HAL.";
            MovieListArray[2].MovieTitle = "A Clockwork Orange";
            MovieListArray[2].Category = "Sci- Fi";
            MovieListArray[2].MovieDescription = "A Sci- Fi tale of Orange Clocks!";
            MovieListArray[3].MovieTitle = "Close Encounters of the Third Kind";
            MovieListArray[3].Category = "Sci- Fi";
            MovieListArray[3].MovieDescription = "A Sci- Fi tale of Encounters that are close!";
            MovieListArray[4].MovieTitle = "It";
            MovieListArray[4].Category = "Horror";
            MovieListArray[4].MovieDescription = "A terrifiying tale of a clown!";
            MovieListArray[5].MovieTitle = "Mulan";
            MovieListArray[5].Category = "Animated";
            MovieListArray[5].MovieDescription = "A heartwarming tale about Mulan!";
            MovieListArray[6].MovieTitle = "Ants";
            MovieListArray[6].Category = "Animated";
            MovieListArray[6].MovieDescription = "A heartwarming tale about Ants!";
            MovieListArray[7].MovieTitle = "Storks";
            MovieListArray[7].Category = "Animated";
            MovieListArray[7].MovieDescription = "A heartwarming tale about Storks!";
            MovieListArray[8].MovieTitle = "The Lobster";
            MovieListArray[8].Category = "Drama";
            MovieListArray[8].MovieDescription = "A dramatic tale about Lobsters!";
            MovieListArray[9].MovieTitle = "Arrival";
            MovieListArray[9].Category = "Drama";
            MovieListArray[9].MovieDescription = "A dramatic tale about Arriving!";
        }
        private static void CompareInputToData(Movies[] MovieListArray, string UserInput)
        {
            Validate.UserInput(UserInput);
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
                    MoviesInCategory.Add(item);//add matching movie object to ArrayList
                }
            }
            ArrayList TitlesInCategory = new ArrayList();
            foreach (Movies item in MoviesInCategory)
            {
                TitlesInCategory.Add(item.MovieTitle);
            }
            TitlesInCategory.Sort();
            for (int i = 0; i < TitlesInCategory.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {TitlesInCategory[i]}");
            }
            Console.WriteLine("Please enter a number to see the movie's description!");
            int MovieNumberToDescribe = int.Parse(Console.ReadLine());
            while (MovieNumberToDescribe > TitlesInCategory.Count)
            {
                Console.WriteLine("Please enter a valid number!");
                MovieNumberToDescribe = int.Parse(Console.ReadLine());
            }
            string MovieStringToDescribe = (string)TitlesInCategory[MovieNumberToDescribe-1];
            foreach (Movies item in MovieListArray)
            {
                if (MovieStringToDescribe == item.MovieTitle)
                {
                    Console.WriteLine(item.MovieDescription);
                }
            }
        }
        
    }
}
