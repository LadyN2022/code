internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 1)
        {
            Console.WriteLine("Число не чётное");
        }

        else
            Console.WriteLine("Число чётное");

        Console.ReadKey();
    }
}