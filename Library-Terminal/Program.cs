namespace Library_Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                var app = new LibraryConsoleApp();
                app.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine("Wow, you really fucked this one up ... :(.");
                throw;
            }
            
        }
    }
}