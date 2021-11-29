using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            string wordMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordMaxLength.Length)
                    wordMaxLength = words[i];
            Console.WriteLine(wordMaxLength);
            Console.ReadLine();

        }
    }
}
