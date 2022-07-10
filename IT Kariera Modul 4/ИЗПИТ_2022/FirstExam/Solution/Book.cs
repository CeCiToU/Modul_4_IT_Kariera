using System;

namespace Program
{
    internal class Book
    {
        private string title;

        private double rating;

        public Book(string title, double rating)
        {
            Title = title;
            Rating = rating;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Rating
        {

            get { return rating; }
            set { rating = value; }
        }

        public override string ToString()
        {
            return $"Book {title} is with {rating} rating.";
        }
        public Book()
        {
        }

        internal string[] ToArray()
        {
            throw new NotImplementedException();
        }
    }
}