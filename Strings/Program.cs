using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string lowerCaseSentence = firstSentence.ToLower();
            string searchTerm;
            int index;
            int sliceParam;
            
            string input;

            Console.WriteLine("Please enter a word to search for: ");
            input = Console.ReadLine();
            searchTerm = input.ToLower();

            if (lowerCaseSentence.Contains(searchTerm)) {
                Console.WriteLine("true");
                index = lowerCaseSentence.IndexOf(searchTerm);
                Console.WriteLine("Index of search term: " + index);
                sliceParam = index + searchTerm.Length;
                Console.WriteLine("Length of search term: " + searchTerm.Length);

                string sub = firstSentence.Substring(0, index);
                Console.WriteLine("Substring: {0}", sub);

            } else
            {
                Console.WriteLine("false");
            }
        
        }
    }
}
