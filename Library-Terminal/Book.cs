namespace Library_Terminal
{
    public class Book
    {
        public Book(
            string author, 
            string title, 
            BookStatus status = BookStatus.OnShelf)
        {
            Title = title;
            Author = author;
            Status = status;
            DueDate = DateTime.UtcNow;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public BookStatus Status { get; set; }
        public DateTime DueDate { get; set; }
    }
}
