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
            string Text = File.ReadAllText("C:\\VB\\file1.txt");
            string[] wordsall = Text.Split(new[] { ' ', ',', ':', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            
            //Не получилось сделать в помощью этого выражения.Может подскажете как его использовать нужно было :)
            var noPunctuationText = new string(Text.Where(c => !char.IsPunctuation(c)).ToArray());

            //подготовим два Списка для добавления
            List<string> list = new List<string>();
            LinkedList<string> list2 = new LinkedList<string>();

            Console.WriteLine(" Добавление в List ");
            var stopWatch = Stopwatch.StartNew();
            foreach (string word in wordsall)
            {
                list.Add(word);
            }
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------");
            
            Console.WriteLine(" Добавление в LinkedList ");
            var stopWatch2 = Stopwatch.StartNew();
            foreach (string word in wordsall)
            {
                list2.AddFirst(word);
            }
            Console.WriteLine(stopWatch2.Elapsed.TotalMilliseconds);
            Console.ReadKey();
            
        }
    }
}






