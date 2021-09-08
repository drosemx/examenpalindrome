// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;

namespace examenpalindrome
{
    class Program
    {
        public static bool palindrome(string MyString)
        {
            string FinalString = "";
            for (int i = MyString.Length; i > 0; i--)
                FinalString += MyString.Substring(i - 1, 1);

            if (FinalString == MyString)
                return true;
            else
                return false;
        }

        public class MyText
        {
            public string Mystring { get; set; }
            public string Mystring2 { get; set; }

            public MyText(string myString1, string myString2)
            {
                Mystring = myString1;
                Mystring2 = myString2;

            }

            public void GetTextos()
            {
                string FinalString = Mystring + Mystring2;
                //Console.WriteLine("String1: {0}, String2 {1}", Mystring + Mystring2);
                Console.WriteLine("String1:"+ FinalString);
            }
        }


    static void Main(string[]  args)
    {
              Console.WriteLine("Palindrome example");
              Console.WriteLine(palindrome("ama"));
              Console.ReadKey();
                  Console.WriteLine(palindrome("cama"));
                  Console.ReadKey();
            Console.WriteLine("String Concatenation example");
            MyText mytext = new MyText("micasa", "b");
            mytext.GetTextos();
            Console.ReadKey();


        }

    }

}
