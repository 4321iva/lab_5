class Program
{
    static (int min, int max) ЗнайтиМінМакс(int[] масив)
    {
        if (масив == null || масив.Length == 0)
        {
            throw new ArgumentException("Масив не повинен бути порожнім.");
        }

        int мін = масив[0];
        int макс = масив[0];

        foreach (int число in масив)
        {
            if (число < мін)
            {
                мін = число;
            }

            if (число > макс)
            {
                макс = число;
            }
        }

        return (мін, макс);
    }

    static void Main()
    {
        int[] масив = { 3, 5, 7, 2, 8, -1, 4, 10 };

        var (мін, макс) = ЗнайтиМінМакс(масив);
        Console.WriteLine($"Найменший елемент: {мін}, Найбільший елемент: {макс}");
    }
}

