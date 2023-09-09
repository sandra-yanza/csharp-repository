using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssign4
{
    //Class declaration
    public class Movie
    {
        // Fields declaration
        private string title;
        private string storyline;
        private decimal rating;
        private int year;
        private string genre;

        // Constructor declaration (parameterless empty constructor)
        public Movie() 
        {
            this.title = "";
            this.storyline = "";
            this.rating = 0;
            this.year = 0;
            this.genre = "";
        }

        // Another constructor declaration. This is a parameterized constructor.
        public Movie(string title, string storyline, decimal rating, int year, string genre)
        {
            this.title = title;
            this.storyline = storyline;
            this.rating = rating;
            this.year = year;
            this.genre = genre;
        }

        // Property declaration : title 
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }

        // Property declaration : storyline 
        public string Storyline
        {
            get { return storyline; }
            set { this.storyline = value; }
        }

        // Property declaration : rating 
        public decimal Rating
        {
            get { return rating; }
            set { this.rating = value; }
        }

        // Property declaration : year 
        public int Year
        {
            get { return year; }
            set { this.year = value; }
        }

        // Property declaration : genre 
        public string Genre
        {
            get { return genre; }
            set { this.genre = value; }
        }

        // Method declaration to return detail movie 
        public string PrintMovie()
        {
            return "\tTitle movie: " + Title + " \n\tStoryline: " + Storyline +
                "\n\tRating: " + Rating + "\n\tYear: " + Year + "\n\tGenre: " + Genre + "\n";
        }

    } // Closing bracket of the class body
}
