using System.Reflection.Metadata.Ecma335;

namespace Unit_5___Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RunExampleTwo();
            // RunExampleThree();
            RunExampleFour();
        }

        void RunExampleOne()
        {
            MovieGenre actionGenre = MovieGenre.Action;

            // var keyword is inferring the type based on the assigment.
            var comedyGenre = MovieGenre.Comedy;


            if (actionGenre == comedyGenre)
            {

            }
            else
            {
                Console.WriteLine("These are not the same Genres");
            }
        }

        static void RunExampleTwo()
        {
            var nigthmareOnElmStreet = new Movie("Nigthmare On Elm Street", MovieGenre.Horror);
            var fridayTheThirteenth = new Movie("Friday the Thirteenth", MovieGenre.Horror);
            var friday = new Movie("Friday", MovieGenre.Comedy);

            var movies = new List<Movie>();

            movies.Add(nigthmareOnElmStreet);
            movies.Add(fridayTheThirteenth); 
            movies.Add(friday);

            var horrorMovies = movies.Where(movie => movie.Genre == MovieGenre.Horror).ToList();

            foreach (var horrorMovie in horrorMovies)
            {
                Console.WriteLine(horrorMovie.Name);
            }
        }

        static void RunExampleThree()
        {

            Console.WriteLine("Enter the name of your movie.  ");
            var movieName = Console.ReadLine();

            // validate and convert userInput into an ENUM value.
            var genre = GetValidGenre();

            // it's a very very common use case to GET data in some way, and CREATE
            // a new object using that data.
            var movie = new Movie(movieName, genre);
        }

        static void RunExampleFour()
        {
            var genre = MovieGenre.Thriller;

            string name = "James";

            switch(name)
            {
                case "James":
                    Console.WriteLine("I'm the captain now!");
                    break;
            }

            if (genre == MovieGenre.Thriller)
            {

            }
            else if (genre == MovieGenre.Horror)
            {

            }
            else if (genre == MovieGenre.Comedy)
            {

            }


            // enums 
            switch (genre)
            {
                case MovieGenre.Thriller:
                    Console.WriteLine("My heart is pounding!");
                    break;
                case MovieGenre.Horror:
                    Console.WriteLine("My scared :(");
                    break;
                case MovieGenre.Comedy:
                    Console.WriteLine("too funny!");
                    break;
                case MovieGenre.Action:
                    Console.WriteLine("my adrenaline!");
                    break;
                case MovieGenre.Adventure:
                    Console.WriteLine("hell yeah dude.");
                    break;
            }
        }

        static void RunExampleFive()
        {
            var nigthmareOnElmStreet = new Movie("Nigthmare On Elm Street", MovieGenre.Horror);
            var fridayTheThirteenth = new Movie("Friday the Thirteenth", MovieGenre.Horror);
            var friday = new Movie("Friday", MovieGenre.Comedy);

            var movies = new List<Movie>();

            movies.Add(nigthmareOnElmStreet);
            movies.Add(fridayTheThirteenth);
            movies.Add(friday);

            foreach (var movie in movies)
            {
                // looping over all movies and switch cashing
                // on the movie property Genre. A common use case 
                // for enums is exactly this.  you dictate the flow of your
                // app based on an enum value.
                switch (movie.Genre)
                {
                    case MovieGenre.Horror:
                        break;
                    case MovieGenre.Comedy:
                        break;
                    case MovieGenre.Action:
                        break;
                    case MovieGenre.Adventure:
                        break;
                    case MovieGenre.Thriller:
                        break;
                }
            }
        }

        static MovieGenre GetValidGenre()
        {
            while(true)
            {
                Console.Write("Please enter a valid movie genre ");
                // list all the posssible enum values for the user... 
                var userInput = Console.ReadLine();
                // this second argument, if true, will ignore casing
                //                            ⬇️
                if (Enum.TryParse(userInput, true, out MovieGenre genre))
                {
                    return genre;
                }
            }
        }



        static int GetValidInteger()
        {
            while (true)
            {
                Console.Write("enter a valid number ");
                // list all the posssible enum values for the user... 
                var userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int number))
                {
                    return number;
                }
            }
        }
    }
}