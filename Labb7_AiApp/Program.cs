namespace Labb7_AiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordToGuess(); 
        }
        public static void WordToGuess() // Method to take in the info and methods from WordGenerator and then instantiate it in Main
        {
            bool stillGuessing = true;
            int wrongGuess = 0;
            int attemptsLeft = 5;
            WordGenerator wordGenerator = new WordGenerator();


            string secretWord = wordGenerator.GetRandomWord();

            string scrambledWord = wordGenerator.ShuffleWord(secretWord);

            Console.WriteLine(scrambledWord);

            
            Console.WriteLine("\nWhat do you think the correct word is?");
            Console.WriteLine("You get 5 attemps");
            while (stillGuessing && wrongGuess < 5)  // Runs util you guess the correct word or you guess wrong in 5 attempts
            {
                int numberOfGuesses = 0;
                string wordGuessed = Console.ReadLine();

                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (i < wordGuessed.Length && wordGuessed[i] == secretWord[i])
                    {
                        Console.Write(wordGuessed[i]);
                    }
                    else
                    {
                        
                        Console.Write("_");
                        
                    }
                }

                if (wordGuessed == secretWord)
                {
                    Console.WriteLine("\nWell done!");
                    Console.WriteLine("The word was: " + secretWord);
                    stillGuessing = false;
                }
                else
                {
                    wrongGuess++;
                    attemptsLeft--;
                    Console.WriteLine($"\n you have {attemptsLeft} attemps left");
                }
                
            }

            
        }

    }
}
