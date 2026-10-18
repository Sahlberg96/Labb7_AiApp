using System;
using System.Collections.Generic;
using System.Text;

namespace Labb7_AiApp
{
    internal class WordGenerator
    {
        public List<string> WordList = new List<string>()
        {
                "djur","traktor","vattenfall","tiger","flygplan"
        };

        public char[] Letter { get; set; }

        public string GetRandomWord()
        {
            Random randomWord = new Random();

            int index = randomWord.Next(WordList.Count);

            return WordList[index];
        }

        public string ShuffleWord(string word)
        {
            Letter = word.ToCharArray();
            //char temp = Letter[0];
            //Letter[0] = Letter[1];
            //Letter[1] = temp;

            Random mixLetters = new Random();
            for (int i = 0; i < Letter.Length; i++)
            {
                int randomIndex = mixLetters.Next(Letter.Length);

                char temp = Letter[i];
                Letter[i] = Letter[randomIndex];
                Letter[randomIndex] = temp;
               // Console.Write(Letter[randomIndex] + " ");

            }
            return new string(Letter);
        }
    }
}
