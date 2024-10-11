class Program
{
    static void Main()
    {
        // Курси валют
        double usdToUah = 44.0;
        double eurToUah = 45.0;

        Console.WriteLine("Оберіть напрямок конвертації:");
        Console.WriteLine("1: Гривні -> Долари або Євро");
        Console.WriteLine("2: Долари або Євро -> Гривні");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            // Конвертація з гривень у іноземну валюту
            Console.WriteLine("Оберіть валюту для конвертації (USD або EUR): ");
            string currency = Console.ReadLine().ToUpper();

            Console.Write("Введіть суму в гривнях: ");
            double amountInUah = double.Parse(Console.ReadLine());

            double convertedAmount = 0;

            if (currency == "USD")
            {
                convertedAmount = ConvertFromUah(amountInUah, usdToUah);
                Console.WriteLine($"Сума в доларах: {convertedAmount} USD");
            }
            else if (currency == "EUR")
            {
                convertedAmount = ConvertFromUah(amountInUah, eurToUah);
                Console.WriteLine($"Сума в євро: {convertedAmount} EUR");
            }
            else
            {
                Console.WriteLine("Невірно обрана валюта!");
            }
        }
        else if (choice == 2)
        {
            // Конвертація з іноземної валюти у гривні
            Console.WriteLine("Оберіть валюту для конвертації (USD або EUR): ");
            string currency = Console.ReadLine().ToUpper();

            Console.Write("Введіть суму в іноземній валюті: ");
            double amountInForeignCurrency = double.Parse(Console.ReadLine());

            double convertedAmount = 0;

            if (currency == "USD")
            {
                convertedAmount = ConvertToUah(amountInForeignCurrency, usdToUah);
                Console.WriteLine($"Сума в гривнях: {convertedAmount} UAH");
            }
            else if (currency == "EUR")
            {
                convertedAmount = ConvertToUah(amountInForeignCurrency, eurToUah);
                Console.WriteLine($"Сума в гривнях: {convertedAmount} UAH");
            }
            else
            {
                Console.WriteLine("Невірно обрана валюта!");
            }
        }
        else
        {
            Console.WriteLine("Невірний вибір!");
        }
    }

    // Функція для конвертації з гривень у іноземну валюту
    static double ConvertFromUah(double amountInUah, double exchangeRate)
    {
        return amountInUah / exchangeRate;
    }

    // Функція для конвертації з іноземної валюти у гривні
    static double ConvertToUah(double amountInForeignCurrency, double exchangeRate)
    {
        return amountInForeignCurrency * exchangeRate;
    }
}

