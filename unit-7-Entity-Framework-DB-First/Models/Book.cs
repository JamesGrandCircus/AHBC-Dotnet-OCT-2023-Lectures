namespace unit_7_Entity_Framework_DB_First.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public bool CheckedOut { get; set; }
        public DateTime CheckoutDate { get; set; }
    }
}
