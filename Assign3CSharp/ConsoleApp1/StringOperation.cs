using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperation

{
    class StringOperation
    {
        static void Main()
        {
            Console.WriteLine("Enter First String");
            string FirstString = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string SecondString = Console.ReadLine();
            Console.WriteLine("1.Conctenate Strings.");
            Console.WriteLine("2.Length of Two String.");
            Console.WriteLine("3.substring.");
            Console.WriteLine("4.Replace");
            Console.WriteLine("5.Upper Case.");
            Console.WriteLine("6.Lower Case.");
            Console.WriteLine("7.Trim.");
            Console.WriteLine("8.Split.");
            Console.WriteLine("9.Exit");
            Console.Write("\r\nMake a choice: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Concatenatestrings();
                    break;
                case "2":
                    Lengthoftwostrings();
                    break;
                case "3":
                    substring();
                    break;
                case "4":
                    Replace();
                    break;
                case "5":
                    UpperCase();
                    break;
                case "6":
                    LowerCase();
                    break;
                case "7":
                    Trim();
                    break;
                case "8":
                    Split();
                    break;

            }


            void Concatenatestrings()
            {

                string str;
                str = string.Concat(FirstString, SecondString);
                Console.WriteLine(str);
                Console.Read();

            }
            void Lengthoftwostrings()
            {
                Console.WriteLine(FirstString.Length);
                Console.WriteLine(SecondString.Length);
                Console.Read();
            }
            void substring()
            {
                Console.WriteLine(FirstString.Substring(1, 3));
                Console.WriteLine(SecondString.Substring(1, 3));
                Console.Read();
            }
            void Replace()
            {
                Console.WriteLine(FirstString.Replace('i', 'e'));
                Console.WriteLine(FirstString.Replace('e', 'i'));
                Console.Read();
            }
            void UpperCase()
            {
                Console.WriteLine(FirstString.ToUpper());
                Console.WriteLine(SecondString.ToUpper());
                Console.Read();
            }
            void LowerCase()
            {
                Console.WriteLine(FirstString.ToLower());
                Console.WriteLine(SecondString.ToLower());
                Console.Read();
            }
            void Trim()
            {
                Console.WriteLine(FirstString.Trim());
                Console.WriteLine(SecondString.Trim());
                Console.Read();
            }
            void Split()
            {

                string[] split = FirstString.Split(new char[] { 'i', 'u' });
                foreach (string s3 in split)
                {
                    Console.WriteLine(s3);

                }
                string[] split1 = SecondString.Split(new char[] { 'e', 'g' });
                foreach (string s4 in split1)
                {
                    Console.WriteLine(s4);

                }
                Console.Read();
            }
        }
    }
}
