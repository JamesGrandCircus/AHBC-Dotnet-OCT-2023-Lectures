using Microsoft.AspNetCore.Authentication;
using System.Security.Principal;

namespace Unit_8_consuming_apis.Models
{
    public class Library
    {
        public string Name { get; set; }

        public Address address { get; set; }

        public List<Book> Books { get; set; }

    }

    public class Address
    {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}