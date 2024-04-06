using System;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:"); Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание"); Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление"); Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Выход");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 6)
            {
                Console.WriteLine("Выход из программы."); break;
            }
            double result = 0;
            switch (choice)
            {
                case 1:
                    result = Add();
                    break;
                case 2:
                    result = Subtract(); break;
                case 3:
                    result = Multiply();
                    break;
                case 4:
                    result = Divide(); break;
                case 5:
                    result = Power();
                    break;
                default:
                    Console.WriteLine("Ошибка: некорректный выбор операции."); continue;
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
    static double Add()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine()); Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine()); return a + b;
    }
    static double Subtract()
    {
        Console.Write("Введите уменьшаемое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите вычитаемое число: "); double b = double.Parse(Console.ReadLine());
        return a - b;
    }
    static double Multiply()
    {
        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine()); Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine()); return a * b;
    }
    static double Divide()
    {
        Console.Write("Введите делимое число: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Введите делитель: "); double b = double.Parse(Console.ReadLine());
        if (b == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль."); return 0;
        }
        return a / b;
    }
    static double Power()
    {
        Console.Write("Введите число: ");
        double a = double.Parse(Console.ReadLine()); Console.Write("Введите степень: ");
        double b = double.Parse(Console.ReadLine()); return Math.Pow(a, b);
    }
}
