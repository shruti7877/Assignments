namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine(Operations.Sum(1, null, 2)); // 13

                1.DisplayEven(10);
                1.DisplayOdd(10);
                1.DisplayPrimes(20);
                5.DisplayTable();
                2.DisplayTables1To10(4);
                123.ReverseNumber();

                string sentence = "hello Everyone!";
                Console.WriteLine(sentence.CharCount());
                Console.WriteLine(sentence.IsPalindrome());
                Console.WriteLine(sentence.ReverseSentence());
                sentence.CountDetails();
                Console.WriteLine(sentence.ToUpper());
                Console.WriteLine(sentence.ToProperCase());
                Console.WriteLine(sentence.Combine("Shruti here"));
                Console.WriteLine(sentence.RemoveExtraSpaces());
                Console.WriteLine(sentence.WordCount());
                Console.WriteLine(sentence.ContainsSubstring("Shruti"));
                Console.WriteLine(sentence.CountOccurrences("u"));
            }
        }

    }
