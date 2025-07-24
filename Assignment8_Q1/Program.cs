namespace Assignment8_Q1
{
    internal class Program
    {
            static void Main()
        {
            Positive obj = new Positive();

            int[] A1 = { 5, 3, -6, -4, 10, 2 };
            Console.WriteLine(obj.Square(A1));  

            int[] A2 = { 1, 2, 3 };
            Console.WriteLine(obj.Square(A2));  

            int[] A3 = { -1, -3 };
            Console.WriteLine(obj.Square(A3));
        }
    }
}
