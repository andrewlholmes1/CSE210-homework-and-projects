using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 16);
        var text = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        var scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("-----------------------------------");

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\n" + scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            scripture.HideRandomWords();
            Console.Clear();
        }

        Console.WriteLine("\nThanks for memorizing! 🙌");
    }
}