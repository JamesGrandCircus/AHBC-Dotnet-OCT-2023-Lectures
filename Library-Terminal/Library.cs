using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    public class Library
    {
        private List<Book> _books;

        public Library() 
        {
            _books = MakeInitialBooks();
        }

        public IEnumerable<Book> BookList => _books;

        static private List<Book> MakeInitialBooks()
        {
            var books = new List<Book>()
            {
                new Book( "Robert Jordan", "The Eye of the World"),
                new Book("Stieg Larsson", "The Girl With the Dragon Tattoo"),
                new Book("Rebecca Yaros", "Fourth Wing"),
                new Book("Sara Novic", "True Biz"),
                new Book("Bonnie Garmus", "Lessons in Chemistry"),
                new Book("Dan Abnett", "Fell Cargo"),
                new Book("Sarah Penner", "The Lost Apothecary"),
                new Book("Stacy Willingham", "A Flicker in the Dark"),
                new Book("Suzanne Collins", "The Ballad of Songbirds and Snakes"),
                new Book("Gabrielle Zevin", "Tomorrow and Tomorrow and Tomorrow"),
                new Book("William King", "Dragonslayer")
            };

            return books;
        }

        public IEnumerable<Book> SearchByAuthor(string? author)
        {
            return _books.Where(book => book.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
        }
    }
}
