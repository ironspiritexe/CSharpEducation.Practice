namespace Task2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Конвертер величин");

        while (true)
        {
            Console.WriteLine("\nВыберите тип конвектируемых величин:\n");
            Console.WriteLine("1. Метры в километры: ");
            Console.WriteLine("2. Километры в сантиметры");
            Console.WriteLine("3. М/с в Км/ч");
            Console.WriteLine("4. Градусы °С в градусы °F");
            Console.WriteLine("0. Выход из конвектора\n");

            String choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Программа завершена");
                break;
            }

            switch (choice)
            {
                case "1":
                    ConvertMtoKm();
                    break;
                case "2":
                    ConvertKmToCm();
                    break;
                case "3":
                    ConvertMpsToKmph();
                    break;
                case "4":
                    ConvertCelsiusToFahrenheit();
                    break;
                default:
                    Console.WriteLine("Не верный выбор. Попробуйте снова");
                    break;
            }
        }
    }

    static void ConvertMtoKm()
    {
        Console.Write("Введите растояние в метрах: ");
        if (double.TryParse(Console.ReadLine(), out double m))
        {
            double km = m / 1000;
            Console.WriteLine(m + " M " + " = " + km + " Km");
        }
        else
        {
            Console.WriteLine("Не верный ввод");
        }
    }

    static void ConvertKmToCm()
    {
        Console.Write("Введите растояние в Километрах: ");
        if (double.TryParse(Console.ReadLine(), out double km))
        {
            double cm = km * 100000;
            Console.WriteLine(km + " Km " + " = " + cm + " Cm");
        }
        else
        {
            Console.WriteLine("Не верный ввод");
        }
    }

    static void ConvertMpsToKmph()
    {
        Console.Write("Введите скорость в М/с: ");
        if (double.TryParse(Console.ReadLine(), out double mps))
        {
            double kmph = mps * 3.6;
            Console.WriteLine(mps + " M/с " + "=" + kmph + " Км/ч ");
        }
        else
        {
            Console.WriteLine("Не верный ввод");
        }
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Введите температуру в градусах °С: ");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double f = celsius * 9 / 5 + 32;
            Console.WriteLine(celsius + " °C " + " = " + f + " °F");
        }
        else
        {
            Console.WriteLine("Не верный ввод");
        }
    }
}        