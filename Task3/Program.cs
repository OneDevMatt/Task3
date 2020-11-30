using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            WordChecker();
        }



        static void WordChecker()
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            if (word.Contains("s" + "a"))
            {
                word = word.Replace("e", "");
                word = word.Replace("m", "");
                for (int i = 0; i < word.Length; i++)
                {
                    Console.WriteLine(word[i]); 
                }
             Console.WriteLine(word.Length);
            }
            else
            {
                Console.WriteLine(word);
            }
            
        }
    }
}
