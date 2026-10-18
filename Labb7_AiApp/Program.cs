namespace Labb7_AiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WordToGuess();
        }
        public static void WordToGuess()
        {
            bool stillGuessing = true;
            WordGenerator wordGenerator = new WordGenerator();


            //Random randomWord = new Random();

            //int index = randomWord.Next(wordGenerator.WordList.Count);

            string secretWord = wordGenerator.GetRandomWord();

            string scrambledWord = wordGenerator.ShuffleWord(secretWord);

            Console.WriteLine(scrambledWord);

            //wordGenerator.Letter = secretWord.ToCharArray();

            //char temp = wordGenerator.Letter[0];
            //wordGenerator.Letter[0] = wordGenerator.Letter[1];
            //wordGenerator.Letter[1] = temp;

            //Random mixLetters = new Random();
            //for (int i = 0; i < wordGenerator.Letter.Length; i++)
            //{
            //    mixLetters.Next(wordGenerator.Letter[i]);
            //    Console.Write(wordGenerator.Letter[i] + " ");
                
            //}
            Console.WriteLine("\nvad tror du det rätta ordet är?");
            while (stillGuessing)
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
                    Console.WriteLine(" Bra jobbat!");
                    Console.WriteLine("Ordet var: " + secretWord);
                    stillGuessing = false;
                }
                else
                {
                    Console.WriteLine("\ntyvärr det stämde inte försök igen");
                }
            }

            
        }

    }
}
