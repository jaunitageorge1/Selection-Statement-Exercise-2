namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You -- yes, I'm looking at you. What's my favorite school subject?");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                    case "history": Console.WriteLine("Don't know much about history.");
                      break; 
                    case "biology": Console.WriteLine("Don't know much biology");
                      break;
                    case "science": Console.WriteLine("Don't know much about the science books");
                      break;
                    case "french": Console.WriteLine("Don't know much about the French I took");
                      break;
                    case "c#": Console.WriteLine("You guessed it right! Whoo!!");
                      break;
                    default: Console.WriteLine("Really? Never heard that one before.");
                      break;
            }

        }
    }
}

