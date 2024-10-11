// See https://aka.ms/new-console-template for more information

Console.Clear();

Console.WriteLine("This is Mad Libs: When you are done providing the requested words"); 
Console.WriteLine("I will build them into a funny story for you");   
Console.WriteLine("Enter the requested word types;\n");
Console.WriteLine();
// big blob instead of divided lines 
/* This is the orginal story/layout of the story 
"A vacation is when you take a trip to some (adjective) place with your (adjective) family.
Usually, you go to some place that is near a/an (noun) or up on a/an (noun).
A good vacation place is one where you can ride (plural noun) or play (game) or go hunting for (plural noun)
I like to spend my time (verb ending in “ing”) or (verb ending in “ing”). 
When parents go on a vacation, they spend their time eating three (plural noun) a day, and fathers play golf, and mothers sit
around (verb ending in “ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) 
all over his (part of the body) My family is going to go to (place) and I will practice (verb ending in “ing”)
Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number)
hours every day all year making enough (plural noun) to pay for the vacation."
*/

string orginalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural_noun) or play (game) or go hunting for (plural_noun). I like to spend my time (verb_ending_in_“ing”) or (verb_ending_in_“ing”). When parents go on a vacation, they spend their time eating three (plural_noun) a day, and fathers play golf, and mothers sit around (verb_ending_in_“ing”) Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part_of_the_body) My family is going to go to (place) and I will practice (verb_ending_in_“ing”) Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural_noun) to pay for the vacation.";
string[] storyWords = orginalStory.Split(' '); //splits the story into words
string word ="";
string article = "";


for(int i = 0; i<storyWords.Length; i++)
{
    // if the word contains both parantheses then itll do it
    bool isQuestion = storyWords[i].Contains( "(" ) && storyWords[i].Contains( ")" ); //bool true or false
    if(isQuestion == true)
    {
    word = storyWords[i]; //important
    char punctuation = '\0';

        if(".?!".Contains(word[word.Length-1]))
        {
            punctuation = word[word.Length-1];
            word = word.Substring(0, word.Length-1);
        }
    string noParentWord = word.Substring(1,word.Length-2);
    string questionWord = word.Substring(1,word.Length-2); // cound use range operatr but visionalitation 

        if("aeiou".Contains(questionWord[0]))
        {
        article = "an";
        }
        else
        {
        article = "a";
        };

        Console.Write($"Please give me {article} {questionWord} ");
        storyWords[i] = (Console.ReadLine() + punctuation);
    };
}
Console.WriteLine();

for (int newStory = 0; newStory<storyWords.Length; newStory++)
{
    Console.Write($"{storyWords[newStory]} ");
}

Console.WriteLine();