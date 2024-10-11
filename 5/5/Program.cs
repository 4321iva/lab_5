class Program
{
    static void ПідрахуватиГолосніТаПриголосні(string рядок, out int голосні, out int приголосні)
    {
        голосні = 0;
        приголосні = 0;

        string голосніЛітери = "аеєиіїоуюяАЕЄИІЇОУЮЯ";  // Українські голосні

        foreach (char символ in рядок)
        {
            if (Char.IsLetter(символ))  // Перевіряємо, чи є символ буквою
            {
                if (голосніЛітери.Contains(символ))
                {
                    голосні++;
                }
                else
                {
                    приголосні++;
                }
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Введіть слова: ");
        string рядок = Console.ReadLine();

        ПідрахуватиГолосніТаПриголосні(рядок, out int голосні, out int приголосні);

        Console.WriteLine($"Кількість голосних: {голосні}");
        Console.WriteLine($"Кількість приголосних: {приголосні}");
    }
}
