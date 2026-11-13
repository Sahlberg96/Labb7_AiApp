using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7_AiApp
{
    internal class WordGenerator // Class to generate words and provide methods that pick a random word and shuffle its letters
    {
        public List<string> WordList = new List<string>()
        {
                "animal","tractor","waterfall","tiger","airplane"
        };

        public char[] Letter { get; set; }

        public string GetRandomWord() // Asked AI for help on how to move the functionality of both methods from Main into this class.
        {
            Random randomWord = new Random(); // Initially created everything in Main to get it working, then moved these parts here so this class owns the functionality

            int index = randomWord.Next(WordList.Count);

            return WordList[index];
        }

        public string ShuffleWord(string word)
        {
            Letter = word.ToCharArray();
            

            Random mixLetters = new Random();
            for (int i = 0; i < Letter.Length; i++)
            {
                int randomIndex = mixLetters.Next(Letter.Length);

                char temp = Letter[i];
                Letter[i] = Letter[randomIndex];
                Letter[randomIndex] = temp;
               

            }
            return new string(Letter);
        }
    }
}
