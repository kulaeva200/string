using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //метод Compare()
            Console.WriteLine("метод Compare():") ;
            string s1 = "Строка";
            string s2 = "Строка";
            int res = string.Compare(s1, s2);
            Console.WriteLine(res);
            Console.WriteLine();

            //метод Equals()
            Console.WriteLine("метод Equals():");
            string str1 = "s";
            string str2 = "s";

            Console.WriteLine("eq: " + str1.Equals(str2));
            Console.WriteLine("==: " + (str1 == str2));
            Console.WriteLine();

            // метод CompareOrdinal()
            Console.WriteLine("метод CompareOrdinal():");
            string r1 = "alpha";
            string r2 = "Alpha";
            string r3 = "Beta";
            string r4 = "alpha";
            int result;
            result = String.CompareOrdinal(r1, r2);
            if (result < 0)
                Console.WriteLine(r1 + " меньше " + r2);
            else if (result > 0)
                Console.WriteLine(r1 + " больше " + r2);
            else
                Console.WriteLine(r1 + " равно " + r1);
            Console.WriteLine();

            // метод IndexOf()
            Console.WriteLine("метод IndexOf():");
            string s9 = "Строка для поиска символов и подстрок";
            int index = s9.IndexOf("о");
            if (index > -1)
                Console.WriteLine("Индекс первого вхождения символа в строку {0}", index);
            index = s9.IndexOf("сим");
            if (index > -1)
                Console.WriteLine("Индекс первого символа искомой подстроки {0}", index);
            Console.WriteLine();

            // метод  Contains()
            Console.WriteLine("метод  Contains():");
            string s3 = "Текст";
            string s4 = "кст";
            if (s1.Contains(s2))
            {
                Console.WriteLine($"Строка {s3} содержит подстроку {s4}");
            }
            else
            {
                Console.WriteLine($"Строка {s3} не содержит подстроку {s4}");
            }
            Console.WriteLine();



            //  операторы == и !=
            Console.WriteLine("операторы == и != :");
              if (r1 == r4) 
            Console.WriteLine(r1 + " == " + r4);
        if(r1 != r3) 
            Console.WriteLine(r1 + " != " + r3);
        
        if(str1 != str2) 
            Console.WriteLine(r1 + " != " + r2);
        Console.WriteLine();

        }
    }
}
