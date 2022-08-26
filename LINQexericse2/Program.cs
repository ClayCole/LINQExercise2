// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Using Method Syntax, create a list of video games of your choice…

List<string> games = new List<string>();

games.Add("Final Fantasy");
games.Add("Metal Gear Soild");
games.Add("Dark Souls");
games.Add("Frogger");
games.Add("Super Mario");

// Order the list of games by the length of the game’s names... ORDER is the keyword here:

games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

// Bonus below using different LINQs:

Console.WriteLine();
Console.WriteLine("Showing games that start with the Letter F:");
games.Where(x => x[0] == 'F').ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine();
Console.WriteLine("Now showing games that have more then 8 Letters in their title:");
games.Where(x => x.Length > 8).ToList().ForEach(x => Console.WriteLine(x));

Console.ReadLine();