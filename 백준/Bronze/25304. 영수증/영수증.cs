using System;

public class Sum
{
    public static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int re = 0;
        int sum = 0;

        while (n > re)
        {
            string[] array = Console.ReadLine().Split();
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]);

            sum += a * b;
            re++;
        }

        if (sum == x)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
