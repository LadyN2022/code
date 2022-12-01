
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третье число ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else 
            Console.WriteLine(num3);
        }
        else if (num1 < num2)
        {
            if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else 
            Console.WriteLine(num3);
        }
        else if (num1 < num3)
        {
            if (num3 > num2)
            {
                Console.WriteLine(num3);
            }
            else 
            Console.WriteLine(num2);
        }
        else
        Console.WriteLine("все значения равны");
    }
}