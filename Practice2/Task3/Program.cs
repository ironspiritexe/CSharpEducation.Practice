namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Калькулятор для вычисления выражения (а + b — f / а) + f * a * a — (a +b)\n");
        
        Console.Write("Введите переменную а: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Не верный ввод");
            return;
        }

        Console.Write("Введите переменную b: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Не верный ввод");
            return;
        }
        Console.Write("Введите переменную f: ");
        if (!double.TryParse(Console.ReadLine(), out double f))
        {
            Console.WriteLine("Не верный ввод");
            return;
        }
        
        if (a == 0)
        {
            Console.WriteLine("Деление на ноль невозможно! Переменная 'a' не может быть равна 0.");
            return;
        }

        double result = (a + b - f / a) + f * a * a - (a + b);
        Console.WriteLine("Результат выражения: " + result);
    }
}