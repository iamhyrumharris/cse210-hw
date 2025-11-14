using System;

class Program
{
    static void Main(string[] args)
    {
        //Set the scripture reference
        Reference reference = new Reference("Helemans", 5, 12);
        //Set the scripture text
        string text = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation⁠; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        //Create the scripture object
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            //Clear the console to show the scripture
            Console.Clear();
            //Display the scripture
            Console.WriteLine(scripture.GetDisplayText());
            //Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }
            //Ask if the userwants to continue or quit
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            //Hide random words
            scripture.HideRandomWords();
        }
    }
}