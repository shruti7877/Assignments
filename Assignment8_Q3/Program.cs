namespace Assignment8_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum obj1 = new Sum();

            int[] A1 = { 5, 3, -6, -4, 10, 2 };
            int[] A2 = { 1, 2, 3 };
            int[] A3 = { -1, -3 };
            int[] A4 = { 1, 2, 0, -3, 8 };
            int[] A5 = { 1, 2, 3, -3, 8 };

            Console.WriteLine("check 1: " + obj1.solution(A1)); 
            Console.WriteLine("check 2: " + obj1.solution(A2)); 
            Console.WriteLine("check 3: " + obj1.solution(A3)); 
            Console.WriteLine("check 4: " + obj1.solution(A4)); 
            Console.WriteLine("check 5: " + obj1.solution(A5));
        }
    }
}
