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
            WordGenerator wordGenerator = new WordGenerator();


            Random randomWord = new Random();

            int index = randomWord.Next(wordGenerator.WordList.Count);

            string secretWord = wordGenerator.WordList[index];

            char[] guessLetter = secretWord.ToCharArray();

            char temp = guessLetter[0];
            guessLetter[0] = guessLetter[1];
            guessLetter[1] = temp;

            Random mixLetters = new Random();

            for (int i = 0; i < guessLetter.Length; i++)
            {
                mixLetters.Next(guessLetter[i]);
                Console.Write(guessLetter[i]);
            }
        }

    }
}
