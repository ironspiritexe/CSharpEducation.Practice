namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        // a. цикл for. Пусть он выводит в консоль значение своего же счётчика
        // for (int i = 1; i <= 20; i++) 
        //     Console.WriteLine(i);
        
        // b. цикл while. Пусть он выводит в консоль значение своего же счётчика
        // int i = 1;
        // while (i <= 20)
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }
        
        // c. цикл do while. Пусть он выводит в консоль значение своего же счётчика
        // int i = 1;
        // do
        // {
        //     Console.WriteLine(i);
        //     i++;
        // }
        // while (i <= 20);
        
        // d. цикл for, в котором у пользователя запрашиваются слова, затем
        // выводится полная фраза, слова в которой разделены пробелами
        // Console.WriteLine("Введите количество слов");
        // int n = int.Parse(Console.ReadLine());
        // string result = "";
        // for (int i = 0; i < n; i++)
        // {
        //     Console.WriteLine("Введите слово ");
        //     string word = Console.ReadLine();
        //     result = result + word;
        //     if (i < n - 1)
        //     {
        //         result += " ";
        //     }
        // }
        // Console.Write("Ваша фраза: ");
        // Console.Write(result);
        
        // e. цикл while, в котором у пользователя запрашиваются слова, затем
        // выводится полная фраза, слова в которой разделены пробелами.
        // Console.WriteLine("Введите количество слов");
        // int i = 0;
        // int n = int.Parse(Console.ReadLine());
        // string result = "";
        // while (i < n)
        // {
        //     Console.WriteLine("Введите слово ");
        //     string word = Console.ReadLine();
        //     result += word;
        //     if (i < n - 1)
        //     {
        //         result += " ";
        //     }
        //     i++;
        // }
        // Console.Write("Ваша фраза: ");
        // Console.Write(result);
        
        // f. цикл do while, в котором у пользователя запрашиваются слова, затем
        // выводится полная фраза, слова в которой разделены пробелами.
        // Console.WriteLine("Введите количество слов");
        // int i = 0;
        // int n = int.Parse(Console.ReadLine());
        // string result = "";
        // do
        // {
        //     Console.WriteLine("Введите слово "); 
        //     string word = Console.ReadLine();
        //     result += word;
        //     if (i < n - 1)
        //     {
        //         result += " ";
        //     }
        //     i++;
        // }
        // while (i < n);
        // Console.Write("Ваша фраза: ");
        // Console.Write(result);
    }
       
}