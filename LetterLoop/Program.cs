using System;
using System.Data.Common;
using System.Linq;

namespace LetterLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input some letters");

            var input = Console.ReadLine();

            char[] lettersArr = input.ToCharArray();

            var finalList = lettersArr.Select(c => c.ToString()).ToArray();

            for (int i = 0; i < lettersArr.Length; i++)
            {
                var singleChar = string.Join("", Enumerable.Repeat(lettersArr[i], i + 1));
                finalList[i] = onlyFirstLetterIsUppercased(singleChar);
            }

            static string onlyFirstLetterIsUppercased(string letter)
            {
                if (string.IsNullOrEmpty(letter))
                {
                    return string.Empty;
                }
                char[] a = letter.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);

            }
            Console.WriteLine(string.Join('-', finalList));

        }

    }
}
