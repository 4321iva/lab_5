class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Геометричний калькулятор");

            while (true)
            {
                Console.WriteLine("\nОберіть фігуру:");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Прямокутник");
                Console.WriteLine("3. Куб");
                Console.WriteLine("4. Вихід");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть радіус круга: ");
                        double radius = double.Parse(Console.ReadLine());
                        double circleArea = Math.PI * radius * radius;
                        Console.WriteLine($"Площа круга: {circleArea:F2}");
                        break;
                    case 2:
                        Console.Write("Введіть довжину прямокутника: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Введіть ширину прямокутника: ");
                        double width = double.Parse(Console.ReadLine());
                        double rectangleArea = length * width;
                        Console.WriteLine($"Площа прямокутника: {rectangleArea:F2}");
                        break;
                    case 3:
                        Console.Write("Введіть довжину ребра куба: ");
                        double side = double.Parse(Console.ReadLine());
                        double cubeVolume = side * side * side;
                        Console.WriteLine($"Об'єм куба: {cubeVolume:F2}");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
        }
    }
