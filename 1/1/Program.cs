class Program
{
    static void Main()
    {
        Console.Write("Введіть перший операнд: ");
        double operand1 = double.Parse(Console.ReadLine());

        Console.Write("Введіть операцію (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        Console.Write("Введіть другий операнд: ");
        double operand2 = double.Parse(Console.ReadLine());

        double result = Calculate(operand1, operand2, operation);

        Console.WriteLine($"Результат: {result}");
    }

    // Функція для виконання обчислень
    static double Calculate(double operand1, double operand2, char operation)
    {
        switch (operation)
        {
            case '+':
                return operand1 + operand2;
            case '-':
                return operand1 - operand2;
            case '*':
                return operand1 * operand2;
            case '/':
                if (operand2 != 0)
                    return operand1 / operand2;
                else
                {
                    Console.WriteLine("Помилка: ділення на нуль!");
                    return double.NaN; // Повертаємо нечислове значення (NaN) у випадку ділення на нуль
                }
            default:
                Console.WriteLine("Невірна операція!");
                return double.NaN; // Повертаємо NaN, якщо операція невідома
        }
    }
}
