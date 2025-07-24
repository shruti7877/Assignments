namespace Assignment8_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiply obj = new Multiply();

            int N1 = 2;
            int N2 = 4;
            int Start = 2;
            int End = 6;

            string result = obj.solution(N1, N2, Start, End);
            Console.WriteLine(result);
        }
    }
}
