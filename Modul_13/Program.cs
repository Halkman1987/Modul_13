using System;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Collections;

namespace FinalTask
{

    class Program
    {
        static void Main(string[] args)
        {
            string Text = File.ReadAllText("C:\\Users\\User\\Desktop\\Text1.txt");
            string[] wordsall = Text.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
           
            //Не получилось сделать в помощью этого выражения.Может подскажете как его использовать нужно было :)
            var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());

            Console.WriteLine("----Подсчет 10 самых частых слов ----");
            Dictionary<string, int> uniqWord = new Dictionary<string, int>();//словарь для добавление элементов (Слово/Колличество раз) 
            HashSet<string> HashWords = new HashSet<string>(wordsall);//список уникальных слов из текста
            foreach (var w in HashWords)
            {
                int j = 0;
                foreach (var z in wordsall)
                {
                    if (w == z)
                    {
                        j++;
                    }
                }
                uniqWord.Add(w, j);
            }
            var FinalcountWord = uniqWord.ToArray();
            for (int i = 0; i < FinalcountWord.Length; i++)
                for (int j = i; j < FinalcountWord.Length; j++)
                {
                    if (FinalcountWord[i].Value < FinalcountWord[j].Value)
                        (FinalcountWord[i], FinalcountWord[j]) = (FinalcountWord[j], FinalcountWord[i]);
                }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FinalcountWord[i]);
            }
        }
    }
}






