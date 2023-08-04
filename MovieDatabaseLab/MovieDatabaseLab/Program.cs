
//Movie DataBase Lab

using MovieDatabaseLab;


List<Movie> movieList = new List<Movie>
{
    new Movie("Avengers: Infinity War", "Action" ),
    new Movie("One Piece Film: Red", "Action"),
    new Movie("Spider-Man: Across the Spider-Verse", "Adventure"),
    new Movie("Transformers: Rise of the Beasts", "Adventure"),
    new Movie("Guardians of the Galaxy Vol. 3", "Sci-Fi"),
    new Movie("Avatar: the Way of Water", "Sci-Fi"),
    new Movie("Elemental", "Comedy"),
    new Movie("The Super Mario Bros Movie", "Comedy"),
    new Movie("Puss in Boots: The Last Wish", "Animation"),
    new Movie("Encanto", "Animation")
};

bool again = true;
Console.WriteLine("Welcome to the Movie Lsit Application!");
Console.WriteLine("There are 10 Movies in this list.");

while (again)
{ 
    while (true)
    {
        Console.WriteLine("What category are you interested in?");
        string userInput = Console.ReadLine();

        if (movieList.Select(a => a.Category.ToLower().Trim()).Contains(userInput.ToLower().Trim()))
        {
            List<Movie> matching = movieList.Where(b => b.Category.ToLower().Trim() == userInput.Trim().ToLower()).ToList();
            matching.ForEach(c => Console.WriteLine(c.Title));
            break;
        }
        else
        {
            Console.WriteLine("Sorry, there are no movies that fit that category.");
            continue;
        }
    }

    while (true)
    {
        Console.WriteLine("Continue? (y/n)");
        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine(" ");

        if(choice.KeyChar == 'y')
        {
            break;
        }
        else if (choice.KeyChar == 'n')
        {
            again = false;
            break;
        }
        else
        {
            Console.WriteLine($"Sorry, {choice.KeyChar} is not a valid option.");
            continue;
        }
    }
}