using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{

    internal class BookLibrary
    {
        private string name;

        private List<Book> books = new List<Book>();

        public BookLibrary(string name)
        {


        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public List<Book> Books
        {
            get { return books; }
            set { books = value; }

        }

        public void AddBook(string title, double rating)
        {
            Book currentBook = new Book(title, rating);
            books.Add(currentBook);
        }

        public double AverageRating()
        {
            double num = 0;
            for (int i = 0; i < books.Count; i++)
            {
                num += books[i].Rating;
            }
            num /= books.Count;
            return num;

        }

        public List<string> GetBooksByRating(double rating)
        {
            List<string> titles = new List<string>();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Rating > rating)
                {
                    titles.Add(books[i].Title);
                }
            }
            return titles;
        }

        public List<Book> SortByTitle()
        {
            return books = books.OrderBy(x => x.Title).ToList();
        }

        public List<Book> SortByRating()
        {
            return books = books.OrderByDescending(x => x.Rating).ToList();
        }

        public string[] ProvideInformationAboutAllBooks()
        {
            string[] arr = new string[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                arr[i] = books[i].ToString();
            }
            return arr;
        }

        public bool CheckBookIsInBookLibrary(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    return true;
                }
            }
            return false;
        }
    }
}