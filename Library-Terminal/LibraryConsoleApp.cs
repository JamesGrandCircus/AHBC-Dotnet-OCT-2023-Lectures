using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    public class LibraryConsoleApp
    {
        /// <summary>
        /// Run the library console application, relies on the Library class.
        /// </summary>
        public void Run()
        {
            WriteIntroMessage();

            var library = new Library();
            while (true)
            {
                WriteMenu();
                var appState = SelectMenu();
                var isUserQuittingApp = HandleMenuSelection(appState, library);

                if (isUserQuittingApp)
                {
                    break;
                }
            }
            WriteOutroMessage();
        }

        private bool HandleMenuSelection(LibraryAppState appState, Library library)
        {
            Console.Clear();
            switch (appState)
            {
                case LibraryAppState.DisplayList:
                    DisplayLibraryList(library);
                    break;
                case LibraryAppState.SearchAuthor:
                    SearchByAuthor(library);
                    break;
                case LibraryAppState.SearchTitle:
                    break;
                case LibraryAppState.SelectBook:
                    break;
                case LibraryAppState.ReturnBook:
                    break;
                case LibraryAppState.QuitApp:
                    return true;
            }

            return false;
        }

        private void SearchByAuthor(Library library)
        {
            Console.Write("Please enter the name of the author you want to look up: ");
            string author = Console.ReadLine();
            var books = library.SearchByAuthor(author);

            if (!books.Any())
            {
                Console.WriteLine("There are no books in the library currently written by this author.");
            }
            else
            {
                int i = 1;
                foreach (var book in books)
                {
                    WriteBookRow(book, i);
                    i++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void DisplayLibraryList(Library library)
        {
            var books = library.BookList;

            var i = 1;
            foreach (var book in books)
            {
                WriteBookRow(book, i);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        private void WriteBookRow(Book book, int index)
        {
            Console.WriteLine($"[{index}]:  Title:  {book.Title},  Author: {book.Author},   Status: {book.Status}");
        }

        private void WriteMenu()
        {
            Console.WriteLine("[1]. Display all books");
            Console.WriteLine("[2]. Search By Author");
            Console.WriteLine("[3]. Search By Title");
            Console.WriteLine("[4]. Select Book");
            Console.WriteLine("[5]. Return Book");
            Console.WriteLine("[6]. Quit");
        }

        private LibraryAppState SelectMenu()
        {
            while(true)
            {
                Console.Write("Please select a valid menu option number... [1-6] ");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int menuChoice) && menuChoice > 0 && menuChoice <= 6)
                {
                    var appState = (LibraryAppState)menuChoice;
                    return appState;
                }
            }
        }

        private void WriteIntroMessage()
        {
            Console.WriteLine("Hello, welcome to the Grand Circus Library!");
        }     

        private void WriteOutroMessage()
        {
            Console.WriteLine("Thank you for choosing Grand Circus Library, have a nice day :)");
        }
    }
}
