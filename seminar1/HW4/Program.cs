internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите длину: ");
        var n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            if (i % 2 == 0)
                Console.WriteLine(i);
    }
}