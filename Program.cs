using System;

namespace words_more_than_4_letters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string continueInput;
            do
            {
                Console.WriteLine("Please enter a string:");
                string input = Console.ReadLine();
                int count = CountWordsWithMoreThanFourLetters(input);
                Console.WriteLine("Number of words with more than 4 letters: " + count);
                do
                {
                    Console.WriteLine("Do you want to check another string ? (yes/no)");
                    continueInput = Console.ReadLine().ToLower();
                } while (continueInput != "yes" && continueInput != "no");
            
            } while (Console.ReadLine().ToLower() == "yes");
            }
            public static int CountWordsWithMoreThanFourLetters(string input)
            {
                // Split the input string into words
                string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                int count = 0;              
                foreach (string word in words)
                {
                    if (word.Length > 4)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
