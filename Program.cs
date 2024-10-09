// See https://aka.ms/new-console-template for more information

 Console.Clear();
        
Console.WriteLine("This is Mad Libs. When you are done providing the requested words,");
Console.WriteLine("I will build them into a funny story for you.");
Console.WriteLine("Enter the requested word types:\n");

        // Define the story template with placeholders
        string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family." +
            " Usually, you go to some place that is near a/an (noun) or up on a/an (noun)." +
            " A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun)." +
            " I like to spend my time (verb ending in 'ing') or (verb ending in 'ing')." +
            " When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf," +
            " and mothers sit around (verb ending in 'ing'). Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part of the body)." +
            " My family is going to go to (place) and I will practice (verb ending in 'ing')." +
            " Parents need vacations more than kids because parents are always very (adjective) and because they have to work" +
            " (number) hours every day all year making enough (plural noun) to pay for the vacation.";

        // placeholders to replace
        string[] placeholders = new string[]
        {
            "adjective", "adjective", "noun", "noun", "plural noun", "game", 
            "plural noun", "verb ending in 'ing'", "verb ending in 'ing'", 
            "plural noun", "verb ending in 'ing'", "noun", "plant", 
            "part of the body", "place", "verb ending in 'ing'", 
            "adjective", "number", "plural noun"
        };

        // dictionary to keep track of inputs
        Dictionary<string, string> userInputs = new Dictionary<string, string>();

        // Collect user input for each placeholder
        foreach (string placeholder in placeholders)
        {
            // Determine whether to use "a" or "an"
            string article = "a";
            if ("aeiou".Contains(placeholder[0].ToString().ToLower()))
            {
                article = "an";
            }

            // Prompt user for input
            Console.Write($"Please give me {article} {placeholder}: ");
            string userInput = Console.ReadLine();
            userInputs[placeholder] = userInput;
        }

        // replace placeholders in the original story with inputs
        string filledStory = originalStory;
        foreach (var kvp in userInputs)
        {
            filledStory = filledStory.Replace($"({kvp.Key})", kvp.Value);
        }

        Console.Clear();
        Console.WriteLine("Here is your completed story:\n");
        Console.WriteLine(filledStory);
    

