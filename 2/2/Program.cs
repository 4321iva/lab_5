class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        if (isPrime)
        {
            Console.WriteLine($"{number} є простим числом.");
        }
        else
        {
            Console.WriteLine($"{number} не є простим числом.");
        }
    }

    // Функція для перевірки, чи є число простим
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
