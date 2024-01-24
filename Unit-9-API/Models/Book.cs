namespace Unit_9_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public bool CheckedOut { get; set; }
    }
}
