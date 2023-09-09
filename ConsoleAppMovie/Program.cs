using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleAssign4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //****************** PART A: Default constructor **********************************//
                // Using a constructor without parameters to create an object
                Movie movie = new Movie();

                // Using property to set the title of the movie
                movie.Title = "Forrest Gump";

                // Using property to set the story line of the movie
                movie.Storyline = "The history of the United States from the 1950s " +
                    "to the '70s unfolds from the perspective of an Alabama man with " +
                    "an IQ of 75, who yearns to be reunited with his childhood sweetheart.";

                // Using property to set the rating of the movie
                movie.Rating = 8.8M;

                // Using property to set the year of the movie
                movie.Year = 2020;

                // Using property to set the Genre of the movie
                movie.Genre = "Drama";

                // Call the method to print the detail movie
                Console.WriteLine("This object movie was created with default constructor:\n" + movie.PrintMovie());
                Console.WriteLine("\n");
                Console.WriteLine("Press any key to Continue.");
                Console.ReadKey();
                Console.WriteLine("\n");
                


                //****************** PART B: Parameterized constructor **********************************//
                // Using a constructor with specific parameters for creating three movies

                //Creating object for first movie
                Movie movie1 = new Movie("*Perfume: The Story of a Murderer",
                                    "Jean-Baptiste Grenouille, born with a superior olfactory sense, " +
                                    "creates the world's finest perfume. His work, however, takes a " +
                                    "dark turn as he searches for the ultimate scent.", 
                                    7,2006,"Crime");

                //Creating object for second movie
                Movie movie2 = new Movie("*The Godfather",
                                    "Don Vito Corleone, head of a mafia family, decides to hand over " +
                                    "his empire to his youngest son Michael. However, his decision " +
                                    "unintentionally puts the lives of his loved ones in grave danger.", 
                                    9, 1972, "Drama");

                //Creating object for third movie
                Movie movie3 = new Movie("*The Green Mile",
                                    "A tale set on death row in a Southern jail, where gentle giant " +
                                    "John possesses the mysterious power to heal people's ailments. " +
                                    "When the lead guard, Paul, recognizes John's gift, he tries " +
                                    "to help stave off the condemned man's execution.", 
                                    8, 1999, "Fantasy");

                // Creating an array to store a list of movies
                Movie[] movies = new Movie[] { movie1, movie2, movie3 };


                Console.WriteLine("*** List of movies: ***\n");
                // Using a ForEach for printing each object in the list of movies
                foreach (Movie movieFor in movies)
                {
                    Console.WriteLine("The movie is: \n" + movieFor.PrintMovie());
                    Console.WriteLine("Press any key to Continue.");
                    Console.ReadKey();
                    Console.WriteLine("\n");
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("A format exception has occurred.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error exception has occurred: " +  ex.Message);
            }


        }
    }
}
