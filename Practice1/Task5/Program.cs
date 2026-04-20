namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите фразу: "); // Выводим сообщение с просьбой ввести первую фразу
        string phrase1; // Объявляем переменную для первой фразы
        phrase1 = Console.ReadLine(); // Считываем и записываем первую фразу
        Console.Write("Введите вторую фразу: "); // Выводим сообщение с просьбой ввести вторую фразу
        string phrase2; // Объявляем переменную для второй фразы
        phrase2 = Console.ReadLine(); // Считываем и записываем вторую фразу
        Console.WriteLine(phrase1 + " " + phrase2); // Выводим первую и вторую фразу 
    }
}